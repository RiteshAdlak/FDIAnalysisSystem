using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;



namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        int y=0;
        int f1 = 0, f2 = 0;
        public Form3(int us)
        {
            InitializeComponent();
            y = us;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (y == 8)
            {
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.Show();
            }
            else
            {
                this.Hide();
                Form2 frm = new Form2();
                frm.Show();
            }
        }
        //int f = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            int north = 0, south = 0, west = 0, east = 0, north2 = 0, south2 = 0, west2 = 0, east2 = 0;
            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("project");
            MongoCursor<Class2> put = db.GetCollection<Class2>("economy").FindAll();

            if (f1 == 1)
            { refreshchart(); }
            if (f1 == 0)
            {
                foreach (Class2 i in put)
                {

                    if (i.region.Equals("North"))
                    {
                        if (i.year.Equals(Convert.ToInt32("2015")))
                        {
                            north = north + i.total;
                        }
                        else
                        {
                            north2 = north2 + i.total;
                        }
                    }
                    if (i.region.Equals("East"))
                    {
                        if (i.year.Equals(Convert.ToInt32("2015")))
                        {
                            east = east + i.total;
                        }
                        else
                        {
                            east2 = east2 + i.total;
                        }
                    }
                    if (i.region.Equals("West"))
                    {
                        if (i.year.Equals(Convert.ToInt32("2015")))
                        {
                            west = west + i.total;
                        }
                        else
                        {
                            west2 = west2 + i.total;
                        }
                    }
                    if (i.region.Equals("South"))
                    {
                        if (i.year.Equals(Convert.ToInt32("2015")))
                        {
                            south = south + i.total;
                        }
                        else
                        {
                            south2 = south2 + i.total;
                        }
                    }
                }

                this.chart1.Series["2015"].Points.AddXY("North", north);
                this.chart1.Series["2016"].Points.AddXY("North", north2);

                this.chart1.Series["2015"].Points.AddXY("East", east);
                this.chart1.Series["2016"].Points.AddXY("East", east2);

                this.chart1.Series["2015"].Points.AddXY("West", west);
                this.chart1.Series["2016"].Points.AddXY("West", west2);

                this.chart1.Series["2015"].Points.AddXY("South", south);
                this.chart1.Series["2016"].Points.AddXY("South", south2);

                f1 = 1;
            }
           
    }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

      //  int f = 0;
        private void button1_Click(object sender, EventArgs e)
        {



            int state1_15 = 0, state2_15 = 0, state3_15 = 0, state4_15 = 0, state1_16 = 0, state2_16 = 0, state3_16 = 0, state4_16 = 0; ;
            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("project");
            MongoCursor<Class2> put = db.GetCollection<Class2>("economy").FindAll();

            var s = comboBox2.SelectedItem;
            var q = comboBox3.SelectedItem;
            var r = comboBox4.SelectedItem;
            var p = comboBox5.SelectedItem;
           
            if (f2 == 1)
                refreshchart();
            if (f2 == 0)
            {
                foreach (Class2 i in put)
                {
                    if (i.sname.Equals(s))
                    {
                        if (comboBox1.SelectedItem == "2015" || (comboBox1.SelectedItem == "Both"))
                            if (i.year.Equals(Convert.ToInt32("2015")))
                            {
                                state1_15 = i.total;
                            }
                        if (comboBox1.SelectedItem == "2016" || (comboBox1.SelectedItem == "Both"))
                            if (i.year.Equals(Convert.ToInt32("2016")))
                            {
                                state1_16 = i.total;
                            }
                    }
                    if (i.sname.Equals(q))
                    {
                        if (comboBox1.SelectedItem == "2015" || (comboBox1.SelectedItem == "Both"))
                        {
                            if (i.year.Equals(Convert.ToInt32("2015")))
                            {
                                state2_15 = i.total;
                            }
                        }

                        if (comboBox1.SelectedItem == "2016" || (comboBox1.SelectedItem == "Both"))
                        {
                            if (i.year.Equals(Convert.ToInt32("2016")))
                            {
                                state2_16 = i.total;
                            }
                        }
                    }
                    if (i.sname.Equals(r))
                    {
                        if (comboBox1.SelectedItem == "2015" || (comboBox1.SelectedItem == "Both"))
                            if (i.year.Equals(Convert.ToInt32("2015")))
                            {
                                state3_15 = i.total;
                            }
                        if (comboBox1.SelectedItem== "2016" || (comboBox1.SelectedItem == "Both"))
                            if (i.year.Equals(Convert.ToInt32("2016")))
                            {
                                state3_16 = i.total;
                            }
                    }
                    if (i.sname.Equals(p))
                    {
                        if (comboBox1.SelectedItem== "2015" || (comboBox1.SelectedItem == "Both"))
                            if (i.year.Equals(Convert.ToInt32("2015")))
                            {
                                state4_15 = i.total;
                            }
                        if (comboBox1.SelectedItem == "2016" || (comboBox1.SelectedItem == "Both"))
                            if (i.year.Equals(Convert.ToInt32("2016")))
                            {
                                state4_16 = i.total;
                            }
                    }


                }

                if ((comboBox1.SelectedItem == "2015") || (comboBox1.SelectedItem == "Both"))
                {
                    this.chart2.Series["2015"].Points.AddXY(s, state1_15);
                    this.chart2.Series["2015"].Points.AddXY(q, state2_15);
                    this.chart2.Series["2015"].Points.AddXY(r, state3_15);
                    this.chart2.Series["2015"].Points.AddXY(p, state4_15);
                }
                if ((comboBox1.SelectedItem == "2016") || (comboBox1.SelectedItem == "Both"))
                {
                    this.chart2.Series["2016"].Points.AddXY("state1", state1_16);
                    this.chart2.Series["2016"].Points.AddXY("state2", state2_16);
                    this.chart2.Series["2016"].Points.AddXY("state3", state3_16);
                    this.chart2.Series["2016"].Points.AddXY("state4", state4_16);
                }

                f2 = 1;
            }
        

        }


        void refreshchart()
        {
            this.chart2.Series[0].Points.Clear();
            this.chart2.Series[1].Points.Clear();
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            f1 = 0;
            f2 = 0;

        }

    }
}
    