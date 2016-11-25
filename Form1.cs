using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodCheckbill
{
    public partial class Form1 : Form
    {
        int result; 
        int sum;
        int[] bath = {20,25,25,10,25,20,20}; 
        public Form1() 
        {
            InitializeComponent();
            sum = 0;
            result = 0;

            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox22.Enabled = true;
        }
        
        public void fp() {
    
            if (checkBox1.Checked)
            {
                pictureBox8.Image = new Bitmap(@"E:\FoodCheckbill\FoodCheckbill\Resources\Capture.PNG");
            
            }
            if (checkBox2.Checked)
            {
                pictureBox2.Image = new Bitmap(@"E:\FoodCheckbill\FoodCheckbill\Resources\548af40933b046e0b4d5094335018748.jpg");
            }
                if (checkBox3.Checked)
                {
                pictureBox3.Image = new Bitmap(@"E:\FoodCheckbill\FoodCheckbill\Resources\1349324537.jpg");
            }
                if (checkBox4.Checked)
                {
                pictureBox4.Image = new Bitmap(@"E:\FoodCheckbill\FoodCheckbill\Resources\00217.jpg");
            }
                if (checkBox5.Checked)
                {
                pictureBox5.Image = new Bitmap(@"E:\FoodCheckbill\FoodCheckbill\Resources\Picture1375_normal.jpg");
            }
                if (checkBox6.Checked)
                {
                pictureBox6.Image = new Bitmap(@"E:\FoodCheckbill\FoodCheckbill\Resources\11993298_842334412547331_4038242174309872818_n.jpg");
            }
                if (checkBox7.Checked)
                {
                pictureBox7.Image = new Bitmap(@"E:\FoodCheckbill\FoodCheckbill\Resources\c73c1c2ff11346ffb9c34d024cd5f4e8.jpg");
            }
             
            }
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                result = 0;

                TextBox[] tex = { textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11 };
                int tes = Convert.ToInt32(tex);
                for (int i = 0; i < tex.Length; i++)
                {

                    if (tex[i].Text.Equals("") && tes >= 0)
                        result = result + 0;
                    else result = result + int.Parse(tex[i].Text) * bath[i];
                    {
                    }
                    textBox22.Text = result + "";



                }
            }catch(Exception ex) { MessageBox.Show("กรอกข้อมูลใหม่"); }
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click_2(object sender, EventArgs e)
        { }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox5.Enabled = true; 
                pictureBox8.Image = new Bitmap(@"E:\FoodCheckbill\FoodCheckbill\Resources\Capture.PNG");
            }
            else { textBox5.Clear(); textBox5.Enabled = false; pictureBox8.Image = null; } 
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox6.Enabled = true;
                fp();//เม๊ดตอน
            }
            else { textBox6.Clear(); textBox6.Enabled = false;pictureBox2.Image = null; }
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox7.Enabled = true;
                fp();
            }
            else { textBox7.Clear(); textBox7.Enabled = false; pictureBox3.Image = null; }
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox4.Checked)
            {
                textBox8.Enabled = true;
                fp();
            }
            else { textBox8.Clear(); textBox8.Enabled = false; pictureBox4.Image = null; }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                textBox9.Enabled = true;
                fp();
            }
            else { textBox9.Clear(); textBox9.Enabled = false; pictureBox5.Image = null; }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                textBox10.Enabled = true;
                fp();
            }
            else { textBox10.Clear(); textBox10.Enabled = false; pictureBox6.Image = null; }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                textBox11.Enabled = true;
                fp();
            }
            else { textBox11.Clear(); textBox11.Enabled = false; pictureBox7.Image = null; }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            listBox1.Items.Add("แคลอรี่ของข้าวผัดกะเพรากุ้ง คือ 540 กิโลแคลอรี่");
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            listBox1.Items.Add("แคลอรี่ของข้าวกะเพราหมู คือ 580 กิโลแคลอรี่");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("แคลอรี่ของผัดกะเพราปลาหมึก คือ 535 กิโลแคลอรี่");

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("แคลอรี่ของข้าวไข่เจียว คือ 445 กิโลแคลอรี่");

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("แคลอรี่ของราดหน้า คือ 435 กิโลแคลอรี่");

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("แคลอรี่ของข้าวขาหมู คือ 690 กิโลแคลอรี่");

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("แคลอรี่ของข้าวมันไก่ทอด คือ 566 กิโลแคลอรี่");

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}