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
    public partial class Chap14_Switch_Test_T : Form
    {
        // 총 구매 금액
        int iTotalPrice = 0;
                
        public Chap14_Switch_Test_T()
        {
            InitializeComponent();
        }

        private void btnAppleOrder_Click(object sender, EventArgs e)
        {
            // 사과주문에 대한 기능

            int iAppleCnt = Convert.ToInt32(lblAppleCnt.Text);
            if (iAppleCnt == 0)
            {
                MessageBox.Show("사과의 재고 수량이 0개입니다. 주문할 수 없습니다.");
                return; // 현재 사과주문 버튼의 로직 종료
            }

            // 재고 수량 차감
            //iAppleCnt -= 1;
            --iAppleCnt;
            lblAppleCnt.Text = iAppleCnt.ToString();

            // 총 구매 금액에 사과 금액 누적
            iTotalPrice += 2000;
        }

        private void btnMelonOrder_Click(object sender, EventArgs e)
        {
            // 참외주문 버튼 클릭 로직

            // 참외의 현재 재고 수량
            int iMelonCnt = Convert.ToInt32(lblMelonCnt.Text);
            if (iMelonCnt == 0)
            {
                MessageBox.Show("참외의 재고 수량이 0개입니다. 주문할 수 없습니다.");
                return;
            }

            // 참외 재고 차감            
            lblMelonCnt.Text = (--iMelonCnt).ToString();

            // 참외 주문 금액 누적
            iTotalPrice += 2500;
        }

        private void btnWMOrder_Click(object sender, EventArgs e)
        {
            // 수박주문 버튼 클릭 로직

            // 수박의 재로 수량
            int iWmCnt = Convert.ToInt32(lblWMCnt.Text);
            if (iWmCnt == 0)
            {
                MessageBox.Show("수박의 재고 수량이 0개입니다. 주문할 수 없습니다.");
                return;
            }

            // 수박 재고 차감            
            lblWMCnt.Text = (--iWmCnt).ToString();

            // 수박 주문 금액 누적
            iTotalPrice += 18000;
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 결제 금액은 {iTotalPrice}입니다.");
        }
    }
}
