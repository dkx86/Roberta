using Roberta.Model;
using Roberta.Repository;
using System;
using System.Windows.Forms;

namespace Roberta.Forms
{
    public partial class AddRecordForm : Form
    {
        private readonly FirearmsRepo _firearmsRepo;
        private readonly AmmunitionRepo _ammunitionRepo;
        private readonly RecordsRepo _recordsRepo;

        public AddRecordForm(Guid? recordGuid)
        {
            InitializeComponent();
            saveButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;

            _firearmsRepo = new FirearmsRepo();
            _ammunitionRepo = new AmmunitionRepo();
            _recordsRepo = new RecordsRepo();

            // init data repos
            _firearmsRepo.Initialize();
            _ammunitionRepo.Initialize();
            _recordsRepo.Initialize();

            firearmComboBox.DataSource = _firearmsRepo.GetAllFirearms();
            ammoComboBox.DataSource = _ammunitionRepo.GetAllAmmo();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var firearm = (Firearm)firearmComboBox.SelectedItem;
            var ammo = (Ammunition)ammoComboBox.SelectedItem;
            var date = dateTimePicker.Value;
            var rounds = (int)roundsNumericUpDown.Value;

            var logRecord = _recordsRepo.CreateNewRecord();
            logRecord.Date = date;
            logRecord.Firearm = firearm;
            logRecord.Ammunition = ammo;
            logRecord.Rounds = rounds;

            _recordsRepo.UpdateOrAdd(logRecord);
            _recordsRepo.Save();
        }

    }
}
