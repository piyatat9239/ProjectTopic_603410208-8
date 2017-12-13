using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopicProject
{
    public partial class drink : Form
    {
        MessageBoxButtons yesNo = MessageBoxButtons.YesNo;

        public drink()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
            }
            else if (checkBox1.Checked == false)
            {
                textBox1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
            }
            else if (checkBox2.Checked == false)
            {
                textBox2.Enabled = false;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
            }
            else if (checkBox3.Checked == false)
            {
                textBox3.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Enabled = true;
            }
            else if (checkBox4.Checked == false)
            {
                textBox4.Enabled = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox5.Enabled = true;
            }
            else if (checkBox5.Checked == false)
            {
                textBox5.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox6.Enabled = true;
            }
            else if (checkBox6.Checked == false)
            {
                textBox6.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int menu1 = 0, menu2 = 0, menu3 = 0, menu4 = 0, menu5 = 0, menu6 = 0;
            int total_drink;

            if (textBox1.Text != "")
            {
                int pmenu1 = int.Parse(textBox1.Text);
                menu1 = 39 * pmenu1;
            }

            if (textBox2.Text != "")
            {
                int pmenu2 = int.Parse(textBox2.Text);
                menu2 = 89 * pmenu2;
            }

            if (textBox3.Text != "")
            {
                int pmenu3 = int.Parse(textBox3.Text);
                menu3 = 59 * pmenu3;
            }

            if (textBox4.Text != "")
            {
                int pmenu4 = int.Parse(textBox4.Text);
                menu4 = 149 * pmenu4;
            }

            if (textBox5.Text != "")
            {
                int pmenu5 = int.Parse(textBox5.Text);
                menu5 = 30 * pmenu5;
            }

            if (textBox6.Text != "")
            {
                int pmenu6 = int.Parse(textBox6.Text);
                menu6 = 99 * pmenu6;
            }

            

            
            
            total_drink = menu1 + menu2 + menu3 + menu4 + menu5 + menu6;
            string Numroom = textBox7.Text.ToString();
            if (total_drink != 0 && textBox7.Text != "")
            {
                DialogResult result1 = MessageBox.Show("Total price : " + total_drink + " Bath" + "\r\n" + "หมายเลขห้อง : " + Numroom, "print??", yesNo);
                System.IO.File.WriteAllText(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +  @"\drink.txt", "Total price : " + total_drink.ToString() + " Bath" + "\r\n" + "หมายเลขห้อง : " + Numroom);

                if (result1 == DialogResult.Yes)
                {
                    System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\drink.txt");
                    psi.Verb = "PRINT";

                    Process.Start(psi);
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน" , "แจ้งเตือน");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข", "แจ้งเตือน");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข", "แจ้งเตือน");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข", "แจ้งเตือน");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข", "แจ้งเตือน");
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข", "แจ้งเตือน");
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข", "แจ้งเตือน");
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข", "แจ้งเตือน");
            }
        }
    }
}
