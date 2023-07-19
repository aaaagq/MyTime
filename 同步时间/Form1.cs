using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 同步时间
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("en-US");
            string format = "r";

            textBox1.Text = MyTime.GetNetDateTime();//获取网络时间
            DateTime datetime = DateTime.ParseExact(textBox1.Text, format, cultureInfo); // 将字符串转换成日期
            MyTime.setSystemTime(datetime.AddHours(8));//+8写入windows系统
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string key = ((Button)sender).Text;
            int h = int.Parse(key.Split('小')[0]);
            MyTime.setSystemTime(DateTime.Now.AddHours(h));

        }
    }
}
