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

namespace Учёт_офисной_техники
{
    public partial class WorksplaceCreateForm : Form
    {
        string sqlCon;
        int idDepartment;
        public WorksplaceCreateForm(string sqlCon, string idDepartment)
        {
            InitializeComponent();
            this.sqlCon = sqlCon;
            this.idDepartment = int.Parse(idDepartment);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textWorkplaceName.Text.Length == 0)
                MessageBox.Show("Поле ввода не может быть пустым.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                SqlConnection con = new SqlConnection(sqlCon);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_addWorkplace", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@name_workplace", SqlDbType.NText).Value = textWorkplaceName.Text;
                cmd.Parameters.Add("@ip", SqlDbType.NVarChar).Value = textIP.Text;
                cmd.Parameters.Add("@mac", SqlDbType.NVarChar).Value = textMAC.Text;
                cmd.Parameters.Add("@domain_name", SqlDbType.NText).Value = textDomainName.Text;
                cmd.Parameters.Add("@id_worker", SqlDbType.Int).Value = comboBoxWorkerName.SelectedIndex;
                cmd.Parameters.Add("@id_departmentintint", SqlDbType.Int).Value = idDepartment;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void WorkspaceCreateForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_loadWorkers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            foreach (DataRow row in dt.Rows)
            {
                string fullName = row["secondName"] + " " + row["name"] + " " + row["middleName"];
                comboBoxWorkerName.Items.Add(fullName);
                if (comboBoxWorkerName.Items.Count > 0)
                    comboBoxWorkerName.SelectedIndex = 0;
            }
            con.Close();
        }
    }
}
