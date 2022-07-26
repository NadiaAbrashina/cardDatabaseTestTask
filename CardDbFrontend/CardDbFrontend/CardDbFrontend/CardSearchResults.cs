using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace CardDbFrontend
{
    public partial class CardSearchResults : Form
    {
        private CardSearchData request;
        private BindingList<CardObject> data;

        public CardSearchResults()
        {
            InitializeComponent();
            request = null;
        }

        public CardSearchResults(CardSearchData cardSearchQuery)
        {
            InitializeComponent();
            request = cardSearchQuery;
        }


        private void CardSearchResults_Load(object sender, EventArgs e)
        {
            using (var vb = new WebClient())
            {
                try
                {
                    data = new BindingList<CardObject>();
                    string response = "";
                    if (request == null)
                    {
                        response = vb.DownloadString("http://localhost:8000/cardDb/cards");
                    }
                    else
                    {
                        response = vb.UploadString(new Uri("http://localhost:8000/cardDb/cardSearchBy"), "POST", JsonConvert.SerializeObject(request));
                    }
                    var result = JsonConvert.DeserializeObject<List<CardObjectFromServer>>(response);
                    foreach (var line in result)
                    {
                        line.fields.pk = (line.pk != null) ? (int)line.pk : -1;
                        data.Add(line.fields);
                    }
                    cardsFound.AutoGenerateColumns = true;
                    cardsFound.DataSource = data;
                    cardsFound.Refresh();
                }
                catch (WebException ex)
                {
                    MessageBox.Show(ex.Message, "Server error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cardsFound_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CardObject cardSelected = data[e.RowIndex];
            Card card = new Card(cardSelected);
            this.Hide();
            card.ShowDialog();
            this.Show();
            this.Invalidate();
            this.Update();
        }
    }
}
