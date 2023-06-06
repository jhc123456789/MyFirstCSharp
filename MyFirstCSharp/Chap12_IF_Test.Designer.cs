
namespace MyFirstCSharp
{
    partial class Chap12_IF_Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chap12_IF_Test));
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCM = new System.Windows.Forms.Button();
            this.txtMultiply = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "입력받을 값";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(187, 20);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(154, 21);
            this.txtInput.TabIndex = 1;
            // 
            // btnCM
            // 
            this.btnCM.Location = new System.Drawing.Point(361, 12);
            this.btnCM.Name = "btnCM";
            this.btnCM.Size = new System.Drawing.Size(158, 42);
            this.btnCM.TabIndex = 2;
            this.btnCM.Text = "2, 5의 공배수 인지 판단";
            this.btnCM.UseVisualStyleBackColor = true;
            this.btnCM.Click += new System.EventHandler(this.btnCM_Click);
            // 
            // txtMultiply
            // 
            this.txtMultiply.Location = new System.Drawing.Point(187, 64);
            this.txtMultiply.Name = "txtMultiply";
            this.txtMultiply.Size = new System.Drawing.Size(154, 21);
            this.txtMultiply.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "8의 배수 일 경우 값과의 곱";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(187, 104);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(154, 21);
            this.txtTotal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "버튼을 클릭한 총 횟수";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 144);
            this.label4.TabIndex = 7;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // Chap12_IF_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMultiply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCM);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Chap12_IF_Test";
            this.Text = "분기문 IF 실습";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCM;
        private System.Windows.Forms.TextBox txtMultiply;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}