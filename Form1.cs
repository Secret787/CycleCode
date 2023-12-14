using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace CycleCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            String s = Environment.NewLine;
            tbx_coder_out.Clear();
            tbx_decoder_in.Clear();
            tbx_decoder_out.Clear();
            tbx_info.Clear();
            tbx_errors.Text = "errors bits:";

            string Xor(string a, string b)               // хорошо
            {
                string result = "";
                for (int i = 1; i < b.Length; i++)
                {
                    if (a[i] == b[i])
                        result += "0";
                    else
                        result += "1";
                }
                return result;
            }
            //010000010110010011100000

            string MainFunc(string d1, string d2)
            {
                for (int i = 0; i < (d1.Length - d2.Length + 1); i++)
                    if (d1[i] == '1')
                    {
                        string tmp = d1.Substring(0, i);
                        for (int j = 0; j < d2.Length; j++)
                        {
                            if (d2[j] == d1[i + j]) { tmp += "0"; }
                            else tmp += "1";
                        }
                        tmp += d1.Substring(i + d2.Length);
                        d1 = tmp;
                    }
                return d1.Substring((d1.Length - d2.Length + 1));
            }

            string test = MainFunc("1000000000000001", "11101101001");  
            string poly = "1011";
            tbx_info.Text += "Тест " + test + s;
            tbx_info.Text += "Полином " + poly + s;

            int d0 = poly.Count(f => (f == '1'));
            string m = tbx_coder_in.Text;
            string e_m = m + string.Join("", Enumerable.Repeat("0", 24));
            string ost = MainFunc(e_m, poly);
            tbx_info.Text += "Остаток от деления: " + ost + s;
            tbx_coder_out.Text = m + ost;
            string t_m = m + ost;

            var nums = new List<int>();
            for (int i = 0; i < t_m.Length; i++) nums.Add(i);
            Random rnd = new Random();
            int q = 2;
            int err_nums = rnd.Next(3);
            for (int j = 0; j < err_nums; j++)
            {
                int err_bit_no = nums[rnd.Next(0, nums.Count())];
                tbx_errors.Text += s + (t_m.Length - err_bit_no - 1).ToString();
                nums.Remove(err_bit_no);
                if (t_m[err_bit_no] == '0')
                    t_m = t_m.Substring(0, err_bit_no) + "1" + t_m.Substring(err_bit_no + 1);
                else
                    t_m = t_m.Substring(0, err_bit_no) + "0" + t_m.Substring(err_bit_no + 1);
            }
            
            tbx_decoder_in.Text = t_m;
            tbx_info.Text += "Приемник " + s;
            int w;
            int sdvig;
            for (sdvig = 0; sdvig < t_m.Length; sdvig++)
            {
                ost = MainFunc(t_m, poly);
                tbx_info.Text += "Сдвиг " + sdvig.ToString() + s;
                tbx_info.Text += "Остаток " + ost.ToString() + s;
                w = ost.Count(f => (f == '1'));
                tbx_info.Text += "Кол-во едениц " + w.ToString() + s; // кол-во едениц


                if (w <= q) break;
                t_m = t_m.Substring(1) + t_m.Substring(0, 1);
            }

            
            ost = Xor("0" + t_m.Substring(t_m.Length - ost.Length), "0" + ost);
            string r_m = t_m.Substring(0, t_m.Length - ost.Length) + ost;
            tbx_info.Text += "Раскодированное сообщение" + r_m + s;
            if (sdvig > 0)
            {
                string tmp2 = r_m.Substring(0, r_m.Length - sdvig);
                r_m = r_m.Substring(r_m.Length - sdvig) + r_m.Substring(0 ,r_m.Length - sdvig);
                tbx_info.Text += "Сдвигаем обратно на " + sdvig.ToString() + s;
            }

            r_m = r_m.Substring(0, m.Length);
            tbx_decoder_out.Text = r_m;

            if (r_m == m) tbx_info.Text += "SUCCESSFULLY" + s;
            else tbx_info.Text += "ERROR";


        }

    
    }
}
