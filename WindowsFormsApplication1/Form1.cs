using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Guest" /*&& textBox2.Text == "guest"*/)
            {
                
              //   Form3 value = new Form3();
                 
                 MessageBox.Show("Login Succsessfully");
                this.Hide();
                Form3 frm3 = new Form3(8);
                frm3.Show();
            }
            else if(comboBox1.SelectedItem=="Admin" && textBox2.Text=="123")
            {
                MessageBox.Show("Login Succsessfully");
                this.Hide();
                Form2 frm = new Form2();

                Form2.formList.Add(this);
                Form2.formList.Add(frm);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid User");        
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
         //   textBox1.Text ="";
            textBox2.Text ="";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            
            Form2.formList.Add(this);
            Form2.formList.Add(frm);
            frm.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Guest")
                textBox2.Enabled = false;
            else
                textBox2.Enabled = true;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        
    }
}
