using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Учёт_офисной_техники
{
    public partial class AuthorizationForm : Form
    {
        // Команда подключения к локальному серверу SQL
        string sqlCon = @"Data Source=(local); Initial Catalog = Учёт_офисной_техники; Integrated Security = True";
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm newForm = new RegistrationForm(sqlCon);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void buttonAuthorizaton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_loadAccountTable", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();

            foreach (DataRow row in dt.Rows)
            {
                SHA256 sha256 = SHA256.Create();
                var inputBytes = Encoding.UTF8.GetBytes(textBoxPassword.Text.ToString() + "qwerty");
                var inputHash = sha256.ComputeHash(inputBytes);
                if (textBoxLogin.Text.ToString() == row["login"].ToString() && BitConverter.ToString(inputHash).Replace("-", "") == row["password"].ToString())
                {
                    MainForm newForm = new MainForm(sqlCon, (int)row["id_worker"]);
                    this.Hide();
                    newForm.ShowDialog();
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Неверные данные", "Ошибка");
        }
    }
}
