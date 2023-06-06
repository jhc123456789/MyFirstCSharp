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
    public partial class Chap14_Switch_Test : Form
    {
        int AppleCount = 0;
        int MCount = 0;
        int WMCount = 0;

        public Chap14_Switch_Test()
        {
            InitializeComponent();
        }

        private void btnAppleOrder_Click(object sender, EventArgs e)
        {
            string sValue = lblAppleCnt.Text;
            int iValue = int.Parse(sValue);
            lblAppleCnt.Text = (iValue - 1).ToString();
            AppleCount = AppleCount + 1;
            if (iValue < 1)
            {
                MessageBox.Show("주문할 수 없습니다.");
                return;
            }

        }

        private void btnMelonOrder_Click(object sender, EventArgs e)
        {
            string sValue = lblMelonCnt.Text;
            int iValue = int.Parse(sValue);
            lblMelonCnt.Text = (iValue - 1).ToString();
            MCount = MCount + 1;
            if (iValue < 1)
            {
                MessageBox.Show("주문할 수 없습니다.");
                return;
            }
        }

        private void btnWMOrder_Click(object sender, EventArgs e)
        {
            string sValue = lblWMCnt.Text;
            int iValue = int.Parse(sValue);
            lblWMCnt.Text = (iValue - 1).ToString();
            WMCount = WMCount + 1;
            if (iValue < 1)
            {
                MessageBox.Show("주문할 수 없습니다.");
                return;
            }

        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            int Total = 2000 * AppleCount + 2500 * MCount + 18000 * WMCount;
            MessageBox.Show($"총 결제금액은 {Total}원 입니다.");
        }


    }
}
