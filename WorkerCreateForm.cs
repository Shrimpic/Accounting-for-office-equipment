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
    public partial class WorkerCreateForm : Form
    {
        string sqlCon;
        int tag;
        public WorkerCreateForm(string sqlCon)
        {
            InitializeComponent();
            this.sqlCon = sqlCon;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textWorkerSecondName.Text.Length == 0 || textWorkerName.Text.Length == 0 || textWorkerMiddleName.Text.Length == 0)
            {
                MessageBox.Show("Необходимо заполнить ФИО сотрудника.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_addWorker", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@secondName", SqlDbType.NText).Value = textWorkerSecondName.Text;
            cmd.Parameters.Add("@name", SqlDbType.NText).Value = textWorkerName.Text;
            cmd.Parameters.Add("@middleName", SqlDbType.NText).Value = textWorkerMiddleName.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            DialogResult = DialogResult.OK;
        }
    }
}
