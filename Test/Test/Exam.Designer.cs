namespace Test
{
    partial class Exam
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exam));
            this.listQuestion = new System.Windows.Forms.ListBox();
            this.groupQuestion = new System.Windows.Forms.GroupBox();
            this.radioAnswer1 = new System.Windows.Forms.RadioButton();
            this.radioAnswer4 = new System.Windows.Forms.RadioButton();
            this.radioAnswer2 = new System.Windows.Forms.RadioButton();
            this.radioAnswer3 = new System.Windows.Forms.RadioButton();
            this.labelResult = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.labelTimerMin = new System.Windows.Forms.Label();
            this.panelError = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.panelCorrect = new System.Windows.Forms.Panel();
            this.labelCorrect = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelNotPass = new System.Windows.Forms.Panel();
            this.labelNotPass = new System.Windows.Forms.Label();
            this.groupBoxNotPass = new System.Windows.Forms.GroupBox();
            this.groupBoxPass = new System.Windows.Forms.GroupBox();
            this.panelPass = new System.Windows.Forms.Panel();
            this.labelPass = new System.Windows.Forms.Label();
            this.Point1 = new System.Windows.Forms.Button();
            this.Point2 = new System.Windows.Forms.Button();
            this.Point3 = new System.Windows.Forms.Button();
            this.Point7 = new System.Windows.Forms.Button();
            this.Point4 = new System.Windows.Forms.Button();
            this.Point5 = new System.Windows.Forms.Button();
            this.Point6 = new System.Windows.Forms.Button();
            this.Point8 = new System.Windows.Forms.Button();
            this.Point9 = new System.Windows.Forms.Button();
            this.Point10 = new System.Windows.Forms.Button();
            this.groupQuestion.SuspendLayout();
            this.panelError.SuspendLayout();
            this.panelCorrect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelNotPass.SuspendLayout();
            this.groupBoxNotPass.SuspendLayout();
            this.groupBoxPass.SuspendLayout();
            this.panelPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // listQuestion
            // 
            this.listQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listQuestion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listQuestion.FormattingEnabled = true;
            this.listQuestion.Location = new System.Drawing.Point(210, 67);
            this.listQuestion.Name = "listQuestion";
            this.listQuestion.Size = new System.Drawing.Size(654, 95);
            this.listQuestion.TabIndex = 4;
            // 
            // groupQuestion
            // 
            this.groupQuestion.Controls.Add(this.radioAnswer1);
            this.groupQuestion.Controls.Add(this.radioAnswer4);
            this.groupQuestion.Controls.Add(this.radioAnswer2);
            this.groupQuestion.Controls.Add(this.radioAnswer3);
            this.groupQuestion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupQuestion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupQuestion.Location = new System.Drawing.Point(210, 213);
            this.groupQuestion.Name = "groupQuestion";
            this.groupQuestion.Size = new System.Drawing.Size(654, 258);
            this.groupQuestion.TabIndex = 13;
            this.groupQuestion.TabStop = false;
            // 
            // radioAnswer1
            // 
            this.radioAnswer1.Location = new System.Drawing.Point(6, 21);
            this.radioAnswer1.Name = "radioAnswer1";
            this.radioAnswer1.Size = new System.Drawing.Size(564, 52);
            this.radioAnswer1.TabIndex = 4;
            this.radioAnswer1.Text = "radioButton1";
            this.radioAnswer1.UseVisualStyleBackColor = true;
            // 
            // radioAnswer4
            // 
            this.radioAnswer4.Location = new System.Drawing.Point(6, 200);
            this.radioAnswer4.Name = "radioAnswer4";
            this.radioAnswer4.Size = new System.Drawing.Size(564, 52);
            this.radioAnswer4.TabIndex = 9;
            this.radioAnswer4.Text = "radioButton1";
            this.radioAnswer4.UseVisualStyleBackColor = true;
            // 
            // radioAnswer2
            // 
            this.radioAnswer2.Location = new System.Drawing.Point(6, 79);
            this.radioAnswer2.Name = "radioAnswer2";
            this.radioAnswer2.Size = new System.Drawing.Size(564, 52);
            this.radioAnswer2.TabIndex = 11;
            this.radioAnswer2.Text = "radioButton1";
            this.radioAnswer2.UseVisualStyleBackColor = true;
            // 
            // radioAnswer3
            // 
            this.radioAnswer3.Location = new System.Drawing.Point(6, 142);
            this.radioAnswer3.Name = "radioAnswer3";
            this.radioAnswer3.Size = new System.Drawing.Size(564, 52);
            this.radioAnswer3.TabIndex = 10;
            this.radioAnswer3.Text = "radioButton1";
            this.radioAnswer3.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.SkyBlue;
            this.labelResult.Location = new System.Drawing.Point(757, 545);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(161, 47);
            this.labelResult.TabIndex = 14;
            this.labelResult.Text = "label1";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(404, 526);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(323, 85);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Следующий вопрос";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnNext_KeyPress);
            // 
            // labelTimerMin
            // 
            this.labelTimerMin.AutoSize = true;
            this.labelTimerMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimerMin.Location = new System.Drawing.Point(141, 557);
            this.labelTimerMin.Name = "labelTimerMin";
            this.labelTimerMin.Size = new System.Drawing.Size(54, 20);
            this.labelTimerMin.TabIndex = 16;
            this.labelTimerMin.Text = "10:00";
            this.labelTimerMin.Click += new System.EventHandler(this.labelTimerMin_Click);
            // 
            // panelError
            // 
            this.panelError.BackColor = System.Drawing.Color.Crimson;
            this.panelError.Controls.Add(this.labelError);
            this.panelError.Location = new System.Drawing.Point(1, 647);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(1122, 113);
            this.panelError.TabIndex = 19;
            this.panelError.Visible = false;
            // 
            // labelError
            // 
            this.labelError.BackColor = System.Drawing.Color.Crimson;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.labelError.Location = new System.Drawing.Point(403, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(323, 97);
            this.labelError.TabIndex = 1;
            this.labelError.Text = "ОШИБКА";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelError.Visible = false;
            // 
            // panelCorrect
            // 
            this.panelCorrect.BackColor = System.Drawing.Color.Lime;
            this.panelCorrect.Controls.Add(this.labelCorrect);
            this.panelCorrect.Location = new System.Drawing.Point(1, 647);
            this.panelCorrect.Name = "panelCorrect";
            this.panelCorrect.Size = new System.Drawing.Size(1122, 113);
            this.panelCorrect.TabIndex = 20;
            this.panelCorrect.Visible = false;
            // 
            // labelCorrect
            // 
            this.labelCorrect.BackColor = System.Drawing.Color.Lime;
            this.labelCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.labelCorrect.Location = new System.Drawing.Point(403, 16);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(323, 97);
            this.labelCorrect.TabIndex = 2;
            this.labelCorrect.Text = "ПРАВИЛЬНО";
            this.labelCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCorrect.Visible = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(1, 67);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(482, 388);
            this.pictureBox.TabIndex = 21;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelNotPass
            // 
            this.panelNotPass.BackColor = System.Drawing.Color.Red;
            this.panelNotPass.Controls.Add(this.labelNotPass);
            this.panelNotPass.ForeColor = System.Drawing.Color.Red;
            this.panelNotPass.Location = new System.Drawing.Point(16, 19);
            this.panelNotPass.Name = "panelNotPass";
            this.panelNotPass.Size = new System.Drawing.Size(917, 212);
            this.panelNotPass.TabIndex = 22;
            // 
            // labelNotPass
            // 
            this.labelNotPass.AutoSize = true;
            this.labelNotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNotPass.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelNotPass.Location = new System.Drawing.Point(302, 71);
            this.labelNotPass.Name = "labelNotPass";
            this.labelNotPass.Size = new System.Drawing.Size(329, 73);
            this.labelNotPass.TabIndex = 0;
            this.labelNotPass.Text = "НЕ СДАЛ";
            // 
            // groupBoxNotPass
            // 
            this.groupBoxNotPass.Controls.Add(this.panelNotPass);
            this.groupBoxNotPass.Location = new System.Drawing.Point(69, 234);
            this.groupBoxNotPass.Name = "groupBoxNotPass";
            this.groupBoxNotPass.Size = new System.Drawing.Size(970, 251);
            this.groupBoxNotPass.TabIndex = 0;
            this.groupBoxNotPass.TabStop = false;
            this.groupBoxNotPass.Visible = false;
            // 
            // groupBoxPass
            // 
            this.groupBoxPass.Controls.Add(this.panelPass);
            this.groupBoxPass.Location = new System.Drawing.Point(69, 158);
            this.groupBoxPass.Name = "groupBoxPass";
            this.groupBoxPass.Size = new System.Drawing.Size(970, 251);
            this.groupBoxPass.TabIndex = 23;
            this.groupBoxPass.TabStop = false;
            this.groupBoxPass.Visible = false;
            // 
            // panelPass
            // 
            this.panelPass.BackColor = System.Drawing.Color.Lime;
            this.panelPass.Controls.Add(this.labelPass);
            this.panelPass.ForeColor = System.Drawing.Color.Red;
            this.panelPass.Location = new System.Drawing.Point(16, 19);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(917, 212);
            this.panelPass.TabIndex = 22;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelPass.Location = new System.Drawing.Point(349, 71);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(220, 73);
            this.labelPass.TabIndex = 0;
            this.labelPass.Text = "СДАЛ";
            // 
            // Point1
            // 
            this.Point1.BackColor = System.Drawing.Color.SkyBlue;
            this.Point1.Enabled = false;
            this.Point1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Point1.Location = new System.Drawing.Point(411, 12);
            this.Point1.Name = "Point1";
            this.Point1.Size = new System.Drawing.Size(22, 23);
            this.Point1.TabIndex = 24;
            this.Point1.Text = "1";
            this.Point1.UseVisualStyleBackColor = false;
            this.Point1.Click += new System.EventHandler(this.Point1_Click);
            // 
            // Point2
            // 
            this.Point2.Enabled = false;
            this.Point2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Point2.Location = new System.Drawing.Point(439, 12);
            this.Point2.Name = "Point2";
            this.Point2.Size = new System.Drawing.Size(22, 23);
            this.Point2.TabIndex = 25;
            this.Point2.Text = "2";
            this.Point2.UseVisualStyleBackColor = true;
            // 
            // Point3
            // 
            this.Point3.Enabled = false;
            this.Point3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Point3.Location = new System.Drawing.Point(467, 12);
            this.Point3.Name = "Point3";
            this.Point3.Size = new System.Drawing.Size(22, 23);
            this.Point3.TabIndex = 26;
            this.Point3.Text = "3";
            this.Point3.UseVisualStyleBackColor = true;
            // 
            // Point7
            // 
            this.Point7.Enabled = false;
            this.Point7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Point7.Location = new System.Drawing.Point(579, 12);
            this.Point7.Name = "Point7";
            this.Point7.Size = new System.Drawing.Size(22, 23);
            this.Point7.TabIndex = 27;
            this.Point7.Text = "7";
            this.Point7.UseVisualStyleBackColor = true;
            // 
            // Point4
            // 
            this.Point4.Enabled = false;
            this.Point4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Point4.Location = new System.Drawing.Point(495, 12);
            this.Point4.Name = "Point4";
            this.Point4.Size = new System.Drawing.Size(22, 23);
            this.Point4.TabIndex = 27;
            this.Point4.Text = "4";
            this.Point4.UseVisualStyleBackColor = true;
            // 
            // Point5
            // 
            this.Point5.Enabled = false;
            this.Point5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Point5.Location = new System.Drawing.Point(523, 12);
            this.Point5.Name = "Point5";
            this.Point5.Size = new System.Drawing.Size(22, 23);
            this.Point5.TabIndex = 28;
            this.Point5.Text = "5";
            this.Point5.UseVisualStyleBackColor = true;
            // 
            // Point6
            // 
            this.Point6.Enabled = false;
            this.Point6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Point6.Location = new System.Drawing.Point(551, 12);
            this.Point6.Name = "Point6";
            this.Point6.Size = new System.Drawing.Size(22, 23);
            this.Point6.TabIndex = 29;
            this.Point6.Text = "6";
            this.Point6.UseVisualStyleBackColor = true;
            // 
            // Point8
            // 
            this.Point8.Enabled = false;
            this.Point8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Point8.Location = new System.Drawing.Point(607, 12);
            this.Point8.Name = "Point8";
            this.Point8.Size = new System.Drawing.Size(22, 23);
            this.Point8.TabIndex = 30;
            this.Point8.Text = "8";
            this.Point8.UseVisualStyleBackColor = true;
            // 
            // Point9
            // 
            this.Point9.Enabled = false;
            this.Point9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Point9.Location = new System.Drawing.Point(635, 12);
            this.Point9.Name = "Point9";
            this.Point9.Size = new System.Drawing.Size(22, 23);
            this.Point9.TabIndex = 31;
            this.Point9.Text = "9";
            this.Point9.UseVisualStyleBackColor = true;
            // 
            // Point10
            // 
            this.Point10.Enabled = false;
            this.Point10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Point10.Location = new System.Drawing.Point(663, 12);
            this.Point10.Name = "Point10";
            this.Point10.Size = new System.Drawing.Size(28, 23);
            this.Point10.TabIndex = 32;
            this.Point10.Text = "10";
            this.Point10.UseVisualStyleBackColor = true;
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1124, 756);
            this.Controls.Add(this.Point10);
            this.Controls.Add(this.Point9);
            this.Controls.Add(this.Point8);
            this.Controls.Add(this.Point6);
            this.Controls.Add(this.Point5);
            this.Controls.Add(this.Point4);
            this.Controls.Add(this.Point7);
            this.Controls.Add(this.Point3);
            this.Controls.Add(this.Point2);
            this.Controls.Add(this.Point1);
            this.Controls.Add(this.groupBoxPass);
            this.Controls.Add(this.groupBoxNotPass);
            this.Controls.Add(this.panelCorrect);
            this.Controls.Add(this.panelError);
            this.Controls.Add(this.labelTimerMin);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.groupQuestion);
            this.Controls.Add(this.listQuestion);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exam";
            this.Text = "Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exam_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Exam_KeyPress);
            this.groupQuestion.ResumeLayout(false);
            this.panelError.ResumeLayout(false);
            this.panelCorrect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelNotPass.ResumeLayout(false);
            this.panelNotPass.PerformLayout();
            this.groupBoxNotPass.ResumeLayout(false);
            this.groupBoxPass.ResumeLayout(false);
            this.panelPass.ResumeLayout(false);
            this.panelPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listQuestion;
        private System.Windows.Forms.GroupBox groupQuestion;
        private System.Windows.Forms.RadioButton radioAnswer1;
        private System.Windows.Forms.RadioButton radioAnswer4;
        private System.Windows.Forms.RadioButton radioAnswer2;
        private System.Windows.Forms.RadioButton radioAnswer3;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label labelTimerMin;
        private System.Windows.Forms.Panel panelError;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Panel panelCorrect;
        private System.Windows.Forms.Label labelCorrect;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelNotPass;
        private System.Windows.Forms.Label labelNotPass;
        private System.Windows.Forms.GroupBox groupBoxNotPass;
        private System.Windows.Forms.GroupBox groupBoxPass;
        private System.Windows.Forms.Panel panelPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button Point1;
        private System.Windows.Forms.Button Point2;
        private System.Windows.Forms.Button Point3;
        private System.Windows.Forms.Button Point7;
        private System.Windows.Forms.Button Point4;
        private System.Windows.Forms.Button Point5;
        private System.Windows.Forms.Button Point6;
        private System.Windows.Forms.Button Point8;
        private System.Windows.Forms.Button Point9;
        private System.Windows.Forms.Button Point10;
    }
}