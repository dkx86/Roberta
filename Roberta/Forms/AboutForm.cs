using System.Windows.Forms;

namespace Roberta.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gitHubLinkLabel.LinkVisited = true;
            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://github.com/dkx86/Roberta");
        }
    }
}
