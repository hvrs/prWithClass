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
        public string path = @"G:\ОАП\PR19\text.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            Car car1 = new Car("Lada", 1700, 75, 2000, 60);
            Car car2 = new Car("BMW", 2500, 190, 1997, 200);
            Car car3 = new Car("Mercedes", 3200, 220, 1995, 187);
            Car car4 = new Car("Opel", 1600, 100, 2006, 75);
            Car car5 = new Car("UAZ",2000, 120,2001,95);
            Car car6 = new Car("AZLK", 1600,75,1985,70);
            car1.Setmarka("VAZ");
            car1.printInf(textBox4, path);
            car2.printInf(textBox4, path);
            car3.printInf(textBox4, path);
            car4.printInf(textBox4,path);
            car5.printInf(textBox4,path);
            car6.printInf(textBox4,path);
            Bus bus = new Bus("PAZ",4000,60,1995,90,32);
            Bus bus1 = new Bus("ZIL",6000,75,1984,85,45);
            bus.printInf(textBox4,path);
            bus1.printInf(textBox4,path);
            //string[,]infAboutCar = new string[2,5];
            /*car1.Deconstruct(out infAboutCar[0,0], out infAboutCar[0,1], out infAboutCar[0,2], out infAboutCar[0,3], out infAboutCar[0,4]);
            car2.Deconstruct(out infAboutCar[1, 0], out infAboutCar[1, 1], out infAboutCar[1, 2], out infAboutCar[1, 3], out infAboutCar[1, 4]);*/
        }



       
    }
}
