using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculater_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num, ans;
        int count;
        private int i;

        public void disable() // creete one method to disable calculator
        {
            // follow are disable when call we disable () function
            textBox1.Enabled = false;
            button1.Show(); // it will still display
            button2.Hide(); // IT WILL BE HIDE
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;


        }
        public void enable() // now  create one fuction to ON calculator
        {
            // following are enable when we call enable() fuction
            textBox1.Enabled = true;
            button2.Show(); // it will still display
            button1.Hide(); // IT WILL BE HIDE
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;




        }
        private void button1_Click(object sender, EventArgs e)
        {
            enable();
        }
        

        private void button16_Click(object sender, EventArgs e)
        {
            // displayed dot(.) intextbox when pres dot(.) button with red colour
            textBox1.Text = textBox1.Text + ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //displayed 0 in textbox when press o buttin with red color
            textBox1.Text = textBox1.Text + "0";
            textBox1.ForeColor = Color.Red;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // displeyed 1 in textbox when pres 1 button with red colour
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Red;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // displayed 2 in Textbox when press 2 button with red colour
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Red;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // displayed 3 in Textbox when press 3 button with red colour
           textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // displayed 4 in Textbox when press 4 button with red colour
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Red;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // displayed 5 in textbox when press 5 button red colour
            textBox1.Text = textBox1.Text  + 5;
            textBox1.ForeColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // displayed 6 in Textbox when press 6 button with red colour
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // displayed 7 in Textbox when press 7 button with red colour
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // displayed 8 in Textbox when press 8 button with red colour
            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // displayed 9 in Textbox when press 9 button with red colour
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e) //clear
        {
            textBox1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)// ENABLE BUTTTON
        {
            disable(); // call enable fuction to calculator
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) // additon button
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";
        }

        private void button11_Click(object sender, EventArgs e)// subtraction
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void button9_Click(object sender, EventArgs e)//multipliction button
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void button18_Click(object sender, EventArgs e)//  division 
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            compute();
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++) ;
            textBox1.Text = textBox1.Text + text[i]; 

        }

        public void compute()
        {

            switch (count) // creating  switch statement

            {
                case 1:
                    ans = num + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 2:
                    ans = num - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                default:
                    break;








            }




        }










    }
    }
    

