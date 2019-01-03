namespace MemoApp
{
    partial class MemoSettingForm
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
            this.BasicForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MemoSettingFormHelpLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DetailForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Detail_PlanForm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Basic_PlanForm = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BasicForm
            // 
            this.BasicForm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BasicForm.Location = new System.Drawing.Point(12, 12);
            this.BasicForm.Name = "BasicForm";
            this.BasicForm.Size = new System.Drawing.Size(201, 102);
            this.BasicForm.TabIndex = 0;
            this.BasicForm.Text = "11.30 금\r\n\r\n12.1 토\r\n\r\n12.2 일";
            this.BasicForm.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BasicForm.UseVisualStyleBackColor = false;
            this.BasicForm.Click += new System.EventHandler(this.BasicForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "기본";
            // 
            // MemoSettingFormHelpLabel
            // 
            this.MemoSettingFormHelpLabel.AutoSize = true;
            this.MemoSettingFormHelpLabel.Location = new System.Drawing.Point(12, 260);
            this.MemoSettingFormHelpLabel.Name = "MemoSettingFormHelpLabel";
            this.MemoSettingFormHelpLabel.Size = new System.Drawing.Size(335, 12);
            this.MemoSettingFormHelpLabel.TabIndex = 2;
            this.MemoSettingFormHelpLabel.Text = "주의 - 버튼을 클릭할 시 현재 선택중인 메모가 초기화됩니다.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "자세히";
            // 
            // DetailForm
            // 
            this.DetailForm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DetailForm.Enabled = false;
            this.DetailForm.Location = new System.Drawing.Point(236, 12);
            this.DetailForm.Name = "DetailForm";
            this.DetailForm.Size = new System.Drawing.Size(201, 102);
            this.DetailForm.TabIndex = 3;
            this.DetailForm.Text = "2018.11.30 금요일\r\n날씨:\r\n\r\n2018.12.1 토\r\n날씨:\r\n\r\n2018.12.2 일\r\n날씨:";
            this.DetailForm.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DetailForm.UseVisualStyleBackColor = false;
            this.DetailForm.Click += new System.EventHandler(this.DetailForm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "자세히+계획";
            // 
            // Detail_PlanForm
            // 
            this.Detail_PlanForm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Detail_PlanForm.Enabled = false;
            this.Detail_PlanForm.Location = new System.Drawing.Point(238, 132);
            this.Detail_PlanForm.Name = "Detail_PlanForm";
            this.Detail_PlanForm.Size = new System.Drawing.Size(201, 102);
            this.Detail_PlanForm.TabIndex = 7;
            this.Detail_PlanForm.Text = "2018.11.30 금요일\r\n날씨:\r\n한 것:\r\n할 것:\r\n\r\n2018.12.1 토요일\r\n날씨:\r\n한 것:\r\n할 것:\r\n";
            this.Detail_PlanForm.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Detail_PlanForm.UseVisualStyleBackColor = false;
            this.Detail_PlanForm.Click += new System.EventHandler(this.Detail_PlanForm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "기본+계획";
            // 
            // Basic_PlanForm
            // 
            this.Basic_PlanForm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Basic_PlanForm.Enabled = false;
            this.Basic_PlanForm.Location = new System.Drawing.Point(14, 132);
            this.Basic_PlanForm.Name = "Basic_PlanForm";
            this.Basic_PlanForm.Size = new System.Drawing.Size(201, 102);
            this.Basic_PlanForm.TabIndex = 5;
            this.Basic_PlanForm.Text = "11.30 금\r\n한것:\r\n할것:\r\n\r\n12.1 토\r\n한것:\r\n할것:\r\n\r\n12.2 일";
            this.Basic_PlanForm.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Basic_PlanForm.UseVisualStyleBackColor = false;
            this.Basic_PlanForm.Click += new System.EventHandler(this.Basic_PlanForm_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(395, 255);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "닫기";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MemoSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 284);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Detail_PlanForm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Basic_PlanForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DetailForm);
            this.Controls.Add(this.MemoSettingFormHelpLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BasicForm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemoSettingForm";
            this.ShowIcon = false;
            this.Text = "메모 형식 셋팅";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BasicForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MemoSettingFormHelpLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DetailForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Detail_PlanForm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Basic_PlanForm;
        private System.Windows.Forms.Button BtnExit;
    }
}