using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap09_StringManage_Test : Form
    {
        public Chap09_StringManage_Test()
        {
            InitializeComponent();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;
            string sBeforeword = txtBefore.Text;
            string sAfterword = txtAfter.Text;
            string sResult = sTitle.Replace(sBeforeword, sAfterword);

            MessageBox.Show(sResult);
            
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"S/W의 위치는 {lblTitle.Text.IndexOf("S/W")} 입니다.");

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;

            MessageBox.Show($"타이틀의 시작 단어는 {sTitle[0]}이고, 마지막 단어는 {sTitle[sTitle.Length - 1]}입니다.");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;
            string sInsertValue = "-DT-";

            txtInsert.Text = sTitle.Insert(0, sInsertValue).Insert(sTitle.Insert(0, sInsertValue).Length, sInsertValue);
            

        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;
            string sValue = "DIGITALTRANING";
            string sReplace = sTitle.Replace(sValue, sValue.ToLower());
            txtLower.Text = sReplace;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;
            string sReplace = sTitle.Replace(" ", string.Empty);
            txtTrim.Text = sReplace;

        }
    }
}
