
namespace ChildrenApp
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.childToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lessonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxDt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxLesson = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peopleToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.childToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.guardianToolStripMenuItem,
            this.lessonsToolStripMenuItem,
            this.cGToolStripMenuItem,
            this.cLToolStripMenuItem});
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.peopleToolStripMenuItem.Text = "Table";
            // 
            // childToolStripMenuItem
            // 
            this.childToolStripMenuItem.Name = "childToolStripMenuItem";
            this.childToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.childToolStripMenuItem.Text = "Child";
            this.childToolStripMenuItem.Click += new System.EventHandler(this.childToolStripMenuItem_Click);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.teacherToolStripMenuItem.Text = "Teacher";
            this.teacherToolStripMenuItem.Click += new System.EventHandler(this.teacherToolStripMenuItem_Click);
            // 
            // guardianToolStripMenuItem
            // 
            this.guardianToolStripMenuItem.Name = "guardianToolStripMenuItem";
            this.guardianToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.guardianToolStripMenuItem.Text = "Guardian";
            this.guardianToolStripMenuItem.Click += new System.EventHandler(this.guardianToolStripMenuItem_Click);
            // 
            // lessonsToolStripMenuItem
            // 
            this.lessonsToolStripMenuItem.Name = "lessonsToolStripMenuItem";
            this.lessonsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.lessonsToolStripMenuItem.Text = "Lessons";
            this.lessonsToolStripMenuItem.Click += new System.EventHandler(this.lessonsToolStripMenuItem_Click);
            // 
            // cGToolStripMenuItem
            // 
            this.cGToolStripMenuItem.Name = "cGToolStripMenuItem";
            this.cGToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cGToolStripMenuItem.Text = "CG";
            this.cGToolStripMenuItem.Click += new System.EventHandler(this.cGToolStripMenuItem_Click);
            // 
            // cLToolStripMenuItem
            // 
            this.cLToolStripMenuItem.Name = "cLToolStripMenuItem";
            this.cLToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cLToolStripMenuItem.Text = "CL";
            this.cLToolStripMenuItem.Click += new System.EventHandler(this.cLToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.addToolStripMenuItem.Text = "add user";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitProgrammToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitProgrammToolStripMenuItem
            // 
            this.exitProgrammToolStripMenuItem.Name = "exitProgrammToolStripMenuItem";
            this.exitProgrammToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitProgrammToolStripMenuItem.Text = "Exit programm";
            this.exitProgrammToolStripMenuItem.Click += new System.EventHandler(this.exitProgrammToolStripMenuItem_Click);
            // 
            // dtGrid
            // 
            this.dtGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Location = new System.Drawing.Point(12, 41);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.ReadOnly = true;
            this.dtGrid.Size = new System.Drawing.Size(872, 284);
            this.dtGrid.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Select Class Day";
            // 
            // cBoxDt
            // 
            this.cBoxDt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDt.FormattingEnabled = true;
            this.cBoxDt.Items.AddRange(new object[] {
            "",
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.cBoxDt.Location = new System.Drawing.Point(15, 370);
            this.cBoxDt.Name = "cBoxDt";
            this.cBoxDt.Size = new System.Drawing.Size(149, 21);
            this.cBoxDt.TabIndex = 59;
            this.cBoxDt.SelectedIndexChanged += new System.EventHandler(this.cBoxDt_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 341);
            this.label2.MaximumSize = new System.Drawing.Size(150, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 60;
            this.label2.Text = "number of children in the guardian";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "SELECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "pupils attending lessons";
            // 
            // cBoxLesson
            // 
            this.cBoxLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxLesson.FormattingEnabled = true;
            this.cBoxLesson.Location = new System.Drawing.Point(302, 372);
            this.cBoxLesson.Name = "cBoxLesson";
            this.cBoxLesson.Size = new System.Drawing.Size(153, 21);
            this.cBoxLesson.TabIndex = 80;
            this.cBoxLesson.SelectedIndexChanged += new System.EventHandler(this.cBoxLesson_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 342);
            this.label4.MaximumSize = new System.Drawing.Size(210, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "Display Activity Less Than Specified";
            this.label4.UseCompatibleTextRendering = true;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(486, 371);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(65, 20);
            this.txtPrice.TabIndex = 82;
            this.txtPrice.Text = "10";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(557, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 83;
            this.button2.Text = "SELECT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(747, 341);
            this.label5.MaximumSize = new System.Drawing.Size(150, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "Earnings of each teacher";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(771, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 85;
            this.button3.Text = "SELECT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxLesson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxDt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGrid);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem childToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProgrammToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lessonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxDt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxLesson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}

