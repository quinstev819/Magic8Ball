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

            }
        }
    }
}
