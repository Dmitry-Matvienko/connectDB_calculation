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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            this.PasswordField.AutoSize = false;
            this.PasswordField.Size = new Size(this.PasswordField.Size.Width, 60);

            UserNameField.Text = "Введите имя";
            UserNameField.ForeColor = Color.Gray;

            UserSurnameField.Text = "Введите фамилию";
            UserSurnameField.ForeColor = Color.Gray;

  
        }
      
      


        Point LastPoint;
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
            LastPoint = new Point(e.X, e.Y);
        }

        private void UserNameField_Enter(object sender, EventArgs e)
        {
            if (UserNameField.Text == "Введите имя")
            {
                UserNameField.Text = "";
                UserNameField.ForeColor = Color.Black;
            }
        }

        private void UserNameField_Leave(object sender, EventArgs e)
        {
            if (UserNameField.Text == "")
            {
                UserNameField.Text = "Введите имя";
                UserNameField.ForeColor = Color.Gray;
            }
        }

        private void UserSurnameField_Enter(object sender, EventArgs e)
        {
            if (UserSurnameField.Text == "Введите фамилию")
            {
                UserSurnameField.Text = "";
                UserSurnameField.ForeColor = Color.Black;
            }
        }

        private void UserSurnameField_Leave(object sender, EventArgs e)
        {
            if (UserSurnameField.Text == "")
            {
                UserSurnameField.Text = "Введите фамилию";
                UserSurnameField.ForeColor = Color.Gray;
            }
        }

       

        private void Button1Register_Click(object sender, EventArgs e)
        {

            if (UserNameField.Text == "Введите имя") // вывод-предупреждение о пустой строке
            {
                MessageBox.Show("Введите имя");
                return;
            }

            
            else if (UserSurnameField.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return;


            }
            else if (LoginField.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }


            else if (PasswordField.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }


            if (CheckUniqueUser()) // если функция возвращает значение true, выходим из нее
                return;
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@login, @pass, @name, @surname)", db.getConnection()); // вставляем в таблицу БД данные о новом пользователе с использованием заглушки
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PasswordField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = UserNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = UserSurnameField.Text;

            db.OpenConnection(); // открытие соединения для обработки запроса о регистрации

            if (command.ExecuteNonQuery() == 1) // Если запрос был корректным (=1), создается аккаунт
            {
                MessageBox.Show("Аккаунт создан");
                
            }
            else
                MessageBox.Show("Аккаунт не был создан"); 
            db.CloseConnection(); // закрытия соединения запроса 
        }

        public Boolean CheckUniqueUser() // проверка на "уникального" пользователя   

        {

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL" , db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginField.Text;
            

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует");
                return true;
            }
            else
            {
                return false;

            }
         }

        private void AuthorizationLink_Click(object sender, EventArgs e) // перекидываем на окно авторизации
        {
            this.Hide();
            LoginForm loginFrom = new LoginForm();
            loginFrom.StartPosition = FormStartPosition.CenterScreen;
            loginFrom.Show();
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Введите логин")
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Black;
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                LoginField.Text = "Введите логин";
                LoginField.ForeColor = Color.Gray;
            }
        }

        private void AuthorizationLink_MouseEnter(object sender, EventArgs e)
        {
            AuthorizationLink.ForeColor = Color.Black;
        }

        private void AuthorizationLink_MouseLeave(object sender, EventArgs e)
        {
            AuthorizationLink.ForeColor = Color.White;
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
