using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap12_IF_Test : Form
    {
        public Chap12_IF_Test()
        {
            InitializeComponent();
        }
        int ClickCount = 0;

        private void btnCM_Click(object sender, EventArgs e)
        {
            string sValue = txtInput.Text;
            int iResult = 0;
            bool bFlag = false;
            bFlag = int.TryParse(sValue, out iResult);
            ClickCount = ClickCount + 1;
            txtTotal.Text = ClickCount.ToString();

            if (!bFlag)
            {
                MessageBox.Show("제대로 된 숫자를 넣어주세요.");
                return;
            }
            if (iResult % 2 == 0 && iResult % 5 ==0)
            {
                MessageBox.Show("2, 5 공배수입니다.");
            }
            if (iResult % 8 ==0)
            {
                txtMultiply.Text = (iResult * 8).ToString();
            }
            else
            {
                MessageBox.Show("2, 5 공배수가 아닙니다.");
            }

        }
    }
}
