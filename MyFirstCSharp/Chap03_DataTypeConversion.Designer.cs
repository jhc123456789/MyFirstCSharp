﻿namespace MyFirstCSharp
{
    partial class Chap03_DataTypeConversion
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
            this.btnItoS = new System.Windows.Forms.Button();
            this.btnStoI = new System.Windows.Forms.Button();
            this.btnNull = new System.Windows.Forms.Button();
            this.btnSUM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnItoS
            // 
            this.btnItoS.Location = new System.Drawing.Point(12, 12);
            this.btnItoS.Name = "btnItoS";
            this.btnItoS.Size = new System.Drawing.Size(119, 45);
            this.btnItoS.TabIndex = 0;
            this.btnItoS.Text = "숫자 -> 문자";
            this.btnItoS.UseVisualStyleBackColor = true;
            this.btnItoS.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStoI
            // 
            this.btnStoI.Location = new System.Drawing.Point(137, 12);
            this.btnStoI.Name = "btnStoI";
            this.btnStoI.Size = new System.Drawing.Size(119, 45);
            this.btnStoI.TabIndex = 1;
            this.btnStoI.Text = "문자 -> 숫자";
            this.btnStoI.UseVisualStyleBackColor = true;
            this.btnStoI.Click += new System.EventHandler(this.btnStoI_Click);
            // 
            // btnNull
            // 
            this.btnNull.Location = new System.Drawing.Point(262, 12);
            this.btnNull.Name = "btnNull";
            this.btnNull.Size = new System.Drawing.Size(119, 44);
            this.btnNull.TabIndex = 2;
            this.btnNull.Text = "Null 변환 처리";
            this.btnNull.UseVisualStyleBackColor = true;
            this.btnNull.Click += new System.EventHandler(this.btnNull_Click);
            // 
            // btnSUM
            // 
            this.btnSUM.Location = new System.Drawing.Point(387, 12);
            this.btnSUM.Name = "btnSUM";
            this.btnSUM.Size = new System.Drawing.Size(119, 45);
            this.btnSUM.TabIndex = 3;
            this.btnSUM.Text = "SUM";
            this.btnSUM.UseVisualStyleBackColor = true;
            this.btnSUM.Click += new System.EventHandler(this.btnSUM_Click);
            // 
            // Chap03_DataTypeConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 229);
            this.Controls.Add(this.btnSUM);
            this.Controls.Add(this.btnNull);
            this.Controls.Add(this.btnStoI);
            this.Controls.Add(this.btnItoS);
            this.Name = "Chap03_DataTypeConversion";
            this.Text = "Chap03_DataTypeConversion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnItoS;
        private System.Windows.Forms.Button btnStoI;
        private System.Windows.Forms.Button btnNull;
        private System.Windows.Forms.Button btnSUM;
    }
}