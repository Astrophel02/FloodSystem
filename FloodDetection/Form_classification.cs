using DC_feature_extract_6Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Train_data_getNative;

namespace FloodDetection
{
    public partial class Form_classification : Form
    {
        public Form_classification()
        {
            InitializeComponent();
        }


        public static class data
        {
            public static double[,] feature = null;
            public static double[,] SVM_train_data = null;
        }

        /// <summary>
        /// 获取按钮---C矩阵文件夹路径获取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_inputdata_path_get_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            // 对话框描述
            dialog.Description = "请选择极化协方差矩阵（C）所在文件夹";
            //是否显示 新建文件夹 按钮，默认为 true
            dialog.ShowNewFolderButton = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // 获取用户选择的文件夹路径
                string selectedPath = dialog.SelectedPath;
                // 显示
                textBox_inputdata_path.Text = selectedPath;
                //执行日志
                if (String.IsNullOrEmpty(richTextBox_fc_pre_process_run_record.Text))
                    richTextBox_fc_pre_process_run_record.AppendText(System.DateTime.Now.ToString() + " - - - - C矩阵所在文件夹路径获取成功");
                else
                    richTextBox_fc_pre_process_run_record.AppendText(Environment.NewLine + System.DateTime.Now.ToString() +
                        " - - - - C矩阵所在文件夹路径获取成功");
            }
        }

        /// <summary>
        /// 获取按钮---样本数据文件夹路径获取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_fc_sample_path_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "请选择样本文件";
            // 初始文件选择位置为桌面
            openfile.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // 设置默认文件名
            openfile.FileName = "";
            // 设置文件过滤类型
            openfile.Filter = "(*.bin)|*.bin";
            openfile.FilterIndex = 1;
            // 设置对话框是否记忆之前打开目录
            openfile.RestoreDirectory = true;
            //设置文件是否可以多选
            openfile.Multiselect = false;

            openfile.ShowDialog();
            string fullname = openfile.FileName;

            // 显示
            textBox_fc_sample_path.Text = fullname;
            // 执行日志
            if (String.IsNullOrEmpty(richTextBox_fc_pre_process_run_record.Text))
                richTextBox_fc_pre_process_run_record.AppendText(System.DateTime.Now.ToString() + " - - - - 样本文件路径获取成功");
            else
                richTextBox_fc_pre_process_run_record.AppendText(Environment.NewLine + System.DateTime.Now.ToString() +
                    " - - - - 样本文件路径获取成功");
        }

        /// <summary>
        /// 清除按钮---影像大小数据清除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_fc_image_size_clear_Click(object sender, EventArgs e)
        {
            textBox_fc_image_size_row.Text = string.Empty;
            textBox_fc_image_size_column.Text = string.Empty;
        }

        /// <summary>
        /// 数据生成按钮--数据预处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button_fc_pre_data_get_Click(object sender, EventArgs e)
        {
            if (textBox_inputdata_path.Text != "" && textBox_fc_sample_path.Text != "" &&
                textBox_fc_image_size_row.Text != "" && textBox_fc_image_size_column.Text != "") // 判断Textbox是否正确填充，正确则进入执行阶段
            {
                richTextBox_fc_pre_process_run_record.AppendText(Environment.NewLine + System.DateTime.Now.ToString() +
                       " - - - - 地物分类训练数据正在生成，请稍后···");

                FarmClassification FC = new FarmClassification();
                FC_svm_train_data Svm_Train_Data = new FC_svm_train_data();

                // 获取输入值
                string row_input = textBox_fc_image_size_row.Text;
                string col_input = textBox_fc_image_size_column.Text;
                // 确保输入类型正确
                try
                {
                    Convert.ToInt32(row_input);
                    Convert.ToInt32(col_input);
                }
                catch
                {
                    MessageBox.Show("输入类型错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    richTextBox_fc_pre_process_run_record.AppendText(Environment.NewLine + System.DateTime.Now.ToString() +
                           " - - - - 发生错误：影像行列信息输入类型错误");
                    //---------------  ---------------------------------------------------------------------------------------------

                    System.Environment.Exit(0);   // --------------
                }
                int row = Convert.ToInt32(row_input);
                int column = Convert.ToInt32(col_input);
                string folderpath_C = textBox_inputdata_path.Text;
                string filepath_sample = textBox_fc_sample_path.Text;
                // 特征提取
                object resultObj_feature = await Task.Run(() =>
                {
                    return FC.DC_feature_extract_6(1, folderpath_C, row, column);
                });
                object[] resultObjs_feature = (object[])resultObj_feature;
                data.feature = (double[,])resultObjs_feature[0];

                richTextBox_fc_pre_process_run_record.AppendText(Environment.NewLine + System.DateTime.Now.ToString() +
                           " - - - - 特征提取已完成");

                // 训练数据生成（合并特征与样本，剔除未标记项）
                object resultObj_dataget = await Task.Run(() =>
                {
                    return Svm_Train_Data.Train_data_get(1, filepath_sample, folderpath_C, row, column, data.feature);
                });
                object[] resultObjs_dataget = (object[])resultObj_dataget;
                data.SVM_train_data = (double[,])resultObjs_dataget[0];

                // 执行日志
                richTextBox_fc_pre_process_run_record.AppendText(Environment.NewLine + System.DateTime.Now.ToString() +
                           " - - - - 训练数据已生成（文件保存路径与C矩阵文件路径相同）");

            }
            else // 错误则在执行日志上输出提示，并弹窗提示
            {
                if (String.IsNullOrEmpty(richTextBox_fc_pre_process_run_record.Text))
                    richTextBox_fc_pre_process_run_record.AppendText(System.DateTime.Now.ToString() + " - - - - 发生错误：缺少必要参数");
                else
                    richTextBox_fc_pre_process_run_record.AppendText(Environment.NewLine + System.DateTime.Now.ToString() +
                        " - - - - 发生错误：缺少必要参数");
                MessageBox.Show("请填写必要参数", "错误提示");
            }
        }

        /// <summary>
        /// 获取按钮---影像大小获取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_fc_image_size_get_Click(object sender, EventArgs e)
        {
            MessageBox.Show("敬请期待···");
        }

        /// <summary>
        /// 数据保存按钮--数据预处理        -------------------- 后需更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_fc_pre_data_notice_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "模型输入数据保存";
            // 初始文件选择位置为桌面
            savefile.InitialDirectory = textBox_inputdata_path.Text;
            // 设置默认文件名
            savefile.FileName = "SVM_输入数据";
            // 设置文件过滤类型
            savefile.Filter = "(*.txt)|*.txt|(*.dat)|*.dat";
            savefile.FilterIndex = 1;
            // 设置对话框是否记忆之前打开目录
            savefile.RestoreDirectory = true;
            /*
            if (savefile.ShowDialog() == DialogResult.OK)

            {
                try
                {
                    System.IO.File.WriteAllText(savefile.FileName, richTextBox_fc_SVM_inputdata_show.Text);
                    MessageBox.Show("导出成功！");
                    // 执行日志内显示
                    richTextBox_fc_pre_process_run_record.AppendText(Environment.NewLine + System.DateTime.Now.ToString() +
                        " - - - - 模型输入数据保存成功");
                }
                catch
                {
                    MessageBox.Show("导出失败！");
                    // 执行日志内显示
                    richTextBox_fc_pre_process_run_record.AppendText(Environment.NewLine + System.DateTime.Now.ToString() +
                        " - - - - 模型输入数据保存失败");
                }

            }             */
        }
    }
}
