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
    public partial class DeviceInfoCreateForm : Form
    {
        string sqlCon;
        int idWorkplace;
        public DeviceInfoCreateForm(string sqlCon, string idWorkplace)
        {
            InitializeComponent();
            this.sqlCon = sqlCon;
            this.idWorkplace = int.Parse(idWorkplace);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textDeviceModel.Text.Length == 0 || textNum.Text.Length == 0)
                MessageBox.Show("Поля ввода не может быть пустым.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                SqlConnection con = new SqlConnection(sqlCon);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_addDeviceInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@name_device_info", SqlDbType.NText).Value = textDeviceModel.Text;
                cmd.Parameters.Add("@number", SqlDbType.NText).Value = textNum.Text;
                cmd.Parameters.Add("@installdate", SqlDbType.Date).Value = dateTimePicker.Value.Date;
                cmd.Parameters.Add("@id_workplace", SqlDbType.Int).Value = idWorkplace;
                cmd.Parameters.Add("@id_device", SqlDbType.Int).Value = comboBoxDevice.SelectedIndex;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                DialogResult = DialogResult.OK;
            }
        }

        private void DeviceInfoCreateForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();


            SqlCommand cmd = new SqlCommand("sp_loadDevices", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            foreach (DataRow row in dt.Rows)
            {
                string name = row["name_device"].ToString();
                comboBoxDevice.Items.Add(name);
                if (comboBoxDevice.Items.Count > 0)
                    comboBoxDevice.SelectedIndex = 0;
            }
            con.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
