using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.PasswordField.AutoSize = false;
            this.PasswordField.Size = new Size(this.PasswordField.Size.Width, 64);     
        }

        //public System.Windows.Forms.FormStartPosition StartPositione { get; set; }
        //public void StartPositions() 
        //{
        //    LoginForm start = new LoginForm();
        //    start.StartPosition = FormStartPosition.CenterScreen;
            
        //}


     

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }


        Point LastPoint; // Переменная для перетаскивания элементов формы
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y); // новая позиция элементов
        }

        private void Button1Login_Click(object sender, EventArgs e)
        {
            String LoginUsers = LoginField.Text;
            String PasswordUsers = PasswordField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = password" , db.getConnection()); // сравниваем данные из БД используя заглушку
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginUsers; // устанавливаем тип данных и переменную для заглушки
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PasswordUsers;

            adapter.SelectCommand = command; // указываем какую команду будем выполнять
            adapter.Fill(table); // заполняем объект table 

            if (table.Rows.Count > 0) // если авторизация успешна, перекидываем на проект
            {
                this.Hide();
                ProjectFrorm projectForm = new ProjectFrorm();
                projectForm.StartPosition = FormStartPosition.CenterScreen;
                projectForm.Show();
               }
            else
                MessageBox.Show("Try again");
        }

        private void RegisterLink_Click(object sender, EventArgs e) // если пользователя не существует, перекидываем в окно регистрации
        {
            this.Hide();
            RegisterForm registerLink = new RegisterForm();
            registerLink.StartPosition = FormStartPosition.CenterScreen;
            registerLink.Show();
        }

        private void RegisterLink_MouseEnter(object sender, EventArgs e)
        {
            RegisterLink.ForeColor = Color.Black;
        }

        private void RegisterLink_MouseLeave(object sender, EventArgs e)
        {
            RegisterLink.ForeColor = Color.White;
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
