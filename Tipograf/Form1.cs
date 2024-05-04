using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Tipograf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void TypographRules(ref string text)
        {
            //Правило 19
            text = text.Replace("&", "&");

            //Правило 17
            text = Regex.Replace(text, @"\bампер-вольт\b", "А · В", RegexOptions.IgnoreCase);

            //Правило 13
            text = text.Replace("...", "…");

            //Правило 9
            text = text.Replace("+-", "±");

            //Правило 5
            text = Regex.Replace(text, @"\s*-\s*", "-");

            //Правило ё заменяется на йо
            text = text.Replace("ё", "йо");

            //Правило после цифры и перед знаком % должен стоять пробел
            text = Regex.Replace(text, @"(?<!\s)(%)", " $1");
        }

        private void btntip_Click(object sender, EventArgs e)
        {
            string text = textBoxinput.Text;
            TypographRules(ref text);
            textBoxoutput.Text = text;
        }
    }
}
