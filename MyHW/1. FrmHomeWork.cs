 
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmHomeWork : Form
    {
        int n1, n2, n3;
        public FrmHomeWork()
        {
            InitializeComponent();
            textBox1.KeyPress += txtInputCheck;
            textBox2.KeyPress += txtInputCheck;
            textBox3.KeyPress += txtInputCheck;
            textBox4.KeyPress += txtInputCheck;
        }


        private void txtInputCheck(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9') &&
              !(txt.Name == "textBox4" && (txt.Text == "" || txt.SelectionLength==txt.Text.Length) && e.KeyChar == '-'))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 100;
            int b = 66;
            int c = 77;

            int result = a;
            if (result < b) result = b;
            if (result < c) result = c;
            lblResult.Text = String.Format("{0}、{1}、{2}三個數的最大值為 {3}", a, b, c, result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] nums = { 33, 4, 5, 11, 222, 34 };

            int even = 0, odd = 0;
            StringBuilder sb = new StringBuilder();
            foreach (int n in nums)
            {
                sb.Append(n + ",");
                if (n % 2 == 0)
                    even++;
                else
                    odd++;
            }
            sb.Remove(sb.Length - 1, 1);
            lblResult.Text = String.Format("陣列 {0} 之中，\r\n奇數共 {1} 個，偶數共 {2} 個。",sb, odd, even);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string[] names = { "aaa", "ksdkfjsdk" };

            StringBuilder sb = new StringBuilder();
            int max = names[0].Length;
            sb.Append(names[0] + "、");
            int index = 0;
            
            for (int i = 1; i < names.Length; i++)
            {
                sb.Append(names[i]+"、");
                if (max < names[i].Length)
                {
                    max = names[i].Length;
                    index = i;
                }
            }
            sb.Remove(sb.Length-1, 1);
            lblResult.Text = "陣列 " + sb.ToString() + " 之中的最長名字為 " + names[index];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                lblResult.Text = "尚未輸入";
                return;
            }
            lblResult.Text = int.Parse(textBox4.Text) % 2 == 0 ? "偶數" : "奇數";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] nums = { 2, 3, 46, 33, 22, 100, 150, 33, 55 };

            StringBuilder sb = new StringBuilder();
            int max = int.MinValue;
            int min = int.MaxValue;
            sb.Append("陣列 ");

            foreach (int n in nums)
            {
                sb.Append(n + " , ");
                if(min > n) min = n;
                if(max < n) max = n;
            }
            sb.Remove(sb.Length - 3, 3);
            sb.Append(" 之中\r\n最大值為 " + max + "\r\n最小值為 " + min);

            lblResult.Text = sb.ToString(); 
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblResult.Text = "結果(已清空)";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("九九乘法表\r\n");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    string temp = i * j < 10 ? "  " + i * j : (i * j).ToString();
                    sb.Append("  " + j + "x" + i + "=" + temp + " | ");
                }
                if (i != 9)
                    sb.Append("\r\n");
            }
            lblResult.Text = sb.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int n = 100;

            Stack<int> stack = new Stack<int>();
            StringBuilder sb = new StringBuilder();
            while (n > 0)
            {
                stack.Push(n % 2);
                n /= 2;
            }
            while (stack.Count > 0)
                sb.Append(stack.Pop());
            lblResult.Text = sb.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string[] names = { "aaa", "bbb", "ccc", "Mary", "Tom" };

            StringBuilder sb= new StringBuilder();
            sb.Append("陣列 ");
            int result = 0;
            foreach (string s in names)
            {
                sb.Append(s+ "、");
                foreach (char c in s)
                {
                    if (c == 'C' || c == 'c')
                    {
                        result++;
                        break;
                    }
                }
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append(" 之中\r\n有C or c的名字共有 " + result + " 個");
            lblResult.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] nums = { 2, 3, 46, 33, 22, 100, 150, 33, 55 };

            lblResult.Text = MaxScore(nums).ToString();
        }

        private int MaxScore(int[] arrNum)
        {
            int max = arrNum[0];
            for (int i = 1; i < arrNum.Length; i++)
                if (max < arrNum[i]) 
                    max = arrNum[i];
            return max;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            StringBuilder sb=new StringBuilder();
            Random rd = new Random();
            HashSet<int> set = new HashSet<int>();

            sb.Append("樂透號碼:");
            for (int i = 0; i < 6; i++)
            {
                int temp = rd.Next(1, 49);
                if (set.Add(temp))
                    sb.Append(" " + temp);
                else
                    i--;
            }
            lblResult.Text = sb.ToString();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (isNum())
            {
                int sum = 0;
                int i = n1;
                while (i <= n2)
                {
                    sum += i;
                    i += n3;
                }
                lblResult.Text = String.Format("from:{0} to {1}\r\nstep:{2}\r\nSum={3}", n1, n2, n3, sum);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isNum())
            {
                int sum = 0;
                int i = n1;
                do
                {
                    sum += i;
                    i += n3;
                } while (i <= n2);
                lblResult.Text = String.Format("from:{0} to {1}\r\nstep:{2}\r\nSum={3}", n1, n2, n3, sum);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (isNum())
            {
                int sum = 0;
                for (int i = n1; i <= n2; i += n3)
                    sum += i;
                lblResult.Text = String.Format("from:{0} to {1}\r\nstep:{2}\r\nSum={3}", n1, n2, n3, sum);
            }
        }

        private bool isNum()
        {
            if (int.TryParse(textBox1.Text, out n1))
                if (int.TryParse(textBox2.Text, out n2))
                    if (int.TryParse(textBox3.Text, out n3) && n3!=0)
                        return true;
            if(textBox3.Text=="0")
                MessageBox.Show("Step不可為0");
            else
                MessageBox.Show("請輸入數值");
            return false;
        }

        
    }
}
