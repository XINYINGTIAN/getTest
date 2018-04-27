using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFWinFormTest.TestSvcRef;

namespace WCFWinFormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestSvcClient client = new TestSvcClient();
            string s = client.GetAppSettings("WCFAppSetTest");
            lst.Items.Add(s);
            client.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lst.Items.Add("Writing config: ");
            lst.Items.Add("dm: " + textBox1.Text);
            lst.Items.Add("nr: " + textBox2.Text);
            TestSvcClient client = new TestSvcClient();
            int ret = client.WriteConfig(textBox1.Text, textBox2.Text);
            lst.Items.Add("Return: " + ret);
            client.Close();
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
