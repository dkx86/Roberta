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

namespace Roberta
{
    public partial class MainForm : Form
    {
        private readonly FirearmsRepo _firearmsRepo;
        private int lastSelectedFirearmIndex;

        public MainForm()
        {
            _firearmsRepo = new FirearmsRepo();

            InitializeComponent();
            // init data repos
            _firearmsRepo.Initialize();

            FillListsWithData();

            FirearmsSwitchEditMode(false);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _firearmsRepo.Save();
        }

        private void FillListsWithData()
        {
            LoadFirearms();
        }

        private void LoadFirearms()
        {
            var firearms = _firearmsRepo.GetAllFirearms();
            firearmsListBox.Items.Clear();
            firearms.ForEach(f => firearmsListBox.Items.Add(f));
            firearmsListBox.SetSelected(lastSelectedFirearmIndex, true);
        }

        private void FillFirearmCard(Firearm firearm)
        {
            firearmManufacturerTextBox.Text = firearm.Manufacturer;
            firearmModelTextBox.Text = firearm.Model;
            firearmCaliberTextBox.Text = firearm.Caliber;
            firearmSerialNumberTextBox.Text = firearm.SerialNumber;
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
            _firearmsRepo.Delete(firearm.Id);
            _firearmsRepo.Save();
            lastSelectedFirearmIndex = 0;
            LoadFirearms();
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
    }
}
