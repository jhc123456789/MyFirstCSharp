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
    public partial class Chap18_While : Form
    {
        public Chap18_While()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            // 1부터 100까지의 합을 While문으로 표현
            
            // 결과를 담을 외부 변수
            int iResult = 0;

            // 조건 (1부터 100까지 증가시킬 변수)
            int iCount = 0;

            // 조건을 만족하는 동안 계속 반복
            // For 문법 : 종료되는 조건이 반드시 포함
            // While 문법 : 종료 조건이 포함되지 않아도 된다.
            while(iCount <= 100)
            {
                iCount++;
                if (iCount >= 20 && iCount <= 30)
                {
                    // 20부터 30사이의 값은 누적하지 않는다.
                    continue;
                }
                iResult += iCount; // 100까지 누적 결과

                if (iResult > 1000)
                {
                    // 누적합산의 결과 값이 1000 초과할 경우 반복문(While) 종료
                    break;
                }
            }
            MessageBox.Show($"결과는 {iResult} 입니다");
            

            
        }

        private void btnWhileNoExit_Click(object sender, EventArgs e)
        {
            // 무한 루프
            // 주식 매매 프로그램 또는 서버의 신호를 대기하여 받아와야하는 프로그램의 경우 불규칙적으로 들어오는 데이터를 항상 수신 대기해야 하므로
            // 무한루프를 구현해두고 수신을 대기하는 프로그래밍을 할 수 있다.

            // 무한 루프를 구성할 경우 bool을 이용하여 처리한다.

            int iCnt    = 1;
            int iResult = 0;

            bool bOnOff = true;

            while(true)
            {
                iCnt++;
                iResult += iCnt;
            }

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            // Do While 
            // 반복문을 실행하지만 무조건 최초 1회는 실행될 수 있도록 하는 반복문

            // Do 문을 실행 후 While 문의 조건을 만족시킬 경우 (참)일 경우
            // Do의 내용을 반복

            int iCount = 1000;
            int iResult = 0;

            do
            {
                // 최초 1회 실행 및 조건 만족 시 반복 실행
                iResult += iCount;
                iCount--;
            }
            while (iCount < 100);            
        }
    }
}
