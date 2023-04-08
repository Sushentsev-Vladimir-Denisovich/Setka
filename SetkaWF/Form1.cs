using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetkaWF
{
    public partial class Form1 : Form
    {
        static bool tok = true;
        static double[,] setka = new double[13, 13];
        static double rez;
        static bool flag = false;
        public static Random rnd = new Random();
        //static int[] n = new int[100];
        //static int[] m = new int[100];
        static int n;
        static int m;
        static int pok = 0;
        static double current, count = 0;
        static bool minitok = false;

        public static double[,] Rez(double[,] mas, double rez)
        {
            flag = false;
            for (int i = 0; i < 13; i++)
            {
                for (int j = 1; j < 12; j++)
                {
                    if (mas[i, j] == rez)
                    {
                        //count++;
                        //mas[i, j] = 1;
                        //flag = true;
                        //n[pok] = i;
                        //m[pok] = j;
                        //pok++;
                        count++;
                        mas[i, j] = -5;
                        flag = true;
                        n = i;
                        m = j;
                    }
                }
            }

            return mas;
        }

        public static bool Prov(double[,] mas, int x, int y)
        {
            bool t = false;

            for (int i = 0; i < x + 1; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i == x && j == y - 1)
                    {
                        return t;
                    }
                    if (mas[i, j] == current)
                    {
                        t = true;
                        return t;
                    }
                }
            }

            return t;
        }

        /*public static bool Tok(double[,] mas)
        {
            bool t;


            return t;
        }*/
        public static bool Proverka(double[,] mas)
        {
            bool t = true, f = false;
            int i = 0;

            for (int j = 1; j < 12; j++)
            {
                if (j % 2 == 1)
                {
                    if (mas[i, j] == -5 && mas[i + 2, j] == -5 && mas[i + 4, j] == -5 && mas[i + 6, j] == -5 && mas[i + 8, j] == -5 && mas[i + 10, j] == -5 && mas[i + 12, j] == -5)
                    {
                        t = false;
                        return t;
                    }
                }
                else
                {
                    if (mas[i + 1, j] == -5 && mas[i + 3, j] == -5 && mas[i + 5, j] == -5 && mas[i + 7, j] == -5 && mas[i + 9, j] == -5 && mas[i + 11, j] == -5)
                    {
                        t = false;
                        return t;
                    }
                }
            }

            i = 0;
            int k, l;
            int[,] prov = new int[13, 13];

            for (int j = 1; j < 12; j+=2)//0
            {
                if (mas[i,j] == -5)
                {
                    f = true;

                    if (j != 0)
                    {
                        if (j != 12)
                        {
                            prov[i + 1, j - 1] = 1;
                            prov[i + 1, j + 1] = 1;
                        }
                        else prov[i + 1, j - 1] = 1;
                    }
                    else
                    {
                        prov[i + 1, j + 1] = 1;
                    }
                }
            }

            if (f == true)
            {
                f = false;

                i += 1;
                for (int j = 0; j < 13; j += 2)//1
                {
                    if (prov[i, j] == 1 && mas[i, j] == -5)
                    {
                        f = true;

                        if (j != 0)
                        {
                            if (j != 12)
                            {
                                prov[i + 1, j - 1] = 1;
                                prov[i + 1, j + 1] = 1;
                            }
                            else prov[i + 1, j - 1] = 1;
                        }
                        else
                        {
                            prov[i + 1, j + 1] = 1;
                        }
                    }
                }
                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 1; j < 12; j += 2)//2
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 0; j < 13; j += 2)//3
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 1; j < 12; j += 2)//4
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 0; j < 13; j += 2)//5
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 1; j < 12; j += 2)//6
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 0; j < 13; j += 2)//7
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 1; j < 12; j += 2)//8
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 0; j < 13; j += 2)//9
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 1; j < 12; j += 2)//10
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 0; j < 13; j += 2)//11
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 1; j < 12; j += 2)//12
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            t = false;
                            return t;
                        }
                    }
                }
            }
            

            /*int i = 0, j, k, l;

            for (j = 1; j < 12; j++)
            {
                if (mas[j, j] == -5)
                {
                    k = j + 1;
                    l = j - 1;
                    i += 1;

                }
            }*/


            return t;
        }

        public Form1()
        {
            InitializeComponent();
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.RowCount = 13;
            dataGridView1.ColumnCount = 13;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            flag = false;
            tok = true;
            label3.Text = "Тики Ток: Есть";
            label3.ForeColor = Color.Black;

            dataGridView1.RowCount = 13;
            dataGridView1.ColumnCount = 13;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.Width = 40;

            for (int i = 0; i < 13; i++)
            {

                for (int j = 0; j < 13; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;

                    if (j == 0)
                    {
                        setka[i, j] = 1;
                        dataGridView1.Rows[i].Cells[j].Value = "\t╬";
                    }
                    if (j == 12)
                    {
                        setka[i, j] = 1;
                        dataGridView1.Rows[i].Cells[j].Value = "\t╬";
                    }

                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        setka[i, j] = 1;
                        dataGridView1.Rows[i].Cells[j].Value = "\t╬";
                    }
                    else
                    { if (i % 2 == 1 && j % 2 == 1)
                        {
                            setka[i, j] = 1;
                        }
                        else
                        {
                            int b = 0;
                            double[] arr = new double[169];
                            for (int k = 0; k < 13; k++)
                            {
                                for (int l = 0; l < 13; l++)
                                {
                                    arr[b] = setka[k, l];
                                    b++;
                                }
                            }

                            double num = rnd.NextDouble();
                            num = Math.Round(num, 2);
                            if (arr.Contains(num))
                            {
                                j--;
                            }
                            else
                            {
                                setka[i, j] = num;
                            }
                        }
                    }   
                    
                }
            }


            for (int i = 0; i < 13; ++i)
            {
                for (int j = 0; j < 13; ++j)
                {
                    dataGridView1.Rows[n].Cells[m].Style.ForeColor = Color.Black;
                    dataGridView1.Rows[n].Cells[m].Style.BackColor = Color.White;

                    if (setka[i, j] != 1)
                        dataGridView1.Rows[i].Cells[j].Value = setka[i, j];
                    else
                    {
                        //.Rows[i].Cells[j].Value = "";
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            rez = rnd.NextDouble();
            rez = Math.Round(rez, 2);
            while (rez == 1)
            {
                rez = rnd.NextDouble();
                rez = Math.Round(rez, 2);
            }
            textBox1.Text = rez.ToString();
            setka = Rez(setka, rez);
            if (flag == true)
            {
                textBox2.Text = "Есть";
                for (int i = 0; i < 13; ++i)
                {
                    for (int j = 0; j < 13; ++j)
                    {
                        if (setka[i, j] != 1)
                            dataGridView1.Rows[i].Cells[j].Value = setka[i, j];
                        else
                        {
                            //dataGridView1.Rows[i].Cells[j].Value = "";
                        }
                    }
                }
                //for (int i = 0; i < pok; i++)
                //{
                //dataGridView1.Rows[n[i]].Cells[m[i]].Style.BackColor = Color.Red;
                dataGridView1.Rows[n].Cells[m].Style.ForeColor = Color.Red;
                dataGridView1.Rows[n].Cells[m].Style.BackColor = Color.Red;
                //}
            }
            else
            {
                textBox2.Text = "Нет";
            }
            textBox3.Text = count.ToString();
            pok = 0;
            tok = Proverka(setka);
            if (tok == false)
            {
                label3.Text = "Ток: НЕТ!";
                label3.ForeColor = Color.Red;
                
                double V = count / 84;
                textBox4.Text = V.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            
            while (label3.Text != "Ток: НЕТ!")
            {

                /*rez = rnd.NextDouble();
                rez = Math.Round(rez, 2);
                while (rez == 1)
                {
                    rez = rnd.NextDouble();
                    rez = Math.Round(rez, 2);
                }
                textBox1.Text = rez.ToString();
                setka = Rez(setka, rez);
                if (flag == true)
                {
                    textBox2.Text = "Есть";
                    for (int i = 0; i < 13; ++i)
                    {
                        for (int j = 0; j < 13; ++j)
                        {
                            if (setka[i, j] != 1)
                                dataGridView1.Rows[i].Cells[j].Value = setka[i, j];
                            else
                            {
                                dataGridView1.Rows[i].Cells[j].Value = "";
                            }
                        }
                    }
                    //for (int i = 0; i < pok; i++)
                    //{
                    //dataGridView1.Rows[n[i]].Cells[m[i]].Style.BackColor = Color.Red;
                    dataGridView1.Rows[n].Cells[m].Style.ForeColor = Color.Red;
                    dataGridView1.Rows[n].Cells[m].Style.BackColor = Color.Red;
                    //}
                }
                else
                {
                    textBox2.Text = "Нет";
                }
                pok = 0;
                tok = Proverka(setka);
                if (tok == false)
                {
                    label3.Text = "Ток: НЕТ!";
                    label3.ForeColor = Color.Red;
                    textBox3.Text = count.ToString();
                    double V = count / 84;
                    textBox4.Text = V.ToString();
                }
                */
                button2_Click(sender, e);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
