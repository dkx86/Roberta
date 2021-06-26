using Roberta.Model;
using Roberta.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Roberta.Forms
{
    public partial class StatisticForm : Form
    {
        private readonly FirearmsRepo _firearmsRepo;
        private readonly AmmunitionRepo _ammunitionRepo;
        private readonly RecordsRepo _recordsRepo;

        public StatisticForm()
        {
            _firearmsRepo = new FirearmsRepo();
            _ammunitionRepo = new AmmunitionRepo();
            _recordsRepo = new RecordsRepo();

            // init data repos
            _firearmsRepo.Initialize();
            _ammunitionRepo.Initialize();
            _recordsRepo.Initialize();

            InitializeComponent();
            ClearChart();
            FillFirearms();
        }

        private void FillFirearms()
        {
            firearmsComboBox.DataSource = _firearmsRepo.GetAllFirearms();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            ClearChart();
            var fromDate = fromDateTimePicker.Value;
            var toDate = toDateTimePicker.Value;

            var selectedFirearm = firearmsComboBox.SelectedItem as Firearm;

            List<LogRecord> records =  _recordsRepo.GetStats(selectedFirearm.Id, fromDate, toDate);
            
            int totalRounds = 0;
            Dictionary<Ammunition, int> roundsPerAmmo = new Dictionary<Ammunition, int>();
            foreach(var record in records)
            {
                totalRounds += record.Rounds;
                int rounds = 0;
                if (roundsPerAmmo.TryGetValue(record.Ammunition, out rounds))
                {
                    roundsPerAmmo[record.Ammunition] = rounds + record.Rounds;
                }
                else
                {
                    roundsPerAmmo.Add(record.Ammunition, record.Rounds);
                }
            }
            
            
            totalRoundsValueLabel.Text = totalRounds.ToString();
            roundsChart.Titles.Add(selectedFirearm.ToString());
            FillChartSeries(roundsPerAmmo);
        }

        private void ClearChart()
        {
            roundsChart.Titles.Clear();
            roundsChart.Series.Clear();
        }

        private void FillChartSeries(Dictionary<Ammunition, int> roundsPerAmmo)
        {
            
            
            foreach (KeyValuePair<Ammunition, int> entry in roundsPerAmmo)
            {
                Series series = roundsChart.Series.Add(entry.Key.ToString());
                series.Points.Add(entry.Value);
            }
        }
    }
}
