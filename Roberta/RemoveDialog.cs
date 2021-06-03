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
    public partial class RemoveDialog : Form
    {
        public RemoveDialog()
        {
            InitializeComponent();
            dialogYesButton.DialogResult = DialogResult.Yes;
            dialogNoButton.DialogResult = DialogResult.No;
        }

        public void SetMessage(string message)
        {
            dialogMessageLabel.Text = message;
        }
    }
}
