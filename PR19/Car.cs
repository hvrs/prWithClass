using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBox = System.Windows.Forms.TextBox;
using System.IO;

namespace PR19
{
    class Car
    {

        private string marka = "";
        private int V_dvig;
        private int maxSpeed;
        private int year;
        private int powerfl;
        public Car(string marka, int V_dvig, int maxSpeed, int year, int powerfl)
        {
            this.marka = marka;
            this.V_dvig = V_dvig;
            this.maxSpeed = maxSpeed;
            this.year = year;
            this.powerfl = powerfl;
        }
       public void printInf(TextBox textBox, string path) //Печать данных об автомобилях
        {
            try
            {
                textBox.Text += marka + " " + V_dvig + " " + maxSpeed + " " + year + " " + powerfl +  Environment.NewLine;
                using (FileStream flt = File.Create(path))
                {
                    byte[] cars = new UTF8Encoding(true).GetBytes(textBox.Text);
                    flt.Write(cars, 0, cars.Length);
                }
            }
            catch (Exception)
            {

                
            }
        }
        public void Setmarka(string newMark)//Метод, изменяющий марку автомобиля
        {
            marka = newMark;
        }
        public void SetV_dvig(int v_dvg)//Метод, изменяющий объем двигателя автомобиля
        {
            V_dvig = v_dvg;
        }
        public void SetSpecifications(int speed, int pwrFl)//Метод, изменяющий скорость и мощность
        {
            maxSpeed = speed;
            powerfl = pwrFl;
        }
        public void SetSpecifications(int pwrFl)//Метод, мощность(перегружен)
        {          
            powerfl = pwrFl;
        }

    }
   
}
