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
