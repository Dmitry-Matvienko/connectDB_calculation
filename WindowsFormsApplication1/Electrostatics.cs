using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Electrostatics : Form
    {
        public Electrostatics()
        {
            InitializeComponent();
        }

        private void электромагнитныеКолебанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kolebaniya kolebaniya = new Kolebaniya();
            kolebaniya.StartPosition = FormStartPosition.CenterScreen;
            kolebaniya.Show();
        }

        private void кинематикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kinematics kinematics = new Kinematics();
            kinematics.StartPosition = FormStartPosition.CenterScreen;
            kinematics.Show();
        }

        private void электрическийТокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Curent curent = new Curent();
            curent.StartPosition = FormStartPosition.CenterScreen;
            curent.Show();
        }

        private void магнетизмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MagnetismForm magnetism = new MagnetismForm();
            magnetism.StartPosition = FormStartPosition.CenterScreen;
            magnetism.Show();
        }

      

        private void Calculation_Click(object sender, EventArgs e)
        {
            double W = Convert.ToDouble(Potensial.Text);
            double q = Convert.ToDouble(Charge.Text);

            double f;

            f = W / q;

            Answer.Text = f.ToString("Ответ: ") + f + (" вольт");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            if (base.WindowState == FormWindowState.Normal)
            {
                base.WindowState = FormWindowState.Minimized;
            }
        }


       
    }
}
