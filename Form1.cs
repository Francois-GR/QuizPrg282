using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace quizPracticle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (File.Exists("testFile.txt"))
                {
                    List<string> data = new List<string>();
                    data = File.ReadAllLines("testFile.txt").ToList();
                    foreach(string item in data)
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
