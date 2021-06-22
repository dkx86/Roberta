using Roberta.Model;
using Roberta.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Roberta
{
    public partial class MainForm : Form
    {
        private readonly FirearmsRepo _firearmsRepo;
        private readonly AmmunitionRepo _ammunitionRepo;
        private readonly RecordsRepo _recordsRepo;

        private int lastSelectedFirearmIndex;
        private int lastSelectedAmmoIndex;

        public MainForm()
        {
            _firearmsRepo = new FirearmsRepo();
            _ammunitionRepo = new AmmunitionRepo();
            _recordsRepo = new RecordsRepo();

            // init data repos
            _firearmsRepo.Initialize();
            _ammunitionRepo.Initialize();
            _recordsRepo.Initialize();

            InitializeComponent();

            LoadFirearms();
            FirearmsSwitchEditMode(false);

            LoadAmmunition();
            AmmoSwitchEditMode(false);

            LoadLogRecords(false);
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _firearmsRepo.Save();
            _ammunitionRepo.Save();
        }

        private void LoadFirearms()
        {
            var firearms = _firearmsRepo.GetAllFirearms();
            firearmsListBox.Items.Clear();
            firearms.ForEach(f => firearmsListBox.Items.Add(f));
            if (firearmsListBox.Items.Count > 0 && lastSelectedFirearmIndex < firearmsListBox.Items.Count)
                firearmsListBox.SetSelected(lastSelectedFirearmIndex, true);

            firearmsListBox.Refresh();
        }

        private void LoadAmmunition()
        {
            var ammo = _ammunitionRepo.GetAllAmmo();
            ammoListBox.Items.Clear();
            
            ammo.ForEach(a => ammoListBox.Items.Add(a));
            if (ammoListBox.Items.Count > 0 && lastSelectedAmmoIndex < ammoListBox.Items.Count)
                ammoListBox.SetSelected(lastSelectedAmmoIndex, true);

            ammoListBox.Refresh();
        }

        private void FillFirearmCard(Firearm firearm)
        {
            firearmManufacturerTextBox.Text = firearm.Manufacturer;
            firearmModelTextBox.Text = firearm.Model;
            firearmCaliberTextBox.Text = firearm.Caliber;
            firearmSerialNumberTextBox.Text = firearm.SerialNumber;
        }

        private void FillAmmoCard(Ammunition ammo)
        {
            ammoManufacturerTextBox.Text = ammo.Manufacturer;
            ammoCaliberTextBox.Text = ammo.Caliber;
            ammoManufacturerTextBox.Text = ammo.Manufacturer;
            SetAmmoSelectedProjectileType(ammo.ProjectileType);

            ammoWeightTextBox.Text = ammo.ProjectileWeight.ToString();
            ammoBirdshotSizeTextBox.Text = ammo.BirdshotSize;
            ammoBuckshotSizeTextBox.Text = ammo.BuckshotSize;
            ammoBulletSlugNameTextBox.Text = ammo.BulletSlugName;

        }

        private void FirearmsSwitchEditMode(bool isOn)
        {
            firearmManufacturerTextBox.ReadOnly = !isOn;
            firearmModelTextBox.ReadOnly = !isOn;
            firearmCaliberTextBox.ReadOnly = !isOn;
            firearmSerialNumberTextBox.ReadOnly = !isOn;
            firearmSaveButton.Visible = isOn;
            firearmCancelButton.Visible = isOn;
        }

        private void AmmoSwitchEditMode(bool isOn)
        {
            ammoManufacturerTextBox.ReadOnly = !isOn;
            ammoCaliberTextBox.ReadOnly = !isOn;
            ammoBulletRadioButton.Enabled = isOn;
            ammoBirdshotRadioButton.Enabled = isOn;
            ammoBuckshotRadioButton.Enabled = isOn;
            ammoSlugRadioButton.Enabled = isOn;

            ammoWeightTextBox.ReadOnly = !isOn;
            ammoBirdshotSizeTextBox.ReadOnly = !isOn;
            ammoBuckshotSizeTextBox.ReadOnly = !isOn;
            ammoBulletSlugNameTextBox.ReadOnly = !isOn;

            ammoSaveButton.Visible = isOn;
            ammoCancelButton.Visible = isOn;
        }



        private void firearmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastSelectedFirearmIndex = firearmsListBox.SelectedIndex;
            var firearm = (Firearm)firearmsListBox.SelectedItem;
            FillFirearmCard(firearm);
        }



        private void firearmSaveButton_Click(object sender, EventArgs e)
        {
            var firearm = (Firearm)firearmsListBox.SelectedItem;
            firearm.Manufacturer = firearmManufacturerTextBox.Text;
            firearm.Model = firearmModelTextBox.Text;
            firearm.Caliber = firearmCaliberTextBox.Text;
            firearm.SerialNumber = firearmSerialNumberTextBox.Text;

            _firearmsRepo.UpdateOrAdd(firearm);
            _firearmsRepo.Save();

            FirearmsSwitchEditMode(false);

            LoadFirearms();
        }


        private void firearmCancelButton_Click(object sender, EventArgs e)
        {
            FirearmsSwitchEditMode(false);
            _firearmsRepo.ReloadFromDisk();
            LoadFirearms();
        }


        // Firearms menu items

        private void createFirearmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(1);
            var newFirearm = _firearmsRepo.CreateNewFirearm();
            firearmsListBox.Items.Add(newFirearm);
            firearmsListBox.SetSelected(firearmsListBox.Items.Count - 1, true);

            FirearmsSwitchEditMode(true);
        }

        private void editFirearmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirearmsSwitchEditMode(true);
        }

        private void removeFirearmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var firearm = (Firearm)firearmsListBox.SelectedItem;

            RemoveDialog dialog = new RemoveDialog();
            dialog.SetMessage("Delete " + firearm.ToString());
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (dialog.ShowDialog(this) == DialogResult.Yes)
            {
                _firearmsRepo.Delete(firearm.Id);
                _firearmsRepo.Save();
                lastSelectedFirearmIndex = 0;
                LoadFirearms();
            }

            dialog.Dispose();

        }

        // TabControl

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = tabControl.SelectedIndex;

            // Disable all
            removeRecordToolStripMenuItem.Enabled = false;

            editFirearmToolStripMenuItem.Enabled = false;
            removeFirearmToolStripMenuItem.Enabled = false;

            editAmmoToolStripMenuItem.Enabled = false;
            removeAmmoToolStripMenuItem.Enabled = false;

            switch (index)
            {
                case 0: // LOG
                    removeRecordToolStripMenuItem.Enabled = true;
                    break;
                case 1: //Firearms
                    editFirearmToolStripMenuItem.Enabled = true;
                    removeFirearmToolStripMenuItem.Enabled = true;
                    break;
                case 2: //Ammunitions
                    editAmmoToolStripMenuItem.Enabled = true;
                    removeAmmoToolStripMenuItem.Enabled = true;
                    break;
            }
        }


        // Firearms menu items
        private void createAmmoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(2);
            var newAmmo = _ammunitionRepo.CreateNewAmmo();
            ammoListBox.Items.Add(newAmmo);
            ammoListBox.SetSelected(ammoListBox.Items.Count - 1, true);

            AmmoSwitchEditMode(true);
        }

        private void editAmmoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmmoSwitchEditMode(true);
        }

        private void removeAmmoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ammo = (Ammunition)ammoListBox.SelectedItem;

            RemoveDialog dialog = new RemoveDialog();
            dialog.SetMessage("Delete " + ammo.ToString());
            if (dialog.ShowDialog(this) == DialogResult.Yes)
            {
                _ammunitionRepo.Delete(ammo.Id);
                _ammunitionRepo.Save();
                lastSelectedAmmoIndex = 0;
                LoadAmmunition();
            }

            dialog.Dispose();
        }

        private void ammoSaveButton_Click(object sender, EventArgs e)
        {
            var ammo = (Ammunition)ammoListBox.SelectedItem;
            ammo.Manufacturer = ammoManufacturerTextBox.Text;
            ammo.Caliber = ammoCaliberTextBox.Text;
            ammo.ProjectileType = GetAmmoSelectedProjectileType();
            ammo.ProjectileWeight = float.Parse(ammoWeightTextBox.Text);
            ammo.BirdshotSize = ammoBirdshotSizeTextBox.Text;
            ammo.BuckshotSize = ammoBuckshotSizeTextBox.Text;
            ammo.BulletSlugName = ammoBulletSlugNameTextBox.Text;

            _ammunitionRepo.UpdateOrAdd(ammo);
            _ammunitionRepo.Save();

            AmmoSwitchEditMode(false);
            LoadAmmunition();
        }

        private Projectile GetAmmoSelectedProjectileType()
        {
            var checkedButton = ammoProjectileGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton == ammoBuckshotRadioButton)
                return Projectile.Buckshot;
            if (checkedButton == ammoBirdshotRadioButton)
                return Projectile.Birdshot;
            if (checkedButton == ammoSlugRadioButton)
                return Projectile.Slug;

            return Projectile.Bullet;
        }

        private void SetAmmoSelectedProjectileType(Projectile projectile)
        {
            ammoBulletRadioButton.Enabled = false;
            ammoBirdshotRadioButton.Enabled = false;
            ammoBuckshotRadioButton.Enabled = false;
            ammoSlugRadioButton.Enabled = false;

            switch (projectile)
            {
                case Projectile.Bullet:
                    ammoBulletRadioButton.Checked = true;
                    ammoBulletRadioButton.Enabled = true;
                    break;

                case Projectile.Birdshot:
                    ammoBirdshotRadioButton.Checked = true;
                    ammoBirdshotRadioButton.Enabled = true;
                    break;

                case Projectile.Buckshot:
                    ammoBuckshotRadioButton.Checked = true;
                    ammoBuckshotRadioButton.Enabled = true;
                    break;

                case Projectile.Slug:
                    ammoSlugRadioButton.Checked = true;
                    ammoSlugRadioButton.Enabled = true;
                    break;
            }

        }

        private void ammoCancelButton_Click(object sender, EventArgs e)
        {
            AmmoSwitchEditMode(false);
            _ammunitionRepo.ReloadFromDisk();
            LoadAmmunition();
        }

        private void ammoBulletRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ammoProjectileWeightLabel.Enabled = true;
            ammoWeightTextBox.Enabled = true;

            ammoWeightGrammLabel.Enabled = true;

            ammoBirdshotSizeLabel.Enabled = false;
            ammoBirdshotSizeTextBox.Enabled = false;

            ammoBuckshotSizeLabel.Enabled = false;
            ammoBuckshotSizeTextBox.Enabled = false;

            ammoBulletSlugNameLabel.Enabled = true;
            ammoBulletSlugNameTextBox.Enabled = true;
        }

        private void ammoBirdshotRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ammoProjectileWeightLabel.Enabled = true;
            ammoWeightTextBox.Enabled = true;
            ammoWeightGrammLabel.Enabled = true;

            ammoBirdshotSizeLabel.Enabled = true;
            ammoBirdshotSizeTextBox.Enabled = true;

            ammoBuckshotSizeLabel.Enabled = false;
            ammoBuckshotSizeTextBox.Enabled = false;

            ammoBulletSlugNameLabel.Enabled = false;
            ammoBulletSlugNameTextBox.Enabled = false;
        }

        private void ammoBuckshotRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ammoProjectileWeightLabel.Enabled = true;
            ammoWeightTextBox.Enabled = true;
            ammoWeightGrammLabel.Enabled = true;

            ammoBirdshotSizeLabel.Enabled = false;
            ammoBirdshotSizeTextBox.Enabled = false;

            ammoBuckshotSizeLabel.Enabled = true;
            ammoBuckshotSizeTextBox.Enabled = true;

            ammoBulletSlugNameLabel.Enabled = false;
            ammoBulletSlugNameTextBox.Enabled = false;
        }

        private void ammoSlugRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ammoProjectileWeightLabel.Enabled = true;
            ammoWeightTextBox.Enabled = true;
            ammoWeightGrammLabel.Enabled = true;

            ammoBirdshotSizeLabel.Enabled = false;
            ammoBirdshotSizeTextBox.Enabled = false;

            ammoBuckshotSizeLabel.Enabled = false;
            ammoBuckshotSizeTextBox.Enabled = false;

            ammoBulletSlugNameLabel.Enabled = true;
            ammoBulletSlugNameTextBox.Enabled = true;
        }

        private void ammoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastSelectedAmmoIndex = ammoListBox.SelectedIndex;
            var ammo = (Ammunition)ammoListBox.SelectedItem;
            FillAmmoCard(ammo);
        }

        // LOG records

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRecordForm dialog = new AddRecordForm(null);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                LoadLogRecords(true);
            }

            dialog.Dispose();
        }

        private void removeRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = logDataGridView.SelectedRows[0];
            var record = row.DataBoundItem as LogRecord;

            RemoveDialog dialog = new RemoveDialog();
            dialog.SetMessage("Delete LOG records at " + record.Date);
            if (dialog.ShowDialog(this) == DialogResult.Yes)
            {
                _recordsRepo.Delete(record.Id);
                _recordsRepo.Save();
                LoadLogRecords(false);
            }

            dialog.Dispose();
        }

        private void LoadLogRecords(bool reinit)
        {
            if (reinit)
                _recordsRepo.ReloadFromDisk();

            logDataGridView.DataSource = _recordsRepo.GetAll();
            logDataGridView.Columns["Id"].Visible = false;
            logDataGridView.Refresh();
        }
    }
}
