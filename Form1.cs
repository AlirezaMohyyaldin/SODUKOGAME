
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1234
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("شما به بازی وارد شدید","soduko game");
            Form3 f1 = new Form3();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("موفق باشید","SODUKO GAME");
            this.Close();
        }
    }
}
