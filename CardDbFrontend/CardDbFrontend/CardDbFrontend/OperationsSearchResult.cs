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
    public partial class OperationsSearchResult : Form
    {
        private int cardId;

        public OperationsSearchResult(int cardIdInput)
        {
            cardId = cardIdInput;
            InitializeComponent();
        }

        private void OperationsSearchResult_Load(object sender, EventArgs e)
        {
            using (var vb = new WebClient())
            {
                try
                {
                    var data = new BindingList<OperationObject>();
                    var cardSelect = new CardSelectData();
                    cardSelect.card = cardId;
                    vb.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    var response = vb.UploadString(new Uri("http://localhost:8000/cardDb/cardOperationsSelect"), "POST", JsonConvert.SerializeObject(cardSelect));
                    var result = JsonConvert.DeserializeObject<List<OperationObjectFromServer>>(response);
                    foreach (var line in result)
                    {
                        data.Add(line.fields);
                    }
                    operations.AutoGenerateColumns = true;
                    operations.DataSource = data;
                    operations.Refresh();
                }
                catch (WebException ex)
                {
                    MessageBox.Show(ex.Message, "Server error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
