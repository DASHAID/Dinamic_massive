using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Разбить заданный двумерный целочисленный массив на два ступенчатых массива, первый из которых содержит все элементы с четными значениями, а
//второй – все элементы с нечетными значениями
namespace Lab_4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dataGridView1.RowCount = 10; //Указываем количество строк
			dataGridView1.ColumnCount = 10; //Указываем количество столбцов
			dataGridView2.RowCount = 10;
			dataGridView2.ColumnCount = 10;
			dataGridView3.RowCount = 10; 
			dataGridView3.ColumnCount = 10;
			int[,] a = new int[10, 10]; //Инициализируем начальный массив
            int[][] a_del = new int[10][]; //ступенчатые массивы 
            int[][] a_not_del = new int[10][];
			int [] tmp=new int[10]; //для сохранения значений для ступенчатых массивов
            int[] tmp_2 = new int[10];
            int i, j, num_first=0, num_second = 0;
			//Заполняем матрицу случайными числами
			Random rand = new Random();
			for (i = 0; i < 10; i++)
				for (j = 0; j < 10; j++)
					a[i, j] = rand.Next(-99, 99);
			//Выводим матрицу в dataGridView1
			for (i = 0; i < 10; i++)
			{
				num_first = 0;
				num_second = 0;
				for (j = 0; j < 10; j++)
				{
					dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);

					if (a[i, j] % 2 == 0)
					{
						
						tmp[num_first] = a[i, j];
						num_first++;

                    }
					//dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
					else
					{
						
						tmp_2[num_second] = a[i, j];
						num_second++;
					}
						//dataGridView3.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);

				}

				a_del[i] = new int[num_first];

				for(int k=0; k<num_first; k++)
				{
					a_del[i][k] = tmp[k];
                    dataGridView2.Rows[i].Cells[k].Value = Convert.ToString(a_del[i][k]);
                }
				a_not_del[i] = new int[num_second];
                for (int k = 0; k < num_second; k++)
                {
                    a_not_del[i][k] = tmp_2[k];
                    dataGridView3.Rows[i].Cells[k].Value = Convert.ToString(a_not_del[i][k]);
                }
            }


		}
	}
}
