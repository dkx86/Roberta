
namespace Roberta.Forms
{
    partial class AddRecordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateLabel = new System.Windows.Forms.Label();
            this.firearmLabel = new System.Windows.Forms.Label();
            this.ammoLabel = new System.Windows.Forms.Label();
            this.roundsLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firearmComboBox = new System.Windows.Forms.ComboBox();
            this.ammoComboBox = new System.Windows.Forms.ComboBox();
            this.roundsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roundsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(30, 30);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date:";
            // 
            // firearmLabel
            // 
            this.firearmLabel.AutoSize = true;
            this.firearmLabel.Location = new System.Drawing.Point(30, 60);
            this.firearmLabel.Name = "firearmLabel";
            this.firearmLabel.Size = new System.Drawing.Size(44, 13);
            this.firearmLabel.TabIndex = 1;
            this.firearmLabel.Text = "Firearm:";
            // 
            // ammoLabel
            // 
            this.ammoLabel.AutoSize = true;
            this.ammoLabel.Location = new System.Drawing.Point(30, 90);
            this.ammoLabel.Name = "ammoLabel";
            this.ammoLabel.Size = new System.Drawing.Size(64, 13);
            this.ammoLabel.TabIndex = 2;
            this.ammoLabel.Text = "Ammunition:";
            // 
            // roundsLabel
            // 
            this.roundsLabel.AutoSize = true;
            this.roundsLabel.Location = new System.Drawing.Point(30, 120);
            this.roundsLabel.Name = "roundsLabel";
            this.roundsLabel.Size = new System.Drawing.Size(47, 13);
            this.roundsLabel.TabIndex = 3;
            this.roundsLabel.Text = "Rounds:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(105, 30);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 4;
            // 
            // firearmComboBox
            // 
            this.firearmComboBox.FormattingEnabled = true;
            this.firearmComboBox.Location = new System.Drawing.Point(105, 60);
            this.firearmComboBox.Name = "firearmComboBox";
            this.firearmComboBox.Size = new System.Drawing.Size(200, 21);
            this.firearmComboBox.TabIndex = 5;
            // 
            // ammoComboBox
            // 
            this.ammoComboBox.FormattingEnabled = true;
            this.ammoComboBox.Location = new System.Drawing.Point(105, 90);
            this.ammoComboBox.Name = "ammoComboBox";
            this.ammoComboBox.Size = new System.Drawing.Size(200, 21);
            this.ammoComboBox.TabIndex = 6;
            // 
            // roundsNumericUpDown
            // 
            this.roundsNumericUpDown.Location = new System.Drawing.Point(105, 120);
            this.roundsNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.roundsNumericUpDown.Name = "roundsNumericUpDown";
            this.roundsNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.roundsNumericUpDown.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(33, 176);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(230, 176);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 233);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.roundsNumericUpDown);
            this.Controls.Add(this.ammoComboBox);
            this.Controls.Add(this.firearmComboBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.roundsLabel);
            this.Controls.Add(this.ammoLabel);
            this.Controls.Add(this.firearmLabel);
            this.Controls.Add(this.dateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LOG Record";
            ((System.ComponentModel.ISupportInitialize)(this.roundsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label firearmLabel;
        private System.Windows.Forms.Label ammoLabel;
        private System.Windows.Forms.Label roundsLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox firearmComboBox;
        private System.Windows.Forms.ComboBox ammoComboBox;
        private System.Windows.Forms.NumericUpDown roundsNumericUpDown;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}