namespace MyFirstCSharp
{
    partial class Chap09_StringManage_Test
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
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnLength = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtBefore = new System.Windows.Forms.TextBox();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.txtTrim = new System.Windows.Forms.TextBox();
            this.txtLower = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1186, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "안녕하세요 2023 제조혁신 인재양성 S/W 개발 교육과정을 이수하게 된 OOO  입니다. 즐겁고 보람찬 DIGITALTRANING 교육이 되었으" +
    "면 합니다.";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(17, 70);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(218, 56);
            this.btnReplace.TabIndex = 1;
            this.btnReplace.Text = "OOO -> 본인 이름으로 변경\r\n* 라벨 TEXT에 직접 변경해서 표현";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnLength
            // 
            this.btnLength.Location = new System.Drawing.Point(241, 70);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(191, 56);
            this.btnLength.TabIndex = 2;
            this.btnLength.Text = "S/W의 위치 찾고 메세지박스\r\n*구현은 In Line으로";
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(438, 70);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(215, 56);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "시작 단어와 마지막 단어 각각 1자씩 메세지로 표현";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(659, 70);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(175, 56);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "타이틀 문자열의 앞, 뒤에 \"-DT-\" 문자열 삽입\r\n* 라벨 TEXT에 직접 표현";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(840, 70);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(224, 56);
            this.btnLower.TabIndex = 5;
            this.btnLower.Text = "DIGITALTRAINING만 소문자로 변경\r\n* DIGITALTRAINING 문자는 고정\r\n* 라벨 TEXT에 직접 표현";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1070, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(222, 56);
            this.button6.TabIndex = 6;
            this.button6.Text = "타이틀의 문자열의 모든 공백 없애기\r\n*라벨 TEXT에 직접 표현";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtBefore
            // 
            this.txtBefore.Location = new System.Drawing.Point(106, 132);
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.Size = new System.Drawing.Size(129, 21);
            this.txtBefore.TabIndex = 7;
            // 
            // txtAfter
            // 
            this.txtAfter.Location = new System.Drawing.Point(106, 159);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.Size = new System.Drawing.Size(129, 21);
            this.txtAfter.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "변경 전 문자열";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "변경 후 문자열";
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(663, 143);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(170, 21);
            this.txtInsert.TabIndex = 11;
            // 
            // txtTrim
            // 
            this.txtTrim.Location = new System.Drawing.Point(1095, 143);
            this.txtTrim.Name = "txtTrim";
            this.txtTrim.Size = new System.Drawing.Size(170, 21);
            this.txtTrim.TabIndex = 12;
            // 
            // txtLower
            // 
            this.txtLower.Location = new System.Drawing.Point(868, 143);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(174, 21);
            this.txtLower.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1278, 52);
            this.button1.TabIndex = 14;
            this.button1.Text = "원본 문자열 되돌리기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Chap09_StringManage_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLower);
            this.Controls.Add(this.txtTrim);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAfter);
            this.Controls.Add(this.txtBefore);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnLength);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.lblTitle);
            this.Name = "Chap09_StringManage_Test";
            this.Text = "문자열 다루기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnLength;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtBefore;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.TextBox txtTrim;
        private System.Windows.Forms.TextBox txtLower;
        private System.Windows.Forms.Button button1;
    }
}