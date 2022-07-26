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
    public partial class Card : Form
    {
        private CardObject cardSelected;
        public Card(CardObject cardInput)
        {
            InitializeComponent();
            cardSelected = cardInput;
        }

        private void Card_Load(object sender, EventArgs e)
        {
            cardId.Text = cardSelected.cardSeries + cardSelected.cardId;
            startDate.Text = cardSelected.startDate.ToString();
            endDate.Text = cardSelected.endDate.ToString();
            cvv.Text = cardSelected.cvv;
            count.Text = cardSelected.count.ToString();
            status.Text = cardSelected.status.ToString();
        }

        private void History_Click(object sender, EventArgs e)
        {
            OperationsSearchResult operationsSearchResult = new OperationsSearchResult(cardSelected.pk);
            this.Hide();
            operationsSearchResult.ShowDialog();
        }

        private void PerformOperation_Click(object sender, EventArgs e)
        {
            if (cardSelected.status == CardStatus.ACTIVE)
            {
                PerformOperation performOperation = new PerformOperation(cardSelected.pk);
                this.Hide();
                performOperation.ShowDialog();
            }
            else
            {
                MessageBox.Show("Карта не активна! Не можна виконати операцію.");
            }
        }

        private void deleteCard_Click(object sender, EventArgs e)
        {
            var responce = MessageBox.Show("Ви впевнені, що хочете видалити картку?", "Підтвердіть операцію", MessageBoxButtons.OKCancel);
            if (responce == DialogResult.OK)
            {
                using (var vb = new WebClient())
                {
                    CardSelectData cardDelete = new CardSelectData();
                    LogData logData = new LogData();
                    cardDelete.card = cardSelected.pk;
                    logData.cardId = cardSelected.cardId;
                    logData.cardSeries = cardSelected.cardSeries;
                    logData.count = cardSelected.count.ToString().Replace(',', '.');
                    logData.operation = (int)CardOperationType.CARD_DELETED;
                    string cardDeleteLine = JsonConvert.SerializeObject(cardDelete);
                    string logDataLine = JsonConvert.SerializeObject(logData);
                    try
                    {
                        vb.UploadString(new Uri("http://localhost:8000/cardDb/logwrite"), "POST", logDataLine);
                        vb.UploadString(new Uri("http://localhost:8000/cardDb/cardRemove"), "DELETE", cardDeleteLine);
                        MessageBox.Show("Карту видалено");
                    }
                    catch (WebException ex)
                    {
                        MessageBox.Show(ex.Message,"Server error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.Hide();
            }
        }

        private void ChangeCard_Click(object sender, EventArgs e)
        {
            CardStatusDialog cardStatus = new CardStatusDialog(cardSelected);
            this.Hide();
            cardStatus.ShowDialog();
        }
    }
}
