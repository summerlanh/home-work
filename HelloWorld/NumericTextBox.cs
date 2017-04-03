using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace HelloWorld
{
    public class NumericTextBox : TextBox
    {
        protected override void OnPreviewTextInput(TextCompositionEventArgs e)
        {
            // gate keeper is called handled
            // if a number then let it through if a char do not let it through
            e.Handled = !AreAllValidNumericChars(e.Text);
            base.OnPreviewTextInput(e);
        }

        private bool AreAllValidNumericChars(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsNumber(c)) return false;
            }
            return true;
        }
    }
}
