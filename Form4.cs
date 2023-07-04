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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int[,] sa = new int[9,9];
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sa[0,0] = Convert.ToInt32(textBox1.Text);
                sa[0, 1] = Convert.ToInt32(textBox2.Text);
                sa[0, 2] = Convert.ToInt32(textBox3.Text);
                sa[0, 3] = Convert.ToInt32(textBox4.Text);
                sa[0, 4] = Convert.ToInt32(textBox5.Text);
                sa[0, 5] = Convert.ToInt32(textBox6.Text);
                sa[0, 6] = Convert.ToInt32(textBox7.Text);
                sa[0, 7] = Convert.ToInt32(textBox8.Text);
                sa[0, 8] = Convert.ToInt32(textBox9.Text);
                sa[0, 9] = Convert.ToInt32(textBox10.Text);
                sa[1, 0] = Convert.ToInt32(textBox11.Text);
                sa[1, 1] = Convert.ToInt32(textBox12.Text);
                sa[1, 2] = Convert.ToInt32(textBox13.Text);
                sa[1, 3] = Convert.ToInt32(textBox14.Text);
                sa[1, 4] = Convert.ToInt32(textBox15.Text);
                sa[1, 5] = Convert.ToInt32(textBox16.Text);
                sa[1, 6] = Convert.ToInt32(textBox17.Text);
                sa[1, 7] = Convert.ToInt32(textBox18.Text);
                sa[1, 8] = Convert.ToInt32(textBox19.Text);
                sa[1, 9] = Convert.ToInt32(textBox20.Text);
                sa[2, 0] = Convert.ToInt32(textBox21.Text);
                sa[2, 1] = Convert.ToInt32(textBox22.Text);
                sa[2, 2] = Convert.ToInt32(textBox23.Text);
                sa[2, 3] = Convert.ToInt32(textBox24.Text);
                sa[2, 4] = Convert.ToInt32(textBox25.Text);
                sa[2, 5] = Convert.ToInt32(textBox26.Text);
                sa[2, 6] = Convert.ToInt32(textBox27.Text);
                sa[2, 7] = Convert.ToInt32(textBox28.Text);
                sa[2, 8] = Convert.ToInt32(textBox29.Text);
                sa[2, 9] = Convert.ToInt32(textBox30.Text);
                sa[3, 0] = Convert.ToInt32(textBox31.Text);
                sa[3, 1] = Convert.ToInt32(textBox32.Text);
                sa[3, 2] = Convert.ToInt32(textBox33.Text);
                sa[3, 3] = Convert.ToInt32(textBox34.Text);
                sa[3, 4] = Convert.ToInt32(textBox35.Text);
                sa[3, 5] = Convert.ToInt32(textBox36.Text);
                sa[3, 6] = Convert.ToInt32(textBox37.Text);
                sa[3, 7] = Convert.ToInt32(textBox38.Text);
                sa[3, 8] = Convert.ToInt32(textBox39.Text);
                sa[3, 9] = Convert.ToInt32(textBox40.Text);
                sa[4, 0] = Convert.ToInt32(textBox41.Text);
                sa[4, 1] = Convert.ToInt32(textBox42.Text);
                sa[4, 2] = Convert.ToInt32(textBox43.Text);
                sa[4, 3] = Convert.ToInt32(textBox44.Text);
                sa[4, 4] = Convert.ToInt32(textBox45.Text);
                sa[4, 5] = Convert.ToInt32(textBox46.Text);
                sa[4, 6] = Convert.ToInt32(textBox47.Text);
                sa[4, 7] = Convert.ToInt32(textBox48.Text);
                sa[4, 8] = Convert.ToInt32(textBox49.Text);
                sa[4, 9] = Convert.ToInt32(textBox50.Text);
                sa[5, 0] = Convert.ToInt32(textBox51.Text);
                sa[5, 1] = Convert.ToInt32(textBox52.Text);
                sa[5, 2] = Convert.ToInt32(textBox53.Text);
                sa[5, 3] = Convert.ToInt32(textBox54.Text);
                sa[5, 4] = Convert.ToInt32(textBox55.Text);
                sa[5, 5] = Convert.ToInt32(textBox56.Text);
                sa[5, 6] = Convert.ToInt32(textBox57.Text);
                sa[5, 7] = Convert.ToInt32(textBox58.Text);
                sa[5, 8] = Convert.ToInt32(textBox59.Text);
                sa[5, 9] = Convert.ToInt32(textBox60.Text);
                sa[6, 0] = Convert.ToInt32(textBox61.Text);
                sa[6, 1] = Convert.ToInt32(textBox62.Text);
                sa[6, 2] = Convert.ToInt32(textBox63.Text);
                sa[6, 3] = Convert.ToInt32(textBox64.Text);
                sa[6, 4] = Convert.ToInt32(textBox65.Text);
                sa[6, 5] = Convert.ToInt32(textBox66.Text);
                sa[6, 6] = Convert.ToInt32(textBox67.Text);
                sa[6, 7] = Convert.ToInt32(textBox68.Text);
                sa[6, 8] = Convert.ToInt32(textBox69.Text);
                sa[6, 9] = Convert.ToInt32(textBox70.Text);
                sa[7, 0] = Convert.ToInt32(textBox71.Text);
                sa[7, 1] = Convert.ToInt32(textBox72.Text);
                sa[7, 2] = Convert.ToInt32(textBox73.Text);
                sa[7, 3] = Convert.ToInt32(textBox74.Text);
                sa[7, 4] = Convert.ToInt32(textBox75.Text);
                sa[7, 5] = Convert.ToInt32(textBox76.Text);
                sa[7, 6] = Convert.ToInt32(textBox77.Text);
                sa[7, 7] = Convert.ToInt32(textBox78.Text);
                sa[7, 8] = Convert.ToInt32(textBox79.Text);
                sa[7, 9] = Convert.ToInt32(textBox80.Text);
                sa[8, 0] = Convert.ToInt32(textBox81.Text);
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (sa[i, j] == 0)
                        {
                            for (int k = 0; k < 9; k=+2)
                            {
                                for (int y = 0; y < 9; y=+2)
                                {
                                    Random rand = new Random();
                                    sa[i, j] = rand.Next(1, 9);
                                    if (sa[i, j] == sa[k, y])
                                    {
                                        sa[i, j] = rand.Next(1,9);
                                        Console.WriteLine(sa[i, j]);
                                        MessageBox.Show("پازل حل می شود");
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("پازل قابل حل نیست ");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
