﻿
namespace MyFirstCSharp
{
    partial class Chap19_Foreach_Test
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtForeach = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "1     2     3     4\r\n5     6     7     8 \r\n9     10   11   12\r\n\r\n위 3*4 배열을 만들고\r\nF" +
    "oreach 기능을 이용하여 데이터 추출 후\r\n텍스트박스에 같은 배치로 표현하세요.]";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(27, 114);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(225, 68);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "2차원 배열 Foreach로 표현하기";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtForeach
            // 
            this.txtForeach.Location = new System.Drawing.Point(27, 188);
            this.txtForeach.Multiline = true;
            this.txtForeach.Name = "txtForeach";
            this.txtForeach.Size = new System.Drawing.Size(225, 211);
            this.txtForeach.TabIndex = 2;
            // 
            // Chap19_Foreach_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtForeach);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label1);
            this.Name = "Chap19_Foreach_Test";
            this.Text = "배열 표현하기 Foreach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtForeach;
    }
}