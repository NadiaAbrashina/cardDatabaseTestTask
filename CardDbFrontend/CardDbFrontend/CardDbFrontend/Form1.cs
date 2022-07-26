using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardDbFrontend
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void SeeCards_Click(object sender, EventArgs e)
        {
            CardSearchResults cardSearchResults = new CardSearchResults();
            this.Hide();
            cardSearchResults.ShowDialog();
            this.Show();
        }

        private void SeeLog_Click(object sender, EventArgs e)
        {
            LogView viewLogs = new LogView();
            this.Hide();
            viewLogs.ShowDialog();
            this.Show();
        }

        private void SearchCards_Click(object sender, EventArgs e)
        {
            CardSearch cardSearch = new CardSearch();
            this.Hide();
            cardSearch.ShowDialog();
            this.Show();
        }

        private void AddCards_Click(object sender, EventArgs e)
        {
            CardGenerate cardGenerate = new CardGenerate();
            this.Hide();
            cardGenerate.ShowDialog();
            this.Show();
        }
    }
}
