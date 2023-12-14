using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
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
            tbx_coder_out.Clear();
            tbx_decoder_in.Clear();
            tbx_decoder_out.Clear();
            tbx_info.Clear();
            tbx_errors.Text = "errors bits:";

            string Xor(string a, string b)
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

            string Mod2Div2(string dividend, string divisor) 
            {
                for (int i = 0; i < (dividend.Length - divisor.Length + 1); i++) 
                    if (dividend[i] == '1')
                    {
                        string tmp = dividend.Substring(0, i);
                        for (int j = 0; j < divisor.Length; j++)
                            if (divisor[j] == dividend[i + j])
                                tmp += "0";
                            else tmp += "1";
                        tmp += dividend.Substring(i + divisor.Length);
                        dividend = tmp;
                    }
                return dividend.Substring((dividend.Length - divisor.Length + 1));
            }

            string test = Mod2Div2("1000000000000001", "11010001");  // не используемая переменная
            string poly = "1110110110010011101110111";
            
            tbx_info.Text += "Полином " + poly + Environment.NewLine;


            

            int d0 = poly.Count(f => (f == '1'));
            


            string message;
            message = tbx_coder_in.Text;
            
            string ext_message = message + string.Join("", Enumerable.Repeat("0", poly.Length - 1));

            
            string rest = Mod2Div2(ext_message, poly);

            tbx_info.Text += "Остаток деления: " + rest + Environment.NewLine;

            string coded_message = message + rest;
            tbx_coder_out.Text = coded_message;

            string transmitted_message = coded_message;

            var nums = new List<int>();
            for (int i = 0; i < transmitted_message.Length; i++) nums.Add(i);
            
            Random rand = new Random();
            int q = 2;
            int err_nums = rand.Next(3);
           
            for (int j = 0; j < err_nums; j++)
            {
                int err_bit_no = nums[rand.Next(0, nums.Count())];
                tbx_errors.Text += Environment.NewLine + (transmitted_message.Length - err_bit_no - 1).ToString();

                nums.Remove(err_bit_no);
                if (transmitted_message[err_bit_no] == '0')
                    transmitted_message = transmitted_message.Substring(0, err_bit_no) + "1" + transmitted_message.Substring(err_bit_no + 1);
                else
                    transmitted_message = transmitted_message.Substring(0, err_bit_no) + "0" + transmitted_message.Substring(err_bit_no + 1);

            }

            tbx_decoder_in.Text = transmitted_message;
            tbx_info.Text += "Приемник " + Environment.NewLine;
            int w;
            int shift_count;
            for (shift_count = 0; shift_count < transmitted_message.Length; shift_count++)
            {
                rest = Mod2Div2(transmitted_message, poly);
                tbx_info.Text += "Сдвиг " + shift_count.ToString() + Environment.NewLine;
                tbx_info.Text += "Остаток " + rest.ToString() + Environment.NewLine;
                w = rest.Count(f => (f == '1'));
                tbx_info.Text += "Мощность остатка " + w.ToString() + Environment.NewLine;

                if (w <= q) break;
                transmitted_message = transmitted_message.Substring(1) + transmitted_message.Substring(0, 1);
            }

            
            rest = Xor("0" + transmitted_message.Substring(transmitted_message.Length - rest.Length), "0" + rest);
            string restored_message = transmitted_message.Substring(0, transmitted_message.Length - rest.Length) + rest;
            tbx_info.Text += "Восстановленное сообщение " + restored_message + Environment.NewLine;
            if (shift_count > 0)
            {
                string tmp2 = restored_message.Substring(0, restored_message.Length - shift_count);
                restored_message = restored_message.Substring(restored_message.Length - shift_count) + restored_message.Substring(0 ,restored_message.Length - shift_count);
                tbx_info.Text += "Сдвигаем обратно на " + shift_count.ToString() + Environment.NewLine;
            }

            restored_message = restored_message.Substring(0, message.Length);
            tbx_decoder_out.Text = restored_message;

            if (restored_message == message) tbx_info.Text += "УСПЕШНО !!!" + Environment.NewLine;
            else tbx_info.Text += "ОШИБКА";


        }
    }
}
