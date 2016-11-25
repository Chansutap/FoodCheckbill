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
        int result; //เก็บจำนวนราคาทั้งหมดของอาหาร
        int sum; //เก็บจำนวนทั้งหมดของอาหาร
        int[] bath = {20,25,25,10,25,20,20}; //ราคาตามลำดับของเมนู 
        public Form1() 
        {
            InitializeComponent();//คำสั่งสร้างคอมฌพเน้น
            sum = 0;//กำหนดsumเม่ากับ0
            result = 0;//เก็บจำนวนราคาsumเท่ากับ0

            textBox5.Enabled = true;//เปิดการทำงานของtextBox5
            textBox6.Enabled = true;//เปิดการทำงานของtextBox6
            textBox7.Enabled = true;//เปิดการทำงานของtextBox7
            textBox8.Enabled = true;//เปิดการทำงานของtextBox8
            textBox9.Enabled = true;//เปิดการทำงานของtextBox9
            textBox10.Enabled = true;//เปิดการทำงานของtextBox10
            textBox11.Enabled = true;//เปิดการทำงานของtextBox11
            textBox22.Enabled = true;//เปิดการทำงานของtextBox22
        }
        
        public void fp() {//method
    
            if (checkBox1.Checked)//คำสั่งถ้าcheckBox1ถูกติ๊กก็จะแสดภาพ
            {
                pictureBox8.Image = new Bitmap(@"E:\FoodCheckbill\FoodCheckbill\Resources\Capture.PNG");//ให้pictureBox8แสดงภาพ
            
            }
            if (checkBox2.Checked)//คำสั่งถ้าcheckBox2ถูกติ๊กก็จะแสดภาพ
            {
                pictureBox2.Image = new Bitmap(@"E:\FoodCheckbill\FoodCheckbill\Resources\548af40933b046e0b4d5094335018748.jpg");//ให้pictureBox2แสดงภาพ
            }
                if (checkBox3.Checked)//คำสั่งถ้าcheckBox3ถูกติ๊กก็จะแสดภาพ
                {
                pictureBox3.Image = new Bitmap(@"E:\FoodCheckbill\FoodCheckbill\Resources\1349324537.jpg");//ให้pictureBox3แสดงภาพ
            }
                if (checkBox4.Checked)//คำสั่งถ้าcheckBox4ถูกติ๊กก็จะแสดภาพ
                
                pictureBox4.Image = new Bitmap(@"E:\FoodCheckbill\FoodCheckbill\Resources\00217.jpg");//ให้pictureBox4แสดงภาพ
            }
                if (checkBox5.Checked)//คำสั่งถ้าcheckBox5ถูกติ๊กก็จะแสดภาพ
                {
                pictureBox5.Image = new Bitmap(@"E:\FoodCheckbill\FoodCheckbill\Resources\Picture1375_normal.jpg");//ให้pictureBox5แสดงภาพ
            }
                if (checkBox6.Checked)//คำสั่งถ้าcheckBox6ถูกติ๊กก็จะแสดภาพ
                {
                pictureBox6.Image = new Bitmap(@"E:\FoodCheckbill\FoodCheckbill\Resources\11993298_842334412547331_4038242174309872818_n.jpg");//ให้pictureBox6แสดงภาพ
            }
                if (checkBox7.Checked)//คำสั่งถ้าcheckBox7ถูกติ๊กก็จะแสดภาพ
                {
                pictureBox7.Image = new Bitmap(@"E:\FoodCheckbill\FoodCheckbill\Resources\c73c1c2ff11346ffb9c34d024cd5f4e8.jpg");//ให้pictureBox7แสดงภาพ
            }
             
            }
        private void button1_Click(object sender, EventArgs e)
        {
            try {//คำสั่งการดักจับ
                result = 0;//กำหนดให้resultเท่ากับ0

                TextBox[] tex = { textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11 };//นำtextboxทั้ง6มาเก็บไว้ที่อาเรย์ที่ชื่อ tex
                int tes = Convert.ToInt32(tex);//ใช้แปลงtexที่แสดงตัวเลข integer 32 bit signed ให้เป็นตัวเลข
                for (int i = 0; i < tex.Length; i++)//วนลูปตามจำนวนขนาดของtex
                {

                    if (tex[i].Text.Equals("") && tes >= 0)//ถ้าสติงในtexเป็นค่าวางให้มาแสดงที่นี้
                        result = result + 0;//ให้นำ0ใปบวกกับresultมาเก็บไปในresult
                    else result = result + int.Parse(tex[i].Text) * bath[i];//ถ้าเหตุการณ์ข้างบนเป็นเท็จให้มาแสดงที่นี้และนำค่าในtextboxมาแปงค่าก่อนแล้วนำมาคูณกับบาทแล้วมาบวกกับresultเอามาเก็บไว้ที่resultอีกที
                    {
                    }
                    textBox22.Text = result + "";//แสดงค่าของresultในtextbox22



                }
            }catch(Exception ex) { MessageBox.Show("กรอกข้อมูลใหม่"); } //คำสั่งการดักจับแล้วใ้แสดงข้อความกรอกข้อมูลใหม่
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
            if (checkBox1.Checked)//คำสั่งถ้าcheckbox1ถูกติ๊ก็จะมาแสดงภาพ
            {
                textBox5.Enabled = true; //เปิดการทำงานของtextbox5
                pictureBox8.Image = new Bitmap(@"E:\FoodCheckbill\FoodCheckbill\Resources\Capture.PNG");//ให้แสดงรูปภาพที่pictureBox8
            }
            else { textBox5.Clear(); textBox5.Enabled = false; pictureBox8.Image = null; } //เคลียร์textbox5แล้วปิดข้อความในtextbox5และให้เปิดภาพในpictureBox8
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)//คำสั่งถ้าcheckbox2ถูกติ๊ก็จะมาแสดงภาพ
            {
                textBox6.Enabled = true;//เปิดการทำงานของtextbox6
                fp();//เม๊ดตอน
            }
            else { textBox6.Clear(); textBox6.Enabled = false;pictureBox2.Image = null; }//เคลียร์textbox6แล้วปิดข้อความในtextbox6และให้เปิดภาพในpictureBox2
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked)//คำสั่งถ้าcheckbox3ถูกติ๊ก็จะมาแสดงภาพ
            {
                textBox7.Enabled = true;//เปิดการทำงานของtextbox7
                fp();
            }
            else { textBox7.Clear(); textBox7.Enabled = false; pictureBox3.Image = null; }//เคลียร์textbox7แล้วปิดข้อความในtextbox7และให้เปิดภาพในpictureBox3
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox4.Checked)//คำสั่งถ้าcheckbox4ถูกติ๊ก็จะมาแสดงภาพ
            {
                textBox8.Enabled = true;//เปิดการทำงานของtextbox8
                fp();//รับค่าในเมดธอนมาแสดง
            }
            else { textBox8.Clear(); textBox8.Enabled = false; pictureBox4.Image = null; }//เคลียร์textbox8แล้วปิดข้อความในtextbox8และให้เปิดภาพในpictureBox4
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
            listBox1.Items.Add("แคลอรี่ของข้าวผัดกะเพรากุ้ง คือ 540 กิโลแคลอรี่"); //แสดงข้อความใน listBox1
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            listBox1.Items.Add("แคลอรี่ของข้าวกะเพราหมู คือ 580 กิโลแคลอรี่");//แสดงข้อความใน listBox1
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("แคลอรี่ของผัดกะเพราปลาหมึก คือ 535 กิโลแคลอรี่");//แสดงข้อความใน listBox1

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("แคลอรี่ของข้าวไข่เจียว คือ 445 กิโลแคลอรี่");//แสดงข้อความใน listBox1

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("แคลอรี่ของราดหน้า คือ 435 กิโลแคลอรี่");//แสดงข้อความใน listBox1

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("แคลอรี่ของข้าวขาหมู คือ 690 กิโลแคลอรี่");//แสดงข้อความใน listBox1

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("แคลอรี่ของข้าวมันไก่ทอด คือ 566 กิโลแคลอรี่");//แสดงข้อความใน listBox1

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
