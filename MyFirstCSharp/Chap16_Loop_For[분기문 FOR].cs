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
    public partial class Chap16_Loop_For : Form
    {
        // 반복문
        // 특정한 조건을 만족할 때까지 반복하여 동일한 로직을 실행하는 문법


        public Chap16_Loop_For()
        {
            InitializeComponent();
        }

        private void btnForSum_Click(object sender, EventArgs e)
        {
            // 1부터 100까지 합하는 로직

            // 1. 누적값이 저장되는 변수
            int iSumValue = 0;

            // 1부터 100까지 반복
            // i : 반복하면서 조건을 만족시킬 변수
            //     반복문을 종료할 수 있는 변수
            // int i = 0  : int형 변수 i가 0이라는 값을 가지고 시작
            // ; i <= 100 : 참인 조건인지 판단하는 구문 
            // ; i++      : 후위 증가 연산자
            //              다음 조건을 비교하기 위하여 증가하는 구문
            for (int i = 0; i <= 100; i++)
            {
                iSumValue += i;
            }
            MessageBox.Show(iSumValue.ToString());

        }

        private void btnArraySum_Click(object sender, EventArgs e)
        {
            // 배열의 데이터 수만큼 for문으로 반복 후 배열의 값 더하기

            // 1. 임의의 배열의 값 등록 (배열에 포함된 데이터의 갯수 및 값을 모른다고 가정)
            int[] iValues = { 10, 20, 30, 40, 50, 50, 20 };
            //                0   1   2   3   4   5   6

            // 2. For문을 통하여 iValues 배열에 있는 모든 값을 더하기
            int iSumValue = 0; // 배열의 모든 값을 더해서 누적시킬 변수

            // int i : 배열의 주소 값으로 사용될 i
            for (int i = 0; i < iValues.Length; i++)
            {
                if (iValues[i] >= 40)
                {
                    if (iValues[i] == 50)
                    {
                        break;
                    }
                    continue;
                }
                iSumValue += iValues[i];
            }
            MessageBox.Show(iSumValue.ToString()); // "60"

        }

        private void btnGuGu_Click(object sender, EventArgs e)
        {
            string sResult = string.Empty;
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    sResult += $"{i} * {j} = {i * j}\r\n";
                    // 2 * 1 = 2   // 2 * 1 = 2   // 2 * 1 = 2  
                                   // 2 * 2 = 4   // 2 * 2 = 4
                                                  // 2 * 3 = 6
                }
                txtGuGu.Text = sResult;
            }
        }

        private void btnImmutable_Click(object sender, EventArgs e)
        {
            // 값 형식의 타입
            // Immutable Type (string)과 Mutable Type (int)
            // Immutable 타입은 저장되는 번지수만 늘어나서 데이터가 증가하는 방식
            // 누적되기 전의 데이터가 사라지지 않는 방식
            // 2 * 1 = 2   // 2 * 1 = 2   // 2 * 1 = 2  
                           // 2 * 2 = 4   // 2 * 2 = 4
                                          // 2 * 3 = 6
            // 데이터가 누적될 때 불필요한 메모리 공간이 많이 소비되므로 비효율적인 코딩이 될 수 있다.
            // StringBuilder를 사용할 것을 권장 (강추)

            StringBuilder sBuilder = new StringBuilder();
            // 12345678910......100
            for (int i = 1; i <= 100; i++)
            {
                sBuilder.Append(i.ToString());
            }
            MessageBox.Show(sBuilder.ToString());

            sBuilder.Clear(); // 내용 삭제

        }
    }
}
