using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopicProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void foodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            food foods = new food();
            foods.Show();
        }

        private void drinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drink drinks = new drink();
            drinks.Show();
        }

        private void roomRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roomrate room = new roomrate();
            room.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            label4.Text = "0";
            label8.Text = "0";
            label9.Text = "0";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;

            }
            else if (checkBox1.Checked == false)
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                label4.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
            }
            else if (checkBox2.Checked == false)
            {
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                label8.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                comboBox5.Enabled = true;
                comboBox6.Enabled = true;

            }
            else if (checkBox3.Checked == false)
            {
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
                comboBox5.SelectedIndex = -1;
                comboBox6.SelectedIndex = -1;
                label9.Text = "0";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
            int room_standrad = int.Parse(comboBox1.Text);
            int day_standrad = int.Parse(comboBox2.Text);
            int total_standard;
            total_standard = room_standrad * day_standrad * 350;
            label4.Text = total_standard.ToString();
            }
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text != "" && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1)
            {
            int room_superior = int.Parse(comboBox4.Text);
            int day_superior = int.Parse(comboBox3.Text);
            int total_superior;
            total_superior = room_superior * day_superior * 500;
            label8.Text = total_superior.ToString();
            }

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.Text != "" && comboBox5.SelectedIndex != -1 && comboBox6.SelectedIndex != -1)
            {
            int room_deluxe = int.Parse(comboBox6.Text);
            int day_delexe = int.Parse(comboBox5.Text);
            int total_delexe;
            total_delexe = room_deluxe * day_delexe * 800;
            label9.Text = total_delexe.ToString();
            }


        }
        public void sum(int room1)
        {
            if (room1 < 0)
            {
                MessageBox.Show("ขออภัยครับ ห้องเต็ม :)", "แจ้งเตือน");
            }
            else
            {
               label11.Text = room1.ToString();
            }
        }

        int room;
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" || comboBox3.Text != "" || comboBox5.Text != "")
            {

                if (comboBox1.Text != "")
                {
                    room = int.Parse(label11.Text);
                    int live1 = int.Parse(comboBox1.Text);
                    room = room - live1;
                    sum(room);
                }

                if (comboBox4.Text != "")
                {
                    room = int.Parse(label11.Text);
                    int live2 = int.Parse(comboBox4.Text);
                    room = room - live2;
                    sum(room);
                }

                if (comboBox6.Text != "")
                {
                    room = int.Parse(label11.Text);
                    int live3 = int.Parse(comboBox6.Text);
                    room = room - live3;
                    sum(room);
                }

                int room2 = int.Parse(label11.Text);
                if (room >= 0)
                {
                    int total_stand = int.Parse(label4.Text);
                    int total_super = int.Parse(label8.Text);
                    int total_delux = int.Parse(label9.Text);
                    int btn_total;
                    btn_total = total_stand + total_super + total_delux;
                    MessageBox.Show("Total price : " + btn_total);
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "แจ้งเตือน");
            }
          
            int amount_room = int.Parse(label11.Text);


        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text != "" && comboBox6.SelectedIndex != -1 && comboBox5.SelectedIndex != -1)
            {
                int room_deluxe = int.Parse(comboBox6.Text);
                int day_delexe = int.Parse(comboBox5.Text);
                int total_delexe;
                total_delexe = room_deluxe * day_delexe * 800;
                label9.Text = total_delexe.ToString();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text != "" && comboBox4.SelectedIndex != -1 && comboBox3.SelectedIndex != -1)
            {
                int room_superior = int.Parse(comboBox4.Text);
                int day_superior = int.Parse(comboBox3.Text);
                int total_superior;
                total_superior = room_superior * day_superior * 500;
                label8.Text = total_superior.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {
                int room_standrad = int.Parse(comboBox1.Text);
                int day_standrad = int.Parse(comboBox2.Text);
                int total_standard;
                total_standard = room_standrad * day_standrad * 350;
                label4.Text = total_standard.ToString();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
