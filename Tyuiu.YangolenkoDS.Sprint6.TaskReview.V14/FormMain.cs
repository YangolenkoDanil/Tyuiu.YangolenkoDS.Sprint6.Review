using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.YangolenkoDS.Sprint6.TaskReview.V14.Lib;

namespace Tyuiu.YangolenkoDS.Sprint6.TaskReview.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public int row = 0;
        public int col = 0;
        public int r1 = 0, r2 = 0;
        public int[,] MyArray;

        private void buttonDone_YDS_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int First = Convert.ToInt32(textBoxVarK_YDS.Text);
                int Second = Convert.ToInt32(textBoxVarL_YDS.Text);
                int MyC = Convert.ToInt32(textBoxVarC_YDS.Text);

                int MyAnswer = ds.Result(MyArray, MyC, First, Second);

                textBoxResult_YDS.Text = Convert.ToString(MyAnswer);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxVarK_YDS.Enabled = false;
            textBoxVarL_YDS.Enabled = false;
            textBoxVarC_YDS.Enabled = false;
            buttonDone_YDS.Enabled = false;
        }

        private void buttonPushMatrix_YDS_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int row = Convert.ToInt32(textBoxVarN_YDS.Text), col = Convert.ToInt32(textBoxVarM_YDS.Text);
                int r1 = Convert.ToInt32(textBoxVarn1_YDS.Text), r2 = Convert.ToInt32(textBoxVarn2_YDS.Text);
                int[,] array = new int[row, col];

                MyArray = ds.GetMatrix(row, col, r1, r2);

                dataGridViewMatrix_YDS.RowCount = row;
                dataGridViewMatrix_YDS.ColumnCount = col;

                for (int i = 0; i < col; i++)
                {
                    dataGridViewMatrix_YDS.Columns[i].Width = 50;
                }

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        dataGridViewMatrix_YDS.Rows[i].Cells[j].Value = Convert.ToString(MyArray[i, j]);
                    }
                }
                textBoxVarK_YDS.Enabled = true;
                textBoxVarL_YDS.Enabled = true;
                textBoxVarC_YDS.Enabled = true;
                buttonDone_YDS.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
