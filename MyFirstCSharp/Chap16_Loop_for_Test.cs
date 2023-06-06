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
    public partial class Chap16_Loop_for_Test : Form
    {
        public Chap16_Loop_for_Test()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string sStart = txtStart.Text;
            string sEnd = txtEnd.Text;
            string sEvenResult = string.Empty;
            string sOddResult = string.Empty;
            int iResult = 0;
            bool bFlagStart = false;
            bool bFlagEnd = false;
            bFlagStart = int.TryParse(sStart, out iResult);
            bFlagEnd = int.TryParse(sEnd, out iResult);
            int iEvenResult = 0;
            int iOddResult = 0;
           

            if (!bFlagStart || !bFlagEnd)
            {
                MessageBox.Show("제대로 된 숫자를 넣어주세요.");
                return;
            }
            if (int.Parse(sStart) > int.Parse(sEnd))
            {
                MessageBox.Show("뒤 숫자를 더 크게 하세요!");
                return;
            }
            for (int i = int.Parse(sStart); i <= int.Parse(sEnd); i++)
            {                
                if (i % 2 ==0)
                {
                    iEvenResult += i;
                    sEvenResult += $"{i} ";

                }
                else
                {
                    iOddResult += i;
                    sOddResult += $"{i} ";
                }
            }
            MessageBox.Show($"짝수 합 : {iEvenResult}, 홀수 합 : {iOddResult}");
            txtEvenResult.Text = sEvenResult;
            txtOddResult.Text = sOddResult;       




        }
    }
}
