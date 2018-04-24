using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == textBox7.Text)
            {
                MongoClient client = new MongoClient("mongodb://localhost");
                MongoServer server = client.GetServer();
                MongoDatabase db = server.GetDatabase("project");
                MongoCollection<BsonDocument> log1 = db.GetCollection<BsonDocument>("login");
                BsonDocument log = new BsonDocument
            {
                {"uname",textBox9.Text.Trim()},
                {"uemail",textBox8.Text.Trim()},
                {"upass",textBox7.Text.Trim()}      
            };
                log1.Insert(log);

                MessageBox.Show("Registered Successfully!!!");
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Re-confirm Password");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
