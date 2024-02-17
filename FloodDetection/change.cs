using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathWorks.MATLAB.NET.Arrays;
using changeDetectionNative;
using System.Threading;

namespace FloodDetection
{
    public partial class change : Form
    {
        
        // 创建data类，用于全局变量存储
        public static class data
        {
            public static string beforeImage = "";
            public static string afterImage = "";
        }
        public change()
        {
            InitializeComponent();
            // textBox3.ReadOnly = true;
        }

        // 灾前影像读取
        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "请选择影像所在的目录";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                this.before.Text = folderBrowser.SelectedPath; // 文件夹路径显示在Textbox中
                data.beforeImage = folderBrowser.SelectedPath; // 文件夹路径传入data类的beforeImage变量中
                textBox3.Text = textBox3.Text + System.DateTime.Now.ToString("T") + " 灾前影像目录加载成功" + "\r\n";
            }
        }
        // 灾后影像读取
        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser1 = new FolderBrowserDialog();
            folderBrowser1.Description = "请选择影像所在的目录";
            if (folderBrowser1.ShowDialog() == DialogResult.OK)
            {
                this.after.Text = folderBrowser1.SelectedPath;
                data.afterImage = folderBrowser1.SelectedPath;
                textBox3.Text = textBox3.Text + System.DateTime.Now.ToString("T") + " 灾后影像目录加载成功" + "\r\n";
            }
        }
        // 执行变化检测程序
        private async void button1_Click(object sender, EventArgs e)
        {
            
            if (before.Text != "" && after.Text != "" && l.Text != "" && s.Text != "") // 判断Textbox是否正确填充，正确则进入执行阶段
            {
                textBox3.Text = textBox3.Text + System.DateTime.Now.ToString("T") +  " 正在执行变化检测程序...请稍后" + "\r\n";
                ChangeDetection CD = new ChangeDetection();
                int lines; int samples;
                lines = Convert.ToInt32(this.l.Text);
                samples = Convert.ToInt32(this.s.Text);
                object resultObj = await Task.Run(() =>
                {
                    return CD.changeDetection(1, data.beforeImage, data.afterImage, lines, samples);
                });
                // object resultObj = CD.changeDetection(1, data.beforeImage, data.afterImage, lines, samples);
                object[] resultObjs = (object[])resultObj;
                double[,] bw = (double[,])resultObjs[0];
                textBox3.Text = textBox3.Text + System.DateTime.Now.ToString("T") +   "执行成功，请点击保存以储存结果" + "\r\n";
            }
            else // 错误则在执行日志上输出提示，并弹窗提示
            {
                textBox3.Text = textBox3.Text + System.DateTime.Now.ToString("T") +  " 缺少必要参数，请补充" + "\r\n";
                MessageBox.Show("请填写必要参数","错误提示");
            }
        }

        //实现程序退出
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //实现结果保存和展示
        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + System.DateTime.Now.ToString("T") + " 保存成功" + "\r\n";
        }
    }
}
