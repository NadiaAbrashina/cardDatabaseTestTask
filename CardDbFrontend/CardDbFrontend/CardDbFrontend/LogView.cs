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
    public partial class LogView : Form
    {
        public LogView()
        {
            InitializeComponent();
        }

        private void LogView_Load(object sender, EventArgs e)
        {
            using (var vb = new WebClient())
            {
                try
                {
                    var response = vb.DownloadString("http://localhost:8000/cardDb/readLog");
                    var result = JsonConvert.DeserializeObject<List<LogObjectFromServer>>(response);
                    BindingList<LogObject> data = new BindingList<LogObject>();
                    foreach (var line in result)
                    {
                        data.Add(line.fields);
                    }
                    logResults.AutoGenerateColumns = true;
                    logResults.DataSource = data;
                    logResults.Refresh();
                }
                catch (WebException ex)
                {
                    MessageBox.Show(ex.Message, "Server error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
