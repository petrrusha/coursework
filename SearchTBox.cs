using System.Windows.Forms;
namespace ElDee
{
    class SearchTBox : RichTextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            //запрет повторений
            if (TextLength != 0 && (e.KeyChar == ' ' || e.KeyChar == '-'))
                if (Text[SelectionStart - 1] == ' ' || Text[SelectionStart - 1] == '-')
                    e.Handled = true;
            if (e.KeyChar == ' ' || e.KeyChar == '-')
                for (int i = 0, g = 0; i < TextLength; i++)
                {
                    if ('-' == Text[i] || ' ' == Text[i])
                        g++;
                    if (g >= 2)
                    {
                        e.Handled = true;
                        break;
                    }
                }


            if (TextLength == 0)
            {
                if (!char.IsLetterOrDigit(e.KeyChar))
                    e.Handled = true;
            }
            else
            {
                if (char.IsDigit(Text[0]))
                {
                    if (!(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 18 || e.KeyChar == '-'))
                        e.Handled = true;
                }
                else
                {
                    if (!(char.IsLetter(e.KeyChar) || e.KeyChar == 18 || e.KeyChar == ' '))
                        e.Handled = true;
                }
            }
            base.OnKeyPress(e);
        }
    }
}
