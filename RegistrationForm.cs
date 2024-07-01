using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace Учёт_офисной_техники
{
    public partial class RegistrationForm : Form
    {
        string sqlCon;
        public RegistrationForm(string sqlCon)
        {
            InitializeComponent();
            this.sqlCon = sqlCon;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_loadAccountTable", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            foreach (DataRow row in dt.Rows)
            {
                if (textBoxLogin.Text.ToString() == row["login"].ToString())
                {
                    MessageBox.Show("Такой логин уже существует", "Ошибка");
                    return;
                }
            }   
            cmd = new SqlCommand("sp_addAccount", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@name", SqlDbType.NText).Value = textBoxName.Text;
            cmd.Parameters.Add("@middleName", SqlDbType.NText).Value = textBoxMiddleName.Text;
            cmd.Parameters.Add("@secondName", SqlDbType.NText).Value = textBoxSecondName.Text;
            cmd.Parameters.Add("@login", SqlDbType.NText).Value = textBoxLogin.Text;

            SHA256 sha256 = SHA256.Create();
            var inputBytes = Encoding.UTF8.GetBytes(textBoxPassword.Text+"qwerty");
            var inputHash = sha256.ComputeHash(inputBytes);
            cmd.Parameters.Add("@password", SqlDbType.NText).Value = BitConverter.ToString(inputHash).Replace("-", "");

            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            MessageBox.Show("Аккаунт создан", "Внимание");

            con.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AuthorizationForm newForm = new AuthorizationForm();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
