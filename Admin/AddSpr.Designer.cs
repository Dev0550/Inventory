namespace Admin
{
    partial class AddSpr
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_department = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_post = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_department.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_post.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(440, 49);
            this.simpleButton1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 32);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Дохилкунӣ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_department);
            this.groupBox5.Location = new System.Drawing.Point(28, 35);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(388, 51);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Шӯъба";
            // 
            // txt_department
            // 
            this.txt_department.Location = new System.Drawing.Point(17, 18);
            this.txt_department.Name = "txt_department";
            this.txt_department.Properties.AutoHeight = false;
            this.txt_department.Size = new System.Drawing.Size(355, 24);
            this.txt_department.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_post);
            this.groupBox1.Location = new System.Drawing.Point(28, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 51);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вазифа";
            // 
            // txt_post
            // 
            this.txt_post.Location = new System.Drawing.Point(17, 17);
            this.txt_post.Name = "txt_post";
            this.txt_post.Properties.AutoHeight = false;
            this.txt_post.Size = new System.Drawing.Size(355, 24);
            this.txt_post.TabIndex = 5;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(440, 114);
            this.simpleButton2.LookAndFeel.SkinName = "Office 2010 Blue";
            this.simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(119, 32);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Дохилкунӣ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(452, 213);
            this.simpleButton3.LookAndFeel.SkinName = "Office 2010 Blue";
            this.simpleButton3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(119, 32);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "Баромад";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.simpleButton2);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 187);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Формаи дохилкуни";
            // 
            // AddSpr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 258);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.groupBox2);
            this.Name = "AddSpr";
            this.Text = "Inventory - Бақайдгирии шӯъба ва вазифахои нав";
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_department.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_post.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraEditors.TextEdit txt_department;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txt_post;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}