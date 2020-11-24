using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberPlace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            resetColor();
            bool[,] fill = new bool[9, 9];
            int[,] num = new int[9, 9];
            fill = checkFill(fill);
            num = fillNum(fill, num);
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0;j < 9; j++) {
                    if(num[i,j] == 10)
                    {
                        MessageBox.Show("エラーが発生しました。\n数字ではない文字列、または1-9以外の数が入力されています。\n"
                             + "\n該当箇所: " + i.ToString() + " , " + j.ToString(), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                }
            }
            int[,] oldNum = new int[9, 9];
            Array.Copy(num, oldNum, num.Length);
            SolveNumberPlace sn = new SolveNumberPlace();
            num = sn.Main(num);
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    if (num[i, j] != oldNum[i, j])
                    {
                        showNewNum(i, j, num[i, j]);
                    }

                }
            }
        }

        public bool[,] checkFill(bool[,] fill)
        {
            fill[0, 0] = textBox0_0.Text.Trim().Equals("") ? false : true;
            fill[0, 1] = textBox0_1.Text.Trim().Equals("") ? false : true;
            fill[0, 2] = textBox0_2.Text.Trim().Equals("") ? false : true;
            fill[0, 3] = textBox0_3.Text.Trim().Equals("") ? false : true;
            fill[0, 4] = textBox0_4.Text.Trim().Equals("") ? false : true;
            fill[0, 5] = textBox0_5.Text.Trim().Equals("") ? false : true;
            fill[0, 6] = textBox0_6.Text.Trim().Equals("") ? false : true;
            fill[0, 7] = textBox0_7.Text.Trim().Equals("") ? false : true;
            fill[0, 8] = textBox0_8.Text.Trim().Equals("") ? false : true;
            fill[1, 0] = textBox1_0.Text.Trim().Equals("") ? false : true;
            fill[1, 1] = textBox1_1.Text.Trim().Equals("") ? false : true;
            fill[1, 2] = textBox1_2.Text.Trim().Equals("") ? false : true;
            fill[1, 3] = textBox1_3.Text.Trim().Equals("") ? false : true;
            fill[1, 4] = textBox1_4.Text.Trim().Equals("") ? false : true;
            fill[1, 5] = textBox1_5.Text.Trim().Equals("") ? false : true;
            fill[1, 6] = textBox1_6.Text.Trim().Equals("") ? false : true;
            fill[1, 7] = textBox1_7.Text.Trim().Equals("") ? false : true;
            fill[1, 8] = textBox1_8.Text.Trim().Equals("") ? false : true;
            fill[2, 0] = textBox2_0.Text.Trim().Equals("") ? false : true;
            fill[2, 1] = textBox2_1.Text.Trim().Equals("") ? false : true;
            fill[2, 2] = textBox2_2.Text.Trim().Equals("") ? false : true;
            fill[2, 3] = textBox2_3.Text.Trim().Equals("") ? false : true;
            fill[2, 4] = textBox2_4.Text.Trim().Equals("") ? false : true;
            fill[2, 5] = textBox2_5.Text.Trim().Equals("") ? false : true;
            fill[2, 6] = textBox2_6.Text.Trim().Equals("") ? false : true;
            fill[2, 7] = textBox2_7.Text.Trim().Equals("") ? false : true;
            fill[2, 8] = textBox2_8.Text.Trim().Equals("") ? false : true;
            fill[3, 0] = textBox3_0.Text.Trim().Equals("") ? false : true;
            fill[3, 1] = textBox3_1.Text.Trim().Equals("") ? false : true;
            fill[3, 2] = textBox3_2.Text.Trim().Equals("") ? false : true;
            fill[3, 3] = textBox3_3.Text.Trim().Equals("") ? false : true;
            fill[3, 4] = textBox3_4.Text.Trim().Equals("") ? false : true;
            fill[3, 5] = textBox3_5.Text.Trim().Equals("") ? false : true;
            fill[3, 6] = textBox3_6.Text.Trim().Equals("") ? false : true;
            fill[3, 7] = textBox3_7.Text.Trim().Equals("") ? false : true;
            fill[3, 8] = textBox3_8.Text.Trim().Equals("") ? false : true;
            fill[4, 0] = textBox4_0.Text.Trim().Equals("") ? false : true;
            fill[4, 1] = textBox4_1.Text.Trim().Equals("") ? false : true;
            fill[4, 2] = textBox4_2.Text.Trim().Equals("") ? false : true;
            fill[4, 3] = textBox4_3.Text.Trim().Equals("") ? false : true;
            fill[4, 4] = textBox4_4.Text.Trim().Equals("") ? false : true;
            fill[4, 5] = textBox4_5.Text.Trim().Equals("") ? false : true;
            fill[4, 6] = textBox4_6.Text.Trim().Equals("") ? false : true;
            fill[4, 7] = textBox4_7.Text.Trim().Equals("") ? false : true;
            fill[4, 8] = textBox4_8.Text.Trim().Equals("") ? false : true;
            fill[5, 0] = textBox5_0.Text.Trim().Equals("") ? false : true;
            fill[5, 1] = textBox5_1.Text.Trim().Equals("") ? false : true;
            fill[5, 2] = textBox5_2.Text.Trim().Equals("") ? false : true;
            fill[5, 3] = textBox5_3.Text.Trim().Equals("") ? false : true;
            fill[5, 4] = textBox5_4.Text.Trim().Equals("") ? false : true;
            fill[5, 5] = textBox5_5.Text.Trim().Equals("") ? false : true;
            fill[5, 6] = textBox5_6.Text.Trim().Equals("") ? false : true;
            fill[5, 7] = textBox5_7.Text.Trim().Equals("") ? false : true;
            fill[5, 8] = textBox5_8.Text.Trim().Equals("") ? false : true;
            fill[6, 0] = textBox6_0.Text.Trim().Equals("") ? false : true;
            fill[6, 1] = textBox6_1.Text.Trim().Equals("") ? false : true;
            fill[6, 2] = textBox6_2.Text.Trim().Equals("") ? false : true;
            fill[6, 3] = textBox6_3.Text.Trim().Equals("") ? false : true;
            fill[6, 4] = textBox6_4.Text.Trim().Equals("") ? false : true;
            fill[6, 5] = textBox6_5.Text.Trim().Equals("") ? false : true;
            fill[6, 6] = textBox6_6.Text.Trim().Equals("") ? false : true;
            fill[6, 7] = textBox6_7.Text.Trim().Equals("") ? false : true;
            fill[6, 8] = textBox6_8.Text.Trim().Equals("") ? false : true;
            fill[7, 0] = textBox7_0.Text.Trim().Equals("") ? false : true;
            fill[7, 1] = textBox7_1.Text.Trim().Equals("") ? false : true;
            fill[7, 2] = textBox7_2.Text.Trim().Equals("") ? false : true;
            fill[7, 3] = textBox7_3.Text.Trim().Equals("") ? false : true;
            fill[7, 4] = textBox7_4.Text.Trim().Equals("") ? false : true;
            fill[7, 5] = textBox7_5.Text.Trim().Equals("") ? false : true;
            fill[7, 6] = textBox7_6.Text.Trim().Equals("") ? false : true;
            fill[7, 7] = textBox7_7.Text.Trim().Equals("") ? false : true;
            fill[7, 8] = textBox7_8.Text.Trim().Equals("") ? false : true;
            fill[8, 0] = textBox8_0.Text.Trim().Equals("") ? false : true;
            fill[8, 1] = textBox8_1.Text.Trim().Equals("") ? false : true;
            fill[8, 2] = textBox8_2.Text.Trim().Equals("") ? false : true;
            fill[8, 3] = textBox8_3.Text.Trim().Equals("") ? false : true;
            fill[8, 4] = textBox8_4.Text.Trim().Equals("") ? false : true;
            fill[8, 5] = textBox8_5.Text.Trim().Equals("") ? false : true;
            fill[8, 6] = textBox8_6.Text.Trim().Equals("") ? false : true;
            fill[8, 7] = textBox8_7.Text.Trim().Equals("") ? false : true;
            fill[8, 8] = textBox8_8.Text.Trim().Equals("") ? false : true;
            return fill;
        }

        public int[,] fillNum(bool[,] fill, int[,] num)
            /*textBoxの内容をnumに格納するメソッド。
             * numに格納される値の意味は下記
             * 0...入力されてない(不明部分)
             * 1-9...入力された数字
             * 10...入力されているが1-9以外かParseに失敗した(あとでエラー出力)
             */
        {
            bool success;
            if (fill[0, 0])
            {
                success = int.TryParse(this.textBox0_0.Text, out num[0, 0]);
                if (!success || (num[0, 0] < 1 || num[0, 0] > 9))
                {
                    num[0, 0] = 10;
                }
            }
            else
            {
                num[0, 0] = 0;
            }
            if (fill[0, 1])
            {
                success = int.TryParse(this.textBox0_1.Text, out num[0, 1]);
                if (!success || (num[0, 1] < 1 || num[0, 1] > 9))
                {
                    num[0, 1] = 10;
                }
            }
            else
            {
                num[0, 1] = 0;
            }
            if (fill[0, 2])
            {
                success = int.TryParse(this.textBox0_2.Text, out num[0, 2]);
                if (!success || (num[0, 2] < 1 || num[0, 2] > 9))
                {
                    num[0, 2] = 10;
                }
            }
            else
            {
                num[0, 2] = 0;
            }
            if (fill[0, 3])
            {
                success = int.TryParse(this.textBox0_3.Text, out num[0, 3]);
                if (!success || (num[0, 3] < 1 || num[0, 3] > 9))
                {
                    num[0, 3] = 10;
                }
            }
            else
            {
                num[0, 3] = 0;
            }
            if (fill[0, 4])
            {
                success = int.TryParse(this.textBox0_4.Text, out num[0, 4]);
                if (!success || (num[0, 4] < 1 || num[0, 4] > 9))
                {
                    num[0, 4] = 10;
                }
            }
            else
            {
                num[0, 4] = 0;
            }
            if (fill[0, 5])
            {
                success = int.TryParse(this.textBox0_5.Text, out num[0, 5]);
                if (!success || (num[0, 5] < 1 || num[0, 5] > 9))
                {
                    num[0, 5] = 10;
                }
            }
            else
            {
                num[0, 5] = 0;
            }
            if (fill[0, 6])
            {
                success = int.TryParse(this.textBox0_6.Text, out num[0, 6]);
                if (!success || (num[0, 6] < 1 || num[0, 6] > 9))
                {
                    num[0, 6] = 10;
                }
            }
            else
            {
                num[0, 6] = 0;
            }
            if (fill[0, 7])
            {
                success = int.TryParse(this.textBox0_7.Text, out num[0, 7]);
                if (!success || (num[0, 7] < 1 || num[0, 7] > 9))
                {
                    num[0, 7] = 10;
                }
            }
            else
            {
                num[0, 7] = 0;
            }
            if (fill[0, 8])
            {
                success = int.TryParse(this.textBox0_8.Text, out num[0, 8]);
                if (!success || (num[0, 8] < 1 || num[0, 8] > 9))
                {
                    num[0, 8] = 10;
                }
            }
            else
            {
                num[0, 8] = 0;
            }
            if (fill[1, 0])
            {
                success = int.TryParse(this.textBox1_0.Text, out num[1, 0]);
                if (!success || (num[1, 0] < 1 || num[1, 0] > 9))
                {
                    num[1, 0] = 10;
                }
            }
            else
            {
                num[1, 0] = 0;
            }
            if (fill[1, 1])
            {
                success = int.TryParse(this.textBox1_1.Text, out num[1, 1]);
                if (!success || (num[1, 1] < 1 || num[1, 1] > 9))
                {
                    num[1, 1] = 10;
                }
            }
            else
            {
                num[1, 1] = 0;
            }
            if (fill[1, 2])
            {
                success = int.TryParse(this.textBox1_2.Text, out num[1, 2]);
                if (!success || (num[1, 2] < 1 || num[1, 2] > 9))
                {
                    num[1, 2] = 10;
                }
            }
            else
            {
                num[1, 2] = 0;
            }
            if (fill[1, 3])
            {
                success = int.TryParse(this.textBox1_3.Text, out num[1, 3]);
                if (!success || (num[1, 3] < 1 || num[1, 3] > 9))
                {
                    num[1, 3] = 10;
                }
            }
            else
            {
                num[1, 3] = 0;
            }
            if (fill[1, 4])
            {
                success = int.TryParse(this.textBox1_4.Text, out num[1, 4]);
                if (!success || (num[1, 4] < 1 || num[1, 4] > 9))
                {
                    num[1, 4] = 10;
                }
            }
            else
            {
                num[1, 4] = 0;
            }
            if (fill[1, 5])
            {
                success = int.TryParse(this.textBox1_5.Text, out num[1, 5]);
                if (!success || (num[1, 5] < 1 || num[1, 5] > 9))
                {
                    num[1, 5] = 10;
                }
            }
            else
            {
                num[1, 5] = 0;
            }
            if (fill[1, 6])
            {
                success = int.TryParse(this.textBox1_6.Text, out num[1, 6]);
                if (!success || (num[1, 6] < 1 || num[1, 6] > 9))
                {
                    num[1, 6] = 10;
                }
            }
            else
            {
                num[1, 6] = 0;
            }
            if (fill[1, 7])
            {
                success = int.TryParse(this.textBox1_7.Text, out num[1, 7]);
                if (!success || (num[1, 7] < 1 || num[1, 7] > 9))
                {
                    num[1, 7] = 10;
                }
            }
            else
            {
                num[1, 7] = 0;
            }
            if (fill[1, 8])
            {
                success = int.TryParse(this.textBox1_8.Text, out num[1, 8]);
                if (!success || (num[1, 8] < 1 || num[1, 8] > 9))
                {
                    num[1, 8] = 10;
                }
            }
            else
            {
                num[1, 8] = 0;
            }
            if (fill[2, 0])
            {
                success = int.TryParse(this.textBox2_0.Text, out num[2, 0]);
                if (!success || (num[2, 0] < 1 || num[2, 0] > 9))
                {
                    num[2, 0] = 10;
                }
            }
            else
            {
                num[2, 0] = 0;
            }
            if (fill[2, 1])
            {
                success = int.TryParse(this.textBox2_1.Text, out num[2, 1]);
                if (!success || (num[2, 1] < 1 || num[2, 1] > 9))
                {
                    num[2, 1] = 10;
                }
            }
            else
            {
                num[2, 1] = 0;
            }
            if (fill[2, 2])
            {
                success = int.TryParse(this.textBox2_2.Text, out num[2, 2]);
                if (!success || (num[2, 2] < 1 || num[2, 2] > 9))
                {
                    num[2, 2] = 10;
                }
            }
            else
            {
                num[2, 2] = 0;
            }
            if (fill[2, 3])
            {
                success = int.TryParse(this.textBox2_3.Text, out num[2, 3]);
                if (!success || (num[2, 3] < 1 || num[2, 3] > 9))
                {
                    num[2, 3] = 10;
                }
            }
            else
            {
                num[2, 3] = 0;
            }
            if (fill[2, 4])
            {
                success = int.TryParse(this.textBox2_4.Text, out num[2, 4]);
                if (!success || (num[2, 4] < 1 || num[2, 4] > 9))
                {
                    num[2, 4] = 10;
                }
            }
            else
            {
                num[2, 4] = 0;
            }
            if (fill[2, 5])
            {
                success = int.TryParse(this.textBox2_5.Text, out num[2, 5]);
                if (!success || (num[2, 5] < 1 || num[2, 5] > 9))
                {
                    num[2, 5] = 10;
                }
            }
            else
            {
                num[2, 5] = 0;
            }
            if (fill[2, 6])
            {
                success = int.TryParse(this.textBox2_6.Text, out num[2, 6]);
                if (!success || (num[2, 6] < 1 || num[2, 6] > 9))
                {
                    num[2, 6] = 10;
                }
            }
            else
            {
                num[2, 6] = 0;
            }
            if (fill[2, 7])
            {
                success = int.TryParse(this.textBox2_7.Text, out num[2, 7]);
                if (!success || (num[2, 7] < 1 || num[2, 7] > 9))
                {
                    num[2, 7] = 10;
                }
            }
            else
            {
                num[2, 7] = 0;
            }
            if (fill[2, 8])
            {
                success = int.TryParse(this.textBox2_8.Text, out num[2, 8]);
                if (!success || (num[2, 8] < 1 || num[2, 8] > 9))
                {
                    num[2, 8] = 10;
                }
            }
            else
            {
                num[2, 8] = 0;
            }
            if (fill[3, 0])
            {
                success = int.TryParse(this.textBox3_0.Text, out num[3, 0]);
                if (!success || (num[3, 0] < 1 || num[3, 0] > 9))
                {
                    num[3, 0] = 10;
                }
            }
            else
            {
                num[3, 0] = 0;
            }
            if (fill[3, 1])
            {
                success = int.TryParse(this.textBox3_1.Text, out num[3, 1]);
                if (!success || (num[3, 1] < 1 || num[3, 1] > 9))
                {
                    num[3, 1] = 10;
                }
            }
            else
            {
                num[3, 1] = 0;
            }
            if (fill[3, 2])
            {
                success = int.TryParse(this.textBox3_2.Text, out num[3, 2]);
                if (!success || (num[3, 2] < 1 || num[3, 2] > 9))
                {
                    num[3, 2] = 10;
                }
            }
            else
            {
                num[3, 2] = 0;
            }
            if (fill[3, 3])
            {
                success = int.TryParse(this.textBox3_3.Text, out num[3, 3]);
                if (!success || (num[3, 3] < 1 || num[3, 3] > 9))
                {
                    num[3, 3] = 10;
                }
            }
            else
            {
                num[3, 3] = 0;
            }
            if (fill[3, 4])
            {
                success = int.TryParse(this.textBox3_4.Text, out num[3, 4]);
                if (!success || (num[3, 4] < 1 || num[3, 4] > 9))
                {
                    num[3, 4] = 10;
                }
            }
            else
            {
                num[3, 4] = 0;
            }
            if (fill[3, 5])
            {
                success = int.TryParse(this.textBox3_5.Text, out num[3, 5]);
                if (!success || (num[3, 5] < 1 || num[3, 5] > 9))
                {
                    num[3, 5] = 10;
                }
            }
            else
            {
                num[3, 5] = 0;
            }
            if (fill[3, 6])
            {
                success = int.TryParse(this.textBox3_6.Text, out num[3, 6]);
                if (!success || (num[3, 6] < 1 || num[3, 6] > 9))
                {
                    num[3, 6] = 10;
                }
            }
            else
            {
                num[3, 6] = 0;
            }
            if (fill[3, 7])
            {
                success = int.TryParse(this.textBox3_7.Text, out num[3, 7]);
                if (!success || (num[3, 7] < 1 || num[3, 7] > 9))
                {
                    num[3, 7] = 10;
                }
            }
            else
            {
                num[3, 7] = 0;
            }
            if (fill[3, 8])
            {
                success = int.TryParse(this.textBox3_8.Text, out num[3, 8]);
                if (!success || (num[3, 8] < 1 || num[3, 8] > 9))
                {
                    num[3, 8] = 10;
                }
            }
            else
            {
                num[3, 8] = 0;
            }
            if (fill[4, 0])
            {
                success = int.TryParse(this.textBox4_0.Text, out num[4, 0]);
                if (!success || (num[4, 0] < 1 || num[4, 0] > 9))
                {
                    num[4, 0] = 10;
                }
            }
            else
            {
                num[4, 0] = 0;
            }
            if (fill[4, 1])
            {
                success = int.TryParse(this.textBox4_1.Text, out num[4, 1]);
                if (!success || (num[4, 1] < 1 || num[4, 1] > 9))
                {
                    num[4, 1] = 10;
                }
            }
            else
            {
                num[4, 1] = 0;
            }
            if (fill[4, 2])
            {
                success = int.TryParse(this.textBox4_2.Text, out num[4, 2]);
                if (!success || (num[4, 2] < 1 || num[4, 2] > 9))
                {
                    num[4, 2] = 10;
                }
            }
            else
            {
                num[4, 2] = 0;
            }
            if (fill[4, 3])
            {
                success = int.TryParse(this.textBox4_3.Text, out num[4, 3]);
                if (!success || (num[4, 3] < 1 || num[4, 3] > 9))
                {
                    num[4, 3] = 10;
                }
            }
            else
            {
                num[4, 3] = 0;
            }
            if (fill[4, 4])
            {
                success = int.TryParse(this.textBox4_4.Text, out num[4, 4]);
                if (!success || (num[4, 4] < 1 || num[4, 4] > 9))
                {
                    num[4, 4] = 10;
                }
            }
            else
            {
                num[4, 4] = 0;
            }
            if (fill[4, 5])
            {
                success = int.TryParse(this.textBox4_5.Text, out num[4, 5]);
                if (!success || (num[4, 5] < 1 || num[4, 5] > 9))
                {
                    num[4, 5] = 10;
                }
            }
            else
            {
                num[4, 5] = 0;
            }
            if (fill[4, 6])
            {
                success = int.TryParse(this.textBox4_6.Text, out num[4, 6]);
                if (!success || (num[4, 6] < 1 || num[4, 6] > 9))
                {
                    num[4, 6] = 10;
                }
            }
            else
            {
                num[4, 6] = 0;
            }
            if (fill[4, 7])
            {
                success = int.TryParse(this.textBox4_7.Text, out num[4, 7]);
                if (!success || (num[4, 7] < 1 || num[4, 7] > 9))
                {
                    num[4, 7] = 10;
                }
            }
            else
            {
                num[4, 7] = 0;
            }
            if (fill[4, 8])
            {
                success = int.TryParse(this.textBox4_8.Text, out num[4, 8]);
                if (!success || (num[4, 8] < 1 || num[4, 8] > 9))
                {
                    num[4, 8] = 10;
                }
            }
            else
            {
                num[4, 8] = 0;
            }
            if (fill[5, 0])
            {
                success = int.TryParse(this.textBox5_0.Text, out num[5, 0]);
                if (!success || (num[5, 0] < 1 || num[5, 0] > 9))
                {
                    num[5, 0] = 10;
                }
            }
            else
            {
                num[5, 0] = 0;
            }
            if (fill[5, 1])
            {
                success = int.TryParse(this.textBox5_1.Text, out num[5, 1]);
                if (!success || (num[5, 1] < 1 || num[5, 1] > 9))
                {
                    num[5, 1] = 10;
                }
            }
            else
            {
                num[5, 1] = 0;
            }
            if (fill[5, 2])
            {
                success = int.TryParse(this.textBox5_2.Text, out num[5, 2]);
                if (!success || (num[5, 2] < 1 || num[5, 2] > 9))
                {
                    num[5, 2] = 10;
                }
            }
            else
            {
                num[5, 2] = 0;
            }
            if (fill[5, 3])
            {
                success = int.TryParse(this.textBox5_3.Text, out num[5, 3]);
                if (!success || (num[5, 3] < 1 || num[5, 3] > 9))
                {
                    num[5, 3] = 10;
                }
            }
            else
            {
                num[5, 3] = 0;
            }
            if (fill[5, 4])
            {
                success = int.TryParse(this.textBox5_4.Text, out num[5, 4]);
                if (!success || (num[5, 4] < 1 || num[5, 4] > 9))
                {
                    num[5, 4] = 10;
                }
            }
            else
            {
                num[5, 4] = 0;
            }
            if (fill[5, 5])
            {
                success = int.TryParse(this.textBox5_5.Text, out num[5, 5]);
                if (!success || (num[5, 5] < 1 || num[5, 5] > 9))
                {
                    num[5, 5] = 10;
                }
            }
            else
            {
                num[5, 5] = 0;
            }
            if (fill[5, 6])
            {
                success = int.TryParse(this.textBox5_6.Text, out num[5, 6]);
                if (!success || (num[5, 6] < 1 || num[5, 6] > 9))
                {
                    num[5, 6] = 10;
                }
            }
            else
            {
                num[5, 6] = 0;
            }
            if (fill[5, 7])
            {
                success = int.TryParse(this.textBox5_7.Text, out num[5, 7]);
                if (!success || (num[5, 7] < 1 || num[5, 7] > 9))
                {
                    num[5, 7] = 10;
                }
            }
            else
            {
                num[5, 7] = 0;
            }
            if (fill[5, 8])
            {
                success = int.TryParse(this.textBox5_8.Text, out num[5, 8]);
                if (!success || (num[5, 8] < 1 || num[5, 8] > 9))
                {
                    num[5, 8] = 10;
                }
            }
            else
            {
                num[5, 8] = 0;
            }
            if (fill[6, 0])
            {
                success = int.TryParse(this.textBox6_0.Text, out num[6, 0]);
                if (!success || (num[6, 0] < 1 || num[6, 0] > 9))
                {
                    num[6, 0] = 10;
                }
            }
            else
            {
                num[6, 0] = 0;
            }
            if (fill[6, 1])
            {
                success = int.TryParse(this.textBox6_1.Text, out num[6, 1]);
                if (!success || (num[6, 1] < 1 || num[6, 1] > 9))
                {
                    num[6, 1] = 10;
                }
            }
            else
            {
                num[6, 1] = 0;
            }
            if (fill[6, 2])
            {
                success = int.TryParse(this.textBox6_2.Text, out num[6, 2]);
                if (!success || (num[6, 2] < 1 || num[6, 2] > 9))
                {
                    num[6, 2] = 10;
                }
            }
            else
            {
                num[6, 2] = 0;
            }
            if (fill[6, 3])
            {
                success = int.TryParse(this.textBox6_3.Text, out num[6, 3]);
                if (!success || (num[6, 3] < 1 || num[6, 3] > 9))
                {
                    num[6, 3] = 10;
                }
            }
            else
            {
                num[6, 3] = 0;
            }
            if (fill[6, 4])
            {
                success = int.TryParse(this.textBox6_4.Text, out num[6, 4]);
                if (!success || (num[6, 4] < 1 || num[6, 4] > 9))
                {
                    num[6, 4] = 10;
                }
            }
            else
            {
                num[6, 4] = 0;
            }
            if (fill[6, 5])
            {
                success = int.TryParse(this.textBox6_5.Text, out num[6, 5]);
                if (!success || (num[6, 5] < 1 || num[6, 5] > 9))
                {
                    num[6, 5] = 10;
                }
            }
            else
            {
                num[6, 5] = 0;
            }
            if (fill[6, 6])
            {
                success = int.TryParse(this.textBox6_6.Text, out num[6, 6]);
                if (!success || (num[6, 6] < 1 || num[6, 6] > 9))
                {
                    num[6, 6] = 10;
                }
            }
            else
            {
                num[6, 6] = 0;
            }
            if (fill[6, 7])
            {
                success = int.TryParse(this.textBox6_7.Text, out num[6, 7]);
                if (!success || (num[6, 7] < 1 || num[6, 7] > 9))
                {
                    num[6, 7] = 10;
                }
            }
            else
            {
                num[6, 7] = 0;
            }
            if (fill[6, 8])
            {
                success = int.TryParse(this.textBox6_8.Text, out num[6, 8]);
                if (!success || (num[6, 8] < 1 || num[6, 8] > 9))
                {
                    num[6, 8] = 10;
                }
            }
            else
            {
                num[6, 8] = 0;
            }
            if (fill[7, 0])
            {
                success = int.TryParse(this.textBox7_0.Text, out num[7, 0]);
                if (!success || (num[7, 0] < 1 || num[7, 0] > 9))
                {
                    num[7, 0] = 10;
                }
            }
            else
            {
                num[7, 0] = 0;
            }
            if (fill[7, 1])
            {
                success = int.TryParse(this.textBox7_1.Text, out num[7, 1]);
                if (!success || (num[7, 1] < 1 || num[7, 1] > 9))
                {
                    num[7, 1] = 10;
                }
            }
            else
            {
                num[7, 1] = 0;
            }
            if (fill[7, 2])
            {
                success = int.TryParse(this.textBox7_2.Text, out num[7, 2]);
                if (!success || (num[7, 2] < 1 || num[7, 2] > 9))
                {
                    num[7, 2] = 10;
                }
            }
            else
            {
                num[7, 2] = 0;
            }
            if (fill[7, 3])
            {
                success = int.TryParse(this.textBox7_3.Text, out num[7, 3]);
                if (!success || (num[7, 3] < 1 || num[7, 3] > 9))
                {
                    num[7, 3] = 10;
                }
            }
            else
            {
                num[7, 3] = 0;
            }
            if (fill[7, 4])
            {
                success = int.TryParse(this.textBox7_4.Text, out num[7, 4]);
                if (!success || (num[7, 4] < 1 || num[7, 4] > 9))
                {
                    num[7, 4] = 10;
                }
            }
            else
            {
                num[7, 4] = 0;
            }
            if (fill[7, 5])
            {
                success = int.TryParse(this.textBox7_5.Text, out num[7, 5]);
                if (!success || (num[7, 5] < 1 || num[7, 5] > 9))
                {
                    num[7, 5] = 10;
                }
            }
            else
            {
                num[7, 5] = 0;
            }
            if (fill[7, 6])
            {
                success = int.TryParse(this.textBox7_6.Text, out num[7, 6]);
                if (!success || (num[7, 6] < 1 || num[7, 6] > 9))
                {
                    num[7, 6] = 10;
                }
            }
            else
            {
                num[7, 6] = 0;
            }
            if (fill[7, 7])
            {
                success = int.TryParse(this.textBox7_7.Text, out num[7, 7]);
                if (!success || (num[7, 7] < 1 || num[7, 7] > 9))
                {
                    num[7, 7] = 10;
                }
            }
            else
            {
                num[7, 7] = 0;
            }
            if (fill[7, 8])
            {
                success = int.TryParse(this.textBox7_8.Text, out num[7, 8]);
                if (!success || (num[7, 8] < 1 || num[7, 8] > 9))
                {
                    num[7, 8] = 10;
                }
            }
            else
            {
                num[7, 8] = 0;
            }
            if (fill[8, 0])
            {
                success = int.TryParse(this.textBox8_0.Text, out num[8, 0]);
                if (!success || (num[8, 0] < 1 || num[8, 0] > 9))
                {
                    num[8, 0] = 10;
                }
            }
            else
            {
                num[8, 0] = 0;
            }
            if (fill[8, 1])
            {
                success = int.TryParse(this.textBox8_1.Text, out num[8, 1]);
                if (!success || (num[8, 1] < 1 || num[8, 1] > 9))
                {
                    num[8, 1] = 10;
                }
            }
            else
            {
                num[8, 1] = 0;
            }
            if (fill[8, 2])
            {
                success = int.TryParse(this.textBox8_2.Text, out num[8, 2]);
                if (!success || (num[8, 2] < 1 || num[8, 2] > 9))
                {
                    num[8, 2] = 10;
                }
            }
            else
            {
                num[8, 2] = 0;
            }
            if (fill[8, 3])
            {
                success = int.TryParse(this.textBox8_3.Text, out num[8, 3]);
                if (!success || (num[8, 3] < 1 || num[8, 3] > 9))
                {
                    num[8, 3] = 10;
                }
            }
            else
            {
                num[8, 3] = 0;
            }
            if (fill[8, 4])
            {
                success = int.TryParse(this.textBox8_4.Text, out num[8, 4]);
                if (!success || (num[8, 4] < 1 || num[8, 4] > 9))
                {
                    num[8, 4] = 10;
                }
            }
            else
            {
                num[8, 4] = 0;
            }
            if (fill[8, 5])
            {
                success = int.TryParse(this.textBox8_5.Text, out num[8, 5]);
                if (!success || (num[8, 5] < 1 || num[8, 5] > 9))
                {
                    num[8, 5] = 10;
                }
            }
            else
            {
                num[8, 5] = 0;
            }
            if (fill[8, 6])
            {
                success = int.TryParse(this.textBox8_6.Text, out num[8, 6]);
                if (!success || (num[8, 6] < 1 || num[8, 6] > 9))
                {
                    num[8, 6] = 10;
                }
            }
            else
            {
                num[8, 6] = 0;
            }
            if (fill[8, 7])
            {
                success = int.TryParse(this.textBox8_7.Text, out num[8, 7]);
                if (!success || (num[8, 7] < 1 || num[8, 7] > 9))
                {
                    num[8, 7] = 10;
                }
            }
            else
            {
                num[8, 7] = 0;
            }
            if (fill[8, 8])
            {
                success = int.TryParse(this.textBox8_8.Text, out num[8, 8]);
                if (!success || (num[8, 8] < 1 || num[8, 8] > 9))
                {
                    num[8, 8] = 10;
                }
            }
            else
            {
                num[8, 8] = 0;
            }
            return num;
        }

        public void showNewNum(int frame, int spot, int ans)
        {
            Console.WriteLine("showNewNum loaded");
            Color color = Color.Blue;
            string ansStr = ans.ToString();
            if (frame == 0)
            {
                if (spot == 0)
                {
                    textBox0_0.Text = ansStr;
                    textBox0_0.ForeColor = color;
                }
                if (spot == 1)
                {
                    textBox0_1.Text = ansStr;
                    textBox0_1.ForeColor = color;
                }
                if (spot == 2)
                {
                    textBox0_2.Text = ansStr;
                    textBox0_2.ForeColor = color;
                }
                if (spot == 3)
                {
                    textBox0_3.Text = ansStr;
                    textBox0_3.ForeColor = color;
                }
                if (spot == 4)
                {
                    textBox0_4.Text = ansStr;
                    textBox0_4.ForeColor = color;
                }
                if (spot == 5)
                {
                    textBox0_5.Text = ansStr;
                    textBox0_5.ForeColor = color;
                }
                if (spot == 6)
                {
                    textBox0_6.Text = ansStr;
                    textBox0_6.ForeColor = color;
                }
                if (spot == 7)
                {
                    textBox0_7.Text = ansStr;
                    textBox0_7.ForeColor = color;
                }
                if (spot == 8)
                {
                    textBox0_8.Text = ansStr;
                    textBox0_8.ForeColor = color;
                }
            }
            if (frame == 1)
            {
                if (spot == 0)
                {
                    textBox1_0.Text = ansStr;
                    textBox1_0.ForeColor = color;
                }
                if (spot == 1)
                {
                    textBox1_1.Text = ansStr;
                    textBox1_1.ForeColor = color;
                }
                if (spot == 2)
                {
                    textBox1_2.Text = ansStr;
                    textBox1_2.ForeColor = color;
                }
                if (spot == 3)
                {
                    textBox1_3.Text = ansStr;
                    textBox1_3.ForeColor = color;
                }
                if (spot == 4)
                {
                    textBox1_4.Text = ansStr;
                    textBox1_4.ForeColor = color;
                }
                if (spot == 5)
                {
                    textBox1_5.Text = ansStr;
                    textBox1_5.ForeColor = color;
                }
                if (spot == 6)
                {
                    textBox1_6.Text = ansStr;
                    textBox1_6.ForeColor = color;
                }
                if (spot == 7)
                {
                    textBox1_7.Text = ansStr;
                    textBox1_7.ForeColor = color;
                }
                if (spot == 8)
                {
                    textBox1_8.Text = ansStr;
                    textBox1_8.ForeColor = color;
                }
            }
            if (frame == 2)
            {
                if (spot == 0)
                {
                    textBox2_0.Text = ansStr;
                    textBox2_0.ForeColor = color;
                }
                if (spot == 1)
                {
                    textBox2_1.Text = ansStr;
                    textBox2_1.ForeColor = color;
                }
                if (spot == 2)
                {
                    textBox2_2.Text = ansStr;
                    textBox2_2.ForeColor = color;
                }
                if (spot == 3)
                {
                    textBox2_3.Text = ansStr;
                    textBox2_3.ForeColor = color;
                }
                if (spot == 4)
                {
                    textBox2_4.Text = ansStr;
                    textBox2_4.ForeColor = color;
                }
                if (spot == 5)
                {
                    textBox2_5.Text = ansStr;
                    textBox2_5.ForeColor = color;
                }
                if (spot == 6)
                {
                    textBox2_6.Text = ansStr;
                    textBox2_6.ForeColor = color;
                }
                if (spot == 7)
                {
                    textBox2_7.Text = ansStr;
                    textBox2_7.ForeColor = color;
                }
                if (spot == 8)
                {
                    textBox2_8.Text = ansStr;
                    textBox2_8.ForeColor = color;
                }
            }
            if (frame == 3)
            {
                if (spot == 0)
                {
                    textBox3_0.Text = ansStr;
                    textBox3_0.ForeColor = color;
                }
                if (spot == 1)
                {
                    textBox3_1.Text = ansStr;
                    textBox3_1.ForeColor = color;
                }
                if (spot == 2)
                {
                    textBox3_2.Text = ansStr;
                    textBox3_2.ForeColor = color;
                }
                if (spot == 3)
                {
                    textBox3_3.Text = ansStr;
                    textBox3_3.ForeColor = color;
                }
                if (spot == 4)
                {
                    textBox3_4.Text = ansStr;
                    textBox3_4.ForeColor = color;
                }
                if (spot == 5)
                {
                    textBox3_5.Text = ansStr;
                    textBox3_5.ForeColor = color;
                }
                if (spot == 6)
                {
                    textBox3_6.Text = ansStr;
                    textBox3_6.ForeColor = color;
                }
                if (spot == 7)
                {
                    textBox3_7.Text = ansStr;
                    textBox3_7.ForeColor = color;
                }
                if (spot == 8)
                {
                    textBox3_8.Text = ansStr;
                    textBox3_8.ForeColor = color;
                }
            }
            if (frame == 4)
            {
                if (spot == 0)
                {
                    textBox4_0.Text = ansStr;
                    textBox4_0.ForeColor = color;
                }
                if (spot == 1)
                {
                    textBox4_1.Text = ansStr;
                    textBox4_1.ForeColor = color;
                }
                if (spot == 2)
                {
                    textBox4_2.Text = ansStr;
                    textBox4_2.ForeColor = color;
                }
                if (spot == 3)
                {
                    textBox4_3.Text = ansStr;
                    textBox4_3.ForeColor = color;
                }
                if (spot == 4)
                {
                    textBox4_4.Text = ansStr;
                    textBox4_4.ForeColor = color;
                }
                if (spot == 5)
                {
                    textBox4_5.Text = ansStr;
                    textBox4_5.ForeColor = color;
                }
                if (spot == 6)
                {
                    textBox4_6.Text = ansStr;
                    textBox4_6.ForeColor = color;
                }
                if (spot == 7)
                {
                    textBox4_7.Text = ansStr;
                    textBox4_7.ForeColor = color;
                }
                if (spot == 8)
                {
                    textBox4_8.Text = ansStr;
                    textBox4_8.ForeColor = color;
                }
            }
            if (frame == 5)
            {
                if (spot == 0)
                {
                    textBox5_0.Text = ansStr;
                    textBox5_0.ForeColor = color;
                }
                if (spot == 1)
                {
                    textBox5_1.Text = ansStr;
                    textBox5_1.ForeColor = color;
                }
                if (spot == 2)
                {
                    textBox5_2.Text = ansStr;
                    textBox5_2.ForeColor = color;
                }
                if (spot == 3)
                {
                    textBox5_3.Text = ansStr;
                    textBox5_3.ForeColor = color;
                }
                if (spot == 4)
                {
                    textBox5_4.Text = ansStr;
                    textBox5_4.ForeColor = color;
                }
                if (spot == 5)
                {
                    textBox5_5.Text = ansStr;
                    textBox5_5.ForeColor = color;
                }
                if (spot == 6)
                {
                    textBox5_6.Text = ansStr;
                    textBox5_6.ForeColor = color;
                }
                if (spot == 7)
                {
                    textBox5_7.Text = ansStr;
                    textBox5_7.ForeColor = color;
                }
                if (spot == 8)
                {
                    textBox5_8.Text = ansStr;
                    textBox5_8.ForeColor = color;
                }
            }
            if (frame == 6)
            {
                if (spot == 0)
                {
                    textBox6_0.Text = ansStr;
                    textBox6_0.ForeColor = color;
                }
                if (spot == 1)
                {
                    textBox6_1.Text = ansStr;
                    textBox6_1.ForeColor = color;
                }
                if (spot == 2)
                {
                    textBox6_2.Text = ansStr;
                    textBox6_2.ForeColor = color;
                }
                if (spot == 3)
                {
                    textBox6_3.Text = ansStr;
                    textBox6_3.ForeColor = color;
                }
                if (spot == 4)
                {
                    textBox6_4.Text = ansStr;
                    textBox6_4.ForeColor = color;
                }
                if (spot == 5)
                {
                    textBox6_5.Text = ansStr;
                    textBox6_5.ForeColor = color;
                }
                if (spot == 6)
                {
                    textBox6_6.Text = ansStr;
                    textBox6_6.ForeColor = color;
                }
                if (spot == 7)
                {
                    textBox6_7.Text = ansStr;
                    textBox6_7.ForeColor = color;
                }
                if (spot == 8)
                {
                    textBox6_8.Text = ansStr;
                    textBox6_8.ForeColor = color;
                }
            }
            if (frame == 7)
            {
                if (spot == 0)
                {
                    textBox7_0.Text = ansStr;
                    textBox7_0.ForeColor = color;
                }
                if (spot == 1)
                {
                    textBox7_1.Text = ansStr;
                    textBox7_1.ForeColor = color;
                }
                if (spot == 2)
                {
                    textBox7_2.Text = ansStr;
                    textBox7_2.ForeColor = color;
                }
                if (spot == 3)
                {
                    textBox7_3.Text = ansStr;
                    textBox7_3.ForeColor = color;
                }
                if (spot == 4)
                {
                    textBox7_4.Text = ansStr;
                    textBox7_4.ForeColor = color;
                }
                if (spot == 5)
                {
                    textBox7_5.Text = ansStr;
                    textBox7_5.ForeColor = color;
                }
                if (spot == 6)
                {
                    textBox7_6.Text = ansStr;
                    textBox7_6.ForeColor = color;
                }
                if (spot == 7)
                {
                    textBox7_7.Text = ansStr;
                    textBox7_7.ForeColor = color;
                }
                if (spot == 8)
                {
                    textBox7_8.Text = ansStr;
                    textBox7_8.ForeColor = color;
                }
            }
            if (frame == 8)
            {
                if (spot == 0)
                {
                    textBox8_0.Text = ansStr;
                    textBox8_0.ForeColor = color;
                }
                if (spot == 1)
                {
                    textBox8_1.Text = ansStr;
                    textBox8_1.ForeColor = color;
                }
                if (spot == 2)
                {
                    textBox8_2.Text = ansStr;
                    textBox8_2.ForeColor = color;
                }
                if (spot == 3)
                {
                    textBox8_3.Text = ansStr;
                    textBox8_3.ForeColor = color;
                }
                if (spot == 4)
                {
                    textBox8_4.Text = ansStr;
                    textBox8_4.ForeColor = color;
                }
                if (spot == 5)
                {
                    textBox8_5.Text = ansStr;
                    textBox8_5.ForeColor = color;
                }
                if (spot == 6)
                {
                    textBox8_6.Text = ansStr;
                    textBox8_6.ForeColor = color;
                }
                if (spot == 7)
                {
                    textBox8_7.Text = ansStr;
                    textBox8_7.ForeColor = color;
                }
                if (spot == 8)
                {
                    textBox8_8.Text = ansStr;
                    textBox8_8.ForeColor = color;
                }
            }

        }

        private void importTxt_Click(object sender, EventArgs e)
        {
            string fileName = "";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                label1.Text = fileName;
            }
            if(!fileName.EndsWith(".txt"))
            {
                MessageBox.Show("エラーが発生しました。\ntxtファイルではないファイルがインポートされました。\n"
                             + "\n該当箇所: " + fileName, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string filePath = fileName;
            string[] txtArray = File.ReadAllLines(filePath);
            int formatError = 0;
            if(txtArray.Length != 9) //9行じゃない場合
            {
                formatError = 10;
            }
            string[] numStr_1 = txtArray[0].Split(',');
            if (numStr_1.Length != 9)
                formatError = 1;
            string[] numStr_2 = txtArray[1].Split(',');
            if (numStr_2.Length != 9)
                formatError = 2;
            string[] numStr_3 = txtArray[2].Split(',');
            if (numStr_3.Length != 9)
                formatError = 3;
            string[] numStr_4 = txtArray[3].Split(',');
            if (numStr_4.Length != 9)
                formatError = 4;
            string[] numStr_5 = txtArray[4].Split(',');
            if (numStr_5.Length != 9)
                formatError = 5;
            string[] numStr_6 = txtArray[5].Split(',');
            if (numStr_6.Length != 9)
                formatError = 6;
            string[] numStr_7 = txtArray[6].Split(',');
            if (numStr_7.Length != 9)
                formatError = 7;
            string[] numStr_8 = txtArray[7].Split(',');
            if (numStr_8.Length != 9)
                formatError = 8;
            string[] numStr_9 = txtArray[8].Split(',');
            if (numStr_9.Length != 9)
                formatError = 9;
            if(formatError != 0 && formatError != 10)
            {
                MessageBox.Show("エラーが発生しました。\ntxtファイルの記述方法に誤りがあります。\n"
                             + "\n該当箇所: " + fileName + "\n" + formatError + "行目", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(formatError == 10)
            {
                MessageBox.Show("エラーが発生しました。\ntxtファイルの記述方法に誤りがあります。\n"
                             + "\n該当箇所: " + fileName + "\n" + "行数が9行ではありません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox0_0.Text = numStr_1[0].Trim();
            textBox0_1.Text = numStr_1[1].Trim();
            textBox0_2.Text = numStr_1[2].Trim();
            textBox0_3.Text = numStr_1[3].Trim();
            textBox0_4.Text = numStr_1[4].Trim();
            textBox0_5.Text = numStr_1[5].Trim();
            textBox0_6.Text = numStr_1[6].Trim();
            textBox0_7.Text = numStr_1[7].Trim();
            textBox0_8.Text = numStr_1[8].Trim();
            textBox1_0.Text = numStr_2[0].Trim();
            textBox1_1.Text = numStr_2[1].Trim();
            textBox1_2.Text = numStr_2[2].Trim();
            textBox1_3.Text = numStr_2[3].Trim();
            textBox1_4.Text = numStr_2[4].Trim();
            textBox1_5.Text = numStr_2[5].Trim();
            textBox1_6.Text = numStr_2[6].Trim();
            textBox1_7.Text = numStr_2[7].Trim();
            textBox1_8.Text = numStr_2[8].Trim();
            textBox2_0.Text = numStr_3[0].Trim();
            textBox2_1.Text = numStr_3[1].Trim();
            textBox2_2.Text = numStr_3[2].Trim();
            textBox2_3.Text = numStr_3[3].Trim();
            textBox2_4.Text = numStr_3[4].Trim();
            textBox2_5.Text = numStr_3[5].Trim();
            textBox2_6.Text = numStr_3[6].Trim();
            textBox2_7.Text = numStr_3[7].Trim();
            textBox2_8.Text = numStr_3[8].Trim();
            textBox3_0.Text = numStr_4[0].Trim();
            textBox3_1.Text = numStr_4[1].Trim();
            textBox3_2.Text = numStr_4[2].Trim();
            textBox3_3.Text = numStr_4[3].Trim();
            textBox3_4.Text = numStr_4[4].Trim();
            textBox3_5.Text = numStr_4[5].Trim();
            textBox3_6.Text = numStr_4[6].Trim();
            textBox3_7.Text = numStr_4[7].Trim();
            textBox3_8.Text = numStr_4[8].Trim();
            textBox4_0.Text = numStr_5[0].Trim();
            textBox4_1.Text = numStr_5[1].Trim();
            textBox4_2.Text = numStr_5[2].Trim();
            textBox4_3.Text = numStr_5[3].Trim();
            textBox4_4.Text = numStr_5[4].Trim();
            textBox4_5.Text = numStr_5[5].Trim();
            textBox4_6.Text = numStr_5[6].Trim();
            textBox4_7.Text = numStr_5[7].Trim();
            textBox4_8.Text = numStr_5[8].Trim();
            textBox5_0.Text = numStr_6[0].Trim();
            textBox5_1.Text = numStr_6[1].Trim();
            textBox5_2.Text = numStr_6[2].Trim();
            textBox5_3.Text = numStr_6[3].Trim();
            textBox5_4.Text = numStr_6[4].Trim();
            textBox5_5.Text = numStr_6[5].Trim();
            textBox5_6.Text = numStr_6[6].Trim();
            textBox5_7.Text = numStr_6[7].Trim();
            textBox5_8.Text = numStr_6[8].Trim();
            textBox6_0.Text = numStr_7[0].Trim();
            textBox6_1.Text = numStr_7[1].Trim();
            textBox6_2.Text = numStr_7[2].Trim();
            textBox6_3.Text = numStr_7[3].Trim();
            textBox6_4.Text = numStr_7[4].Trim();
            textBox6_5.Text = numStr_7[5].Trim();
            textBox6_6.Text = numStr_7[6].Trim();
            textBox6_7.Text = numStr_7[7].Trim();
            textBox6_8.Text = numStr_7[8].Trim();
            textBox7_0.Text = numStr_8[0].Trim();
            textBox7_1.Text = numStr_8[1].Trim();
            textBox7_2.Text = numStr_8[2].Trim();
            textBox7_3.Text = numStr_8[3].Trim();
            textBox7_4.Text = numStr_8[4].Trim();
            textBox7_5.Text = numStr_8[5].Trim();
            textBox7_6.Text = numStr_8[6].Trim();
            textBox7_7.Text = numStr_8[7].Trim();
            textBox7_8.Text = numStr_8[8].Trim();
            textBox8_0.Text = numStr_9[0].Trim();
            textBox8_1.Text = numStr_9[1].Trim();
            textBox8_2.Text = numStr_9[2].Trim();
            textBox8_3.Text = numStr_9[3].Trim();
            textBox8_4.Text = numStr_9[4].Trim();
            textBox8_5.Text = numStr_9[5].Trim();
            textBox8_6.Text = numStr_9[6].Trim();
            textBox8_7.Text = numStr_9[7].Trim();
            textBox8_8.Text = numStr_9[8].Trim();
        }

        public void resetColor()
        {
            Color color = Color.Black;
            textBox0_0.ForeColor = color;
            textBox0_1.ForeColor = color;
            textBox0_2.ForeColor = color;
            textBox0_3.ForeColor = color;
            textBox0_4.ForeColor = color;
            textBox0_5.ForeColor = color;
            textBox0_6.ForeColor = color;
            textBox0_7.ForeColor = color;
            textBox0_8.ForeColor = color;
            textBox1_0.ForeColor = color;
            textBox1_1.ForeColor = color;
            textBox1_2.ForeColor = color;
            textBox1_3.ForeColor = color;
            textBox1_4.ForeColor = color;
            textBox1_5.ForeColor = color;
            textBox1_6.ForeColor = color;
            textBox1_7.ForeColor = color;
            textBox1_8.ForeColor = color;
            textBox2_0.ForeColor = color;
            textBox2_1.ForeColor = color;
            textBox2_2.ForeColor = color;
            textBox2_3.ForeColor = color;
            textBox2_4.ForeColor = color;
            textBox2_5.ForeColor = color;
            textBox2_6.ForeColor = color;
            textBox2_7.ForeColor = color;
            textBox2_8.ForeColor = color;
            textBox3_0.ForeColor = color;
            textBox3_1.ForeColor = color;
            textBox3_2.ForeColor = color;
            textBox3_3.ForeColor = color;
            textBox3_4.ForeColor = color;
            textBox3_5.ForeColor = color;
            textBox3_6.ForeColor = color;
            textBox3_7.ForeColor = color;
            textBox3_8.ForeColor = color;
            textBox4_0.ForeColor = color;
            textBox4_1.ForeColor = color;
            textBox4_2.ForeColor = color;
            textBox4_3.ForeColor = color;
            textBox4_4.ForeColor = color;
            textBox4_5.ForeColor = color;
            textBox4_6.ForeColor = color;
            textBox4_7.ForeColor = color;
            textBox4_8.ForeColor = color;
            textBox5_0.ForeColor = color;
            textBox5_1.ForeColor = color;
            textBox5_2.ForeColor = color;
            textBox5_3.ForeColor = color;
            textBox5_4.ForeColor = color;
            textBox5_5.ForeColor = color;
            textBox5_6.ForeColor = color;
            textBox5_7.ForeColor = color;
            textBox5_8.ForeColor = color;
            textBox6_0.ForeColor = color;
            textBox6_1.ForeColor = color;
            textBox6_2.ForeColor = color;
            textBox6_3.ForeColor = color;
            textBox6_4.ForeColor = color;
            textBox6_5.ForeColor = color;
            textBox6_6.ForeColor = color;
            textBox6_7.ForeColor = color;
            textBox6_8.ForeColor = color;
            textBox7_0.ForeColor = color;
            textBox7_1.ForeColor = color;
            textBox7_2.ForeColor = color;
            textBox7_3.ForeColor = color;
            textBox7_4.ForeColor = color;
            textBox7_5.ForeColor = color;
            textBox7_6.ForeColor = color;
            textBox7_7.ForeColor = color;
            textBox7_8.ForeColor = color;
            textBox8_0.ForeColor = color;
            textBox8_1.ForeColor = color;
            textBox8_2.ForeColor = color;
            textBox8_3.ForeColor = color;
            textBox8_4.ForeColor = color;
            textBox8_5.ForeColor = color;
            textBox8_6.ForeColor = color;
            textBox8_7.ForeColor = color;
            textBox8_8.ForeColor = color;
        }
    }
}
