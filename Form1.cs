using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace IW7_Zombie
{
    public partial class Form1 : Form
    {

        public Mem Memlib = new Mem();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Memlib.OpenProcess("iw7_ship"))
            {
                MessageBox.Show("Connected and ready to use");
                button1.Enabled = false;
                button1.Text = "Connected";
                if (backgroundWorker1.IsBusy == false)
                    backgroundWorker1.RunWorkerAsync();

            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (checkBox1.Checked) {
                    Memlib.WriteMemory("base+0x3CA2AC0", "int", "999");
                    Memlib.WriteMemory("base+0x3CA2B08", "int", "999");
                    Memlib.WriteMemory("base+0x3CA2AE4", "int", "999");
                    //Memlib.WriteMemory("base+1808F08", "int", "999999");
                    //Memlib.WriteMemory("base+1808F20", "int", "999999");
                }
                if (checkBox2.Checked)
                {
                    Memlib.WriteMemory("base+0x3D227F0", "int", "250");
                    
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
