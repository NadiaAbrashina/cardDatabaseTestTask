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
    public partial class CardSearch : Form
    {
        public CardSearch()
        {
            InitializeComponent();
        }

        private CardSearchData AgregateData()
        {
            CardSearchData result = new CardSearchData();

            result.searchBySeries = searchBySeries.Checked;
            result.searchById = searchByNumber.Checked;
            result.searchByDateStartFrom = searchStartDateFrom.Checked;
            result.searchByDateStartTo = searchStartDayTo.Checked;
            result.searchByDateEndFrom = searchEndDayTo.Checked;
            result.searchByCountFrom = searchCountFrom.Checked;
            result.searchByCountTo = searchCountTo.Checked;
            result.searchByCountFrom = searchCountFrom.Checked;
            result.searchByStatus = searchStatus.Checked;

            result.cardSeries = seriesInput.Text;
            result.cardId = numberInput.Text;
            result.dateStartFrom = startDateFrom.Value;
            result.dateStartTo = startDateTo.Value;
            result.dateEndFrom = endDateFrom.Value;
            result.dateEndTo = endDateTo.Value;
            result.countFrom = countFron.Value.ToString().Replace(',','.');
            result.countTo = countTo.Value.ToString().Replace(',', '.');
            result.status = (int)statusInput.SelectedValue;

            return result;
        }

        private void CardSearch_Load(object sender, EventArgs e)
        {
            statusInput.DataSource = Enum.GetValues(typeof(CardStatus));
        }

        private void Search_Click(object sender, EventArgs e)
        {
            CardSearchData cardSearchData = AgregateData();
            CardSearchResults cardSearchResults = new CardSearchResults(cardSearchData);
            cardSearchResults.ShowDialog();
        }
    }
}
