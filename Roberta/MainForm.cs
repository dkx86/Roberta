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
        private int lastSelectedFirearmIndex;
        private int lastSelectedAmmoIndex;

        public MainForm()
        {
            _firearmsRepo = new FirearmsRepo();
            _ammunitionRepo = new AmmunitionRepo();

            InitializeComponent();
            // init data repos
            _firearmsRepo.Initialize();

            LoadFirearms();
            FirearmsSwitchEditMode(false);

            LoadAmmunition();
            AmmoSwitchEditMode(false);
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
            if(firearmsListBox.Items.Count > 0)
                firearmsListBox.SetSelected(lastSelectedFirearmIndex, true);
        }

        private void LoadAmmunition()
        {
            var ammo = _ammunitionRepo.GetAllAmmo();
            ammoListBox.Items.Clear();
            ammo.ForEach(a => ammoListBox.Items.Add(a));
            if(ammoListBox.Items.Count > 0)
                ammoListBox.SetSelected(lastSelectedAmmoIndex, true);
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

            ammoWeightNumericUpDown.Value = (decimal)ammo.ProjectileWeight;
            ammoBirdshotSizeTextBox.Text = ammo.BirdshotSize;
            ammoBirdshotSizeTextBox.Text = ammo.BuckshotSize;
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
            ammoProjectileGroupBox.Enabled = isOn;
            ammoWeightNumericUpDown.ReadOnly = !isOn;
            ammoWeightNumericUpDown.Enabled = isOn;
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
            editRecordToolStripMenuItem.Enabled = false;
            removeRecordToolStripMenuItem.Enabled = false;

            editFirearmToolStripMenuItem.Enabled = false;
            removeFirearmToolStripMenuItem.Enabled = false;

            editAmmoToolStripMenuItem.Enabled = false;
            removeAmmoToolStripMenuItem.Enabled = false;

            switch (index)
            {
                case 0: // LOG
                    editRecordToolStripMenuItem.Enabled = true;
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
            ammo.ProjectileWeight = (float)ammoWeightNumericUpDown.Value;
            ammo.BirdshotSize = ammoBirdshotSizeTextBox.Text;
            ammo.BuckshotSize = ammoBirdshotSizeTextBox.Text;
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

            switch (projectile)
            {
                case Projectile.Bullet:
                    ammoBulletRadioButton.Checked = true;
                    break;

                case Projectile.Birdshot:
                    ammoBirdshotRadioButton.Checked = true;
                    break;

                case Projectile.Buckshot:
                    ammoBuckshotRadioButton.Checked = true;
                    break;

                case Projectile.Slug:
                    ammoSlugRadioButton.Checked = true;
                    break;
            }

        }

        private void ammoCancelButton_Click(object sender, EventArgs e)
        {
            AmmoSwitchEditMode(false);
            LoadAmmunition();
        }

        private void ammoBulletRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ammoProjectileWeightLabel.Visible = true;
            ammoWeightNumericUpDown.Visible = true;
            ammoWeightGrammLabel.Visible = true;

            ammoBirdshotSizeLabel.Visible = false;
            ammoBirdshotSizeTextBox.Visible = false;

            ammoBuckshotSizeLabel.Visible = false;
            ammoBuckshotSizeTextBox.Visible = false;

            ammoBulletSlugNameLabel.Visible = true;
            ammoBulletSlugNameTextBox.Visible = true;
        }

        private void ammoBirdshotRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ammoProjectileWeightLabel.Visible = true;
            ammoWeightNumericUpDown.Visible = true;
            ammoWeightGrammLabel.Visible = true;

            ammoBirdshotSizeLabel.Visible = true;
            ammoBirdshotSizeTextBox.Visible = true;

            ammoBuckshotSizeLabel.Visible = false;
            ammoBuckshotSizeTextBox.Visible = false;

            ammoBulletSlugNameLabel.Visible = false;
            ammoBulletSlugNameTextBox.Visible = false;
        }

        private void ammoBuckshotRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ammoProjectileWeightLabel.Visible = true;
            ammoWeightNumericUpDown.Visible = true;
            ammoWeightGrammLabel.Visible = true;

            ammoBirdshotSizeLabel.Visible = false;
            ammoBirdshotSizeTextBox.Visible = false;

            ammoBuckshotSizeLabel.Visible = true;
            ammoBuckshotSizeTextBox.Visible = true;

            ammoBulletSlugNameLabel.Visible = false;
            ammoBulletSlugNameTextBox.Visible = false;
        }

        private void ammoSlugRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ammoProjectileWeightLabel.Visible = true;
            ammoWeightNumericUpDown.Visible = true;
            ammoWeightGrammLabel.Visible = true;

            ammoBirdshotSizeLabel.Visible = false;
            ammoBirdshotSizeTextBox.Visible = false;

            ammoBuckshotSizeLabel.Visible = false;
            ammoBuckshotSizeTextBox.Visible = false;

            ammoBulletSlugNameLabel.Visible = true;
            ammoBulletSlugNameTextBox.Visible = true;
        }

        private void ammoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastSelectedAmmoIndex = ammoListBox.SelectedIndex;
            var ammo = (Ammunition)ammoListBox.SelectedItem;
            FillAmmoCard(ammo);
        }
    }
}
