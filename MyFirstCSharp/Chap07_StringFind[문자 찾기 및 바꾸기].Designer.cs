﻿namespace MyFirstCSharp
{
    partial class Chap07_StringFind
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIndexof = new System.Windows.Forms.TextBox();
            this.btnIndexof = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLastIndexof = new System.Windows.Forms.TextBox();
            this.btnLastIndex = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStartWith = new System.Windows.Forms.TextBox();
            this.btnStartWith = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtEndWith = new System.Windows.Forms.TextBox();
            this.btnEndWith = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtContain = new System.Windows.Forms.TextBox();
            this.btnContain = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBefore = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(628, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "동해물과 백두산이 마르고 닳도록 하느님이 보우하사 우리 나라 만세";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIndexof);
            this.groupBox1.Controls.Add(this.btnIndexof);
            this.groupBox1.Location = new System.Drawing.Point(17, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Index of()";
            // 
            // txtIndexof
            // 
            this.txtIndexof.Location = new System.Drawing.Point(9, 25);
            this.txtIndexof.Name = "txtIndexof";
            this.txtIndexof.Size = new System.Drawing.Size(167, 21);
            this.txtIndexof.TabIndex = 1;
            // 
            // btnIndexof
            // 
            this.btnIndexof.Location = new System.Drawing.Point(9, 52);
            this.btnIndexof.Name = "btnIndexof";
            this.btnIndexof.Size = new System.Drawing.Size(167, 41);
            this.btnIndexof.TabIndex = 0;
            this.btnIndexof.Text = "찾기";
            this.btnIndexof.UseVisualStyleBackColor = true;
            this.btnIndexof.Click += new System.EventHandler(this.btnIndexof_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLastIndexof);
            this.groupBox2.Controls.Add(this.btnLastIndex);
            this.groupBox2.Location = new System.Drawing.Point(214, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 101);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Last Index of()";
            // 
            // txtLastIndexof
            // 
            this.txtLastIndexof.Location = new System.Drawing.Point(9, 25);
            this.txtLastIndexof.Name = "txtLastIndexof";
            this.txtLastIndexof.Size = new System.Drawing.Size(167, 21);
            this.txtLastIndexof.TabIndex = 1;
            // 
            // btnLastIndex
            // 
            this.btnLastIndex.Location = new System.Drawing.Point(9, 52);
            this.btnLastIndex.Name = "btnLastIndex";
            this.btnLastIndex.Size = new System.Drawing.Size(167, 41);
            this.btnLastIndex.TabIndex = 0;
            this.btnLastIndex.Text = "찾기";
            this.btnLastIndex.UseVisualStyleBackColor = true;
            this.btnLastIndex.Click += new System.EventHandler(this.btnLastIndex_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtStartWith);
            this.groupBox3.Controls.Add(this.btnStartWith);
            this.groupBox3.Location = new System.Drawing.Point(411, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 101);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "StartWith()";
            // 
            // txtStartWith
            // 
            this.txtStartWith.Location = new System.Drawing.Point(9, 25);
            this.txtStartWith.Name = "txtStartWith";
            this.txtStartWith.Size = new System.Drawing.Size(167, 21);
            this.txtStartWith.TabIndex = 1;
            // 
            // btnStartWith
            // 
            this.btnStartWith.Location = new System.Drawing.Point(9, 52);
            this.btnStartWith.Name = "btnStartWith";
            this.btnStartWith.Size = new System.Drawing.Size(167, 41);
            this.btnStartWith.TabIndex = 0;
            this.btnStartWith.Text = "판단하기";
            this.btnStartWith.UseVisualStyleBackColor = true;
            this.btnStartWith.Click += new System.EventHandler(this.btnStartWith_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtEndWith);
            this.groupBox4.Controls.Add(this.btnEndWith);
            this.groupBox4.Location = new System.Drawing.Point(608, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 101);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "EndWith()";
            // 
            // txtEndWith
            // 
            this.txtEndWith.Location = new System.Drawing.Point(9, 25);
            this.txtEndWith.Name = "txtEndWith";
            this.txtEndWith.Size = new System.Drawing.Size(167, 21);
            this.txtEndWith.TabIndex = 1;
            // 
            // btnEndWith
            // 
            this.btnEndWith.Location = new System.Drawing.Point(9, 52);
            this.btnEndWith.Name = "btnEndWith";
            this.btnEndWith.Size = new System.Drawing.Size(167, 41);
            this.btnEndWith.TabIndex = 0;
            this.btnEndWith.Text = "판단하기";
            this.btnEndWith.UseVisualStyleBackColor = true;
            this.btnEndWith.Click += new System.EventHandler(this.btnEndWith_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtContain);
            this.groupBox5.Controls.Add(this.btnContain);
            this.groupBox5.Location = new System.Drawing.Point(17, 168);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(191, 101);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contains()";
            // 
            // txtContain
            // 
            this.txtContain.Location = new System.Drawing.Point(9, 25);
            this.txtContain.Name = "txtContain";
            this.txtContain.Size = new System.Drawing.Size(167, 21);
            this.txtContain.TabIndex = 1;
            // 
            // btnContain
            // 
            this.btnContain.Location = new System.Drawing.Point(9, 52);
            this.btnContain.Name = "btnContain";
            this.btnContain.Size = new System.Drawing.Size(167, 41);
            this.btnContain.TabIndex = 0;
            this.btnContain.Text = "판단하기";
            this.btnContain.UseVisualStyleBackColor = true;
            this.btnContain.Click += new System.EventHandler(this.btnContain_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtAfter);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.txtBefore);
            this.groupBox6.Controls.Add(this.btnReplace);
            this.groupBox6.Location = new System.Drawing.Point(214, 168);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(585, 101);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Replace()";
            // 
            // txtAfter
            // 
            this.txtAfter.Location = new System.Drawing.Point(305, 25);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.Size = new System.Drawing.Size(110, 21);
            this.txtAfter.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "변경 후 문자열";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "변경 전 문자열";
            // 
            // txtBefore
            // 
            this.txtBefore.Location = new System.Drawing.Point(98, 25);
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.Size = new System.Drawing.Size(110, 21);
            this.txtBefore.TabIndex = 1;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(9, 52);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(167, 41);
            this.btnReplace.TabIndex = 0;
            this.btnReplace.Text = "바꾸기";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // Chap07_StringFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Chap07_StringFind";
            this.Text = "문자열 찾기 및 바꾸기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIndexof;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtIndexof;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLastIndexof;
        private System.Windows.Forms.Button btnLastIndex;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtStartWith;
        private System.Windows.Forms.Button btnStartWith;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtEndWith;
        private System.Windows.Forms.Button btnEndWith;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtContain;
        private System.Windows.Forms.Button btnContain;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtBefore;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAfter;
    }
}