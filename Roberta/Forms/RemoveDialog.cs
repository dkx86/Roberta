using System.Windows.Forms;

namespace Roberta.Forms
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
            itemLabel.Text = message;
        }

    }
}
