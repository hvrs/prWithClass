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
        public string path = @"G:\ОАП\PR199\text.txt";
        public string marka = "";
        public int V_dvig;
        public int maxSpeed;
        public int year;
        public int powerfl;
        public Car(string marka, int V_dvig, int maxSpeed, int year, int powerfl)
        {
            this.marka = marka;
            this.V_dvig = V_dvig;
            this.maxSpeed = maxSpeed;
            this.year = year;
            this.powerfl = powerfl;
        }
       public void printInf(TextBox textBox) //Печать данных об автомобилях
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
        public void printInf() //Печать данных об автомобилях
        {
            try
            {
                string todok = marka + " " + V_dvig + " " + maxSpeed + " " + year + " " + powerfl + Environment.NewLine;
                File.AppendAllText(path,todok);
            }
            catch (Exception)
            {


            }
        }

        public virtual void Setmarka(string newMark)//Метод, изменяющий марку автомобиля
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
        public void Deconstruct(out string marka, out string V_dvig, out string maxSpeed, out string year, out string powerfl)
        {
            marka = this.marka;
            V_dvig = Convert.ToString(this.V_dvig);
            maxSpeed = Convert.ToString(this.maxSpeed);
            year = Convert.ToString(this.year);
            powerfl = Convert.ToString(this.powerfl);           
        }

    }
    class Bus : Car
    {
        public int NumSeats;
        public Bus(string marka, int V_dvig, int maxSpeed, int year, int powerfl, int numSeats) : base(marka, V_dvig, maxSpeed, year, powerfl)
        {
            NumSeats = numSeats;
        }
        public new void printInf(TextBox textBox) 
        {
            try
            {
                textBox.Text += marka + " " + V_dvig + " " + maxSpeed + " " + year + " " + powerfl + " " + NumSeats +Environment.NewLine;
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
        public void Print()
        {
            try
            {
                string todok = marka + " " + V_dvig + " " + maxSpeed + " " + year + " " + powerfl + " " + NumSeats + Environment.NewLine;
                File.AppendAllText(path, todok);
            }
            catch (Exception)
            {
            }
        }
        public override void Setmarka(string newMark)
        {
            marka = newMark;
        }
        public new void SetV_dvig(int v_dvg)
        {
            V_dvig = v_dvg;
        }
        public new void SetSpecifications(int speed, int pwrFl)
        {
            maxSpeed = speed;
            powerfl = pwrFl;
        }
        public new void SetSpecifications(int pwrFl)
        {
            powerfl = pwrFl;
        }
    }
}
