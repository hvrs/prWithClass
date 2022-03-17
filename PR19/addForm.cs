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
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Car addcar = new Car(tbMark.Text, int.Parse(tbVdvg.Text), int.Parse(tbSpeed.Text), int.Parse(tbYear.Text), int.Parse(tbPowerfl.Text));
                addcar.printInf();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка");
            }
            
        }
    }
}
