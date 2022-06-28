using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            switch (rand.Next(0, 10))
            {
                case 0: button2.BackColor = Color.Green; break;
                case 1: button2.BackColor = Color.Red; break;
                case 2: button2.BackColor = Color.Yellow; break;
                case 3: button2.BackColor = Color.White; break;
                case 4: button2.BackColor = Color.Gray; break;
                case 5: button2.BackColor = Color.Blue; break;
                case 6: button2.BackColor = Color.Cyan; break;
                case 7: button2.BackColor = Color.DarkBlue; break;
                case 8: button2.BackColor = Color.DarkCyan; break;
                case 9: button2.BackColor = Color.DarkGray; break;
                case 10: button2.BackColor = Color.DarkRed; break;
            }

            if (button1.BackColor == Color.Red)
            { 
                double x = double.Parse(for_x.Text);
                double y = double.Parse(for_y.Text);

                if (x!=0 && y!=0)
                {
                    double res1 = (5 * x / (Math.Pow(x, 3) + Math.Pow(y, 3)) - 1 / (Math.Tan(3 * x / y)));
                    Result_1.Text = Convert.ToString(res1);
                }
                else
                {
                    Result_1.Text = "Error!";
                }                             
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            switch (rand.Next(0, 10))
            {
                case 0: button1.BackColor = Color.Green; break;
                case 1: button1.BackColor = Color.Red; break;
                case 2: button1.BackColor = Color.Yellow; break;
                case 3: button1.BackColor = Color.White; break;
                case 4: button1.BackColor = Color.Gray; break;
                case 5: button1.BackColor = Color.Blue; break;
                case 6: button1.BackColor = Color.Cyan; break;
                case 7: button1.BackColor = Color.DarkBlue; break;
                case 8: button1.BackColor = Color.DarkCyan; break;
                case 9: button1.BackColor = Color.DarkGray; break;
                case 10: button1.BackColor = Color.DarkRed; break;
                    
            }
            if (button2.BackColor == Color.Green)
            {
                double x = int.Parse(for_x.Text);
                double a = int.Parse(for_a.Text);

                if ((a != 0) && (x > 0 && a > 0) || (x < 0 && a < 0))
                {
                    double res2 = Math.Sign(x-2*a)+Math.Log((x/a),3);
                    Result_2.Text = Convert.ToString(res2);
                }
                else
                {
                    Result_2.Text = "Error!";
                }
            }           
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(
                "Прости. Прощай. Привет", 
                "Важливе повідомлення");
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
