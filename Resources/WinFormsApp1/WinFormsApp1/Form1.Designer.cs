﻿
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstControl1 = new WinFormsApp1.FirstControl();
            this.firstControl2 = new WinFormsApp1.FirstControl();
            this.secondControl1 = new WinFormsApp1.SecondControl();
            this.thirdControl1 = new WinFormsApp1.ThirdControl();
            this.fourthControl1 = new WinFormsApp1.FourthControl();
            this.fifthControl1 = new WinFormsApp1.FifthControl();
            this.sixthControl1 = new WinFormsApp1.SixthControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 566);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.ForestGreen;
            this.SidePanel.Location = new System.Drawing.Point(0, 45);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(25, 60);
            this.SidePanel.TabIndex = 4;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(31, 291);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 60);
            this.button6.TabIndex = 8;
            this.button6.Text = "  FEATURES";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(31, 455);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 60);
            this.button5.TabIndex = 7;
            this.button5.Text = "  ABOUT";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(31, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 60);
            this.button4.TabIndex = 6;
            this.button4.Text = "  SIGN IN";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(31, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "  SIGN UP";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(31, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 60);
            this.button3.TabIndex = 5;
            this.button3.Text = "MATERIAL";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(31, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "  HOME";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(162, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 27);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(1039, 33);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(34, 42);
            this.button8.TabIndex = 8;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(835, 33);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(38, 42);
            this.button10.TabIndex = 10;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(999, 33);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(34, 42);
            this.button11.TabIndex = 11;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(879, 33);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(34, 42);
            this.button7.TabIndex = 12;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(919, 33);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(34, 42);
            this.button12.TabIndex = 13;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(670, 277);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(339, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "EducationMania By ~DayNightCoders";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // firstControl1
            // 
            this.firstControl1.Location = new System.Drawing.Point(162, 174);
            this.firstControl1.Name = "firstControl1";
            this.firstControl1.Size = new System.Drawing.Size(938, 392);
            this.firstControl1.TabIndex = 16;
            this.firstControl1.Load += new System.EventHandler(this.firstControl1_Load);
            // 
            // firstControl2
            // 
            this.firstControl2.Location = new System.Drawing.Point(539, 84);
            this.firstControl2.Name = "firstControl2";
            this.firstControl2.Size = new System.Drawing.Size(8, 8);
            this.firstControl2.TabIndex = 17;
            // 
            // secondControl1
            // 
            this.secondControl1.Location = new System.Drawing.Point(162, 160);
            this.secondControl1.Name = "secondControl1";
            this.secondControl1.Size = new System.Drawing.Size(947, 406);
            this.secondControl1.TabIndex = 18;
            // 
            // thirdControl1
            // 
            this.thirdControl1.Location = new System.Drawing.Point(177, 160);
            this.thirdControl1.Name = "thirdControl1";
            this.thirdControl1.Size = new System.Drawing.Size(964, 418);
            this.thirdControl1.TabIndex = 19;
            // 
            // fourthControl1
            // 
            this.fourthControl1.Location = new System.Drawing.Point(162, 151);
            this.fourthControl1.Name = "fourthControl1";
            this.fourthControl1.Size = new System.Drawing.Size(1008, 458);
            this.fourthControl1.TabIndex = 20;
            // 
            // fifthControl1
            // 
            this.fifthControl1.Location = new System.Drawing.Point(162, 151);
            this.fifthControl1.Name = "fifthControl1";
            this.fifthControl1.Size = new System.Drawing.Size(926, 411);
            this.fifthControl1.TabIndex = 21;
            // 
            // sixthControl1
            // 
            this.sixthControl1.Location = new System.Drawing.Point(162, 160);
            this.sixthControl1.Name = "sixthControl1";
            this.sixthControl1.Size = new System.Drawing.Size(1172, 505);
            this.sixthControl1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 566);
            this.Controls.Add(this.sixthControl1);
            this.Controls.Add(this.fifthControl1);
            this.Controls.Add(this.fourthControl1);
            this.Controls.Add(this.thirdControl1);
            this.Controls.Add(this.secondControl1);
            this.Controls.Add(this.firstControl2);
            this.Controls.Add(this.firstControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private FirstControl firstControl1;
        private FirstControl firstControl2;
        private SecondControl secondControl1;
        private ThirdControl thirdControl1;
        private FourthControl fourthControl1;
        private FifthControl fifthControl1;
        private SixthControl sixthControl1;
    }
}

