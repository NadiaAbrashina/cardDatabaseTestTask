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
    public partial class CardGenerate : Form
    {
        public CardGenerate()
        {
            InitializeComponent();
        }

        private void CardGenerate_Load(object sender, EventArgs e)
        {
            cardActiveTerm.DataSource = Enum.GetValues(typeof(CardDurations));
        }

        private void startGenerationButton_Click(object sender, EventArgs e)
        {
            using (var vb = new WebClient())
            {
                CardGenerateData cardGenerateData = new CardGenerateData();
                cardGenerateData.cardsNumber = (int)cardsNumber.Value;
                cardGenerateData.cardsSeries = cardsSeries.Text;
                CardDurations term = (CardDurations)cardActiveTerm.SelectedValue;
                cardGenerateData.daysActive = (term == CardDurations.MONTH) ? 30 : (term == CardDurations.SIX_MONTHS) ? 180 : 365;
                string cardGenerateLine = JsonConvert.SerializeObject(cardGenerateData);

                try
                {
                    var responce = vb.UploadString(new Uri("http://localhost:8000/cardDb/cardsGenerate"), "POST", cardGenerateLine);
                    List<CardObjectFromServer> cardsGenerated = JsonConvert.DeserializeObject<List<CardObjectFromServer>>(responce);
                    foreach (CardObjectFromServer obj in cardsGenerated)
                    {
                        LogData logCreation = new LogData();
                        logCreation.cardSeries = obj.fields.cardSeries;
                        logCreation.cardId = obj.fields.cardId;
                        logCreation.count = obj.fields.count.ToString().Replace(',', '.');
                        logCreation.operation = (int)CardOperationType.CARD_CREATED;
                        vb.UploadString(new Uri("http://localhost:8000/cardDb/logwrite"), "POST", JsonConvert.SerializeObject(logCreation));
                        vb.UploadString(new Uri("http://localhost:8000/cardDb/cardAdd"), "POST", JsonConvert.SerializeObject(obj.fields));
                    }
                    MessageBox.Show("Карти створено");
                }
                catch (WebException ex)
                {
                    MessageBox.Show(ex.Message, "Server error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
