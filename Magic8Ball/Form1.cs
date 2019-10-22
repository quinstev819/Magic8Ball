using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Random randGen = new Random();
            int answers = randGen.Next(1, 21);

            switch (answers)
            {
                case 1:
                    outputLabel.Text = "It is certain.";
                    break;
                case 2:
                    outputLabel.Text = "It is decidedly so.";
                    break;
                case 3:
                    outputLabel.Text = "Without a doubt.";
                    break;
                case 4:
                    outputLabel.Text = "Yes - definitely.";
                    break;
                case 5:
                    outputLabel.Text = "You may rely on it.";
                    break;
                case 6:
                    outputLabel.Text = "As I see it, yes.";
                    break;
                case 7:
                    outputLabel.Text = "Most likely.";
                    break;
                case 8:
                    outputLabel.Text = "Outlook good.";
                    break;
                case 9:
                    outputLabel.Text = "Yes.";
                    break;
                case 10:
                    outputLabel.Text = "Signs point to yes.";
                    break;
                case 11:
                    outputLabel.Text = "Reply hazy, try again.";
                    break;
                case 12:
                    outputLabel.Text = "Ask again later.";
                    break;
                case 13:
                    outputLabel.Text = "Better not tell you now";
                    break;
                case 14:
                    outputLabel.Text = "Cannot predict now.";
                    break;
                case 15:
                    outputLabel.Text = "Concentrate and ask again.";
                    break;
                case 16:
                    outputLabel.Text = "Don't count on it.";
                    break;
                case 17:
                    outputLabel.Text = "My reply is no.";
                    break;
                case 18:
                    outputLabel.Text = "My sources say no.";
                    break;
                case 19:
                    outputLabel.Text = "Outlook not so good.";
                    break;
                case 20:
                    outputLabel.Text = "Very doubtful.";
                    break;
                default:
                    outputLabel.Text = "Please try again.";
                    break;
            }
        }
    }
}
