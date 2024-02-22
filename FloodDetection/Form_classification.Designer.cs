namespace FloodDetection
{
    partial class Form_classification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_classification_svm = new System.Windows.Forms.TabControl();
            this.tabPage_fc_data_pre_process = new System.Windows.Forms.TabPage();
            this.groupBox_fc_image_size = new System.Windows.Forms.GroupBox();
            this.button_fc_image_size_clear = new System.Windows.Forms.Button();
            this.label_fc_image_size_column = new System.Windows.Forms.Label();
            this.label_fc_image_size_row = new System.Windows.Forms.Label();
            this.textBox_fc_image_size_column = new System.Windows.Forms.TextBox();
            this.textBox_fc_image_size_row = new System.Windows.Forms.TextBox();
            this.button_fc_image_size_get = new System.Windows.Forms.Button();
            this.button_fc_pre_data_notice = new System.Windows.Forms.Button();
            this.groupBox_fc_pre_process_path = new System.Windows.Forms.GroupBox();
            this.textBox_fc_sample_path = new System.Windows.Forms.TextBox();
            this.textBox_inputdata_path = new System.Windows.Forms.TextBox();
            this.button_inputdata_path_get = new System.Windows.Forms.Button();
            this.button_fc_sample_path = new System.Windows.Forms.Button();
            this.label_fc_input_path = new System.Windows.Forms.Label();
            this.label_fc_sample_path = new System.Windows.Forms.Label();
            this.button_fc_pre_data_get = new System.Windows.Forms.Button();
            this.groupBox_fc_pre_process_show = new System.Windows.Forms.GroupBox();
            this.richTextBox_fc_pre_process_run_record = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_fc_svm_predict = new System.Windows.Forms.Button();
            this.button_fc_svm_train = new System.Windows.Forms.Button();
            this.groupBox_fc_svm_train = new System.Windows.Forms.GroupBox();
            this.splitContainer_fc_svm_train_down = new System.Windows.Forms.SplitContainer();
            this.button_fc_svm_model_savepath = new System.Windows.Forms.Button();
            this.label_fc_train_data_folderpath = new System.Windows.Forms.Label();
            this.textBox_fc_svm_model_savepath = new System.Windows.Forms.TextBox();
            this.textBox_fc_train_data_folderpath = new System.Windows.Forms.TextBox();
            this.button_fc_train_data_folderpath = new System.Windows.Forms.Button();
            this.label_fc_svm_model_savepath = new System.Windows.Forms.Label();
            this.splitContainer_fc_svm_train_up = new System.Windows.Forms.SplitContainer();
            this.groupBox_fc_svm_model_info = new System.Windows.Forms.GroupBox();
            this.splitContainer_svm_model_info = new System.Windows.Forms.SplitContainer();
            this.radioButton_model_info_self_set = new System.Windows.Forms.RadioButton();
            this.radioButton_model_info_default = new System.Windows.Forms.RadioButton();
            this.comboBox_svm_class_weight = new System.Windows.Forms.ComboBox();
            this.label_svm_kernel = new System.Windows.Forms.Label();
            this.label_svm_decision_function_shape = new System.Windows.Forms.Label();
            this.label_svm_class_weight = new System.Windows.Forms.Label();
            this.comboBox_svm_decision_function_shape = new System.Windows.Forms.ComboBox();
            this.textBox_svm_gamma = new System.Windows.Forms.TextBox();
            this.label_svm_train_radio = new System.Windows.Forms.Label();
            this.comboBox_svm_kernel = new System.Windows.Forms.ComboBox();
            this.textBox_svm_C = new System.Windows.Forms.TextBox();
            this.label_svm_C = new System.Windows.Forms.Label();
            this.label_svm_gamma = new System.Windows.Forms.Label();
            this.textBox_svm_train_radio = new System.Windows.Forms.TextBox();
            this.groupBox_fc_feature_select = new System.Windows.Forms.GroupBox();
            this.checkedListBox_fc_feature_select = new System.Windows.Forms.CheckedListBox();
            this.groupBox_fc_svm_predict = new System.Windows.Forms.GroupBox();
            this.button_svm_predict_result_path = new System.Windows.Forms.Button();
            this.label_svm_predict_model_path = new System.Windows.Forms.Label();
            this.textBox_svm_predict_result_path = new System.Windows.Forms.TextBox();
            this.button_svm_predict_model_path = new System.Windows.Forms.Button();
            this.textBox_svm_predict_model_path = new System.Windows.Forms.TextBox();
            this.label_svm_predict_result_path = new System.Windows.Forms.Label();
            this.tabControl_classification_svm.SuspendLayout();
            this.tabPage_fc_data_pre_process.SuspendLayout();
            this.groupBox_fc_image_size.SuspendLayout();
            this.groupBox_fc_pre_process_path.SuspendLayout();
            this.groupBox_fc_pre_process_show.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox_fc_svm_train.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_fc_svm_train_down)).BeginInit();
            this.splitContainer_fc_svm_train_down.Panel1.SuspendLayout();
            this.splitContainer_fc_svm_train_down.Panel2.SuspendLayout();
            this.splitContainer_fc_svm_train_down.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_fc_svm_train_up)).BeginInit();
            this.splitContainer_fc_svm_train_up.Panel1.SuspendLayout();
            this.splitContainer_fc_svm_train_up.Panel2.SuspendLayout();
            this.splitContainer_fc_svm_train_up.SuspendLayout();
            this.groupBox_fc_svm_model_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_svm_model_info)).BeginInit();
            this.splitContainer_svm_model_info.Panel1.SuspendLayout();
            this.splitContainer_svm_model_info.Panel2.SuspendLayout();
            this.splitContainer_svm_model_info.SuspendLayout();
            this.groupBox_fc_feature_select.SuspendLayout();
            this.groupBox_fc_svm_predict.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_classification_svm
            // 
            this.tabControl_classification_svm.Controls.Add(this.tabPage_fc_data_pre_process);
            this.tabControl_classification_svm.Controls.Add(this.tabPage2);
            this.tabControl_classification_svm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_classification_svm.Location = new System.Drawing.Point(0, 0);
            this.tabControl_classification_svm.Name = "tabControl_classification_svm";
            this.tabControl_classification_svm.SelectedIndex = 0;
            this.tabControl_classification_svm.Size = new System.Drawing.Size(840, 514);
            this.tabControl_classification_svm.TabIndex = 1;
            // 
            // tabPage_fc_data_pre_process
            // 
            this.tabPage_fc_data_pre_process.Controls.Add(this.groupBox_fc_image_size);
            this.tabPage_fc_data_pre_process.Controls.Add(this.button_fc_pre_data_notice);
            this.tabPage_fc_data_pre_process.Controls.Add(this.groupBox_fc_pre_process_path);
            this.tabPage_fc_data_pre_process.Controls.Add(this.button_fc_pre_data_get);
            this.tabPage_fc_data_pre_process.Controls.Add(this.groupBox_fc_pre_process_show);
            this.tabPage_fc_data_pre_process.Location = new System.Drawing.Point(4, 25);
            this.tabPage_fc_data_pre_process.Name = "tabPage_fc_data_pre_process";
            this.tabPage_fc_data_pre_process.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_fc_data_pre_process.Size = new System.Drawing.Size(832, 485);
            this.tabPage_fc_data_pre_process.TabIndex = 0;
            this.tabPage_fc_data_pre_process.Text = "数据预处理";
            this.tabPage_fc_data_pre_process.UseVisualStyleBackColor = true;
            // 
            // groupBox_fc_image_size
            // 
            this.groupBox_fc_image_size.Controls.Add(this.button_fc_image_size_clear);
            this.groupBox_fc_image_size.Controls.Add(this.label_fc_image_size_column);
            this.groupBox_fc_image_size.Controls.Add(this.label_fc_image_size_row);
            this.groupBox_fc_image_size.Controls.Add(this.textBox_fc_image_size_column);
            this.groupBox_fc_image_size.Controls.Add(this.textBox_fc_image_size_row);
            this.groupBox_fc_image_size.Controls.Add(this.button_fc_image_size_get);
            this.groupBox_fc_image_size.Location = new System.Drawing.Point(563, 38);
            this.groupBox_fc_image_size.Name = "groupBox_fc_image_size";
            this.groupBox_fc_image_size.Size = new System.Drawing.Size(224, 127);
            this.groupBox_fc_image_size.TabIndex = 12;
            this.groupBox_fc_image_size.TabStop = false;
            this.groupBox_fc_image_size.Text = "影像大小";
            // 
            // button_fc_image_size_clear
            // 
            this.button_fc_image_size_clear.Location = new System.Drawing.Point(123, 87);
            this.button_fc_image_size_clear.Name = "button_fc_image_size_clear";
            this.button_fc_image_size_clear.Size = new System.Drawing.Size(78, 33);
            this.button_fc_image_size_clear.TabIndex = 5;
            this.button_fc_image_size_clear.Text = "清除";
            this.button_fc_image_size_clear.UseVisualStyleBackColor = true;
            this.button_fc_image_size_clear.Click += new System.EventHandler(this.button_fc_image_size_clear_Click);
            // 
            // label_fc_image_size_column
            // 
            this.label_fc_image_size_column.AutoSize = true;
            this.label_fc_image_size_column.Location = new System.Drawing.Point(35, 64);
            this.label_fc_image_size_column.Name = "label_fc_image_size_column";
            this.label_fc_image_size_column.Size = new System.Drawing.Size(22, 15);
            this.label_fc_image_size_column.TabIndex = 4;
            this.label_fc_image_size_column.Text = "列";
            // 
            // label_fc_image_size_row
            // 
            this.label_fc_image_size_row.AutoSize = true;
            this.label_fc_image_size_row.Location = new System.Drawing.Point(35, 33);
            this.label_fc_image_size_row.Name = "label_fc_image_size_row";
            this.label_fc_image_size_row.Size = new System.Drawing.Size(22, 15);
            this.label_fc_image_size_row.TabIndex = 3;
            this.label_fc_image_size_row.Text = "行";
            // 
            // textBox_fc_image_size_column
            // 
            this.textBox_fc_image_size_column.Location = new System.Drawing.Point(76, 56);
            this.textBox_fc_image_size_column.Name = "textBox_fc_image_size_column";
            this.textBox_fc_image_size_column.Size = new System.Drawing.Size(100, 25);
            this.textBox_fc_image_size_column.TabIndex = 2;
            // 
            // textBox_fc_image_size_row
            // 
            this.textBox_fc_image_size_row.Location = new System.Drawing.Point(76, 25);
            this.textBox_fc_image_size_row.Name = "textBox_fc_image_size_row";
            this.textBox_fc_image_size_row.Size = new System.Drawing.Size(100, 25);
            this.textBox_fc_image_size_row.TabIndex = 1;
            // 
            // button_fc_image_size_get
            // 
            this.button_fc_image_size_get.Location = new System.Drawing.Point(22, 87);
            this.button_fc_image_size_get.Name = "button_fc_image_size_get";
            this.button_fc_image_size_get.Size = new System.Drawing.Size(84, 33);
            this.button_fc_image_size_get.TabIndex = 0;
            this.button_fc_image_size_get.Text = "获取";
            this.button_fc_image_size_get.UseVisualStyleBackColor = true;
            this.button_fc_image_size_get.Click += new System.EventHandler(this.button_fc_image_size_get_Click);
            // 
            // button_fc_pre_data_notice
            // 
            this.button_fc_pre_data_notice.Location = new System.Drawing.Point(675, 432);
            this.button_fc_pre_data_notice.Name = "button_fc_pre_data_notice";
            this.button_fc_pre_data_notice.Size = new System.Drawing.Size(109, 34);
            this.button_fc_pre_data_notice.TabIndex = 11;
            this.button_fc_pre_data_notice.Text = "使用说明";
            this.button_fc_pre_data_notice.UseVisualStyleBackColor = true;
            this.button_fc_pre_data_notice.Click += new System.EventHandler(this.button_fc_pre_data_notice_Click);
            // 
            // groupBox_fc_pre_process_path
            // 
            this.groupBox_fc_pre_process_path.Controls.Add(this.textBox_fc_sample_path);
            this.groupBox_fc_pre_process_path.Controls.Add(this.textBox_inputdata_path);
            this.groupBox_fc_pre_process_path.Controls.Add(this.button_inputdata_path_get);
            this.groupBox_fc_pre_process_path.Controls.Add(this.button_fc_sample_path);
            this.groupBox_fc_pre_process_path.Controls.Add(this.label_fc_input_path);
            this.groupBox_fc_pre_process_path.Controls.Add(this.label_fc_sample_path);
            this.groupBox_fc_pre_process_path.Location = new System.Drawing.Point(31, 38);
            this.groupBox_fc_pre_process_path.Name = "groupBox_fc_pre_process_path";
            this.groupBox_fc_pre_process_path.Size = new System.Drawing.Size(513, 127);
            this.groupBox_fc_pre_process_path.TabIndex = 10;
            this.groupBox_fc_pre_process_path.TabStop = false;
            this.groupBox_fc_pre_process_path.Text = "文件路径";
            // 
            // textBox_fc_sample_path
            // 
            this.textBox_fc_sample_path.Location = new System.Drawing.Point(145, 82);
            this.textBox_fc_sample_path.Name = "textBox_fc_sample_path";
            this.textBox_fc_sample_path.ReadOnly = true;
            this.textBox_fc_sample_path.Size = new System.Drawing.Size(245, 25);
            this.textBox_fc_sample_path.TabIndex = 6;
            // 
            // textBox_inputdata_path
            // 
            this.textBox_inputdata_path.Location = new System.Drawing.Point(145, 39);
            this.textBox_inputdata_path.Name = "textBox_inputdata_path";
            this.textBox_inputdata_path.ReadOnly = true;
            this.textBox_inputdata_path.Size = new System.Drawing.Size(245, 25);
            this.textBox_inputdata_path.TabIndex = 0;
            // 
            // button_inputdata_path_get
            // 
            this.button_inputdata_path_get.Location = new System.Drawing.Point(415, 38);
            this.button_inputdata_path_get.Name = "button_inputdata_path_get";
            this.button_inputdata_path_get.Size = new System.Drawing.Size(75, 26);
            this.button_inputdata_path_get.TabIndex = 1;
            this.button_inputdata_path_get.Text = "获取";
            this.button_inputdata_path_get.UseVisualStyleBackColor = true;
            this.button_inputdata_path_get.Click += new System.EventHandler(this.button_inputdata_path_get_Click);
            // 
            // button_fc_sample_path
            // 
            this.button_fc_sample_path.Location = new System.Drawing.Point(415, 81);
            this.button_fc_sample_path.Name = "button_fc_sample_path";
            this.button_fc_sample_path.Size = new System.Drawing.Size(75, 26);
            this.button_fc_sample_path.TabIndex = 7;
            this.button_fc_sample_path.Text = "获取";
            this.button_fc_sample_path.UseVisualStyleBackColor = true;
            this.button_fc_sample_path.Click += new System.EventHandler(this.button_fc_sample_path_Click);
            // 
            // label_fc_input_path
            // 
            this.label_fc_input_path.AutoSize = true;
            this.label_fc_input_path.Location = new System.Drawing.Point(26, 42);
            this.label_fc_input_path.Name = "label_fc_input_path";
            this.label_fc_input_path.Size = new System.Drawing.Size(105, 15);
            this.label_fc_input_path.TabIndex = 2;
            this.label_fc_input_path.Text = "C矩阵存放路径";
            // 
            // label_fc_sample_path
            // 
            this.label_fc_sample_path.AutoSize = true;
            this.label_fc_sample_path.Location = new System.Drawing.Point(28, 85);
            this.label_fc_sample_path.Name = "label_fc_sample_path";
            this.label_fc_sample_path.Size = new System.Drawing.Size(97, 15);
            this.label_fc_sample_path.TabIndex = 5;
            this.label_fc_sample_path.Text = "样本存放路径";
            // 
            // button_fc_pre_data_get
            // 
            this.button_fc_pre_data_get.Location = new System.Drawing.Point(545, 432);
            this.button_fc_pre_data_get.Name = "button_fc_pre_data_get";
            this.button_fc_pre_data_get.Size = new System.Drawing.Size(110, 34);
            this.button_fc_pre_data_get.TabIndex = 9;
            this.button_fc_pre_data_get.Text = "数据生成";
            this.button_fc_pre_data_get.UseVisualStyleBackColor = true;
            this.button_fc_pre_data_get.Click += new System.EventHandler(this.button_fc_pre_data_get_Click);
            // 
            // groupBox_fc_pre_process_show
            // 
            this.groupBox_fc_pre_process_show.Controls.Add(this.richTextBox_fc_pre_process_run_record);
            this.groupBox_fc_pre_process_show.Location = new System.Drawing.Point(31, 175);
            this.groupBox_fc_pre_process_show.Name = "groupBox_fc_pre_process_show";
            this.groupBox_fc_pre_process_show.Size = new System.Drawing.Size(756, 241);
            this.groupBox_fc_pre_process_show.TabIndex = 3;
            this.groupBox_fc_pre_process_show.TabStop = false;
            this.groupBox_fc_pre_process_show.Text = "执行日志";
            // 
            // richTextBox_fc_pre_process_run_record
            // 
            this.richTextBox_fc_pre_process_run_record.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_fc_pre_process_run_record.Location = new System.Drawing.Point(3, 21);
            this.richTextBox_fc_pre_process_run_record.Name = "richTextBox_fc_pre_process_run_record";
            this.richTextBox_fc_pre_process_run_record.ReadOnly = true;
            this.richTextBox_fc_pre_process_run_record.Size = new System.Drawing.Size(750, 217);
            this.richTextBox_fc_pre_process_run_record.TabIndex = 1;
            this.richTextBox_fc_pre_process_run_record.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_fc_svm_predict);
            this.tabPage2.Controls.Add(this.button_fc_svm_train);
            this.tabPage2.Controls.Add(this.groupBox_fc_svm_train);
            this.tabPage2.Controls.Add(this.groupBox_fc_svm_predict);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(832, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "地物分类";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_fc_svm_predict
            // 
            this.button_fc_svm_predict.Location = new System.Drawing.Point(691, 447);
            this.button_fc_svm_predict.Name = "button_fc_svm_predict";
            this.button_fc_svm_predict.Size = new System.Drawing.Size(94, 27);
            this.button_fc_svm_predict.TabIndex = 1;
            this.button_fc_svm_predict.Text = "模型分类";
            this.button_fc_svm_predict.UseVisualStyleBackColor = true;
            // 
            // button_fc_svm_train
            // 
            this.button_fc_svm_train.Location = new System.Drawing.Point(569, 447);
            this.button_fc_svm_train.Name = "button_fc_svm_train";
            this.button_fc_svm_train.Size = new System.Drawing.Size(94, 27);
            this.button_fc_svm_train.TabIndex = 0;
            this.button_fc_svm_train.Text = "模型训练";
            this.button_fc_svm_train.UseVisualStyleBackColor = true;
            // 
            // groupBox_fc_svm_train
            // 
            this.groupBox_fc_svm_train.Controls.Add(this.splitContainer_fc_svm_train_down);
            this.groupBox_fc_svm_train.Location = new System.Drawing.Point(32, 18);
            this.groupBox_fc_svm_train.Name = "groupBox_fc_svm_train";
            this.groupBox_fc_svm_train.Size = new System.Drawing.Size(757, 292);
            this.groupBox_fc_svm_train.TabIndex = 10;
            this.groupBox_fc_svm_train.TabStop = false;
            this.groupBox_fc_svm_train.Text = "模型训练";
            // 
            // splitContainer_fc_svm_train_down
            // 
            this.splitContainer_fc_svm_train_down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_fc_svm_train_down.Location = new System.Drawing.Point(3, 21);
            this.splitContainer_fc_svm_train_down.Name = "splitContainer_fc_svm_train_down";
            this.splitContainer_fc_svm_train_down.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_fc_svm_train_down.Panel1
            // 
            this.splitContainer_fc_svm_train_down.Panel1.Controls.Add(this.button_fc_svm_model_savepath);
            this.splitContainer_fc_svm_train_down.Panel1.Controls.Add(this.label_fc_train_data_folderpath);
            this.splitContainer_fc_svm_train_down.Panel1.Controls.Add(this.textBox_fc_svm_model_savepath);
            this.splitContainer_fc_svm_train_down.Panel1.Controls.Add(this.textBox_fc_train_data_folderpath);
            this.splitContainer_fc_svm_train_down.Panel1.Controls.Add(this.button_fc_train_data_folderpath);
            this.splitContainer_fc_svm_train_down.Panel1.Controls.Add(this.label_fc_svm_model_savepath);
            // 
            // splitContainer_fc_svm_train_down.Panel2
            // 
            this.splitContainer_fc_svm_train_down.Panel2.Controls.Add(this.splitContainer_fc_svm_train_up);
            this.splitContainer_fc_svm_train_down.Size = new System.Drawing.Size(751, 268);
            this.splitContainer_fc_svm_train_down.SplitterDistance = 72;
            this.splitContainer_fc_svm_train_down.TabIndex = 6;
            // 
            // button_fc_svm_model_savepath
            // 
            this.button_fc_svm_model_savepath.Location = new System.Drawing.Point(554, 56);
            this.button_fc_svm_model_savepath.Name = "button_fc_svm_model_savepath";
            this.button_fc_svm_model_savepath.Size = new System.Drawing.Size(82, 25);
            this.button_fc_svm_model_savepath.TabIndex = 5;
            this.button_fc_svm_model_savepath.Text = "获取";
            this.button_fc_svm_model_savepath.UseVisualStyleBackColor = true;
            // 
            // label_fc_train_data_folderpath
            // 
            this.label_fc_train_data_folderpath.AutoSize = true;
            this.label_fc_train_data_folderpath.Location = new System.Drawing.Point(133, 25);
            this.label_fc_train_data_folderpath.Name = "label_fc_train_data_folderpath";
            this.label_fc_train_data_folderpath.Size = new System.Drawing.Size(97, 15);
            this.label_fc_train_data_folderpath.TabIndex = 0;
            this.label_fc_train_data_folderpath.Text = "训练数据位置";
            // 
            // textBox_fc_svm_model_savepath
            // 
            this.textBox_fc_svm_model_savepath.Location = new System.Drawing.Point(236, 56);
            this.textBox_fc_svm_model_savepath.Name = "textBox_fc_svm_model_savepath";
            this.textBox_fc_svm_model_savepath.Size = new System.Drawing.Size(295, 25);
            this.textBox_fc_svm_model_savepath.TabIndex = 3;
            // 
            // textBox_fc_train_data_folderpath
            // 
            this.textBox_fc_train_data_folderpath.Location = new System.Drawing.Point(236, 20);
            this.textBox_fc_train_data_folderpath.Name = "textBox_fc_train_data_folderpath";
            this.textBox_fc_train_data_folderpath.Size = new System.Drawing.Size(295, 25);
            this.textBox_fc_train_data_folderpath.TabIndex = 2;
            // 
            // button_fc_train_data_folderpath
            // 
            this.button_fc_train_data_folderpath.Location = new System.Drawing.Point(554, 20);
            this.button_fc_train_data_folderpath.Name = "button_fc_train_data_folderpath";
            this.button_fc_train_data_folderpath.Size = new System.Drawing.Size(82, 25);
            this.button_fc_train_data_folderpath.TabIndex = 4;
            this.button_fc_train_data_folderpath.Text = "获取";
            this.button_fc_train_data_folderpath.UseVisualStyleBackColor = true;
            // 
            // label_fc_svm_model_savepath
            // 
            this.label_fc_svm_model_savepath.AutoSize = true;
            this.label_fc_svm_model_savepath.Location = new System.Drawing.Point(134, 61);
            this.label_fc_svm_model_savepath.Name = "label_fc_svm_model_savepath";
            this.label_fc_svm_model_savepath.Size = new System.Drawing.Size(97, 15);
            this.label_fc_svm_model_savepath.TabIndex = 1;
            this.label_fc_svm_model_savepath.Text = "模型保存位置";
            // 
            // splitContainer_fc_svm_train_up
            // 
            this.splitContainer_fc_svm_train_up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_fc_svm_train_up.IsSplitterFixed = true;
            this.splitContainer_fc_svm_train_up.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_fc_svm_train_up.Name = "splitContainer_fc_svm_train_up";
            // 
            // splitContainer_fc_svm_train_up.Panel1
            // 
            this.splitContainer_fc_svm_train_up.Panel1.Controls.Add(this.groupBox_fc_svm_model_info);
            // 
            // splitContainer_fc_svm_train_up.Panel2
            // 
            this.splitContainer_fc_svm_train_up.Panel2.Controls.Add(this.groupBox_fc_feature_select);
            this.splitContainer_fc_svm_train_up.Panel2MinSize = 125;
            this.splitContainer_fc_svm_train_up.Size = new System.Drawing.Size(751, 192);
            this.splitContainer_fc_svm_train_up.SplitterDistance = 547;
            this.splitContainer_fc_svm_train_up.TabIndex = 0;
            // 
            // groupBox_fc_svm_model_info
            // 
            this.groupBox_fc_svm_model_info.Controls.Add(this.splitContainer_svm_model_info);
            this.groupBox_fc_svm_model_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_fc_svm_model_info.Location = new System.Drawing.Point(0, 0);
            this.groupBox_fc_svm_model_info.Name = "groupBox_fc_svm_model_info";
            this.groupBox_fc_svm_model_info.Size = new System.Drawing.Size(547, 192);
            this.groupBox_fc_svm_model_info.TabIndex = 0;
            this.groupBox_fc_svm_model_info.TabStop = false;
            this.groupBox_fc_svm_model_info.Text = "模型参数";
            // 
            // splitContainer_svm_model_info
            // 
            this.splitContainer_svm_model_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer_svm_model_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_svm_model_info.IsSplitterFixed = true;
            this.splitContainer_svm_model_info.Location = new System.Drawing.Point(3, 21);
            this.splitContainer_svm_model_info.Name = "splitContainer_svm_model_info";
            // 
            // splitContainer_svm_model_info.Panel1
            // 
            this.splitContainer_svm_model_info.Panel1.Controls.Add(this.radioButton_model_info_self_set);
            this.splitContainer_svm_model_info.Panel1.Controls.Add(this.radioButton_model_info_default);
            this.splitContainer_svm_model_info.Panel1MinSize = 30;
            // 
            // splitContainer_svm_model_info.Panel2
            // 
            this.splitContainer_svm_model_info.Panel2.Controls.Add(this.comboBox_svm_class_weight);
            this.splitContainer_svm_model_info.Panel2.Controls.Add(this.label_svm_kernel);
            this.splitContainer_svm_model_info.Panel2.Controls.Add(this.label_svm_decision_function_shape);
            this.splitContainer_svm_model_info.Panel2.Controls.Add(this.label_svm_class_weight);
            this.splitContainer_svm_model_info.Panel2.Controls.Add(this.comboBox_svm_decision_function_shape);
            this.splitContainer_svm_model_info.Panel2.Controls.Add(this.textBox_svm_gamma);
            this.splitContainer_svm_model_info.Panel2.Controls.Add(this.label_svm_train_radio);
            this.splitContainer_svm_model_info.Panel2.Controls.Add(this.comboBox_svm_kernel);
            this.splitContainer_svm_model_info.Panel2.Controls.Add(this.textBox_svm_C);
            this.splitContainer_svm_model_info.Panel2.Controls.Add(this.label_svm_C);
            this.splitContainer_svm_model_info.Panel2.Controls.Add(this.label_svm_gamma);
            this.splitContainer_svm_model_info.Panel2.Controls.Add(this.textBox_svm_train_radio);
            this.splitContainer_svm_model_info.Size = new System.Drawing.Size(541, 168);
            this.splitContainer_svm_model_info.SplitterDistance = 80;
            this.splitContainer_svm_model_info.TabIndex = 26;
            // 
            // radioButton_model_info_self_set
            // 
            this.radioButton_model_info_self_set.AutoSize = true;
            this.radioButton_model_info_self_set.Location = new System.Drawing.Point(19, 96);
            this.radioButton_model_info_self_set.Name = "radioButton_model_info_self_set";
            this.radioButton_model_info_self_set.Size = new System.Drawing.Size(88, 19);
            this.radioButton_model_info_self_set.TabIndex = 39;
            this.radioButton_model_info_self_set.TabStop = true;
            this.radioButton_model_info_self_set.Text = "自行设定";
            this.radioButton_model_info_self_set.UseVisualStyleBackColor = true;
            // 
            // radioButton_model_info_default
            // 
            this.radioButton_model_info_default.AutoSize = true;
            this.radioButton_model_info_default.Location = new System.Drawing.Point(19, 41);
            this.radioButton_model_info_default.Name = "radioButton_model_info_default";
            this.radioButton_model_info_default.Size = new System.Drawing.Size(58, 19);
            this.radioButton_model_info_default.TabIndex = 38;
            this.radioButton_model_info_default.TabStop = true;
            this.radioButton_model_info_default.Text = "默认";
            this.radioButton_model_info_default.UseVisualStyleBackColor = true;
            // 
            // comboBox_svm_class_weight
            // 
            this.comboBox_svm_class_weight.FormattingEnabled = true;
            this.comboBox_svm_class_weight.Location = new System.Drawing.Point(310, 114);
            this.comboBox_svm_class_weight.Name = "comboBox_svm_class_weight";
            this.comboBox_svm_class_weight.Size = new System.Drawing.Size(121, 23);
            this.comboBox_svm_class_weight.TabIndex = 28;
            // 
            // label_svm_kernel
            // 
            this.label_svm_kernel.AutoSize = true;
            this.label_svm_kernel.Location = new System.Drawing.Point(232, 29);
            this.label_svm_kernel.Name = "label_svm_kernel";
            this.label_svm_kernel.Size = new System.Drawing.Size(52, 15);
            this.label_svm_kernel.TabIndex = 29;
            this.label_svm_kernel.Text = "核函数";
            // 
            // label_svm_decision_function_shape
            // 
            this.label_svm_decision_function_shape.AutoSize = true;
            this.label_svm_decision_function_shape.Location = new System.Drawing.Point(229, 73);
            this.label_svm_decision_function_shape.Name = "label_svm_decision_function_shape";
            this.label_svm_decision_function_shape.Size = new System.Drawing.Size(67, 15);
            this.label_svm_decision_function_shape.TabIndex = 30;
            this.label_svm_decision_function_shape.Text = "决策函数";
            // 
            // label_svm_class_weight
            // 
            this.label_svm_class_weight.AutoSize = true;
            this.label_svm_class_weight.Location = new System.Drawing.Point(229, 117);
            this.label_svm_class_weight.Name = "label_svm_class_weight";
            this.label_svm_class_weight.Size = new System.Drawing.Size(67, 15);
            this.label_svm_class_weight.TabIndex = 31;
            this.label_svm_class_weight.Text = "类别权重";
            // 
            // comboBox_svm_decision_function_shape
            // 
            this.comboBox_svm_decision_function_shape.FormattingEnabled = true;
            this.comboBox_svm_decision_function_shape.Location = new System.Drawing.Point(310, 69);
            this.comboBox_svm_decision_function_shape.Name = "comboBox_svm_decision_function_shape";
            this.comboBox_svm_decision_function_shape.Size = new System.Drawing.Size(121, 23);
            this.comboBox_svm_decision_function_shape.TabIndex = 27;
            // 
            // textBox_svm_gamma
            // 
            this.textBox_svm_gamma.Location = new System.Drawing.Point(103, 111);
            this.textBox_svm_gamma.Name = "textBox_svm_gamma";
            this.textBox_svm_gamma.Size = new System.Drawing.Size(90, 25);
            this.textBox_svm_gamma.TabIndex = 37;
            // 
            // label_svm_train_radio
            // 
            this.label_svm_train_radio.AutoSize = true;
            this.label_svm_train_radio.Location = new System.Drawing.Point(15, 29);
            this.label_svm_train_radio.Name = "label_svm_train_radio";
            this.label_svm_train_radio.Size = new System.Drawing.Size(82, 15);
            this.label_svm_train_radio.TabIndex = 32;
            this.label_svm_train_radio.Text = "训练集占比";
            // 
            // comboBox_svm_kernel
            // 
            this.comboBox_svm_kernel.FormattingEnabled = true;
            this.comboBox_svm_kernel.Location = new System.Drawing.Point(310, 25);
            this.comboBox_svm_kernel.Name = "comboBox_svm_kernel";
            this.comboBox_svm_kernel.Size = new System.Drawing.Size(121, 23);
            this.comboBox_svm_kernel.TabIndex = 26;
            // 
            // textBox_svm_C
            // 
            this.textBox_svm_C.Location = new System.Drawing.Point(103, 69);
            this.textBox_svm_C.Name = "textBox_svm_C";
            this.textBox_svm_C.Size = new System.Drawing.Size(90, 25);
            this.textBox_svm_C.TabIndex = 36;
            // 
            // label_svm_C
            // 
            this.label_svm_C.AutoSize = true;
            this.label_svm_C.Location = new System.Drawing.Point(49, 73);
            this.label_svm_C.Name = "label_svm_C";
            this.label_svm_C.Size = new System.Drawing.Size(15, 15);
            this.label_svm_C.TabIndex = 33;
            this.label_svm_C.Text = "C";
            // 
            // label_svm_gamma
            // 
            this.label_svm_gamma.AutoSize = true;
            this.label_svm_gamma.Location = new System.Drawing.Point(32, 114);
            this.label_svm_gamma.Name = "label_svm_gamma";
            this.label_svm_gamma.Size = new System.Drawing.Size(47, 15);
            this.label_svm_gamma.TabIndex = 34;
            this.label_svm_gamma.Text = "gamma";
            // 
            // textBox_svm_train_radio
            // 
            this.textBox_svm_train_radio.Location = new System.Drawing.Point(103, 25);
            this.textBox_svm_train_radio.Name = "textBox_svm_train_radio";
            this.textBox_svm_train_radio.Size = new System.Drawing.Size(90, 25);
            this.textBox_svm_train_radio.TabIndex = 35;
            // 
            // groupBox_fc_feature_select
            // 
            this.groupBox_fc_feature_select.Controls.Add(this.checkedListBox_fc_feature_select);
            this.groupBox_fc_feature_select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_fc_feature_select.Location = new System.Drawing.Point(0, 0);
            this.groupBox_fc_feature_select.Name = "groupBox_fc_feature_select";
            this.groupBox_fc_feature_select.Size = new System.Drawing.Size(200, 192);
            this.groupBox_fc_feature_select.TabIndex = 5;
            this.groupBox_fc_feature_select.TabStop = false;
            this.groupBox_fc_feature_select.Text = "特征选择";
            // 
            // checkedListBox_fc_feature_select
            // 
            this.checkedListBox_fc_feature_select.CheckOnClick = true;
            this.checkedListBox_fc_feature_select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox_fc_feature_select.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkedListBox_fc_feature_select.FormattingEnabled = true;
            this.checkedListBox_fc_feature_select.Items.AddRange(new object[] {
            "C11，|C12|，C22",
            "span，PR",
            "SDWI",
            "H，A，alpha"});
            this.checkedListBox_fc_feature_select.Location = new System.Drawing.Point(3, 21);
            this.checkedListBox_fc_feature_select.Name = "checkedListBox_fc_feature_select";
            this.checkedListBox_fc_feature_select.Size = new System.Drawing.Size(194, 168);
            this.checkedListBox_fc_feature_select.TabIndex = 0;
            // 
            // groupBox_fc_svm_predict
            // 
            this.groupBox_fc_svm_predict.Controls.Add(this.button_svm_predict_result_path);
            this.groupBox_fc_svm_predict.Controls.Add(this.label_svm_predict_model_path);
            this.groupBox_fc_svm_predict.Controls.Add(this.textBox_svm_predict_result_path);
            this.groupBox_fc_svm_predict.Controls.Add(this.button_svm_predict_model_path);
            this.groupBox_fc_svm_predict.Controls.Add(this.textBox_svm_predict_model_path);
            this.groupBox_fc_svm_predict.Controls.Add(this.label_svm_predict_result_path);
            this.groupBox_fc_svm_predict.Location = new System.Drawing.Point(38, 321);
            this.groupBox_fc_svm_predict.Name = "groupBox_fc_svm_predict";
            this.groupBox_fc_svm_predict.Size = new System.Drawing.Size(751, 114);
            this.groupBox_fc_svm_predict.TabIndex = 7;
            this.groupBox_fc_svm_predict.TabStop = false;
            this.groupBox_fc_svm_predict.Text = "模型分类";
            // 
            // button_svm_predict_result_path
            // 
            this.button_svm_predict_result_path.Location = new System.Drawing.Point(567, 67);
            this.button_svm_predict_result_path.Name = "button_svm_predict_result_path";
            this.button_svm_predict_result_path.Size = new System.Drawing.Size(78, 27);
            this.button_svm_predict_result_path.TabIndex = 4;
            this.button_svm_predict_result_path.Text = "获取";
            this.button_svm_predict_result_path.UseVisualStyleBackColor = true;
            // 
            // label_svm_predict_model_path
            // 
            this.label_svm_predict_model_path.AutoSize = true;
            this.label_svm_predict_model_path.Location = new System.Drawing.Point(131, 33);
            this.label_svm_predict_model_path.Name = "label_svm_predict_model_path";
            this.label_svm_predict_model_path.Size = new System.Drawing.Size(97, 15);
            this.label_svm_predict_model_path.TabIndex = 1;
            this.label_svm_predict_model_path.Text = "分类模型位置";
            // 
            // textBox_svm_predict_result_path
            // 
            this.textBox_svm_predict_result_path.Location = new System.Drawing.Point(241, 70);
            this.textBox_svm_predict_result_path.Name = "textBox_svm_predict_result_path";
            this.textBox_svm_predict_result_path.Size = new System.Drawing.Size(295, 25);
            this.textBox_svm_predict_result_path.TabIndex = 4;
            // 
            // button_svm_predict_model_path
            // 
            this.button_svm_predict_model_path.Location = new System.Drawing.Point(567, 27);
            this.button_svm_predict_model_path.Name = "button_svm_predict_model_path";
            this.button_svm_predict_model_path.Size = new System.Drawing.Size(78, 27);
            this.button_svm_predict_model_path.TabIndex = 3;
            this.button_svm_predict_model_path.Text = "获取";
            this.button_svm_predict_model_path.UseVisualStyleBackColor = true;
            // 
            // textBox_svm_predict_model_path
            // 
            this.textBox_svm_predict_model_path.Location = new System.Drawing.Point(241, 27);
            this.textBox_svm_predict_model_path.Name = "textBox_svm_predict_model_path";
            this.textBox_svm_predict_model_path.Size = new System.Drawing.Size(295, 25);
            this.textBox_svm_predict_model_path.TabIndex = 2;
            // 
            // label_svm_predict_result_path
            // 
            this.label_svm_predict_result_path.AutoSize = true;
            this.label_svm_predict_result_path.Location = new System.Drawing.Point(131, 73);
            this.label_svm_predict_result_path.Name = "label_svm_predict_result_path";
            this.label_svm_predict_result_path.Size = new System.Drawing.Size(97, 15);
            this.label_svm_predict_result_path.TabIndex = 3;
            this.label_svm_predict_result_path.Text = "结果保存位置";
            // 
            // Form_classification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 514);
            this.Controls.Add(this.tabControl_classification_svm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_classification";
            this.Text = "分类";
            this.tabControl_classification_svm.ResumeLayout(false);
            this.tabPage_fc_data_pre_process.ResumeLayout(false);
            this.groupBox_fc_image_size.ResumeLayout(false);
            this.groupBox_fc_image_size.PerformLayout();
            this.groupBox_fc_pre_process_path.ResumeLayout(false);
            this.groupBox_fc_pre_process_path.PerformLayout();
            this.groupBox_fc_pre_process_show.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox_fc_svm_train.ResumeLayout(false);
            this.splitContainer_fc_svm_train_down.Panel1.ResumeLayout(false);
            this.splitContainer_fc_svm_train_down.Panel1.PerformLayout();
            this.splitContainer_fc_svm_train_down.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_fc_svm_train_down)).EndInit();
            this.splitContainer_fc_svm_train_down.ResumeLayout(false);
            this.splitContainer_fc_svm_train_up.Panel1.ResumeLayout(false);
            this.splitContainer_fc_svm_train_up.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_fc_svm_train_up)).EndInit();
            this.splitContainer_fc_svm_train_up.ResumeLayout(false);
            this.groupBox_fc_svm_model_info.ResumeLayout(false);
            this.splitContainer_svm_model_info.Panel1.ResumeLayout(false);
            this.splitContainer_svm_model_info.Panel1.PerformLayout();
            this.splitContainer_svm_model_info.Panel2.ResumeLayout(false);
            this.splitContainer_svm_model_info.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_svm_model_info)).EndInit();
            this.splitContainer_svm_model_info.ResumeLayout(false);
            this.groupBox_fc_feature_select.ResumeLayout(false);
            this.groupBox_fc_svm_predict.ResumeLayout(false);
            this.groupBox_fc_svm_predict.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_classification_svm;
        private System.Windows.Forms.TabPage tabPage_fc_data_pre_process;
        private System.Windows.Forms.GroupBox groupBox_fc_image_size;
        private System.Windows.Forms.Button button_fc_image_size_clear;
        private System.Windows.Forms.Label label_fc_image_size_column;
        private System.Windows.Forms.Label label_fc_image_size_row;
        private System.Windows.Forms.TextBox textBox_fc_image_size_column;
        private System.Windows.Forms.TextBox textBox_fc_image_size_row;
        private System.Windows.Forms.Button button_fc_image_size_get;
        private System.Windows.Forms.Button button_fc_pre_data_notice;
        private System.Windows.Forms.GroupBox groupBox_fc_pre_process_path;
        private System.Windows.Forms.TextBox textBox_fc_sample_path;
        private System.Windows.Forms.TextBox textBox_inputdata_path;
        private System.Windows.Forms.Button button_inputdata_path_get;
        private System.Windows.Forms.Button button_fc_sample_path;
        private System.Windows.Forms.Label label_fc_input_path;
        private System.Windows.Forms.Label label_fc_sample_path;
        private System.Windows.Forms.Button button_fc_pre_data_get;
        private System.Windows.Forms.GroupBox groupBox_fc_pre_process_show;
        private System.Windows.Forms.RichTextBox richTextBox_fc_pre_process_run_record;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_fc_svm_predict;
        private System.Windows.Forms.Button button_fc_svm_train;
        private System.Windows.Forms.GroupBox groupBox_fc_svm_train;
        private System.Windows.Forms.SplitContainer splitContainer_fc_svm_train_down;
        private System.Windows.Forms.Button button_fc_svm_model_savepath;
        private System.Windows.Forms.Label label_fc_train_data_folderpath;
        private System.Windows.Forms.TextBox textBox_fc_svm_model_savepath;
        private System.Windows.Forms.TextBox textBox_fc_train_data_folderpath;
        private System.Windows.Forms.Button button_fc_train_data_folderpath;
        private System.Windows.Forms.Label label_fc_svm_model_savepath;
        private System.Windows.Forms.SplitContainer splitContainer_fc_svm_train_up;
        private System.Windows.Forms.GroupBox groupBox_fc_svm_model_info;
        private System.Windows.Forms.SplitContainer splitContainer_svm_model_info;
        private System.Windows.Forms.RadioButton radioButton_model_info_self_set;
        private System.Windows.Forms.RadioButton radioButton_model_info_default;
        private System.Windows.Forms.ComboBox comboBox_svm_class_weight;
        private System.Windows.Forms.Label label_svm_kernel;
        private System.Windows.Forms.Label label_svm_decision_function_shape;
        private System.Windows.Forms.Label label_svm_class_weight;
        private System.Windows.Forms.ComboBox comboBox_svm_decision_function_shape;
        private System.Windows.Forms.TextBox textBox_svm_gamma;
        private System.Windows.Forms.Label label_svm_train_radio;
        private System.Windows.Forms.ComboBox comboBox_svm_kernel;
        private System.Windows.Forms.TextBox textBox_svm_C;
        private System.Windows.Forms.Label label_svm_C;
        private System.Windows.Forms.Label label_svm_gamma;
        private System.Windows.Forms.TextBox textBox_svm_train_radio;
        private System.Windows.Forms.GroupBox groupBox_fc_feature_select;
        private System.Windows.Forms.CheckedListBox checkedListBox_fc_feature_select;
        private System.Windows.Forms.GroupBox groupBox_fc_svm_predict;
        private System.Windows.Forms.Button button_svm_predict_result_path;
        private System.Windows.Forms.Label label_svm_predict_model_path;
        private System.Windows.Forms.TextBox textBox_svm_predict_result_path;
        private System.Windows.Forms.Button button_svm_predict_model_path;
        private System.Windows.Forms.TextBox textBox_svm_predict_model_path;
        private System.Windows.Forms.Label label_svm_predict_result_path;
    }
}