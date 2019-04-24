namespace Test
{
    partial class FMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.label1 = new System.Windows.Forms.Label();
            this.pdd = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.администраторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupPDD = new System.Windows.Forms.GroupBox();
            this.Back = new System.Windows.Forms.Button();
            this.groupTest = new System.Windows.Forms.GroupBox();
            this.Exam = new System.Windows.Forms.Button();
            this.Training = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupPDD.SuspendLayout();
            this.groupTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Правила Дорожного Движения";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pdd
            // 
            this.pdd.AutoSize = true;
            this.pdd.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pdd.Location = new System.Drawing.Point(107, 16);
            this.pdd.Name = "pdd";
            this.pdd.Size = new System.Drawing.Size(207, 117);
            this.pdd.TabIndex = 1;
            this.pdd.Text = "PDD";
            // 
            // Start
            // 
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.Font = new System.Drawing.Font("Swis721 Hv BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Start.Location = new System.Drawing.Point(332, 247);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(176, 51);
            this.Start.TabIndex = 2;
            this.Start.Text = "Выбрать тест";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Settings
            // 
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Settings.Location = new System.Drawing.Point(332, 328);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(176, 51);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "Настройки";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Exit
            // 
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Location = new System.Drawing.Point(332, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(176, 51);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.администраторToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // администраторToolStripMenuItem
            // 
            this.администраторToolStripMenuItem.Name = "администраторToolStripMenuItem";
            this.администраторToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.администраторToolStripMenuItem.Text = "Администратор";
            this.администраторToolStripMenuItem.Click += new System.EventHandler(this.администраторToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // groupPDD
            // 
            this.groupPDD.Controls.Add(this.pdd);
            this.groupPDD.Controls.Add(this.label1);
            this.groupPDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupPDD.ForeColor = System.Drawing.Color.Black;
            this.groupPDD.Location = new System.Drawing.Point(209, 42);
            this.groupPDD.Name = "groupPDD";
            this.groupPDD.Size = new System.Drawing.Size(429, 177);
            this.groupPDD.TabIndex = 6;
            this.groupPDD.TabStop = false;
            // 
            // Back
            // 
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Location = new System.Drawing.Point(83, 415);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(176, 51);
            this.Back.TabIndex = 7;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Visible = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // groupTest
            // 
            this.groupTest.Controls.Add(this.Exam);
            this.groupTest.Controls.Add(this.Training);
            this.groupTest.Location = new System.Drawing.Point(300, 125);
            this.groupTest.Name = "groupTest";
            this.groupTest.Size = new System.Drawing.Size(245, 241);
            this.groupTest.TabIndex = 11;
            this.groupTest.TabStop = false;
            this.groupTest.Visible = false;
            // 
            // Exam
            // 
            this.Exam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exam.Font = new System.Drawing.Font("Swis721 Hv BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exam.Location = new System.Drawing.Point(27, 137);
            this.Exam.Name = "Exam";
            this.Exam.Size = new System.Drawing.Size(176, 51);
            this.Exam.TabIndex = 9;
            this.Exam.Text = "Экзамен";
            this.Exam.UseVisualStyleBackColor = true;
            this.Exam.Click += new System.EventHandler(this.Exam_Click);
            // 
            // Training
            // 
            this.Training.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Training.Font = new System.Drawing.Font("Swis721 Hv BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Training.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Training.Location = new System.Drawing.Point(27, 48);
            this.Training.Name = "Training";
            this.Training.Size = new System.Drawing.Size(176, 51);
            this.Training.TabIndex = 8;
            this.Training.Text = "Тренировка";
            this.Training.UseVisualStyleBackColor = true;
            this.Training.Click += new System.EventHandler(this.Training_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(844, 491);
            this.Controls.Add(this.groupTest);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupPDD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMain";
            this.Text = "PDD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupPDD.ResumeLayout(false);
            this.groupPDD.PerformLayout();
            this.groupTest.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pdd;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem администраторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupPDD;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.GroupBox groupTest;
        private System.Windows.Forms.Button Exam;
        private System.Windows.Forms.Button Training;
    }
}

