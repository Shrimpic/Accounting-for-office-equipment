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
    public partial class DeviceCreateForm : Form
    {
        string sqlCon;
        public DeviceCreateForm(string sqlCon)
        {
            InitializeComponent();
            this.sqlCon = sqlCon;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textDeviceTypeName.Text.Length == 0)
            {
                MessageBox.Show("Поле ввода не может быть пустым.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection con = new SqlConnection(sqlCon);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_addDevice", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@name_device", SqlDbType.NText).Value = textDeviceTypeName.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
