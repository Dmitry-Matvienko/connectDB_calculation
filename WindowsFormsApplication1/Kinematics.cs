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
    public partial class Kinematics : Form
    {
        public Kinematics()
        {
            InitializeComponent();
        }

  
        private void магнетизмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MagnetismForm magnetism = new MagnetismForm();
            magnetism.StartPosition = FormStartPosition.CenterScreen;
            magnetism.Show();
        }

        const double g = 9.8;
        private void CalculationSpeedFall_Click(object sender, EventArgs e)
        {
            
            double h = Convert.ToDouble(HeightValue.Text);

            double Calculate;

            Calculate = Math.Sqrt(2*g*h);

            AnswerSpeedFall.Text = Calculate.ToString("Ответ: v = ") + Calculate + " м/c^2";
        }

        private void электромагнитныеКолебанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kolebaniya kolebaniya = new Kolebaniya();
            kolebaniya.StartPosition = FormStartPosition.CenterScreen;
            kolebaniya.Show();
        }

        private void электрическийТокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Curent curent = new Curent();
            curent.StartPosition = FormStartPosition.CenterScreen;
            curent.Show();
        }

        private void электростатикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Electrostatics electrostatics = new Electrostatics();
            electrostatics.StartPosition = FormStartPosition.CenterScreen;
            electrostatics.Show();
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            if (base.WindowState == FormWindowState.Normal)
            {
                base.WindowState = FormWindowState.Minimized;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    
    }
}
