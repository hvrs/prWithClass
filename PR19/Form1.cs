using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PR19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string path = @"C:\Users\Professional\Desktop\PR19\PR19\text.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            Car car1 = new Car("Lada", 1700, 75, 2000, 60);
            Car car2 = new Car("BMW", 2500, 190, 1997, 200);
            car1.Setmarka("Жопель");
            car1.printInf(textBox4, path);
            car2.printInf(textBox4, path);          
        }



       
    }
}
