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

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
          


            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("PageViews", typeof(int));
            Random t = new Random();
            for (int i = 1; i <= 30; i++)
            {
                DataRow r1 = dt.NewRow();
                DateTime day = new DateTime(2013, 5, i);
                r1[0] = day.ToString("dd-MM-yyyy");
               

                r1[1] = t.Next(5, 30);
                
                    dt.Rows.Add(r1);
            }
           
            dataSet.Tables.Add(dt);
            chart1.Titles[0].Text = "test hang thoy";
            chart1.DataSource = dataSet.Tables[0];
            chart1.DataBind();
        }
    }
}
