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
            cardSearchResults.ShowDialog();
        }

        private void SeeLog_Click(object sender, EventArgs e)
        {
            LogView viewLogs = new LogView();
            viewLogs.ShowDialog();
        }

        private void SearchCards_Click(object sender, EventArgs e)
        {
            CardSearch cardSearch = new CardSearch();
            cardSearch.ShowDialog();
        }

        private void AddCards_Click(object sender, EventArgs e)
        {
            CardGenerate cardGenerate = new CardGenerate();
            cardGenerate.ShowDialog();
        }
    }
}
