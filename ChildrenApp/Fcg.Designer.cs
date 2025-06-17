
namespace ChildrenApp
{
    partial class Fcg
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
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.txtcID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtgID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxChildren = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxGuardian = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxCNm = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxGNm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrid
            // 
            this.dtGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Location = new System.Drawing.Point(12, 57);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.ReadOnly = true;
            this.dtGrid.Size = new System.Drawing.Size(681, 245);
            this.dtGrid.TabIndex = 54;
            // 
            // txtcID
            // 
            this.txtcID.Location = new System.Drawing.Point(12, 22);
            this.txtcID.Name = "txtcID";
            this.txtcID.ReadOnly = true;
            this.txtcID.Size = new System.Drawing.Size(60, 20);
            this.txtcID.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "C_ID";
            // 
            // txtgID
            // 
            this.txtgID.Location = new System.Drawing.Point(91, 22);
            this.txtgID.Name = "txtgID";
            this.txtgID.ReadOnly = true;
            this.txtgID.Size = new System.Drawing.Size(60, 20);
            this.txtgID.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "G_ID";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(95, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 61;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 60;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "CHILDREN SURNAME";
            // 
            // cBoxChildren
            // 
            this.cBoxChildren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxChildren.FormattingEnabled = true;
            this.cBoxChildren.Location = new System.Drawing.Point(166, 21);
            this.cBoxChildren.Name = "cBoxChildren";
            this.cBoxChildren.Size = new System.Drawing.Size(116, 21);
            this.cBoxChildren.TabIndex = 63;
            this.cBoxChildren.SelectedIndexChanged += new System.EventHandler(this.cBoxChildren_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "GUARDIAN SURNAME";
            // 
            // cBoxGuardian
            // 
            this.cBoxGuardian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxGuardian.FormattingEnabled = true;
            this.cBoxGuardian.Location = new System.Drawing.Point(460, 22);
            this.cBoxGuardian.Name = "cBoxGuardian";
            this.cBoxGuardian.Size = new System.Drawing.Size(118, 21);
            this.cBoxGuardian.TabIndex = 65;
            this.cBoxGuardian.SelectedIndexChanged += new System.EventHandler(this.cBoxGuardian_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "CHILDREN NAME";
            // 
            // cBoxCNm
            // 
            this.cBoxCNm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCNm.FormattingEnabled = true;
            this.cBoxCNm.Location = new System.Drawing.Point(291, 21);
            this.cBoxCNm.Name = "cBoxCNm";
            this.cBoxCNm.Size = new System.Drawing.Size(102, 21);
            this.cBoxCNm.TabIndex = 67;
            this.cBoxCNm.SelectedIndexChanged += new System.EventHandler(this.cBoxCNm_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "GUARDIAN  NAME";
            // 
            // cBoxGNm
            // 
            this.cBoxGNm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxGNm.FormattingEnabled = true;
            this.cBoxGNm.Location = new System.Drawing.Point(593, 22);
            this.cBoxGNm.Name = "cBoxGNm";
            this.cBoxGNm.Size = new System.Drawing.Size(102, 21);
            this.cBoxGNm.TabIndex = 69;
            this.cBoxGNm.SelectedIndexChanged += new System.EventHandler(this.cBoxGNm_SelectedIndexChanged);
            // 
            // Fcg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 339);
            this.Controls.Add(this.cBoxGNm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBoxCNm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBoxGuardian);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxChildren);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtgID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Fcg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fcg";
            this.Load += new System.EventHandler(this.Fcg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.TextBox txtcID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxChildren;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxGuardian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxCNm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBoxGNm;
    }
}