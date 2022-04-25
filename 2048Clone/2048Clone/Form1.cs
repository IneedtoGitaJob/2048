using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048Clone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Font = new Font("Tahoma", 40);
            dataGridView1.RowCount = 4;
            dataGridView1.ColumnCount = 4;
            dataGridView1.RowTemplate.Height = dataGridView1.Height / 4;

            //Initialize to 0
            for (int x = 0; x < 4; x++)
            {

                dataGridView1.Rows[x].SetValues(0, 0, 0, 0);
            }


            //Create and seed random
            Random rand = new Random((int)DateTime.Now.Ticks);
            for (int x = 0; x < rand.Next(2, 5); x++)
            {
                dataGridView1.Rows[rand.Next(0, 4)].Cells[rand.Next(0, 4)].Value = 2;

            }


        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            upShift(0, 3);
            newValue();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            leftShift(3, 0);
            newValue();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            rightShift(0,0);
            newValue();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            downShift(0, 0);
            newValue();
        }

        private void leftShift(int column, int row)
        {
            
            for (int y = row; y < 4; y++)
            {
                
                for (int x = column; x > 0; x--)
                {
                    


                    if (((int)dataGridView1.Rows[y].Cells[x - 1].Value == (int)dataGridView1.Rows[y].Cells[x].Value) || ((int)dataGridView1.Rows[y].Cells[x - 1].Value * (int)dataGridView1.Rows[y].Cells[x].Value == 0))
                    {
                        dataGridView1.Rows[y].Cells[x - 1].Value = (int)dataGridView1.Rows[y].Cells[x].Value + (int)dataGridView1.Rows[y].Cells[x - 1].Value;
                        dataGridView1.Rows[y].Cells[x].Value = 0;
                    }


                }


            }
        }

        private void upShift(int column, int row)
        {
            
            for (int y = row; y > 0; y--)
            {
                
                for (int x = column; x < 4; x++)
                {
                    
                    if (((int)dataGridView1.Rows[y - 1].Cells[x].Value == (int)dataGridView1.Rows[y].Cells[x].Value) || ((int)dataGridView1.Rows[y - 1].Cells[x].Value * (int)dataGridView1.Rows[y].Cells[x].Value == 0))
                    {
                        dataGridView1.Rows[y - 1].Cells[x].Value = (int)dataGridView1.Rows[y].Cells[x].Value + (int)dataGridView1.Rows[y - 1].Cells[x].Value;
                        dataGridView1.Rows[y].Cells[x].Value = 0;
                    }



                }


            }

        }

        private void downShift(int column, int row)
        {



            for (int y = row; y < 3; y++)
            {
                for (int x = column; x < 4; x++)
                {

                    if (((int)dataGridView1.Rows[y + 1].Cells[x].Value == (int)dataGridView1.Rows[y].Cells[x].Value) || ((int)dataGridView1.Rows[y + 1].Cells[x].Value * (int)dataGridView1.Rows[y].Cells[x].Value == 0)) 
                    {
                        dataGridView1.Rows[y + 1].Cells[x].Value = (int)dataGridView1.Rows[y].Cells[x].Value + (int)dataGridView1.Rows[y + 1].Cells[x].Value;
                        dataGridView1.Rows[y].Cells[x].Value = 0;
                    }


                }


            }

        }

        private void rightShift(int column, int row)
        {

            for (int y = row; y < 4; y++)
            {
                for (int x = column; x < 3; x++)
                {

                    if (((int)dataGridView1.Rows[y].Cells[x + 1].Value == (int)dataGridView1.Rows[y].Cells[x].Value) || ((int)dataGridView1.Rows[y].Cells[x + 1].Value * (int)dataGridView1.Rows[y].Cells[x].Value == 0))
                    {
                        dataGridView1.Rows[y].Cells[x + 1].Value = (int)dataGridView1.Rows[y].Cells[x].Value + (int)dataGridView1.Rows[y].Cells[x + 1].Value;
                        dataGridView1.Rows[y].Cells[x].Value = 0;
                    }








                }
            }
        }

        private void newValue() 
        {

            Random rand = new Random((int)DateTime.Now.Ticks);
            for (int x = 0; x < rand.Next(1, 3); x++)
            {
                int i = rand.Next(0, 4);
                int j = rand.Next(0, 4);
                if ((int)dataGridView1.Rows[i].Cells[j].Value == 0)
                {
                    dataGridView1.Rows[i].Cells[j].Value = 2;
                }



            }



        }



    }
}
