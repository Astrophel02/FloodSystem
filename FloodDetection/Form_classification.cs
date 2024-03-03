using DC_feature_extract_6Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Train_data_getNative;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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

            // openfile.ShowDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
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
        /// 数据保存按钮--数据预处理        ------------------------------------------------------------------------- 后需更改
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

        /// <summary>
        /// 获取训练数据位置（按钮）--地物分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_fc_train_data_folderpath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile_train_data = new OpenFileDialog();
            openfile_train_data.Title = "请选择训练数据";

            // 若利用数据预处理功能，则为其保存位置；否则，初始文件选择位置为桌面
            if (textBox_inputdata_path.Text != "")
            {
                openfile_train_data.InitialDirectory = textBox_inputdata_path.Text;
            }
            else
            {
                openfile_train_data.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }

            // 设置默认文件名
            openfile_train_data.FileName = "";
            // 设置文件过滤类型
            openfile_train_data.Filter = "(*.txt)|*.txt|(*.bin)|*.bin";
            openfile_train_data.FilterIndex = 1;
            // 设置对话框是否记忆之前打开目录
            openfile_train_data.RestoreDirectory = true;
            //设置文件是否可以多选
            openfile_train_data.Multiselect = false;

            if (openfile_train_data.ShowDialog() == DialogResult.OK)
            {
                string fullname = openfile_train_data.FileName;

                // 显示
                textBox_fc_train_data_filepath.Text = fullname;
                // 执行日志
                if (String.IsNullOrEmpty(richTextBox_fc_pre_process_run_record.Text))
                    richTextBox_fc_pre_process_run_record.AppendText(System.DateTime.Now.ToString() + " - - - - 训练数据获取成功");
                else
                    richTextBox_fc_pre_process_run_record.AppendText(Environment.NewLine + System.DateTime.Now.ToString() +
                        " - - - - 训练数据获取成功");
            }

        }

        /// <summary>
        ///  设置 模型保存位置（按钮）--地物分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_fc_svm_model_savepath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            // 对话框描述
            dialog.Description = "请选择训练模型保存位置";
            //是否显示 新建文件夹 按钮，默认为 true
            dialog.ShowNewFolderButton = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // 获取用户选择的文件夹路径
                string selectedPath = dialog.SelectedPath;
                // 显示
                textBox_fc_svm_model_savepath.Text = selectedPath;
                // 执行日志
                if (String.IsNullOrEmpty(richTextBox_fc_pre_process_run_record.Text))
                    richTextBox_fc_pre_process_run_record.AppendText(System.DateTime.Now.ToString() + " - - - - 训练模型保存位置设定成功");
                else
                    richTextBox_fc_pre_process_run_record.AppendText(Environment.NewLine + System.DateTime.Now.ToString() +
                        " - - - - 训练模型保存位置设定成功");
            }
        }

        /// <summary>
        ///  获取 模型保存位置（按钮）--地物分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_svm_predict_model_path_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile_model_save = new OpenFileDialog();
            openfile_model_save.Title = "请选择训练模型";
            // 初始文件选择位置为桌面
            openfile_model_save.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // 设置默认文件名
            openfile_model_save.FileName = "";
            // 设置文件过滤类型
            openfile_model_save.Filter = "(*.joblib)|*.joblib|(*.bin)|*.bin";
            openfile_model_save.FilterIndex = 1;
            // 设置对话框是否记忆之前打开目录
            openfile_model_save.RestoreDirectory = true;
            //设置文件是否可以多选
            openfile_model_save.Multiselect = false;

            // openfile.ShowDialog();
            if (openfile_model_save.ShowDialog() == DialogResult.OK)
            {
                string fullname = openfile_model_save.FileName;
                // 显示
                textBox_svm_predict_model_path.Text = fullname;
                // 执行日志
                if (String.IsNullOrEmpty(richTextBox_fc_pre_process_run_record.Text))
                    richTextBox_fc_pre_process_run_record.AppendText(System.DateTime.Now.ToString() + " - - - - 模型获取成功");
                else
                    richTextBox_fc_pre_process_run_record.AppendText(Environment.NewLine + System.DateTime.Now.ToString() +
                        " - - - - 模型获取成功");
            }
        }

        /// <summary>
        /// 获取 分类结果保存位置（按钮）--地物分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_svm_predict_result_path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            // 对话框描述
            dialog.Description = "请选择分类结果保存位置";
            //是否显示 新建文件夹 按钮，默认为 true
            dialog.ShowNewFolderButton = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // 获取用户选择的文件夹路径
                string selectedPath = dialog.SelectedPath;
                // 显示
                textBox_svm_predict_result_path.Text = selectedPath;
                // 执行日志
                if (String.IsNullOrEmpty(richTextBox_fc_pre_process_run_record.Text))
                    richTextBox_fc_pre_process_run_record.AppendText(System.DateTime.Now.ToString() + " - - - - 分类结果保存位置设定成功");
                else
                    richTextBox_fc_pre_process_run_record.AppendText(Environment.NewLine + System.DateTime.Now.ToString() +
                        " - - - - 分类结果保存位置设定成功");
            }
        }

        /// <summary>
        ///  选择默认参数进行训练
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_model_info_default_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton_model_info_default.Checked == true)
            {
                // 清空下拉框内容
                comboBox_svm_kernel.Items.Clear();
                comboBox_svm_decision_function_shape.Items.Clear();
                comboBox_svm_class_weight.Items.Clear();

                // 设置SVM训练默认参数
                textBox_svm_train_radio.Text = Convert.ToString(0.7);               // 训练集占比70%
                textBox_svm_C.Text = Convert.ToString(100);                         // 惩罚系数
                textBox_svm_gamma.Text = Convert.ToString(0.9);                     // 核函数参数      如果gamma是'auto'，那么将使用1 / n_features
                // kernel（核函数）
                comboBox_svm_kernel.Items.Add("rbf");         // 径向基函数
                comboBox_svm_kernel.Items.Add("linear");      // 线性核函数
                /*
                comboBox_svm_kernel.Items.Add("多项式核函数");    // poly
                comboBox_svm_kernel.Items.Add("sigmoid函数");     // sigmoid
                comboBox_svm_kernel.Items.Add("核函数矩阵");      // precomputed 
                */
                // decision_function_shape（因变量的形式）
                comboBox_svm_decision_function_shape.Items.Add("ovr");      // 为one v rest（一对多），即一个类别与其他类别进行划分
                comboBox_svm_decision_function_shape.Items.Add("ovo");      // 为one v one（一对一），即将类别两两之间进行划分，用二分类的方法模拟多分类的结果
                // class_weight (调整类别的权重)
                comboBox_svm_class_weight.Items.Add("balanced");      // 自动根据样本数来调整类别权重
                // 设置默认项
                comboBox_svm_class_weight.SelectedIndex = 0;
                comboBox_svm_decision_function_shape.SelectedIndex = 0;
                comboBox_svm_kernel.SelectedIndex = 0;

                // 设置参数输入框为不可编辑
                textBox_svm_C.ReadOnly = true;
                textBox_svm_gamma.ReadOnly = true;
                textBox_svm_train_radio.ReadOnly = true;
                
                comboBox_svm_class_weight.DropDownStyle= ComboBoxStyle.DropDownList;
                comboBox_svm_decision_function_shape.DropDownStyle= ComboBoxStyle.DropDownList;
                comboBox_svm_kernel.DropDownStyle= ComboBoxStyle.DropDownList;
            }
        }

        /// <summary>
        /// 自定义训练参数 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_model_info_self_set_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_model_info_self_set.Checked == true)
            {
                // 清空下拉框内容
                comboBox_svm_kernel.Items.Clear();
                comboBox_svm_decision_function_shape.Items.Clear();
                comboBox_svm_class_weight.Items.Clear();

                // 将参数输入栏清空
                textBox_svm_train_radio.Text = null;               // 训练集占比
                textBox_svm_C.Text = null;                         // 惩罚系数
                textBox_svm_gamma.Text = null;                     // 核函数参数      如果gamma是'auto'，那么将使用1 / n_features
                comboBox_svm_class_weight.Text = null;
                comboBox_svm_decision_function_shape.Text = null;
                comboBox_svm_kernel.Text = null;

                // kernel（核函数）
                comboBox_svm_kernel.Items.Add("rbf");         // 径向基函数
                comboBox_svm_kernel.Items.Add("linear");      // 线性核函数
                /*
                comboBox_svm_kernel.Items.Add("多项式核函数");    // poly
                comboBox_svm_kernel.Items.Add("sigmoid函数");     // sigmoid
                comboBox_svm_kernel.Items.Add("核函数矩阵");      // precomputed 
                */
                // decision_function_shape（因变量的形式）
                comboBox_svm_decision_function_shape.Items.Add("ovr");      // 为one v rest（一对多），即一个类别与其他类别进行划分
                comboBox_svm_decision_function_shape.Items.Add("ovo");      // 为one v one（一对一），即将类别两两之间进行划分，用二分类的方法模拟多分类的结果
                // class_weight (调整类别的权重)
                comboBox_svm_class_weight.Items.Add("balanced");      // 自动根据样本数来调整类别权重

                // 设置参数输入框为可输入
                textBox_svm_C.ReadOnly = false;
                textBox_svm_gamma.ReadOnly = false;
                textBox_svm_train_radio.ReadOnly = false;

                // 设置下拉框为不可输入
                comboBox_svm_class_weight.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox_svm_decision_function_shape.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox_svm_kernel.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        /// <summary>
        /// 模型训练（按钮）--地物分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_fc_svm_train_Click(object sender, EventArgs e)
        {


        }

       
    }
}
