namespace MyFirstCSharp
{
    partial class Chap11_BranchingStatement
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
            this.txtBS = new System.Windows.Forms.TextBox();
            this.btnIF = new System.Windows.Forms.Button();
            this.btnInIF = new System.Windows.Forms.Button();
            this.btnelseIF = new System.Windows.Forms.Button();
            this.btnAndIF = new System.Windows.Forms.Button();
            this.btnOrIF = new System.Windows.Forms.Button();
            this.btnBoolIF = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnOE = new System.Windows.Forms.Button();
            this.btnTernaryOperator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBS
            // 
            this.txtBS.Location = new System.Drawing.Point(12, 12);
            this.txtBS.Name = "txtBS";
            this.txtBS.Size = new System.Drawing.Size(133, 21);
            this.txtBS.TabIndex = 0;
            // 
            // btnIF
            // 
            this.btnIF.Location = new System.Drawing.Point(12, 39);
            this.btnIF.Name = "btnIF";
            this.btnIF.Size = new System.Drawing.Size(133, 61);
            this.btnIF.TabIndex = 1;
            this.btnIF.Text = "IF";
            this.btnIF.UseVisualStyleBackColor = true;
            this.btnIF.Click += new System.EventHandler(this.btnIF_Click);
            // 
            // btnInIF
            // 
            this.btnInIF.Location = new System.Drawing.Point(151, 39);
            this.btnInIF.Name = "btnInIF";
            this.btnInIF.Size = new System.Drawing.Size(133, 61);
            this.btnInIF.TabIndex = 2;
            this.btnInIF.Text = "In IF";
            this.btnInIF.UseVisualStyleBackColor = true;
            this.btnInIF.Click += new System.EventHandler(this.btnInIF_Click);
            // 
            // btnelseIF
            // 
            this.btnelseIF.Location = new System.Drawing.Point(290, 39);
            this.btnelseIF.Name = "btnelseIF";
            this.btnelseIF.Size = new System.Drawing.Size(133, 61);
            this.btnelseIF.TabIndex = 3;
            this.btnelseIF.Text = "else IF";
            this.btnelseIF.UseVisualStyleBackColor = true;
            this.btnelseIF.Click += new System.EventHandler(this.btnelseIF_Click);
            // 
            // btnAndIF
            // 
            this.btnAndIF.Location = new System.Drawing.Point(12, 106);
            this.btnAndIF.Name = "btnAndIF";
            this.btnAndIF.Size = new System.Drawing.Size(133, 61);
            this.btnAndIF.TabIndex = 4;
            this.btnAndIF.Text = "And IF";
            this.btnAndIF.UseVisualStyleBackColor = true;
            this.btnAndIF.Click += new System.EventHandler(this.btnAndIF_Click);
            // 
            // btnOrIF
            // 
            this.btnOrIF.Location = new System.Drawing.Point(151, 106);
            this.btnOrIF.Name = "btnOrIF";
            this.btnOrIF.Size = new System.Drawing.Size(133, 61);
            this.btnOrIF.TabIndex = 5;
            this.btnOrIF.Text = "Or IF";
            this.btnOrIF.UseVisualStyleBackColor = true;
            this.btnOrIF.Click += new System.EventHandler(this.btnOrIF_Click);
            // 
            // btnBoolIF
            // 
            this.btnBoolIF.Location = new System.Drawing.Point(290, 106);
            this.btnBoolIF.Name = "btnBoolIF";
            this.btnBoolIF.Size = new System.Drawing.Size(133, 61);
            this.btnBoolIF.TabIndex = 6;
            this.btnBoolIF.Text = "Bool IF";
            this.btnBoolIF.UseVisualStyleBackColor = true;
            this.btnBoolIF.Click += new System.EventHandler(this.btnBoolIF_Click);
            // 
            // btnPM
            // 
            this.btnPM.Location = new System.Drawing.Point(12, 173);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(133, 61);
            this.btnPM.TabIndex = 7;
            this.btnPM.Text = "음수/양수 판단";
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnOE
            // 
            this.btnOE.Location = new System.Drawing.Point(151, 173);
            this.btnOE.Name = "btnOE";
            this.btnOE.Size = new System.Drawing.Size(133, 61);
            this.btnOE.TabIndex = 8;
            this.btnOE.Text = "홀수 / 짝수 판단";
            this.btnOE.UseVisualStyleBackColor = true;
            this.btnOE.Click += new System.EventHandler(this.btnOE_Click);
            // 
            // btnTernaryOperator
            // 
            this.btnTernaryOperator.Location = new System.Drawing.Point(290, 173);
            this.btnTernaryOperator.Name = "btnTernaryOperator";
            this.btnTernaryOperator.Size = new System.Drawing.Size(133, 61);
            this.btnTernaryOperator.TabIndex = 9;
            this.btnTernaryOperator.Text = "삼항 연산자";
            this.btnTernaryOperator.UseVisualStyleBackColor = true;
            this.btnTernaryOperator.Click += new System.EventHandler(this.btnTernaryOperator_Click);
            // 
            // Chap11_BranchingStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 503);
            this.Controls.Add(this.btnTernaryOperator);
            this.Controls.Add(this.btnOE);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btnBoolIF);
            this.Controls.Add(this.btnOrIF);
            this.Controls.Add(this.btnAndIF);
            this.Controls.Add(this.btnelseIF);
            this.Controls.Add(this.btnInIF);
            this.Controls.Add(this.btnIF);
            this.Controls.Add(this.txtBS);
            this.Name = "Chap11_BranchingStatement";
            this.Text = "분기문 학습하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBS;
        private System.Windows.Forms.Button btnIF;
        private System.Windows.Forms.Button btnInIF;
        private System.Windows.Forms.Button btnelseIF;
        private System.Windows.Forms.Button btnAndIF;
        private System.Windows.Forms.Button btnOrIF;
        private System.Windows.Forms.Button btnBoolIF;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnOE;
        private System.Windows.Forms.Button btnTernaryOperator;
    }
}