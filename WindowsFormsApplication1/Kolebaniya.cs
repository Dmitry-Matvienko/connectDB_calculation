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
    public partial class Kolebaniya : Form
    {
        public Kolebaniya()
        {
            InitializeComponent();
        }

        private void кинематикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kinematics kinematics = new Kinematics();
            kinematics.StartPosition = FormStartPosition.CenterScreen;
            kinematics.Show();
        }

        private void магнетизмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MagnetismForm magnetism = new MagnetismForm();
            magnetism.StartPosition = FormStartPosition.CenterScreen;
            magnetism.Show();
        }

        private void CalculationWaveLength_Click(object sender, EventArgs e)
        {
            double L = Convert.ToDouble(Induction.Text);
            double C = Convert.ToDouble(Capacity.Text);

            double calculate;

            calculate = 1 / (Math.Sqrt(L * C));
            AnswerWaveLength.Text = calculate.ToString("Ответ: ") + calculate + "рад/сек." ;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void CloseButton_Click_1(object sender, EventArgs e)
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
