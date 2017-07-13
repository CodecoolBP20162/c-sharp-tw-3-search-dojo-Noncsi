using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SearchDojo
{
    public partial class Form1 : Form
    {
        string text;
        string pattern;

        public Form1()
        {
            InitializeComponent();
        }

        void SetData()
        {
            text = "One advanced diverted domestic sex repeated bringing you old. " +
                    "Possible procured her trifling laughter thoughts property she met way. " +
                    "Companions shy had solicitude favourable own. Which could saw guest man now heard but. " +
                    "Lasted my coming uneasy marked so should. Gravity letters it amongst herself dearest an windows by. " +
                    "Wooded ladies she basket season age her uneasy saw. Discourse unwilling am no described dejection incommode no listening of. " +
                    "Before nature his parish boy." +
                    "Savings her pleased are several started females met. Short her not among being any. " +
                    "Thing of judge fruit charm views do. Miles mr an forty along as he. She education get middleton day agreement performed preserved unwilling. " +
                    "Do however as pleased offence outward beloved by present. By outward neither he so covered amiable greater. " +
                    "Juvenile proposal betrayed he an informed weddings followed. Precaution day see imprudence sympathize principles. " +
                    "At full leaf give quit to in they up.";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetData();
            txtText.Text = text;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtMatched.Text = "";
           MatchCollection matches = Regex.Matches(text, txtPattern.Text);
            try
            {
                foreach (Match item in matches)
                {
                    txtMatched.Text += (item.ToString());
                }
            }
            catch
            {
                txtMatched.Text = "No match found";
            }
            
        }
    }
}
