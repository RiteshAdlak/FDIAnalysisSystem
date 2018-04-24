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

    public partial class Form2 : Form
    {
        public static List<Form> formList = new List<Form>();
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2.formList.ElementAt(0).Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox3.SelectedItem = "";
            textBox28.Text = "";
            comboBox2.SelectedItem = "";
            comboBox1.SelectedItem = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox8.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
            textBox15.Text = "";
            textBox11.Text = "";
            textBox16.Text = "";
            textBox12.Text = "";
            textBox17.Text = "";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox29.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox25.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox6.Text = "";
            textBox19.Text = "";
            textBox24.Text = "";
        }

        void reset()
        {
            textBox29.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox25.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox6.Text = "";
            textBox19.Text = "";
            textBox24.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {            
            
MongoServer mongo = MongoServer.Create();
            mongo.Connect();
            MongoDatabase db;

            db = mongo.GetDatabase("project");


            MongoCollection<Class2> bk = db.GetCollection<Class2>("economy");
            foreach (Class2 mybook in bk.Find(Query.EQ("state_id", textBox29.Text.Trim())))
            {
                if (mybook.state_id.Equals(textBox29.Text))
                {
                    IMongoUpdate update1 = new UpdateDocument();
                    IMongoUpdate update2 = new UpdateDocument();
                    IMongoUpdate update3 = new UpdateDocument();
                    IMongoUpdate update4 = new UpdateDocument();
                    IMongoUpdate update5 = new UpdateDocument();
                    IMongoUpdate update6 = new UpdateDocument();
                    IMongoUpdate update7 = new UpdateDocument();
                    IMongoUpdate update8 = new UpdateDocument();
                    IMongoUpdate update9 = new UpdateDocument();
                    IMongoUpdate update10 = new UpdateDocument();
                    if (textBox29.Text != "")
                    {
                         if (textBox26.Text != "" || textBox27.Text != "" || textBox25.Text != "" || textBox21.Text != "" || textBox22.Text != ""||
                            textBox20.Text != "" || textBox24.Text != "" || textBox19.Text != "" || textBox23.Text != "" ||textBox6.Text != "")
                        {
                        update1 = MongoDB.Driver.Builders.Update.Set("tour", Convert.ToInt32(textBox26.Text.Trim()));
                        update2 = MongoDB.Driver.Builders.Update.Set("edu", Convert.ToInt32(textBox27.Text.Trim()));
                        update3 = MongoDB.Driver.Builders.Update.Set("trans", Convert.ToInt32(textBox25.Text.Trim()));
                        update4 = MongoDB.Driver.Builders.Update.Set("ftrade", Convert.ToInt32(textBox21.Text.Trim()));
                        update5 = MongoDB.Driver.Builders.Update.Set("infr", Convert.ToInt32(textBox22.Text.Trim()));
                        update6 = MongoDB.Driver.Builders.Update.Set("glob", Convert.ToInt32(textBox20.Text.Trim()));
                        update7 = MongoDB.Driver.Builders.Update.Set("serv", Convert.ToInt32(textBox24.Text.Trim()));
                        update8 = MongoDB.Driver.Builders.Update.Set("res", Convert.ToInt32(textBox19.Text.Trim()));
                        update9 = MongoDB.Driver.Builders.Update.Set("oth", Convert.ToInt32(textBox23.Text.Trim()));
                        update10 = MongoDB.Driver.Builders.Update.Set("pow", Convert.ToInt32(textBox6.Text.Trim()));
                        MessageBox.Show("updated !");

                    

                    bk.Update(Query.EQ("state_id", textBox29.Text), update1);
                    bk.Update(Query.EQ("state_id", textBox29.Text), update2);
                    bk.Update(Query.EQ("state_id", textBox29.Text), update3);
                    bk.Update(Query.EQ("state_id", textBox29.Text), update4);
                    bk.Update(Query.EQ("state_id", textBox29.Text), update5);
                    bk.Update(Query.EQ("state_id", textBox29.Text), update6);
                    bk.Update(Query.EQ("state_id", textBox29.Text), update7);
                    bk.Update(Query.EQ("state_id", textBox29.Text), update8);
                    bk.Update(Query.EQ("state_id", textBox29.Text), update9);
                    bk.Update(Query.EQ("state_id", textBox29.Text), update10);

                    reset();
                 }
                 else
                 {
                       MessageBox.Show("Insert all fields");

                 }
           }


                }
            }
        }
            
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm1 = new Form3(0);
            frm1.Show();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
           int sum = 0;

            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("project");
            MongoCollection<BsonDocument> eco1 = db.GetCollection<BsonDocument>("economy");

            try
            {
                if (textBox28.Text != "")
                {
                    if (textBox12.Text.GetType() == typeof(String) || textBox3.Text.GetType() == typeof(String) || textBox4.Text.GetType() == typeof(String) || textBox8.Text.GetType() == typeof(String) || textBox14.Text.GetType() == typeof(String) || textBox11.Text.GetType() == typeof(String)
                        || textBox13.Text.GetType() == typeof(String) || textBox15.Text.GetType() == typeof(String) || textBox16.Text.GetType() == typeof(String) || textBox17.Text.GetType() == typeof(String))
                    {

                        sum = Convert.ToInt32(textBox3.Text.Trim()) + Convert.ToInt32(textBox4.Text.Trim()) + Convert.ToInt32(textBox8.Text.Trim()) + Convert.ToInt32(textBox14.Text.Trim()) +
                        Convert.ToInt32(textBox13.Text.Trim()) + Convert.ToInt32(textBox15.Text.Trim()) + Convert.ToInt32(textBox11.Text.Trim()) + Convert.ToInt32(textBox16.Text.Trim()) +
                        Convert.ToInt32(textBox17.Text.Trim()) + Convert.ToInt32(textBox12.Text.Trim());
                        BsonDocument eco = new BsonDocument
            {
                {"year",Convert.ToInt32(comboBox3.SelectedItem.ToString())},
                {"region",comboBox2.SelectedItem.ToString()},
                {"sname",comboBox1.SelectedItem.ToString()},
                {"tour",Convert.ToInt32(textBox3.Text.Trim())},
                {"edu",Convert.ToInt32(textBox4.Text.Trim())},
                {"trans",Convert.ToInt32(textBox8.Text.Trim())},
                {"ftrade",Convert.ToInt32(textBox14.Text.Trim())},
                {"infr",Convert.ToInt32(textBox13.Text.Trim())},
                {"glob",Convert.ToInt32(textBox15.Text.Trim())},
                {"serv",Convert.ToInt32(textBox11.Text.Trim())},
                {"res",Convert.ToInt32(textBox16.Text.Trim())},
                {"oth",Convert.ToInt32(textBox17.Text.Trim())},
                {"pow",Convert.ToInt32(textBox12.Text.Trim())},
                 {"state_id",textBox28.Text.Trim()},
                 {"total",sum}        

                 
            };
                        int fadd=0;
                        MongoCursor<Class2> put = db.GetCollection<Class2>("economy").FindAll();
                        foreach (Class2 i in put)
                        {
                            if (i.state_id == textBox28.Text.Trim())
                            {
                                 fadd = 1;
                                 MessageBox.Show("Record already Exist");
                            }
                        }

                        if (fadd == 0)
                        {
                            eco1.Insert(eco);

                            MessageBox.Show("Inserted Successfully");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Enter Data !!! ");
                    }

                }
                else {
                    MessageBox.Show("Enter State_ID !!! ");
                }
            }


            catch (Exception q)
            {

                MessageBox.Show("invalid input");
            }

        }


        private void button6_Click(object sender, EventArgs e)
        {
           MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("project");




            int f = 0;

            MongoCollection<Class2> bk = db.GetCollection<Class2>("economy");
                MongoCursor<Class2> put = db.GetCollection<Class2>("economy").FindAll();
               foreach (Class2 mybook in put)
                {
                    if (mybook.state_id.Equals(textBox30.Text))
                    {
                        bk.Remove(Query.EQ("state_id", textBox30.Text.Trim()));
                        MessageBox.Show("Record successfully deleted!");
                        f = 1;
                        break;
                    }
                   
                }
            if(f==0)
            {
                MessageBox.Show("Record not found!");

            }
                textBox30.Text = "";
           
            
          
            
        }
       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox28.Text = dataGridView1.SelectedCells[0].Value.ToString();
            comboBox3.SelectedItem = dataGridView1.SelectedCells[1].Value.ToString();
            comboBox2.SelectedItem = dataGridView1.SelectedCells[2].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.SelectedCells[3].Value.ToString();


            textBox3.Text = dataGridView1.SelectedCells[4].Value.ToString();
            textBox4.Text = dataGridView1.SelectedCells[5].Value.ToString();
            textBox8.Text = dataGridView1.SelectedCells[6].Value.ToString();
            textBox14.Text = dataGridView1.SelectedCells[7].Value.ToString();
            textBox13.Text = dataGridView1.SelectedCells[8].Value.ToString();
            textBox15.Text = dataGridView1.SelectedCells[9].Value.ToString();
            textBox11.Text = dataGridView1.SelectedCells[10].Value.ToString();
            textBox16.Text = dataGridView1.SelectedCells[11].Value.ToString();
            textBox12.Text = dataGridView1.SelectedCells[12].Value.ToString();
            textBox17.Text = dataGridView1.SelectedCells[13].Value.ToString();
       
        }

        private void refresh()
        {
            try
            {
                MongoClient client = new MongoClient("mongodb://localhost");
                MongoServer server = client.GetServer();
                MongoDatabase db = server.GetDatabase("project");
                MongoCursor<Class2> put = db.GetCollection<Class2>("economy").FindAll();
                dataGridView1.RowCount = 1;
                foreach (Class2 i in put)
                {
                    dataGridView1.Rows.Add(Convert.ToString(i.state_id), Convert.ToString(i.year), Convert.ToString(i.sname), Convert.ToString(i.region), Convert.ToString(i.tour), Convert.ToString(i.edu), Convert.ToString(i.trans), Convert.ToString(i.ftrade),
                        Convert.ToString(i.infr), Convert.ToString(i.glob), Convert.ToString(i.serv), Convert.ToString(i.res), Convert.ToString(i.pow), Convert.ToString(i.oth), i.total);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

           
        }

    
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox30.Text = "";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
