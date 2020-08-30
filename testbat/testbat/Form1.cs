using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;


namespace testbat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("去執行程式外的檔案\r\n這邊是設定為開啟bat檔");
            Process pro = new Process();
            pro.StartInfo.FileName = "C:\\Users\\Public\\Desktop\\Roger9527";
            pro.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process[] processclose = Process.GetProcessesByName("C:\\Users\\wilso\\Desktop\\test.bat");

        }
        public void aka()
        {

        }
        public void bb()
        {
            aka();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("這邊是練習");
            string word = "我是誰";
            var ana = new List<animal> //這個list裡面都是animal這個類別的變數
            {
                new animal(),new Elephant(),new Wolf()
            };
            foreach (var a in ana )
            {
                a.speak();
                MessageBox.Show(a.say + a.dosomething(word));
            }
            
            Wolf bw = new Wolf();
            MessageBox.Show(Convert.ToString(bw.propoety) + "kg");//這邊直接去get
            bw.propoety = 50;
            MessageBox.Show(Convert.ToString ( bw.getweight())+"kg"); //這邊是透過去set 屬性然後用method去呼叫
            MessageBox.Show(Convert.ToString(bw.propoety)+"kg");//這邊直接去get
            Elephant ee = new Elephant();
            ee.speak();
            ee.call(bw);
            MessageBox.Show(ee.say);
            ee.complete(1243);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "C:\\Users\\wilso\\Desktop\\17_turtle.jpg";
            Bitmap img = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = img;
        }
        private void allbutton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "C:\\Users\\wilso\\Desktop\\17_turtle.jpg";
            Bitmap img = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = img;

            Button btn = (Button)sender;
            MessageBox.Show(btn.Text);

        }

        private void batchbutton_Click(object sender, EventArgs e)
        {
            this.button3.PerformClick();          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = true;
            op.FileName = "";
            op.Filter = "txt file (*.*) | *.txt";
            op.Title = "試試看啦";
            string firstfile = "";
            string secondfile = "";
            if (op.ShowDialog() == DialogResult.OK)
            {
                 firstfile = op.FileNames[0];
              //   secondfile = op.FileNames[1];
             //   MessageBox.Show(firstfile + "\r\n" + secondfile);
            }


                 List<string> nl = new List<string>();
            string[] mm = new string[5];
            string[] nm = new string[5];
            for(int a = 0; a<op.FileNames.Length;a++)
            {
            nl.Add(op.FileNames[a]);
            }
            label1.Text = nl[0]; //nl[0]代表第一個
            string[] splitstring = nl[0].Split('_');
            string[] doublestring = splitstring[2].Split('.');
            string[] doublestring2 = doublestring[0].Split('M');
            if( doublestring[0] == "M")
            {
                nm[0] = nl[0];
            }

            MessageBox.Show("第一次分割 :" +splitstring[2]);
            MessageBox.Show("第二次分割 :" + doublestring[0]);
            MessageBox.Show("第三次分割 :" + doublestring2[0]);

            //理論上可以實踐 依據名稱進行分類

        }
    }
}
