
namespace MyFirstCSharp
{
    partial class Chap17_MatrixTest
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
            this.btnCH = new System.Windows.Forms.Button();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "아래의 2,4 배열을 만들고\r\n1행과 2행을 바꾸어 새로운 배열에 담아 \r\n배열의 결과를 텍스트박스에 표현하세요.\r\n\r\n[1, 2, 3, 4   " +
    " => [5, 6, 7, 8\r\n 5, 6, 7, 8]         1, 2, 3, 4]";
            // 
            // btnCH
            // 
            this.btnCH.Location = new System.Drawing.Point(16, 136);
            this.btnCH.Name = "btnCH";
            this.btnCH.Size = new System.Drawing.Size(262, 65);
            this.btnCH.TabIndex = 1;
            this.btnCH.Text = "변경하기";
            this.btnCH.UseVisualStyleBackColor = true;
            this.btnCH.Click += new System.EventHandler(this.btnCH_Click);
            // 
            // txtMatrix
            // 
            this.txtMatrix.Location = new System.Drawing.Point(12, 207);
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.Size = new System.Drawing.Size(266, 144);
            this.txtMatrix.TabIndex = 2;
            // 
            // Chap17_MatrixTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMatrix);
            this.Controls.Add(this.btnCH);
            this.Controls.Add(this.label1);
            this.Name = "Chap17_MatrixTest";
            this.Text = "배열실습";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCH;
        private System.Windows.Forms.TextBox txtMatrix;
    }
}