namespace MemoApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSave = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.SystemLabel = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.SaveFolderPath = new System.Windows.Forms.TextBox();
            this.Fddfile = new System.Windows.Forms.FolderBrowserDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton4 = new System.Windows.Forms.RadioButton();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.MemoSettingFormBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(328, 50);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(94, 25);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(417, 363);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(143, 12);
            this.Label.TabIndex = 2;
            this.Label.Text = "Made by 2019.1 - 강승현";
            // 
            // SystemLabel
            // 
            this.SystemLabel.AutoSize = true;
            this.SystemLabel.Location = new System.Drawing.Point(10, 363);
            this.SystemLabel.Name = "SystemLabel";
            this.SystemLabel.Size = new System.Drawing.Size(371, 12);
            this.SystemLabel.TabIndex = 3;
            this.SystemLabel.Text = "도움말 - 이 앱은 테스트 버전입니다. 많은 버그가 있을 수 있습니다.";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(4, 53);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(160, 21);
            this.DateTimePicker.TabIndex = 4;
            this.DateTimePicker.CloseUp += new System.EventHandler(this.DTP_ValueChanged);
            this.DateTimePicker.DropDown += new System.EventHandler(this.DateTimePicker_DropDown);
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(4, 80);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMemo.Size = new System.Drawing.Size(433, 271);
            this.txtMemo.TabIndex = 5;
            this.txtMemo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtMemo_KeyDown);
            this.txtMemo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TxtMemo_MouseClick);
            // 
            // SaveFolderPath
            // 
            this.SaveFolderPath.Location = new System.Drawing.Point(4, 23);
            this.SaveFolderPath.Name = "SaveFolderPath";
            this.SaveFolderPath.Size = new System.Drawing.Size(272, 21);
            this.SaveFolderPath.TabIndex = 7;
            this.SaveFolderPath.Text = "저장하고 로드할 폴더를 지정해 주세요.";
            this.SaveFolderPath.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SaveFolderPath_MouseClick);
            // 
            // sfdFile
            // 
            this.sfdFile.Filter = "텍스트 파일(*.txt)|\".txt|모든 파일(\".\")|\".\"";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("돋움", 8F);
            this.button1.Location = new System.Drawing.Point(282, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "저장/로드 폴더 지정하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SaveFolderPath_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.MemoSettingFormBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(433, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 328);
            this.panel1.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "도움말 목록";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButton4);
            this.groupBox1.Controls.Add(this.RadioButton3);
            this.groupBox1.Controls.Add(this.RadioButton2);
            this.groupBox1.Controls.Add(this.RadioButton1);
            this.groupBox1.Location = new System.Drawing.Point(3, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "파일 이름 형식";
            // 
            // RadioButton4
            // 
            this.RadioButton4.AutoSize = true;
            this.RadioButton4.Enabled = false;
            this.RadioButton4.Location = new System.Drawing.Point(7, 90);
            this.RadioButton4.Name = "RadioButton4";
            this.RadioButton4.Size = new System.Drawing.Size(47, 16);
            this.RadioButton4.TabIndex = 3;
            this.RadioButton4.Text = "미정";
            this.RadioButton4.UseVisualStyleBackColor = true;
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Enabled = false;
            this.RadioButton3.Location = new System.Drawing.Point(7, 67);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(47, 16);
            this.RadioButton3.TabIndex = 2;
            this.RadioButton3.Text = "미정";
            this.RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Enabled = false;
            this.RadioButton2.Font = new System.Drawing.Font("굴림", 8F);
            this.RadioButton2.Location = new System.Drawing.Point(7, 44);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(131, 15);
            this.RadioButton2.TabIndex = 1;
            this.RadioButton2.Text = "n년 n월 n일~ n월n일";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButtons_Changed);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Checked = true;
            this.RadioButton1.Font = new System.Drawing.Font("굴림", 7F);
            this.RadioButton1.Location = new System.Drawing.Point(7, 21);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(143, 14);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "n년 n월 n째주~ n월 n째주";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButtons_Changed);
            // 
            // MemoSettingFormBtn
            // 
            this.MemoSettingFormBtn.Location = new System.Drawing.Point(3, 46);
            this.MemoSettingFormBtn.Name = "MemoSettingFormBtn";
            this.MemoSettingFormBtn.Size = new System.Drawing.Size(143, 82);
            this.MemoSettingFormBtn.TabIndex = 1;
            this.MemoSettingFormBtn.Text = "메모 셋팅 형식";
            this.MemoSettingFormBtn.UseVisualStyleBackColor = true;
            this.MemoSettingFormBtn.Click += new System.EventHandler(this.MemoSettingFormBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13F);
            this.label1.Location = new System.Drawing.Point(56, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "옵션";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.InputTextBox.Font = new System.Drawing.Font("굴림", 9F);
            this.InputTextBox.Location = new System.Drawing.Point(170, 53);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(152, 21);
            this.InputTextBox.TabIndex = 10;
            this.InputTextBox.Text = "InputOuterMonth변수 입력";
            this.InputTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InputTextBox_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 384);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveFolderPath);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.SystemLabel);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.BtnSave);
            this.Name = "Form1";
            this.Text = "MemoApp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label SystemLabel;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.TextBox SaveFolderPath;
        private System.Windows.Forms.FolderBrowserDialog Fddfile;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MemoSettingFormBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButton4;
        private System.Windows.Forms.RadioButton RadioButton3;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        public System.Windows.Forms.TextBox InputTextBox;
    }
}

