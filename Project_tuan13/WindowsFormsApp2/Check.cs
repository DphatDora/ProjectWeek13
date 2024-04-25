using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class CheckCondition
    {
        public CheckCondition() { }
        ErrorProvider errorProvider = new ErrorProvider();

        bool ValidateIsNotNullOrWhitespace(Guna2TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                // textBox.Tag - use this to get a custom message for this text-box
                var message = "Please provide your Name.";
                errorProvider.SetError(textBox, message);
                return true;
            }
            errorProvider.SetError(textBox, string.Empty); // clears error message
            return false;
        }
        public void AttachValidatingEventToTextBoxes(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is Guna2TextBox)
                {
                    ((Guna2TextBox)control).Validating += (sender, e) =>
                    {
                        e.Cancel = ValidateIsNotNullOrWhitespace((Guna2TextBox)sender);
                    };
                }
                else if (control.HasChildren)
                {
                    AttachValidatingEventToTextBoxes(control); // Gọi đệ quy để duyệt qua tất cả các control con
                }
            }
        }
    }
}
