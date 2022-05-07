using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLibrary.Controls
{
    public partial class PasswordTextBoxUserControl : UserControl
    {
        public PasswordTextBoxUserControl()
        {
            InitializeComponent();
        }

        public PasswordTextBox TextBox
        {
            get => PasswordTextBox;
            set => PasswordTextBox = value;
        }

        private void ToggleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.TextMasked(ToggleCheckBox.Checked);
        }
    }
}
