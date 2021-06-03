
namespace Roberta
{
    partial class RemoveDialog
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
            this.dialogYesButton = new System.Windows.Forms.Button();
            this.dialogNoButton = new System.Windows.Forms.Button();
            this.dialogMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dialogYesButton
            // 
            this.dialogYesButton.Location = new System.Drawing.Point(121, 122);
            this.dialogYesButton.Name = "dialogYesButton";
            this.dialogYesButton.Size = new System.Drawing.Size(75, 23);
            this.dialogYesButton.TabIndex = 0;
            this.dialogYesButton.Text = "Yes";
            this.dialogYesButton.UseVisualStyleBackColor = true;
            // 
            // dialogNoButton
            // 
            this.dialogNoButton.Location = new System.Drawing.Point(268, 122);
            this.dialogNoButton.Name = "dialogNoButton";
            this.dialogNoButton.Size = new System.Drawing.Size(75, 23);
            this.dialogNoButton.TabIndex = 1;
            this.dialogNoButton.Text = "No";
            this.dialogNoButton.UseVisualStyleBackColor = true;
            // 
            // dialogMessageLabel
            // 
            this.dialogMessageLabel.AutoSize = true;
            this.dialogMessageLabel.Location = new System.Drawing.Point(191, 45);
            this.dialogMessageLabel.Name = "dialogMessageLabel";
            this.dialogMessageLabel.Size = new System.Drawing.Size(72, 13);
            this.dialogMessageLabel.TabIndex = 2;
            this.dialogMessageLabel.Text = "Are you sure?";
            // 
            // RemoveDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 177);
            this.Controls.Add(this.dialogMessageLabel);
            this.Controls.Add(this.dialogNoButton);
            this.Controls.Add(this.dialogYesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RemoveDialog";
            this.Text = "Roberta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dialogYesButton;
        private System.Windows.Forms.Button dialogNoButton;
        private System.Windows.Forms.Label dialogMessageLabel;
    }
}