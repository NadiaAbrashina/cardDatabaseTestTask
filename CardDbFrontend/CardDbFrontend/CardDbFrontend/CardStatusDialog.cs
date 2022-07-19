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
    public partial class CardStatusDialog : Form
    {
        private CardObject cardSelected;

        public CardStatusDialog(CardObject cardInput)
        {
            InitializeComponent();
            cardSelected = cardInput;
        }

        private void CardStatusDialog_Load(object sender, EventArgs e)
        {
            statusSelected.DataSource = Enum.GetValues(typeof(CardStatus));
        }

        private void changeStatus_Click(object sender, EventArgs e)
        {
            using (var vb = new WebClient())
            {
                CardStatusChangeData cardStatusChenge = new CardStatusChangeData();
                LogData logData = new LogData();
                cardStatusChenge.card = cardSelected.pk;
                cardStatusChenge.status = (int)statusSelected.SelectedItem;
                logData.cardId = cardSelected.cardId;
                logData.cardSeries = cardSelected.cardSeries;
                logData.count = cardSelected.count.ToString().Replace(',','.');
                logData.operation = (int)CardOperationType.CARD_STATUS_CHANGED;
                string cardDeleteLine = JsonConvert.SerializeObject(cardStatusChenge);
                string logDataLine = JsonConvert.SerializeObject(logData);
                try
                {
                    vb.UploadString(new Uri("http://localhost:8000/cardDb/logwrite"), "POST", logDataLine);
                    vb.UploadString(new Uri("http://localhost:8000/cardDb/cardStatusChange"), "PATCH", cardDeleteLine);
                    MessageBox.Show("Статус змінено");
                }
                catch (WebException ex)
                {
                    MessageBox.Show(ex.Message, "Server error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
