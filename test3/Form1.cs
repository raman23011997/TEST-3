using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "my name is ramanjeet singh,my student number is 200349853 and i nam going to do great in this exam";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 one, two;
            //Int32 one = Convert.ToInt32(textBox1.Text);
            //Int32 two= Convert.ToInt32(textBox2.Text);
            Boolean ok = true;

            if (Int32.TryParse(textBox1.Text, out one) == false)
            {
                lblerr1.Visible = true;
                ok = false;

            }

            if (Int32.TryParse(textBox2.Text, out two) == false)
            {
                lblerr2.Visible = true;
                ok = false;
            }
            if (ok == true)
            {
                Int32 result = multinum(one, two);
                lblres.Text = result.ToString();
            }


        }
        private Int32 multinum(Int32 one, Int32 two)
        {
            Int32 result = one * two;
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            //333///
            String[] display = { "Merry ", "christmas", "c# is great" };
            for (var i = 0; i < 3; i++)
            {
                label3.Text += display[i];
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string password = txtpassword.Text;
            if (txtpassword.Text == "frosty")
            {
                lblpas.ForeColor = Color.Green;
                lblpas.Text = "You entered the correct password";
            }
            else
            {
                lblpas.ForeColor = Color.Red;
                lblpas.Text = "You entered the incorrect password";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[,] MOVIES = new string[3, 3];
            MOVIES[0, 0] = "	How the Grinch Stole Christmas";
            MOVIES[0, 1] = "1966\n";
            MOVIES[1, 0] = "Frosty the Snowman ";
            MOVIES[1, 1] = "1969\n";
            MOVIES[2, 0] = "Arthur Christmas ";
            MOVIES[2, 1] = "2011\n";

            for (var i = 0; i < 3; i++)
            {
                label4.Text += MOVIES[i, 0];
                label4.Text += MOVIES[i, 1];
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Double x = 4;
            Double y = 12;
            Double result = x / y;

            lblQ7.Text = result.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == Spring)
            {

                comboBox2.Text = "March\n,April\n,May\n";
            }
            else
                 if (comboBox1.SelectedItem == Summer)
            {

                comboBox2.Text = "june\n,july\n,august\n";

            }
            else
                 if (comboBox1.SelectedItem == fall)
            {

                comboBox2.Text = "sept\n,oct\n,nov\n";

            }
            else
                 if (comboBox1.SelectedItem == Winter)
            {

                comboBox2.Text = "dec\n,jan\n,feb\n";

            }
            }
    }
}
