namespace Test
{
    partial class FChooseTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChooseTest));
            this.btnNext = new System.Windows.Forms.Button();
            this.listQuestion = new System.Windows.Forms.ListBox();
            this.radioAnswer1 = new System.Windows.Forms.RadioButton();
            this.labelResult = new System.Windows.Forms.Label();
            this.panelError = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.radioAnswer4 = new System.Windows.Forms.RadioButton();
            this.radioAnswer3 = new System.Windows.Forms.RadioButton();
            this.radioAnswer2 = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupQuestion = new System.Windows.Forms.GroupBox();
            this.labelCorrect = new System.Windows.Forms.Label();
            this.panelCorrect = new System.Windows.Forms.Panel();
            this.labelTimerMin = new System.Windows.Forms.Label();
            this.labelTimerSec = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelSign = new System.Windows.Forms.Label();
            this.labelNumberOfQuestions = new System.Windows.Forms.Label();
            this.panelError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupQuestion.SuspendLayout();
            this.panelCorrect.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(404, 423);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(323, 85);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Следующий вопрос";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // listQuestion
            // 
            this.listQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listQuestion.FormattingEnabled = true;
            this.listQuestion.Location = new System.Drawing.Point(209, 12);
            this.listQuestion.Name = "listQuestion";
            this.listQuestion.Size = new System.Drawing.Size(654, 95);
            this.listQuestion.TabIndex = 3;
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
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.SkyBlue;
            this.labelResult.Location = new System.Drawing.Point(733, 374);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(161, 47);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "label1";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelError
            // 
            this.panelError.BackColor = System.Drawing.Color.Crimson;
            this.panelError.Controls.Add(this.labelError);
            this.panelError.Location = new System.Drawing.Point(1, 527);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(1122, 113);
            this.panelError.TabIndex = 8;
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
            // radioAnswer4
            // 
            this.radioAnswer4.Location = new System.Drawing.Point(6, 200);
            this.radioAnswer4.Name = "radioAnswer4";
            this.radioAnswer4.Size = new System.Drawing.Size(564, 52);
            this.radioAnswer4.TabIndex = 9;
            this.radioAnswer4.Text = "radioButton1";
            this.radioAnswer4.UseVisualStyleBackColor = true;
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
            // radioAnswer2
            // 
            this.radioAnswer2.Location = new System.Drawing.Point(6, 79);
            this.radioAnswer2.Name = "radioAnswer2";
            this.radioAnswer2.Size = new System.Drawing.Size(564, 52);
            this.radioAnswer2.TabIndex = 11;
            this.radioAnswer2.Text = "radioButton1";
            this.radioAnswer2.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(482, 388);
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // groupQuestion
            // 
            this.groupQuestion.Controls.Add(this.radioAnswer1);
            this.groupQuestion.Controls.Add(this.radioAnswer4);
            this.groupQuestion.Controls.Add(this.radioAnswer2);
            this.groupQuestion.Controls.Add(this.radioAnswer3);
            this.groupQuestion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupQuestion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupQuestion.Location = new System.Drawing.Point(209, 113);
            this.groupQuestion.Name = "groupQuestion";
            this.groupQuestion.Size = new System.Drawing.Size(654, 258);
            this.groupQuestion.TabIndex = 12;
            this.groupQuestion.TabStop = false;
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
            // panelCorrect
            // 
            this.panelCorrect.BackColor = System.Drawing.Color.Lime;
            this.panelCorrect.Controls.Add(this.labelCorrect);
            this.panelCorrect.Location = new System.Drawing.Point(1, 524);
            this.panelCorrect.Name = "panelCorrect";
            this.panelCorrect.Size = new System.Drawing.Size(1122, 113);
            this.panelCorrect.TabIndex = 9;
            this.panelCorrect.Visible = false;
            // 
            // labelTimerMin
            // 
            this.labelTimerMin.AutoSize = true;
            this.labelTimerMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimerMin.Location = new System.Drawing.Point(115, 457);
            this.labelTimerMin.Name = "labelTimerMin";
            this.labelTimerMin.Size = new System.Drawing.Size(29, 20);
            this.labelTimerMin.TabIndex = 13;
            this.labelTimerMin.Text = "00";
            // 
            // labelTimerSec
            // 
            this.labelTimerSec.AutoSize = true;
            this.labelTimerSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimerSec.Location = new System.Drawing.Point(150, 457);
            this.labelTimerSec.Name = "labelTimerSec";
            this.labelTimerSec.Size = new System.Drawing.Size(29, 20);
            this.labelTimerSec.TabIndex = 14;
            this.labelTimerSec.Text = "00";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimer.Location = new System.Drawing.Point(139, 457);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(14, 20);
            this.labelTimer.TabIndex = 15;
            this.labelTimer.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(866, 457);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(19, 20);
            this.labelNumber.TabIndex = 17;
            this.labelNumber.Text = "0";
            this.labelNumber.Click += new System.EventHandler(this.labelNumber_Click);
            // 
            // labelSign
            // 
            this.labelSign.AutoSize = true;
            this.labelSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSign.Location = new System.Drawing.Point(910, 457);
            this.labelSign.Name = "labelSign";
            this.labelSign.Size = new System.Drawing.Size(14, 20);
            this.labelSign.TabIndex = 18;
            this.labelSign.Text = "/";
            // 
            // labelNumberOfQuestions
            // 
            this.labelNumberOfQuestions.AutoSize = true;
            this.labelNumberOfQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberOfQuestions.Location = new System.Drawing.Point(939, 457);
            this.labelNumberOfQuestions.Name = "labelNumberOfQuestions";
            this.labelNumberOfQuestions.Size = new System.Drawing.Size(19, 20);
            this.labelNumberOfQuestions.TabIndex = 19;
            this.labelNumberOfQuestions.Text = "0";
            // 
            // FChooseTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1124, 637);
            this.Controls.Add(this.labelNumberOfQuestions);
            this.Controls.Add(this.panelCorrect);
            this.Controls.Add(this.labelSign);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelTimerSec);
            this.Controls.Add(this.labelTimerMin);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.listQuestion);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panelError);
            this.Controls.Add(this.groupQuestion);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FChooseTest";
            this.Text = "Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FChooseTest_FormClosing);
            this.Load += new System.EventHandler(this.FChooseTest_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FChooseTest_KeyPress);
            this.panelError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupQuestion.ResumeLayout(false);
            this.panelCorrect.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListBox listQuestion;
        private System.Windows.Forms.RadioButton radioAnswer1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Panel panelError;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.RadioButton radioAnswer4;
        private System.Windows.Forms.RadioButton radioAnswer3;
        private System.Windows.Forms.RadioButton radioAnswer2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupQuestion;
        private System.Windows.Forms.Label labelCorrect;
        private System.Windows.Forms.Panel panelCorrect;
        private System.Windows.Forms.Label labelTimerMin;
        private System.Windows.Forms.Label labelTimerSec;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelSign;
        private System.Windows.Forms.Label labelNumberOfQuestions;
    }
}