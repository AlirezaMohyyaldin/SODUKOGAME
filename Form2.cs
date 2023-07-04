using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1234
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {

        }
        string w2;
        private void textBox28_TextChanged_1(object sender, EventArgs e)
        {
            w2 = Convert.ToString(textBox28.Text);
            if (textBox28.Text.Equals("1") || textBox28.Text.Equals("2") || textBox28.Text.Equals("5") || textBox28.Text.Equals("9")
              || textBox28.Text.Equals("8") || textBox28.Text == t5 || textBox28.Text == d2
              || textBox28.Text == e1 || textBox28.Text == o2 || textBox28.Text == w  || textBox28.Text == w1 ||
              textBox28.Text == w3 || textBox28.Text == w4||textBox28.Text.Equals("4") )
            {
                textBox28.BackColor = Color.Red;
            }
            else
            {
                textBox28.BackColor = Color.White;
            }
        }

        private void textBox73_TextChanged(object sender, EventArgs e)
        {

        }
         
        string x2;
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                x2 = Convert.ToString(textBox1.Text);

                if (textBox1.Text.Equals("9") || textBox1.Text.Equals("2") || textBox1.Text == x4 || textBox1.Text == m
                   || textBox1.Text.Equals("1") || textBox1.Text == y || textBox1.Text == t ||
                   textBox1.Text == t1 || textBox1.Text.Equals("3") || textBox1.Text.Equals("8") ||
                   textBox1.Text == t2 || textBox1.Text == t3 || textBox1.Text == t4
                   || textBox1.Text == t5 || textBox1.Text == t6)
                {
                    textBox1.BackColor = Color.Red;
                }
                else
                {
                    textBox1.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             
        }
       
        string x4;
        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            try
            {
                x4 = Convert.ToString(textBox18.Text);

                if (textBox18.Text.Equals("9") || textBox18.Text.Equals("2") || textBox18.Text.Equals("1") || textBox18.Text.Equals("5")
                  || textBox18.Text.Equals("7") || textBox18.Text == x2 || textBox18.Text == m || textBox18.Text == y
                  || textBox18.Text == t || textBox18.Text == t1 || textBox18.Text == d || textBox18.Text == d1 || textBox18.Text == d2
                  || textBox18.Text == d3 || textBox18.Text == d4 || textBox18.Text == d5)
                {
                    textBox18.BackColor = Color.Red;
                }
                else
                {
                    textBox18.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        string m;
        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m = Convert.ToString(textBox16.Text);
                if (textBox16.Text.Equals("9") || textBox16.Text.Equals("2") || textBox16.Text.Equals("3") || textBox16.Text.Equals("7") ||
                     textBox16.Text.Equals("1") || textBox16.Text == e1 || textBox16.Text == e2 || textBox16.Text == e3
                     || textBox16.Text == e4 || textBox16.Text == e5 || textBox16.Text == x2 || textBox16.Text == x4
                     || textBox16.Text == y  || textBox16.Text == t  || textBox16.Text == t1)
                {
                    textBox16.BackColor = Color.Red;
                }
                else
                {
                    textBox16.BackColor = Color.White;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }
        string y;
        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            try
            {
                y = Convert.ToString(textBox27.Text);
                if (textBox27.Text.Equals("9") || textBox27.Text.Equals("2") || textBox27.Text.Equals("1") || textBox27.Text.Equals("8")
                   || textBox27.Text.Equals("4") || textBox27.Text == m1 || textBox27.Text == m2 || textBox27.Text == m3
                  || textBox27.Text == m4 )
                {
                    textBox27.BackColor = Color.Red;
                }
                else
                {
                    textBox27.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        string t;
        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            t = Convert.ToString(textBox25.Text);
            if (textBox25.Text.Equals("9") || textBox25.Text.Equals("2") || textBox25.Text.Equals("1") || textBox25.Text.Equals("8")
                || textBox25.Text.Equals("4") || textBox25.Text.Equals("6") || textBox25.Text.Equals("3") || 
                textBox25.Text == h || textBox25.Text == h1)
            {
                textBox25.BackColor = Color.Red;
            }
                else
            {
                textBox25.BackColor = Color.White;
            }
        }
        string t1;

        private void textBox26_TextChanged_1(object sender, EventArgs e)
        {
            t1 = Convert.ToString(textBox26.Text);
            if(textBox26.Text.Equals("9") ||  textBox26.Text.Equals("2") ||  textBox26.Text.Equals("1") || textBox26.Text == o
                ||textBox26.Text.Equals("8")|| textBox26.Text.Equals("4") || textBox26.Text == o1 || textBox26.Text == o2 || textBox26.Text == o3)
            {
                textBox26.BackColor = Color.Red;
            }
                else
            {
                textBox26.BackColor = Color.White;
            }
        }
        string t2;
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            t2 = Convert.ToString(textBox6.Text);
            if(textBox6.Text.Equals("9") || textBox6.Text.Equals("2") || textBox6.Text.Equals("8") || textBox6.Text.Equals("1")
               || textBox6.Text.Equals("5") || textBox6.Text.Equals("3") || textBox6.Text == x2 || textBox6.Text ==t3
               || textBox6.Text == t4 || textBox6.Text  == t5 || textBox6.Text == t6 || textBox6.Text == w 
               || textBox6.Text == e5 || textBox6.Text == n || textBox6.Text == o )
            {
                textBox6.BackColor = Color.Red;
            }
                else
            {
                textBox6.BackColor = Color.White;
            }
        }
        string t3;
        private void textBox36_TextChanged_1(object sender, EventArgs e)
        {
            t3 = Convert.ToString(textBox36.Text);
            if(textBox36.Text.Equals("9") || textBox36.Text.Equals("1") || textBox36.Text.Equals("2") || textBox36.Text.Equals("3")
                || textBox36.Text.Equals("8") || textBox36.Text == t4 || textBox36.Text == t5 || textBox36.Text == t6
                || textBox36.Text == x2 || textBox36.Text == t2 || textBox36.Text == d || textBox36.Text == q1 || textBox36.Text == n2
                 || textBox36.Text == m2 || textBox36.Text == h)
            {
                textBox36.BackColor = Color.Red;
            }
                else
            {
                textBox36.BackColor = Color.White;
            }
        }
        string t4;
        private void textBox33_TextChanged_1(object sender, EventArgs e)
        {
            t4 = Convert.ToString(textBox33.Text);
            if (textBox33.Text.Equals("9") || textBox33.Text.Equals("1") || textBox33.Text.Equals("2") || textBox33.Text.Equals("3")
                || textBox33.Text.Equals("8") || textBox33.Text.Equals("4") || textBox33.Text.Equals("7") || textBox33.Text == d1 || textBox3.Text == o1 || textBox33.Text == t3
                || textBox33.Text == t2 || textBox33.Text == x2 || textBox33.Text == t5 || textBox33.Text == t6 )
            {
                textBox33.BackColor = Color.Red;
            }
            else
            {
                textBox33.BackColor = Color.White;
            }
        }
        string t5;
        private void textBox30_TextChanged_1(object sender, EventArgs e)
        {
            t5 = Convert.ToString(textBox30.Text);
            if (textBox30.Text.Equals("3") || textBox30.Text.Equals("1") || textBox30.Text.Equals("4") || textBox30.Text.Equals("5")
               || textBox30.Text.Equals("8")  || textBox30.Text == d1  || textBox30.Text == t4
               || textBox30.Text == t2 || textBox30.Text == x2 || textBox30.Text == t3 || textBox30.Text == t6 ||
               textBox30.Text == d2 || textBox30.Text == e1 || textBox30.Text == o2 || textBox30.Text == w2 )
            {
                textBox30.BackColor = Color.Red;
            }
            else
            {
                textBox30.BackColor = Color.White;
            }
        }
        string t6;
        private void textBox81_TextChanged(object sender, EventArgs e)
        {
            t6 = Convert.ToString(textBox81.Text);
            if (textBox81.Text.Equals("3") || textBox81.Text.Equals("1") || textBox81.Text.Equals("9") 
   || textBox81.Text.Equals("8") || textBox81.Text == t2 || textBox81.Text == t3
   || textBox81.Text == t4 || textBox81.Text == t5 || textBox81.Text == w3 || textBox81.Text == d3 ||
   textBox81.Text == e2 || textBox81.Text == n3 || textBox81.Text == m3 || textBox81.Text == o3)
            {
                textBox81.BackColor = Color.Red;
            }
            else
            {
                textBox81.BackColor = Color.White;
            }
        }
        string d;
        private void textBox45_TextChanged_1(object sender, EventArgs e)
        {
            d = Convert.ToString(textBox41.Text);
            if(textBox45.Text.Equals("5") || textBox45.Text.Equals("7") || textBox45.Text.Equals("2") || textBox45.Text.Equals("3")
                 || textBox45.Text.Equals("9") || textBox45.Text == t3 || textBox45.Text == q1 || textBox45.Text == d
                 || textBox45.Text == n2 || textBox45.Text == m2 || textBox45.Text == h || textBox45.Text == d1 
                 || textBox45.Text == d2 || textBox45.Text == d3 || textBox45.Text == d4 || textBox45.Text == d5 || textBox45.Text == x4)
            {
                textBox45.BackColor = Color.Red;
            }
                else
            {
                textBox45.BackColor = Color.White;
            }
        }
        string d1;
        private void textBox42_TextChanged_1(object sender, EventArgs e)
        {
            d1 = Convert.ToString(textBox42.Text);
            if (textBox42.Text.Equals("5") || textBox42.Text.Equals("7") || textBox42.Text.Equals("2") || textBox42.Text.Equals("3")
                || textBox42.Text.Equals("9") || textBox42.Text.Equals("8") || textBox42.Text.Equals("4")
                || textBox42.Text == t4 || textBox42.Text == o1 || textBox42.Text == d
                || textBox42.Text == x4 || textBox42.Text == d2 || textBox42.Text == d3| textBox42.Text == d4
                || textBox42.Text == d5)
            {
                textBox42.BackColor = Color.Red;
            }
            else
            {
                textBox42.BackColor = Color.White;
            }
        }
        string d2;
        private void textBox39_TextChanged_1(object sender, EventArgs e)
        {
            d2 = Convert.ToString(textBox39.Text);
            if (textBox39.Text.Equals("5") || textBox39.Text.Equals("7") || textBox39.Text.Equals("1")                                               
               || textBox39.Text.Equals("8") || textBox39.Text.Equals("4")
               || textBox39.Text == t5 || textBox39.Text == o2 || textBox39.Text == w2
               || textBox39.Text == e1 || textBox39.Text == x4 || textBox39.Text == d  | textBox39.Text == d3
               || textBox39.Text == d4 ||  textBox39.Text == d5 )
            {
                textBox39.BackColor = Color.Red;
            }
            else
            {
                textBox39.BackColor = Color.White;
            }
        }
        string d3;
        private void textBox72_TextChanged(object sender, EventArgs e)
        {
            d3 = Convert.ToString(textBox72.Text);
            if (textBox72.Text.Equals("5") || textBox72.Text.Equals("7") || textBox72.Text.Equals("9")
              || textBox72.Text.Equals("3")
              || textBox72.Text == e2 || textBox72.Text == n3 || textBox72.Text == m3
              || textBox72.Text == o3 || textBox72.Text == t6  || textBox72.Text == w3 | textBox72.Text == d4 
              || textBox72.Text == d5 || textBox72.Text == d2 || textBox72.Text == d1 || textBox72.Text ==d
              || textBox72.Text == x4)
            {
                textBox72.BackColor = Color.Red;
            }
            else
            {
                textBox72.BackColor = Color.White;
            }
        }
        string d4;
        private void textBox69_TextChanged(object sender, EventArgs e)
        {
            d4 = Convert.ToString(textBox69.Text);
            if (textBox69.Text.Equals("5") || textBox69.Text.Equals("7") || textBox69.Text.Equals("6")
             || textBox69.Text.Equals("3") || textBox69.Text.Equals("8")
             || textBox69.Text == w4 || textBox69.Text == q2 || textBox69.Text == n4
             || textBox69.Text == m4 || textBox69.Text == e3 || textBox69.Text == d5 || textBox69.Text == d3
             || textBox69.Text == d2 || textBox69.Text == d1 || textBox69.Text == d || textBox69.Text == x4)
            {
                textBox69.BackColor = Color.Red;
            }
            else
            {
                textBox69.BackColor = Color.White;
            }
        }
        string d5;
        private void textBox66_TextChanged(object sender, EventArgs e)
        {
            d5 = Convert.ToString(textBox66.Text);
            if (textBox66.Text.Equals("5") || textBox66.Text.Equals("1") || textBox66.Text.Equals("2")
             || textBox66.Text.Equals("4") || textBox66.Text.Equals("6") || textBox66.Text.Equals("8")
             || textBox66.Text == e4 || textBox66.Text == n5 || textBox66.Text == h1
             || textBox66.Text == d4 || textBox66.Text == d3 || textBox66.Text == d2 || textBox66.Text == d1
             || textBox66.Text == d || textBox66.Text == x4)
            {
                textBox66.BackColor = Color.Red;
            }
            else
            {
                textBox66.BackColor = Color.White;
            }
        }
        string e1;
        private void textBox37_TextChanged_1(object sender, EventArgs e)
        {
            e1 =  Convert.ToString(textBox37.Text);
            if (textBox37.Text.Equals("3") || textBox37.Text.Equals("7") || textBox37.Text.Equals("1")
             || textBox37.Text.Equals("8") || textBox37.Text.Equals("4")|| textBox37.Text.Equals("9")
             || textBox37.Text == t5 || textBox37.Text == d2 || textBox37.Text == w2
             || textBox37.Text == o2 || textBox37.Text == e2 || textBox37.Text == e3| textBox37.Text == e4
             || textBox37.Text == e5 || textBox37.Text == m  || textBox37.Text.Equals("5") )
            {
                textBox37.BackColor = Color.Red;
            }
            else
            {
                textBox37.BackColor = Color.White;
            }
        }
        string e2;
        private void textBox70_TextChanged(object sender, EventArgs e)
        {
            e2 = Convert.ToString(textBox70.Text);
            if (textBox70.Text.Equals("3") || textBox70.Text.Equals("7") || textBox70.Text.Equals("9")
            || textBox70.Text == n3 || textBox70.Text == m3 || textBox70.Text == o3
            || textBox70.Text == w3 || textBox70.Text == t6 || textBox70.Text == d3 || textBox70.Text == e3
            || textBox70.Text == e4 || textBox70.Text == m || textBox70.Text == e5 || textBox70.Text == e1)
            {
                textBox70.BackColor = Color.Red;
            }
            else
            {
                textBox70.BackColor = Color.White;
            }
        }
        string e3;
        private void textBox67_TextChanged(object sender, EventArgs e)
        {
            e3 = Convert.ToString(textBox67.Text);
            if (textBox67.Text.Equals("3") || textBox67.Text.Equals("7") || textBox67.Text.Equals("9")
               ||  textBox67.Text.Equals("6") || textBox67.Text.Equals("8")
            || textBox67.Text == n4 || textBox67.Text == m4 || textBox67.Text == d4
            || textBox67.Text == w4 || textBox67.Text == q2 || textBox67.Text == e4 || textBox67.Text == e2
            || textBox67.Text == e1 || textBox67.Text == m || textBox67.Text == e5 )
            {
                textBox67.BackColor = Color.Red;
            }
            else
            {
                textBox67.BackColor = Color.White;
            }
        }
        string e4;
        private void textBox64_TextChanged(object sender, EventArgs e)
        {
            e4 = Convert.ToString(textBox64.Text);
            if (textBox64.Text.Equals("1") || textBox64.Text.Equals("2") || textBox64.Text.Equals("3")
              || textBox64.Text.Equals("4") || textBox64.Text.Equals("6") || textBox64.Text.Equals("7")
              || textBox6.Text.Equals("8") || textBox64.Text.Equals("9")
           || textBox64.Text == d5  || textBox64.Text == n5 || textBox64.Text == h1
           || textBox64.Text == e3 || textBox64.Text == e2 || textBox64.Text == e1 || textBox64.Text == e5
           || textBox64.Text == m )
            {
                textBox64.BackColor = Color.Red;
            }
            else
            {
                textBox64.BackColor = Color.White;
            }
        }
        string e5;
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            e5 = Convert.ToString(textBox13.Text);
            if(textBox13.Text.Equals("8") || textBox13.Text.Equals("5") || textBox13.Text.Equals("9") || textBox13.Text.Equals("2")
               || textBox13.Text.Equals("3") || textBox13.Text.Equals("7") || textBox13.Text == t2 || textBox13.Text == w
               || textBox13.Text == n || textBox13.Text == o || textBox13.Text == e1 || textBox13.Text == e2 
               || textBox13.Text == e3 || textBox13.Text == e4)
            {
                textBox13.BackColor = Color.Red;
            }
                else
            {
                textBox13.BackColor = Color.White;
            }
        }
        string n;
        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            n = Convert.ToString(textBox14.Text);
            if(textBox14.Text.Equals("8") || textBox14.Text.Equals("5") || textBox14.Text.Equals("9") || textBox14.Text.Equals("2")
               || textBox14.Text.Equals("1") || textBox14.Text == o || textBox14.Text == n1 || textBox14.Text == n2 
               || textBox14.Text == n3 || textBox14.Text == n4 || textBox14.Text == n5 || textBox14.Text == e5 || textBox14.Text == w
               || textBox14.Text == t2)
            {
                textBox14.BackColor = Color.Red;
            }
                else
            {
                textBox14.BackColor = Color.White;
            }
        }
        string m1;
        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            m1 = Convert.ToString(textBox21.Text);
            if(textBox21.Text.Equals("1") || textBox21.Text.Equals("7") || textBox21.Text.Equals("9") || textBox21.Text.Equals("4")
                || textBox21.Text.Equals("8") || textBox21.Text.Equals("2") || textBox21.Text == w1 || textBox21.Text == q
                || textBox21.Text ==n1 || textBox21.Text == m2 || textBox21.Text == m3 || textBox21.Text == m4)
            {
                textBox21.BackColor = Color.Red;
            }
                else
            {
                textBox21.BackColor = Color.White;
            }
        }
        string h;
        private void textBox52_TextChanged_1(object sender, EventArgs e)
        {
            h = Convert.ToString(textBox52.Text);
            if (textBox52.Text.Equals("1") || textBox52.Text.Equals("3") || textBox52.Text.Equals("9") || textBox52.Text.Equals("4")
                || textBox52.Text.Equals("8") || textBox52.Text.Equals("2") || textBox52.Text.Equals("6") || textBox52.Text == m2 || textBox52.Text == q1
                || textBox52.Text == t3 || textBox52.Text == n2 || textBox52.Text == t || textBox52.Text == h1)
            {
                textBox52.BackColor = Color.Red;
            }
            else
            {
                textBox52.BackColor = Color.White;
            }

        }
        string h1;

        private void textBox55_TextChanged_1(object sender, EventArgs e)
        {
            h1 = Convert.ToString(textBox55.Text);
            if (textBox55.Text.Equals("1") || textBox55.Text.Equals("3") || textBox55.Text.Equals("4") || textBox55.Text.Equals("6")
                || textBox55.Text.Equals("8") || textBox55.Text.Equals("2")  || textBox55.Text == d5  || textBox55.Text == e4
                || textBox55.Text == n5 || textBox55.Text == h || textBox55.Text == t )
            {
                textBox55.BackColor = Color.Red;
            }
            else
            {
                textBox55.BackColor = Color.White;
            }
        }
        string m2;
        private void textBox54_TextChanged_1(object sender, EventArgs e)
        {
            m2 = Convert.ToString(textBox54.Text);
            if (textBox54.Text.Equals("2") || textBox54.Text.Equals("3") || textBox54.Text.Equals("4") || textBox54.Text.Equals("8")
                || textBox54.Text.Equals("9") || textBox54.Text == h || textBox54.Text == n2 || textBox54.Text == m
                || textBox54.Text == m1 || textBox54.Text == m3 || textBox54.Text == m4  || textBox54.Text == d ||
                textBox54.Text == t3 || textBox54.Text == q1)
            {
                textBox54.BackColor = Color.Red;
            }
                else
            {
                textBox54.BackColor = Color.White;
            }
        }
        string m3;
        private void textBox63_TextChanged(object sender, EventArgs e)
        {
            m3 = Convert.ToString(textBox63.Text);
            if (textBox63.Text.Equals("2") || textBox63.Text.Equals("3") || textBox63.Text.Equals("4") || textBox63.Text.Equals("8")
               || textBox63.Text.Equals("9") || textBox63.Text == t6 || textBox63.Text == w3 || textBox63.Text == w3
               || textBox63.Text == d3 || textBox63.Text == e2 || textBox63.Text == n3 || textBox63.Text == o3 ||
               textBox63.Text == m4 || textBox63.Text == m2 || textBox63.Text == m1 || textBox63.Text == y)
            {
                textBox63.BackColor = Color.Red;
            }
            else
            {
                textBox63.BackColor = Color.White;
            }
        }
        string m4;
        private void textBox60_TextChanged(object sender, EventArgs e)
        {
            m4 = Convert.ToString(textBox60.Text);
            if (textBox60.Text.Equals("2") || textBox60.Text.Equals("3") || textBox60.Text.Equals("4") || textBox60.Text.Equals("8")
               || textBox60.Text.Equals("9") || textBox60.Text.Equals("6") || textBox60.Text == w4 || textBox60.Text == q2 || textBox60.Text == d4
               || textBox60.Text == n4 || textBox60.Text == e3 || textBox60.Text == m3 || textBox60.Text == m2 ||
               textBox60.Text == m1 || textBox60.Text == y )
            {
                textBox60.BackColor = Color.Red;
            }
            else
            {
                textBox60.BackColor = Color.White;
            }
        }
        string o;
       
        string o1;
      
        string o2;
        
        string o3;
      

        private void textBox23_TextChanged_1(object sender, EventArgs e)
        {
            o = Convert.ToString(textBox23.Text);
            if(textBox23.Text.Equals("8") || textBox23.Text.Equals("5") || textBox23.Text.Equals("9") || textBox23.Text.Equals("2")
              || textBox23.Text.Equals("4")|| textBox23.Text == o1 || textBox23.Text == o2|| textBox23.Text == o3
              || textBox23.Text == t2|| textBox23.Text == w || textBox23.Text == e5 || textBox23.Text == n)
            {
                textBox23.BackColor = Color.Red;
            }
                else
            {
                textBox23.BackColor = Color.White;
            }

        }

        private void textBox50_TextChanged_2(object sender, EventArgs e)
        {
            o1 = Convert.ToString(textBox50.Text);
            if (textBox50.Text.Equals("8") || textBox50.Text.Equals("7")|| textBox50.Text.Equals("9") || textBox50.Text.Equals("2")
             || textBox50.Text.Equals("4") || textBox50.Text == d1 || textBox50.Text == t4 || textBox50.Text == t1
             || textBox50.Text == o2 || textBox50.Text == o3|| textBox23.Text == o  || textBox50.Text.Equals("3"))
            {
                textBox50.BackColor = Color.Red;
            }
            else
            {
                textBox50.BackColor = Color.White;
            }

        }

        private void textBox47_TextChanged_2(object sender, EventArgs e)
        {
            o2 = Convert.ToString(textBox47.Text);
            if (textBox47.Text.Equals("8") || textBox47.Text.Equals("1") || textBox47.Text.Equals("9") || textBox47.Text.Equals("2")
            || textBox47.Text.Equals("4") || textBox47.Text == t5 || textBox47.Text == w2 || textBox47.Text == d2
            || textBox47.Text == e1 || textBox47.Text == t1 || textBox47.Text == o || textBox47.Text.Equals("5")  ||
            textBox47.Text == o1 || textBox47.Text == o3 )
            {
                textBox47.BackColor = Color.Red;
            }
            else
            {
                textBox47.BackColor = Color.White;
            }
        }

        private void textBox62_TextChanged_1(object sender, EventArgs e)
        {
            o3 = Convert.ToString(textBox62.Text);
            if (textBox62.Text.Equals("8") || textBox62.Text.Equals("2") || textBox62.Text.Equals("9") || textBox62.Text.Equals("3")
            || textBox62.Text.Equals("4") || textBox62.Text == t6 || textBox62.Text == w3 || textBox62.Text == d3
            || textBox62.Text == e2 || textBox62.Text == n3 || textBox62.Text == m3 || textBox62.Text == o2 ||
            textBox62.Text == o1 || textBox62.Text == o ||textBox62.Text == t1)
            {
                textBox62.BackColor = Color.Red;
            }
            else
            {
                textBox62.BackColor = Color.White;
            }
        }
        string w;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            w = Convert.ToString(textBox4.Text);
            if( textBox4.Text.Equals("8") || textBox4.Text.Equals("5") || textBox4.Text.Equals("9") || textBox4.Text.Equals("2")
                || textBox4.Text.Equals("1") || textBox4.Text == t2 || textBox4.Text ==e5 || textBox4.Text == n ||
                textBox4.Text == o || textBox4.Text == w1 || textBox4.Text == w2 || textBox4.Text == w3 || textBox4.Text == w4)
            {
                textBox4.BackColor = Color.Red;
            }
                else
            {
                textBox4.BackColor = Color.White;
            }
        }
        string w1;
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           w1 = Convert.ToString(textBox7.Text);
            if(textBox7.Text.Equals("1") || textBox7.Text.Equals("7") || textBox7.Text.Equals("9") || textBox7.Text.Equals("8")
               || textBox7.Text.Equals("4") || textBox7.Text.Equals("2") || textBox7.Text == w2 || textBox7.Text == w3 || textBox7.Text== w4
              || textBox7.Text == q || textBox7.Text == n1 || textBox7.Text == m1)
            {
                textBox7.BackColor = Color.Red;
            }
                else
            {
                textBox7.BackColor = Color.White;
            }
        }
        string w3;
        private void textBox79_TextChanged(object sender, EventArgs e)
        {
            w3 = Convert.ToString(textBox79.Text);
            if (textBox79.Text.Equals("1") || textBox79.Text.Equals("3") || textBox79.Text.Equals("9") || textBox79.Text.Equals("8")
               || textBox79.Text.Equals("2") || textBox79.Text == w2 || textBox79.Text == t6 || textBox79.Text == w4
              || textBox79.Text == w1 || textBox79.Text == w || textBox79.Text == d3 || textBox79.Text == e2
              || textBox79.Text == n3 || textBox79.Text == m3 || textBox79.Text == o3)
            {
                textBox79.BackColor = Color.Red;
            }
            else
            {
                textBox79.BackColor = Color.White;
            }
        }
        string w4;
      

        private void textBox71_TextChanged(object sender, EventArgs e)
        {
            w4 = Convert.ToString(textBox71.Text);
            if (textBox71.Text.Equals("1") || textBox71.Text.Equals("3") || textBox71.Text.Equals("6") || textBox71.Text.Equals("8")
               || textBox71.Text.Equals("2") || textBox71.Text == e3 || textBox71.Text == n4 || textBox71.Text == m4
              || textBox71.Text == d4 || textBox71.Text == q2 || textBox71.Text ==w3  || textBox71.Text == w2
              || textBox71.Text == w1 || textBox71.Text == w)
            {
                textBox71.BackColor = Color.Red;
            }
            else
            {
                textBox71.BackColor = Color.White;
            }
        }
        string n1;
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            n1 = Convert.ToString(textBox11.Text);
            if(textBox8.Text.Equals("1") || textBox8.Text.Equals("7") || textBox8.Text.Equals("9") || textBox8.Text.Equals("8")
                || textBox8.Text.Equals("4") || textBox8.Text.Equals("3") || textBox8.Text.Equals("6") || textBox8.Text == q1
                 || textBox8.Text == q2  || textBox8.Text == n1  || textBox8.Text == m1 || textBox8.Text == w1)
            {
                textBox11.BackColor = Color.Red;
            }
                else
            {
                textBox11.BackColor = Color.White;
            }
        }
        string n2;
        private void textBox44_TextChanged_1(object sender, EventArgs e)
        {
            n2 = Convert.ToString(textBox44.Text);
            if(textBox44.Text.Equals("1") || textBox44.Text.Equals("2") || textBox44.Text.Equals("3") || textBox44.Text.Equals("5")
                || textBox44.Text.Equals("9") || textBox44.Text == m2 || textBox44.Text == h || textBox44.Text == t3 || textBox44.Text == q1
                || textBox44.Text == d || textBox44.Text == n || textBox44.Text == n1 || textBox44.Text == n3
                || textBox44.Text == n4 || textBox44.Text == n5)
            {
                textBox44.BackColor = Color.Red;
            }
                else
            {
                textBox44.BackColor = Color.White;
            }
        }
        string n3;
        private void textBox61_TextChanged(object sender, EventArgs e)
        {
            n3 = Convert.ToString(textBox61.Text);
            if (textBox61.Text.Equals("1") || textBox61.Text.Equals("3") || textBox61.Text.Equals("9") || textBox61.Text.Equals("5")
                || textBox61.Text == m3 || textBox61.Text == o3 || textBox61.Text == t6 || textBox61.Text == e2
                || textBox61.Text == d3 || textBox61.Text == w3 || textBox61.Text == n1 || textBox61.Text == n2
                || textBox61.Text == n4 || textBox61.Text == n5 || textBox61.Text == n)
            {
                textBox61.BackColor = Color.Red;
            }
            else
            {
                textBox61.BackColor = Color.White;
            }
        }
        string n4;
        private void textBox68_TextChanged(object sender, EventArgs e)
        {
            n4 = Convert.ToString(textBox68.Text);
            if (textBox68.Text.Equals("3") || textBox68.Text.Equals("8") || textBox68.Text.Equals("9")
               || textBox68.Text.Equals("6") || textBox68.Text.Equals("5")
            || textBox68.Text == m4 || textBox68.Text == e3 || textBox68.Text == d4
            || textBox68.Text == w4 || textBox68.Text == n5 || textBox68.Text == n3 || textBox68.Text == n2
            || textBox68.Text == n1 || textBox68.Text == n)
            {
                textBox68.BackColor = Color.Red;
            }
            else
            {
                textBox68.BackColor = Color.White;
            }
        }
        string n5;
        private void textBox65_TextChanged(object sender, EventArgs e)
        {
            n5  = Convert.ToString(textBox65.Text);
            if (textBox65.Text.Equals("1") || textBox65.Text.Equals("2") || textBox65.Text.Equals("4")
               || textBox65.Text.Equals("5") || textBox65.Text.Equals("6") || textBox65.Text.Equals("8")|| textBox65.Text.Equals("9")
            || textBox65.Text == d5 || textBox65.Text == e4 || textBox65.Text == h1
            || textBox65.Text == n4 || textBox65.Text == n3 || textBox65.Text == n2 || textBox65.Text == n1
            || textBox65.Text == n)
            {
                textBox65.BackColor = Color.Red;
            }
            else
            {
                textBox65.BackColor = Color.White;
            }
        }
        string q;
       
        string q1;
       
        string q2;
       

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
            q = Convert.ToString(textBox8.Text);
            if(textBox8.Text.Equals("1") || textBox8.Text.Equals("7") || textBox8.Text.Equals("9") || textBox8.Text.Equals("8")
                || textBox8.Text.Equals("4") || textBox8.Text.Equals("3") || textBox8.Text.Equals("6") || textBox8.Text == q1
                 || textBox8.Text == q2  || textBox8.Text == n1  || textBox8.Text == m1 || textBox8.Text == w1)
            {
                textBox8.BackColor = Color.Red;
            }
                else
            {
                textBox8.BackColor = Color.White;
            }
        }

        private void textBox35_TextChanged_2(object sender, EventArgs e)
        {
            q1 = Convert.ToString(textBox35.Text);
            if (textBox35.Text.Equals("2") || textBox35.Text.Equals("3") || textBox35.Text.Equals("6") || textBox35.Text.Equals("8")
            || textBox35.Text.Equals("9") || textBox35.Text == t3 || textBox35.Text == d || textBox35.Text == n2
            || textBox35.Text ==m2 || textBox35.Text == h || textBox35.Text == q || textBox35.Text == q2)
            {
                textBox8.BackColor = Color.Red;
            }
                else
            {
                textBox8.BackColor = Color.White;
            }
        }

        private void textBox76_TextChanged(object sender, EventArgs e)
        {
            q2 = Convert.ToString(textBox76.Text);
            if (textBox76.Text.Equals("2") || textBox76.Text.Equals("3") || textBox76.Text.Equals("6") || textBox76.Text.Equals("8")
           || textBox76.Text.Equals("9") || textBox76.Text.Equals("4") || textBox76.Text == n4 || textBox76.Text == m4 || textBox76.Text == e3
           || textBox76.Text == d4 || textBox76.Text == w4 || textBox76.Text == q1 || textBox76.Text == q)
            {
                textBox76.BackColor = Color.Red;
            }
            else
            {
                textBox76.BackColor = Color.White;
            }
        }

        private void textBox82_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox28.Text.Equals("1") || textBox28.Text.Equals("2") || textBox28.Text.Equals("5") || textBox28.Text.Equals("9")
              || textBox28.Text.Equals("8") || textBox28.Text == t5 || textBox28.Text == d2
              || textBox28.Text == e1 || textBox28.Text == o2 || textBox28.Text == w || textBox28.Text == w1 ||
              textBox28.Text == w3 || textBox28.Text == w4 || textBox28.Text.Equals("4")|| textBox18.Text.Equals("9") || textBox18.Text.Equals("2") || textBox18.Text.Equals("1") || textBox18.Text.Equals("5")
                  || textBox18.Text.Equals("7") || textBox18.Text == x2 || textBox18.Text == m || textBox18.Text == y
                  || textBox18.Text == t || textBox18.Text == t1 || textBox18.Text == d || textBox18.Text == d1 || textBox18.Text == d2
                  || textBox18.Text == d3 || textBox18.Text == d4 || textBox18.Text == d5 || textBox16.Text.Equals("9") || textBox16.Text.Equals("2") || textBox16.Text.Equals("3") || textBox16.Text.Equals("7") ||
                     textBox16.Text.Equals("1") || textBox16.Text == e1 || textBox16.Text == e2 || textBox16.Text == e3
                     || textBox16.Text == e4 || textBox16.Text == e5 || textBox16.Text == x2 || textBox16.Text == x4
                     || textBox16.Text == y || textBox16.Text == t || textBox16.Text == t1 || textBox27.Text.Equals("9") || textBox27.Text.Equals("2") || textBox27.Text.Equals("1") || textBox27.Text.Equals("8")
                   || textBox27.Text.Equals("4") || textBox27.Text == m1 || textBox27.Text == m2 || textBox27.Text == m3
                  || textBox27.Text == m4 || textBox25.Text.Equals("9") || textBox25.Text.Equals("2") || textBox25.Text.Equals("1") || textBox25.Text.Equals("8")
                || textBox25.Text.Equals("4") || textBox25.Text.Equals("6") || textBox25.Text.Equals("3") ||
                textBox25.Text == h || textBox25.Text == h1 || textBox26.Text.Equals("9") || textBox26.Text.Equals("2") || textBox26.Text.Equals("1") || textBox26.Text == o
                || textBox26.Text.Equals("8") || textBox26.Text.Equals("4") || textBox26.Text == o1 || textBox26.Text == o2 || textBox26.Text == o3 || textBox6.Text.Equals("9") || textBox6.Text.Equals("2") || textBox6.Text.Equals("8") || textBox6.Text.Equals("1")
               || textBox6.Text.Equals("5") || textBox6.Text.Equals("3") || textBox6.Text == x2 || textBox6.Text == t3
               || textBox6.Text == t4 || textBox6.Text == t5 || textBox6.Text == t6 || textBox6.Text == w
               || textBox6.Text == e5 || textBox6.Text == n || textBox6.Text == o || textBox4.Text.Equals("8") || textBox4.Text.Equals("5") || textBox4.Text.Equals("9") || textBox4.Text.Equals("2")
                || textBox4.Text.Equals("1") || textBox4.Text == t2 || textBox4.Text == e5 || textBox4.Text == n ||
                textBox4.Text == o || textBox4.Text == w1 || textBox4.Text == w2 || textBox4.Text == w3 || textBox4.Text == w4
                 || textBox13.Text.Equals("8") || textBox13.Text.Equals("5") || textBox13.Text.Equals("9") || textBox13.Text.Equals("2")
               || textBox13.Text.Equals("3") || textBox13.Text.Equals("7") || textBox13.Text == t2 || textBox13.Text == w
               || textBox13.Text == n || textBox13.Text == o || textBox13.Text == e1 || textBox13.Text == e2
               || textBox13.Text == e3 || textBox13.Text == e4 || textBox14.Text.Equals("8") || textBox14.Text.Equals("5") || textBox14.Text.Equals("9") || textBox14.Text.Equals("2")
               || textBox14.Text.Equals("1") || textBox14.Text == o || textBox14.Text == n1 || textBox14.Text == n2
               || textBox14.Text == n3 || textBox14.Text == n4 || textBox14.Text == n5 || textBox14.Text == e5 || textBox14.Text == w
               || textBox14.Text == t2 || textBox23.Text.Equals("8") || textBox23.Text.Equals("5") || textBox23.Text.Equals("9") || textBox23.Text.Equals("2")
              || textBox23.Text.Equals("4") || textBox23.Text == o1 || textBox23.Text == o2 || textBox23.Text == o3
              || textBox23.Text == t2 || textBox23.Text == w || textBox23.Text == e5 || textBox23.Text == n 
              || textBox7.Text.Equals("1") || textBox7.Text.Equals("7") || textBox7.Text.Equals("9") || textBox7.Text.Equals("8")
               || textBox7.Text.Equals("4") || textBox7.Text.Equals("2") || textBox7.Text == w2 || textBox7.Text == w3 || textBox7.Text == w4
              || textBox7.Text == q || textBox7.Text == n1 || textBox7.Text == m1 || textBox8.Text.Equals("1") || textBox8.Text.Equals("7") || textBox8.Text.Equals("9") || textBox8.Text.Equals("8")
                || textBox8.Text.Equals("4") || textBox8.Text.Equals("3") || textBox8.Text.Equals("6") || textBox8.Text == q1
                 || textBox8.Text == q2 || textBox8.Text == n1 || textBox8.Text == m1 || textBox8.Text == w1 || textBox8.Text.Equals("1") || textBox8.Text.Equals("7") || textBox8.Text.Equals("9") || textBox8.Text.Equals("8")
                || textBox8.Text.Equals("4") || textBox8.Text.Equals("3") || textBox8.Text.Equals("6") || textBox8.Text == q1
                 || textBox8.Text == q2 || textBox8.Text == n1 || textBox8.Text == m1 || textBox8.Text == w1 || textBox21.Text.Equals("1") || textBox21.Text.Equals("7") || textBox21.Text.Equals("9") || textBox21.Text.Equals("4")
                || textBox21.Text.Equals("8") || textBox21.Text.Equals("2") || textBox21.Text == w1 || textBox21.Text == q
                || textBox21.Text == n1 || textBox21.Text == m2 || textBox21.Text == m3 || textBox21.Text == m4 || textBox36.Text.Equals("9") || textBox36.Text.Equals("1") || textBox36.Text.Equals("2") || textBox36.Text.Equals("3")
                || textBox36.Text.Equals("8") || textBox36.Text == t4 || textBox36.Text == t5 || textBox36.Text == t6
                || textBox36.Text == x2 || textBox36.Text == t2 || textBox36.Text == d || textBox36.Text == q1 || textBox36.Text == n2
                 || textBox36.Text == m2 || textBox36.Text == h || textBox35.Text.Equals("2") || textBox35.Text.Equals("3") || textBox35.Text.Equals("6") || textBox35.Text.Equals("8")
            || textBox35.Text.Equals("9") || textBox35.Text == t3 || textBox35.Text == d || textBox35.Text == n2
            || textBox35.Text == m2 || textBox35.Text == h || textBox35.Text == q || textBox35.Text == q2 || textBox44.Text.Equals("1") || textBox44.Text.Equals("2") || textBox44.Text.Equals("3") || textBox44.Text.Equals("5")
                || textBox44.Text.Equals("9") || textBox44.Text == m2 || textBox44.Text == h || textBox44.Text == t3 || textBox44.Text == q1
                || textBox44.Text == d || textBox44.Text == n || textBox44.Text == n1 || textBox44.Text == n3
                || textBox44.Text == n4 || textBox44.Text == n5 || textBox54.Text.Equals("2") || textBox54.Text.Equals("3") || textBox54.Text.Equals("4") || textBox54.Text.Equals("8")
                || textBox54.Text.Equals("9") || textBox54.Text == h || textBox54.Text == n2 || textBox54.Text == m
                || textBox54.Text == m1 || textBox54.Text == m3 || textBox54.Text == m4 || textBox54.Text == d ||
                textBox54.Text == t3 || textBox54.Text == q1 || textBox52.Text.Equals("1") || textBox52.Text.Equals("3") || textBox52.Text.Equals("9") || textBox52.Text.Equals("4")
                || textBox52.Text.Equals("8") || textBox52.Text.Equals("2") || textBox52.Text.Equals("6") || textBox52.Text == m2 || textBox52.Text == q1
                || textBox52.Text == t3 || textBox52.Text == n2 || textBox52.Text == t || textBox52.Text == h1 || textBox33.Text.Equals("9") || textBox33.Text.Equals("1") || textBox33.Text.Equals("2") || textBox33.Text.Equals("3")
                || textBox33.Text.Equals("8") || textBox33.Text.Equals("4") || textBox33.Text.Equals("7") || textBox33.Text == d1 || textBox3.Text == o1 || textBox33.Text == t3
                || textBox33.Text == t2 || textBox33.Text == x2 || textBox33.Text == t5 || textBox33.Text == t6 || textBox42.Text.Equals("5") || textBox42.Text.Equals("7") || textBox42.Text.Equals("2") || textBox42.Text.Equals("3")
                || textBox42.Text.Equals("9") || textBox42.Text.Equals("8") || textBox42.Text.Equals("4")
                || textBox42.Text == t4 || textBox42.Text == o1 || textBox42.Text == d
                || textBox42.Text == x4 || textBox42.Text == d2 || textBox42.Text == d3 | textBox42.Text == d4
                || textBox42.Text == d5 || textBox50.Text.Equals("8") || textBox50.Text.Equals("7") || textBox50.Text.Equals("9") || textBox50.Text.Equals("2")
             || textBox50.Text.Equals("4") || textBox50.Text == d1 || textBox50.Text == t4 || textBox50.Text == t1
             || textBox50.Text == o2 || textBox50.Text == o3 || textBox23.Text == o || textBox50.Text.Equals("3") || textBox30.Text.Equals("3") || textBox30.Text.Equals("1") || textBox30.Text.Equals("4") || textBox30.Text.Equals("5")
               || textBox30.Text.Equals("8") || textBox30.Text == d1 || textBox30.Text == t4
               || textBox30.Text == t2 || textBox30.Text == x2 || textBox30.Text == t3 || textBox30.Text == t6 ||
               textBox30.Text == d2 || textBox30.Text == e1 || textBox30.Text == o2 || textBox30.Text == w2 || textBox28.Text.Equals("1") || textBox28.Text.Equals("2") || textBox28.Text.Equals("5") || textBox28.Text.Equals("9")
              || textBox28.Text.Equals("8") || textBox28.Text == t5 || textBox28.Text == d2
              || textBox28.Text == e1 || textBox28.Text == o2 || textBox28.Text == w || textBox28.Text == w1 ||
              textBox28.Text == w3 || textBox28.Text == w4 || textBox28.Text.Equals("4") || textBox39.Text.Equals("5") || textBox39.Text.Equals("7") || textBox39.Text.Equals("1")
               || textBox39.Text.Equals("8") || textBox39.Text.Equals("4")
               || textBox39.Text == t5 || textBox39.Text == o2 || textBox39.Text == w2
               || textBox39.Text == e1 || textBox39.Text == x4 || textBox39.Text == d | textBox39.Text == d3
               || textBox39.Text == d4 || textBox39.Text == d5 || textBox37.Text.Equals("3") || textBox37.Text.Equals("7") || textBox37.Text.Equals("1")
             || textBox37.Text.Equals("8") || textBox37.Text.Equals("4") || textBox37.Text.Equals("9")
             || textBox37.Text == t5 || textBox37.Text == d2 || textBox37.Text == w2
             || textBox37.Text == o2 || textBox37.Text == e2 || textBox37.Text == e3 | textBox37.Text == e4
             || textBox37.Text == e5 || textBox37.Text == m || textBox37.Text.Equals("5") || textBox47.Text.Equals("8") || textBox47.Text.Equals("1") || textBox47.Text.Equals("9") || textBox47.Text.Equals("2")
            || textBox47.Text.Equals("4") || textBox47.Text == t5 || textBox47.Text == w2 || textBox47.Text == d2
            || textBox47.Text == e1 || textBox47.Text == t1 || textBox47.Text == o || textBox47.Text.Equals("5") ||
            textBox47.Text == o1 || textBox47.Text == o3 || textBox81.Text.Equals("3") || textBox81.Text.Equals("1") || textBox81.Text.Equals("9")
   || textBox81.Text.Equals("8") || textBox81.Text == t2 || textBox81.Text == t3
   || textBox81.Text == t4 || textBox81.Text == t5 || textBox81.Text == w3 || textBox81.Text == d3 ||
   textBox81.Text == e2 || textBox81.Text == n3 || textBox81.Text == m3 || textBox81.Text == o3 || textBox79.Text.Equals("1") || textBox79.Text.Equals("3") || textBox79.Text.Equals("9") || textBox79.Text.Equals("8")
               || textBox79.Text.Equals("2") || textBox79.Text == w2 || textBox79.Text == t6 || textBox79.Text == w4
              || textBox79.Text == w1 || textBox79.Text == w || textBox79.Text == d3 || textBox79.Text == e2
              || textBox79.Text == n3 || textBox79.Text == m3 || textBox79.Text == o3 || textBox72.Text.Equals("5") || textBox72.Text.Equals("7") || textBox72.Text.Equals("9")
              || textBox72.Text.Equals("3")
              || textBox72.Text == e2 || textBox72.Text == n3 || textBox72.Text == m3
              || textBox72.Text == o3 || textBox72.Text == t6 || textBox72.Text == w3 | textBox72.Text == d4
              || textBox72.Text == d5 || textBox72.Text == d2 || textBox72.Text == d1 || textBox72.Text == d
              || textBox72.Text == x4 || textBox70.Text.Equals("3") || textBox70.Text.Equals("7") || textBox70.Text.Equals("9")
            || textBox70.Text == n3 || textBox70.Text == m3 || textBox70.Text == o3
            || textBox70.Text == w3 || textBox70.Text == t6 || textBox70.Text == d3 || textBox70.Text == e3
            || textBox70.Text == e4 || textBox70.Text == m || textBox70.Text == e5 || textBox70.Text == e1 || textBox61.Text.Equals("1") || textBox61.Text.Equals("3") || textBox61.Text.Equals("9") || textBox61.Text.Equals("5")
                || textBox61.Text == m3 || textBox61.Text == o3 || textBox61.Text == t6 || textBox61.Text == e2
                || textBox61.Text == d3 || textBox61.Text == w3 || textBox61.Text == n1 || textBox61.Text == n2
                || textBox61.Text == n4 || textBox61.Text == n5 || textBox61.Text == n || textBox63.Text.Equals("2") || textBox63.Text.Equals("3") || textBox63.Text.Equals("4") || textBox63.Text.Equals("8")
               || textBox63.Text.Equals("9") || textBox63.Text == t6 || textBox63.Text == w3 || textBox63.Text == w3
               || textBox63.Text == d3 || textBox63.Text == e2 || textBox63.Text == n3 || textBox63.Text == o3 ||
               textBox63.Text == m4 || textBox63.Text == m2 || textBox63.Text == m1 || textBox63.Text == y || textBox62.Text.Equals("8") || textBox62.Text.Equals("2") || textBox62.Text.Equals("9") || textBox62.Text.Equals("3")
            || textBox62.Text.Equals("4") || textBox62.Text == t6 || textBox62.Text == w3 || textBox62.Text == d3
            || textBox62.Text == e2 || textBox62.Text == n3 || textBox62.Text == m3 || textBox62.Text == o2 ||
            textBox62.Text == o1 || textBox62.Text == o || textBox62.Text == t1 || textBox71.Text.Equals("1") || textBox71.Text.Equals("3") || textBox71.Text.Equals("6") || textBox71.Text.Equals("8")
               || textBox71.Text.Equals("2") || textBox71.Text == e3 || textBox71.Text == n4 || textBox71.Text == m4
              || textBox71.Text == d4 || textBox71.Text == q2 || textBox71.Text == w3 || textBox71.Text == w2
              || textBox71.Text == w1 || textBox71.Text == w || textBox76.Text.Equals("2") || textBox76.Text.Equals("3") || textBox76.Text.Equals("6") || textBox76.Text.Equals("8")
           || textBox76.Text.Equals("9") || textBox76.Text.Equals("4") || textBox76.Text == n4 || textBox76.Text == m4 || textBox76.Text == e3
           || textBox76.Text == d4 || textBox76.Text == w4 || textBox76.Text == q1 || textBox76.Text == q || textBox69.Text.Equals("5") || textBox69.Text.Equals("7") || textBox69.Text.Equals("6")
             || textBox69.Text.Equals("3") || textBox69.Text.Equals("8")
             || textBox69.Text == w4 || textBox69.Text == q2 || textBox69.Text == n4
             || textBox69.Text == m4 || textBox69.Text == e3 || textBox69.Text == d5 || textBox69.Text == d3
             || textBox69.Text == d2 || textBox69.Text == d1 || textBox69.Text == d || textBox69.Text == x4 || textBox67.Text.Equals("3") || textBox67.Text.Equals("7") || textBox67.Text.Equals("9")
               || textBox67.Text.Equals("6") || textBox67.Text.Equals("8")
            || textBox67.Text == n4 || textBox67.Text == m4 || textBox67.Text == d4
            || textBox67.Text == w4 || textBox67.Text == q2 || textBox67.Text == e4 || textBox67.Text == e2
            || textBox67.Text == e1 || textBox67.Text == m || textBox67.Text == e5 || textBox68.Text.Equals("3") || textBox68.Text.Equals("8") || textBox68.Text.Equals("9")
               || textBox68.Text.Equals("6") || textBox68.Text.Equals("5")
            || textBox68.Text == m4 || textBox68.Text == e3 || textBox68.Text == d4
            || textBox68.Text == w4 || textBox68.Text == n5 || textBox68.Text == n3 || textBox68.Text == n2
            || textBox68.Text == n1 || textBox68.Text == n || textBox60.Text.Equals("2") || textBox60.Text.Equals("3") || textBox60.Text.Equals("4") || textBox60.Text.Equals("8")
               || textBox60.Text.Equals("9") || textBox60.Text.Equals("6") || textBox60.Text == w4 || textBox60.Text == q2 || textBox60.Text == d4
               || textBox60.Text == n4 || textBox60.Text == e3 || textBox60.Text == m3 || textBox60.Text == m2 ||
               textBox60.Text == m1 || textBox60.Text == y || textBox66.Text.Equals("5") || textBox66.Text.Equals("1") || textBox66.Text.Equals("2")
             || textBox66.Text.Equals("4") || textBox66.Text.Equals("6") || textBox66.Text.Equals("8")
             || textBox66.Text == e4 || textBox66.Text == n5 || textBox66.Text == h1
             || textBox66.Text == d4 || textBox66.Text == d3 || textBox66.Text == d2 || textBox66.Text == d1
             || textBox66.Text == d || textBox66.Text == x4 || textBox64.Text.Equals("1") || textBox64.Text.Equals("2") || textBox64.Text.Equals("3")
              || textBox64.Text.Equals("4") || textBox64.Text.Equals("6") || textBox64.Text.Equals("7")
              || textBox6.Text.Equals("8") || textBox64.Text.Equals("9")
           || textBox64.Text == d5 || textBox64.Text == n5 || textBox64.Text == h1
           || textBox64.Text == e3 || textBox64.Text == e2 || textBox64.Text == e1 || textBox64.Text == e5
           || textBox64.Text == m || textBox65.Text.Equals("1") || textBox65.Text.Equals("2") || textBox65.Text.Equals("4")
               || textBox65.Text.Equals("5") || textBox65.Text.Equals("6") || textBox65.Text.Equals("8") || textBox65.Text.Equals("9")
            || textBox65.Text == d5 || textBox65.Text == e4 || textBox65.Text == h1
            || textBox65.Text == n4 || textBox65.Text == n3 || textBox65.Text == n2 || textBox65.Text == n1
            || textBox65.Text == n || textBox55.Text.Equals("1") || textBox55.Text.Equals("3") || textBox55.Text.Equals("4") || textBox55.Text.Equals("6")
                || textBox55.Text.Equals("8") || textBox55.Text.Equals("2") || textBox55.Text == d5 || textBox55.Text == e4
                || textBox55.Text == n5 || textBox55.Text == h || textBox55.Text == t)
            {
                MessageBox.Show("تبریک شما موفق به حل شدید", "SODUKO GAME");
            }
            else
            {
                MessageBox.Show("شما پازل را درست حل نکردید", "SODUKO GAME");
            }
        }
    }
}
