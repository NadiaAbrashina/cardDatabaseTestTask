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
    public partial class PerformOperation : Form
    {
        private int cardID;

        public PerformOperation(int cardIdInput)
        {
            InitializeComponent();
            cardID = cardIdInput;
        }

        private void PerformOperation_Load(object sender, EventArgs e)
        {
            operationType.DataSource = Enum.GetValues(typeof(OperationTypes));
        }

        private void Perform_Click(object sender, EventArgs e)
        {
            using (var vb = new WebClient())
            {
                CardOperationPerform cardOperationPerform = new CardOperationPerform();
                cardOperationPerform.card = cardID;
                cardOperationPerform.operationType = (int)operationType.SelectedValue;
                cardOperationPerform.moneyAmount = sumToOperate.Value.ToString().Replace(',','.');
                cardOperationPerform.purpouce = purpous.Text;
                string cardOperationData = JsonConvert.SerializeObject(cardOperationPerform);
                try
                {
                    vb.UploadString(new Uri("http://localhost:8000/cardDb/cardOperationWrite"), "POST", cardOperationData);
                    vb.UploadString(new Uri("http://localhost:8000/cardDb/cardCountChange"), "POST", cardOperationData);
                    MessageBox.Show("Операцію проведено");
                }
                catch (WebException ex)
                {
                    MessageBox.Show(ex.Message, "Server error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
