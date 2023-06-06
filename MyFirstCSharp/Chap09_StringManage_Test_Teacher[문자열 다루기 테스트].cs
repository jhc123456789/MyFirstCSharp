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
    public partial class Chap09_StringManage_T : Form
    {
        // 되돌리기를 위한 원본 문자열을 담을 변수
        // 클래스의 전역변수, 클래스의 필드멤버
        string sTitle;

        // 클래스가 객체화될 때 실행되는 멤버 (생성자 멤버)
        public Chap09_StringManage_T()
        {
            // 클래스가 최초 호출될 때 디자인 올 셋팅하는 함수
            InitializeComponent();
            sTitle = lblTitle.Text;
        }

        private void btnNameChange_Click(object sender, EventArgs e)
        {
            // OOO -> 자기 이름으로 표현
            lblTitle.Text = lblTitle.Text.Replace("OOO", "최정훈");
        }

        private void btnFindSwIndex_Click(object sender, EventArgs e)
        {
            // S/W Index 표시
            MessageBox.Show($" S/W 글귀의 위치는 {lblTitle.Text.IndexOf("S/W")}입니다.");
        }

        private void btnFLWord_Click(object sender, EventArgs e)
        {
            // 타이틀 문자열 변수 담기
            string sTitle = lblTitle.Text;
            MessageBox.Show($" 시작 문자 : {sTitle[0]} ,종료 문자 : {sTitle[sTitle.Length - 1]}");
        }

        private void btnInsertDT_Click(object sender, EventArgs e)
        {
            // 앞 뒤에 -DT- 넣기
            lblTitle.Text = $"-DT-{lblTitle.Text}-DT-";
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            // 특정 문자 소문자로 변경
            string sValue = "DIGITALTRANING";
            lblTitle.Text = lblTitle.Text.Replace(sValue, sValue.ToLower());
        }

        private void btnRemoveSpace_Click(object sender, EventArgs e)
        {
            // 라벨 타이틀 모든 공백 없애기
            lblTitle.Text = lblTitle.Text.Replace(" ", "");
        }

        private void btnRollBack_Click(object sender, EventArgs e)
        {
            // sTitle에 있는 원본 문자열을 다시 lblTitle.text에 대입
            lblTitle.Text = sTitle;
        }
    }
}
