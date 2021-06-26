
namespace Roberta.Forms
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
            this.itemLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dialogYesButton
            // 
            this.dialogYesButton.Location = new System.Drawing.Point(48, 126);
            this.dialogYesButton.Name = "dialogYesButton";
            this.dialogYesButton.Size = new System.Drawing.Size(75, 23);
            this.dialogYesButton.TabIndex = 0;
            this.dialogYesButton.Text = "Yes";
            this.dialogYesButton.UseVisualStyleBackColor = true;
            // 
            // dialogNoButton
            // 
            this.dialogNoButton.Location = new System.Drawing.Point(252, 126);
            this.dialogNoButton.Name = "dialogNoButton";
            this.dialogNoButton.Size = new System.Drawing.Size(75, 23);
            this.dialogNoButton.TabIndex = 1;
            this.dialogNoButton.Text = "No";
            this.dialogNoButton.UseVisualStyleBackColor = true;
            // 
            // dialogMessageLabel
            // 
            this.dialogMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogMessageLabel.AutoSize = true;
            this.dialogMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dialogMessageLabel.Location = new System.Drawing.Point(87, 9);
            this.dialogMessageLabel.Name = "dialogMessageLabel";
            this.dialogMessageLabel.Size = new System.Drawing.Size(202, 20);
            this.dialogMessageLabel.TabIndex = 2;
            this.dialogMessageLabel.Text = "Are you sure to delete this?";
            // 
            // itemLabel
            // 
            this.itemLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.itemLabel.Location = new System.Drawing.Point(1, 29);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(380, 94);
            this.itemLabel.TabIndex = 3;
            this.itemLabel.Text = "label1";
            this.itemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.dialogMessageLabel);
            this.Controls.Add(this.dialogNoButton);
            this.Controls.Add(this.dialogYesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RemoveDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Roberta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dialogYesButton;
        private System.Windows.Forms.Button dialogNoButton;
        private System.Windows.Forms.Label dialogMessageLabel;
        private System.Windows.Forms.Label itemLabel;
    }
}