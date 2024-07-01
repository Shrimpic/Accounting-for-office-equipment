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
    public partial class SoftCreateForm : Form
    {
        string sqlCon;
        int idWorkplace;
        bool mod;
        string idGrid;
        public SoftCreateForm(string sqlCon, string idWorkplace, bool mod, string idGrid)
        {
            InitializeComponent();
            this.sqlCon = sqlCon;
            this.idWorkplace = int.Parse(idWorkplace);
            this.mod = mod;
            this.idGrid = idGrid;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textSoftName.Text.Length == 0)
            {
                MessageBox.Show("Необходимо заполнить название программного обеспечения.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();

            if (mod == false)
            {
                SqlCommand cmd = new SqlCommand("sp_addSoft", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@license", SqlDbType.NText).Value = textLicense.Text;
                cmd.Parameters.Add("@key", SqlDbType.NText).Value = textLicenseKey.Text;
                cmd.Parameters.Add("@name_soft", SqlDbType.NText).Value = textSoftName.Text;
                cmd.Parameters.Add("@installdate", SqlDbType.Date).Value = dateTimePicker.Value.Date;
                cmd.Parameters.Add("@id_workplace", SqlDbType.Int).Value = idWorkplace;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("sp_updateSoft", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@license", SqlDbType.NText).Value = textLicense.Text;
                cmd.Parameters.Add("@key", SqlDbType.NText).Value = textLicenseKey.Text;
                cmd.Parameters.Add("@name_soft", SqlDbType.NText).Value = textSoftName.Text;
                cmd.Parameters.Add("@installdate", SqlDbType.Date).Value = dateTimePicker.Value.Date;
                cmd.Parameters.Add("@id_workplace", SqlDbType.Int).Value = idWorkplace;
                cmd.Parameters.Add("@id_soft", SqlDbType.Int).Value = idGrid;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
            }

            con.Close();
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
