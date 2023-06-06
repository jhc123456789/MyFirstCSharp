
namespace MyFirstCSharp
{
    partial class Chap16_Loop_for_Test
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEvenResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOddResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "입력받은 범위의 수 중\r\n짝수의 합과 홀수의 합을 구하여 메세지 박스로 표현(짝수 합 : ?, 홀수 합 : ?)\r\n범위 안에 있는 모든 짝수와 홀" +
    "수를 아래의 텍스트박스에 표현하세요.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "입력값";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(60, 84);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(89, 21);
            this.txtStart.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "~";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(175, 84);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(89, 21);
            this.txtEnd.TabIndex = 4;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(60, 114);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(204, 62);
            this.btnResult.TabIndex = 5;
            this.btnResult.Text = "짝수 홀수 합 표현하기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "범위 안에 짝수";
            // 
            // txtEvenResult
            // 
            this.txtEvenResult.Location = new System.Drawing.Point(15, 219);
            this.txtEvenResult.Name = "txtEvenResult";
            this.txtEvenResult.Size = new System.Drawing.Size(624, 21);
            this.txtEvenResult.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "범위 안에 홀수";
            // 
            // txtOddResult
            // 
            this.txtOddResult.Location = new System.Drawing.Point(12, 268);
            this.txtOddResult.Name = "txtOddResult";
            this.txtOddResult.Size = new System.Drawing.Size(624, 21);
            this.txtOddResult.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "* 입력 범위는 숫자만 입력 가능\r\n* 시작 숫자가 종료 숫자보다 크거나 같을 수 없다.\r\n* 벨리데이션 체크의 결과를 메세지박스로 표현";
            // 
            // Chap16_Loop_for_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOddResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEvenResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Chap16_Loop_for_Test";
            this.Text = "짝수 홀수 합 표현하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEvenResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOddResult;
        private System.Windows.Forms.Label label6;
    }
}