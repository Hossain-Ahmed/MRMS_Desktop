using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealRateSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void disable()
        {
            button13.Show();
            button14.Hide();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
           
            button11.Enabled = false;
            button12.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            
            textBox8.Enabled = false;
           
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;
            textBox19.Enabled = false;
            textBox20.Enabled = false;
            textBox21.Enabled = false;
            textBox22.Enabled = false;
            textBox23.Enabled = false;
            textBox24.Enabled = false;
            textBox25.Enabled = false;
            textBox26.Enabled = false;
            textBox27.Enabled = false;
           
            textBox29.Enabled = false;
        }
        public void enable()
        {
            button14.Show();
            button13.Hide();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
          
            button11.Enabled = true;
            button12.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
           
            textBox8.Enabled = true;
           
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            textBox14.Enabled = true;
            textBox15.Enabled = true;
            textBox16.Enabled = true;
            textBox17.Enabled = true;
            textBox18.Enabled = true;
            textBox19.Enabled = true;
            textBox20.Enabled = true;
            textBox21.Enabled = true;
            textBox22.Enabled = true;
            textBox23.Enabled = true;
            textBox24.Enabled = true;
            textBox25.Enabled = true;
            textBox26.Enabled = true;
            textBox27.Enabled = true;
           
            textBox29.Enabled = true;


        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox8.Text = (Convert.ToDecimal(textBox1.Text) + Convert.ToDecimal(textBox2.Text) + Convert.ToDecimal(textBox3.Text) + Convert.ToDecimal(textBox4.Text) + Convert.ToDecimal(textBox5.Text) + Convert.ToDecimal(textBox6.Text)).ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox16.Text = ( Convert.ToDecimal(textBox10.Text) + Convert.ToDecimal(textBox11.Text) + Convert.ToDecimal(textBox12.Text) + Convert.ToDecimal(textBox13.Text) + Convert.ToDecimal(textBox14.Text) + Convert.ToDecimal(textBox15.Text)).ToString("0.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox17.Text = (Convert.ToDecimal(textBox16.Text) / Convert.ToDecimal(textBox8.Text)).ToString("0.00");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)// result for Quamrul vai
        {
            textBox22.Text = (Convert.ToDecimal(textBox1.Text) * Convert.ToDecimal(textBox17.Text) + Convert.ToDecimal(textBox18.Text) + Convert.ToDecimal(textBox19.Text) + Convert.ToDecimal(textBox20.Text) + Convert.ToDecimal(textBox21.Text) - Convert.ToDecimal(textBox15.Text)).ToString("0.00");
        }

        private void button11_Click(object sender, EventArgs e)// clear button
        {
         textBox1.Text = " ";textBox2.Text = " ";textBox3.Text = " "; textBox4.Text = " "; textBox5.Text = " "; textBox6.Text = " "; ; textBox8.Text = " "; ; textBox10.Text = " "; textBox11.Text = " "; textBox12.Text = " "; textBox13.Text = " "; textBox14.Text = " "; textBox29.Text = " ";
         textBox15.Text = " "; textBox16.Text = " "; textBox17.Text = " "; textBox18.Text = " "; textBox19.Text = " "; textBox20.Text = " "; textBox21.Text = " "; textBox22.Text = " "; textBox23.Text = " "; textBox24.Text = " "; textBox25.Text = " "; textBox26.Text = " "; textBox27.Text = " "; 


        }

        private void button5_Click(object sender, EventArgs e)// masum vai
        {
            textBox23.Text = (Convert.ToDecimal(textBox2.Text) * Convert.ToDecimal(textBox17.Text) + Convert.ToDecimal(textBox18.Text) + Convert.ToDecimal(textBox19.Text) + Convert.ToDecimal(textBox20.Text) + Convert.ToDecimal(textBox21.Text) - Convert.ToDecimal(textBox14.Text)).ToString("0.00");
        }

        private void button6_Click(object sender, EventArgs e)// result for ujjol vai
        {
            textBox24.Text = (Convert.ToDecimal(textBox3.Text) * Convert.ToDecimal(textBox17.Text) + Convert.ToDecimal(textBox18.Text) + Convert.ToDecimal(textBox19.Text) + Convert.ToDecimal(textBox20.Text) + Convert.ToDecimal(textBox21.Text) - Convert.ToDecimal(textBox13.Text)).ToString("0.00");

        }

        private void button7_Click(object sender, EventArgs e)// result for Zahir vai
        {
            textBox25.Text = (Convert.ToDecimal(textBox4.Text) * Convert.ToDecimal(textBox17.Text) + Convert.ToDecimal(textBox18.Text) + Convert.ToDecimal(textBox19.Text) + Convert.ToDecimal(textBox20.Text) + Convert.ToDecimal(textBox21.Text) - Convert.ToDecimal(textBox12.Text)).ToString("0.00");
        }

        private void button8_Click(object sender, EventArgs e)// result for Sujon
        {
            textBox26.Text = (Convert.ToDecimal(textBox5.Text) * Convert.ToDecimal(textBox17.Text) + Convert.ToDecimal(textBox18.Text) + Convert.ToDecimal(textBox19.Text) + Convert.ToDecimal(textBox20.Text) + Convert.ToDecimal(textBox21.Text) - Convert.ToDecimal(textBox11.Text)).ToString("0.00");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox27.Text = (Convert.ToDecimal(textBox6.Text) * Convert.ToDecimal(textBox17.Text) + Convert.ToDecimal(textBox18.Text) + Convert.ToDecimal(textBox19.Text) + Convert.ToDecimal(textBox20.Text) + Convert.ToDecimal(textBox21.Text) - Convert.ToDecimal(textBox10.Text)).ToString("0.00");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox29.Text = (Convert.ToDecimal(textBox22.Text) + Convert.ToDecimal(textBox23.Text) + Convert.ToDecimal(textBox24.Text) + Convert.ToDecimal(textBox25.Text) + Convert.ToDecimal(textBox26.Text) + Convert.ToDecimal(textBox27.Text)).ToString("0.00");
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
