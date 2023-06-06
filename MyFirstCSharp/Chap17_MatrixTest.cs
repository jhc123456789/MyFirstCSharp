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
    public partial class Chap17_MatrixTest : Form
    {
        public Chap17_MatrixTest()
        {
            InitializeComponent();
        }

        private void btnCH_Click(object sender, EventArgs e)
        {
            int[,] iValues = new int[2, 4]; // 2행 4열의 2차원 배열 방 생성
            iValues[0, 0] = 1;
            iValues[0, 1] = 2;
            iValues[0, 2] = 3;
            iValues[0, 3] = 4;
            iValues[1, 0] = 5;
            iValues[1, 1] = 6;
            iValues[1, 2] = 7;
            iValues[1, 3] = 8;

            int iMatrixRowCount = iValues.GetLength(0);
            int iMatrixColumnCount = iValues.GetLength(1);
            int[,] iNewMatrix = new int[iMatrixRowCount, iMatrixColumnCount];

            for (int i = 0; i < iMatrixColumnCount; i++)
            {
                iNewMatrix[0, i] = iValues[1, i];
                txtMatrix.Text += iNewMatrix[0, i] + " ";
            }
            txtMatrix.Text += "\r\n";
            for (int i = 0; i < iMatrixColumnCount; i++)
            {
                iNewMatrix[1, i] = iValues[0, i];
                txtMatrix.Text += iNewMatrix[1, i] + " ";
            }
        }


    }
}
