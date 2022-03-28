﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PR19
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public string patht = @"G:\ОАП\PR19\text.txt";
        public string path2 = @"G:\ОАП\PR19\del.txt";
        private void btnCrt_Click(object sender, EventArgs e)
        {
            tbMain.Clear();
            Car car1 = new Car("Lada", 1700, 75, 2000, 60);
            Car car2 = new Car("BMW", 2500, 190, 1997, 200);
            Car car3 = new Car("Mercedes", 3200, 220, 1995, 187);
            Car car4 = new Car("Opel", 1600, 100, 2006, 75);
            Car car5 = new Car("UAZ",2000, 120,2001,95);
            Car car6 = new Car("AZLK", 1600,75,1985,70);
            car1.Setmarka("VAZ");
            car1.printInf(tbMain);
            car2.printInf(tbMain);
            car3.printInf(tbMain);
            car4.printInf(tbMain);
            car5.printInf(tbMain);
            car6.printInf(tbMain);
            Bus bus = new Bus("PAZ",4000,60,1995,90,32);
            Bus bus1 = new Bus("ZIL",6000,75,1984,85,45);
            bus.printInf(tbMain);
            bus1.printInf(tbMain);
            btnCrt.Enabled = false;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addForm addForm = new addForm();
            addForm.Show();
        }

        private void butn_search_Click(object sender, EventArgs e)
        {
            string markaAvt = tb_search.Text;
            using (StreamReader sr = File.OpenText(patht))
            {
                string[,] sp = new string[File.ReadAllLines(patht).Length, 5];
                string[] strok = new string[File.ReadAllLines(patht).Length];
                for (int i = 0; i < File.ReadAllLines(patht).Length; i++)
                {
                    strok = sr.ReadLine().Split();
                    for (int j = 0; j <= 4; j++)
                    {
                        sp[i, j] += strok[j]; //0Марка,1Объем, 2МаксСкор, 3Год, 4Мощность                        
                    }
                }
                tbMain.Clear();
                for (int i = 0; i < sp.GetLength(0); i++)
                {
                    if (sp[i,0] == markaAvt)
                    {
                        tbMain.Text += sp[i, 0] + ' '  + sp[i, 1] + ' ' + sp[i, 2] + ' ' + sp[i, 3] + ' ' + sp[i, 4] + Environment.NewLine;
                    }
                }
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            tbMain.Clear();
            tbMain.Lines = (File.ReadAllLines(patht));
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string markaAvtDel = tb_delete.Text;
            using (StreamReader sr = File.OpenText(patht))
            {
                string[,] sp = new string[File.ReadAllLines(patht).Length, 5];
                string[] strok = new string[File.ReadAllLines(patht).Length];
                for (int i = 0; i < File.ReadAllLines(patht).Length; i++)
                {
                    strok = sr.ReadLine().Split();
                    for (int j = 0; j <= 4; j++)
                    {
                        sp[i, j] += strok[j]; //0Марка,1Объем, 2МаксСкор, 3Год, 4Мощность                        
                    }
                }
                tbMain.Clear();
                File.Delete(patht);
                for (int i = 0; i < sp.GetLength(0); i++)
                {
                    if (sp[i,1] != markaAvtDel)
                    {
                        string newtext = sp[i, 0] + ' ' + sp[i, 1] + ' ' + sp[i, 2] + ' ' + sp[i, 3] + ' ' + sp[i, 4] + Environment.NewLine;
                        File.AppendAllText(path2, newtext);
                    }
                }
                
            }
        }
    }
}
