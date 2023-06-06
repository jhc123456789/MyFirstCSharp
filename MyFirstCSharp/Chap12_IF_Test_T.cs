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
    public partial class Chap12_IF_Test_T : Form
    {
        // 버큰 클릭의 누적 횟수를 담는 변수 (클래스 Chap12_IF_Test_T가 호출될 때(인스턴스화, 객체화) 최초 1회 0으로 초기화 됨)
        int iButtonClickCount = 0; // 클래스 필드 멤버(클래스 전역 변수)

        public Chap12_IF_Test_T()
        {
            InitializeComponent();
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            // 버튼을 총 클릭한 횟수(정수)
            ++iButtonClickCount; // 버튼을 클릭했을 때 1씩 증가(전위증가 연산)
            txtBtnClickCount.Text = iButtonClickCount.ToString();

            // 1. 변수 설정
            string sValue = txtInputValue.Text; // 입력받을 값
            int iValue = 0; // 입력받은 값이 정수로 변환될 변수
            bool bCheck = false; // 입력받은 값이 정수로 변환 가능여부 검증
             
            // 2. 입력한 문자가 숫자로 바뀔 수 있는지 검증. (벨리데이션)
            bCheck = int.TryParse(sValue, out iValue);
            if (!bCheck)
            {
                MessageBox.Show("숫자만 입력하세요");
                return; // 벨리데이션 체크 후 오류 발생 검출 시 로직 호출한 곳으로 반환
            }

            // 3. 2와 5의 공배수인지
            string sMessage = string.Empty; // 분기에 따른 메세지 변수
            if (iValue % 2 == 0 && iValue % 5 == 0)
            {
                sMessage = "2와 5의 공배수입니다.";
            }
            else
            {
                sMessage = "2와 5의 공배수가 아닙니다.";
            }
            MessageBox.Show(sMessage);

            // 4. 8의 배수인지 확인하는 
            if (iValue % 8 == 0)
            {
                // 입력한 값과 8을 곱하여 8의 배수를 텍스트박스에 표현
                txtEMultiValue.Text = (iValue * 8).ToString();
            }
            else
            {
                txtEMultiValue.Text = "";
            }


        }
    }
}
