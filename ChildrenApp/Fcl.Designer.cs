
namespace ChildrenApp
{
    partial class Fcl
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
            this.cBoxCNm = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxLesson = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.cBoxChildren = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxCNm
            // 
            this.cBoxCNm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCNm.FormattingEnabled = true;
            this.cBoxCNm.Location = new System.Drawing.Point(653, 21);
            this.cBoxCNm.Name = "cBoxCNm";
            this.cBoxCNm.Size = new System.Drawing.Size(102, 21);
            this.cBoxCNm.TabIndex = 83;
            this.cBoxCNm.SelectedIndexChanged += new System.EventHandler(this.cBoxCNm_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(650, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "CHILDREN NAME";
            // 
            // cBoxLesson
            // 
            this.cBoxLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxLesson.FormattingEnabled = true;
            this.cBoxLesson.Location = new System.Drawing.Point(172, 21);
            this.cBoxLesson.Name = "cBoxLesson";
            this.cBoxLesson.Size = new System.Drawing.Size(163, 21);
            this.cBoxLesson.TabIndex = 79;
            this.cBoxLesson.SelectedIndexChanged += new System.EventHandler(this.cBoxLesson_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "LESSON";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(101, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 77;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(679, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 76;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 75;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcID
            // 
            this.txtcID.Location = new System.Drawing.Point(97, 22);
            this.txtcID.Name = "txtcID";
            this.txtcID.ReadOnly = true;
            this.txtcID.Size = new System.Drawing.Size(60, 20);
            this.txtcID.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "C_ID";
            // 
            // txtlID
            // 
            this.txtlID.Location = new System.Drawing.Point(18, 22);
            this.txtlID.Name = "txtlID";
            this.txtlID.ReadOnly = true;
            this.txtlID.Size = new System.Drawing.Size(60, 20);
            this.txtlID.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "L_ID";
            // 
            // dtGrid
            // 
            this.dtGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Location = new System.Drawing.Point(18, 57);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.ReadOnly = true;
            this.dtGrid.Size = new System.Drawing.Size(736, 266);
            this.dtGrid.TabIndex = 70;
            // 
            // cBoxChildren
            // 
            this.cBoxChildren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxChildren.FormattingEnabled = true;
            this.cBoxChildren.Location = new System.Drawing.Point(517, 21);
            this.cBoxChildren.Name = "cBoxChildren";
            this.cBoxChildren.Size = new System.Drawing.Size(116, 21);
            this.cBoxChildren.TabIndex = 85;
            this.cBoxChildren.SelectedIndexChanged += new System.EventHandler(this.cBoxChildren_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "CHILDREN SURNAME";
            // 
            // Fcl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 358);
            this.Controls.Add(this.cBoxChildren);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxCNm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBoxLesson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Fcl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fcl";
            this.Load += new System.EventHandler(this.Fcl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cBoxCNm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxLesson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.ComboBox cBoxChildren;
        private System.Windows.Forms.Label label4;
    }
}