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
    public partial class MainForm : Form
    {
        string sqlCon;
        int id_acc;
        public MainForm(string sqlCon, int id)
        {
            InitializeComponent();
            this.sqlCon = sqlCon;
            id_acc = id;
        }
        private void LoadDepartment()
        {
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_loadDepartments", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            foreach (DataRow row in dt.Rows)
            {
                string id_department = row["id_department"].ToString();
                string name = row["name_department"].ToString();
                TreeNode node = new TreeNode(name, 0, 0);
                node.Tag = id_department;
                tree.Nodes.Add(node);
            }
            dr.Close();
            con.Close();
        }
        private void LoadTree()
        {
            tree.Nodes.Clear();

            // Заполнение древа списком отделов
            LoadDepartment();

            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();

            // Заполнение древа списком рабочих мест
            SqlCommand cmd = new SqlCommand("sp_loadWorkplaces", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            if (id_acc == 0) // Проверка статуса пользователя
            {
                foreach (TreeNode node in tree.Nodes)
                    foreach (DataRow row in dt.Rows)
                        if (row["id_department"].ToString() == node.Tag.ToString())
                        {
                            string id_workplace = row["id_workplace"].ToString();
                            string name = row["name_workplace"].ToString();
                            TreeNode n = new TreeNode(name, 1, 1);
                            n.Tag = id_workplace;
                            node.Nodes.Add(n);
                        }
            }
            else
            {
                foreach (TreeNode node in tree.Nodes)
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["id_department"].ToString() == node.Tag.ToString())
                            if ((int)row["id_worker"] == id_acc)
                            {
                                string id_workplace = row["id_workplace"].ToString();
                                string name = row["name_workplace"].ToString();
                                TreeNode n = new TreeNode(name, 1, 1);
                                n.Tag = id_workplace;
                                node.Nodes.Add(n);
                            }
                    }
            }
            con.Close();
        }
        private void LoadDevices()
        {
            gridDevice.Rows.Clear();
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();

            // Заполнение таблицы устройств
            SqlCommand cmd = new SqlCommand("sp_сreateDevicesInfoTable", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_workplace", SqlDbType.Int).Value = tree.SelectedNode.Tag.ToString();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            foreach (DataRow rowDeviceInfo in dt.Rows)
            {
                gridDevice.Rows.Add();
                DataGridViewRow row = gridDevice.Rows[gridDevice.Rows.Count - 1];
                row.Cells[0].Value = gridDevice.Rows.Count.ToString();
                row.Cells[1].Value = rowDeviceInfo["name_device"].ToString();
                row.Cells[2].Value = rowDeviceInfo["name_device_info"].ToString();
                row.Cells[3].Value = rowDeviceInfo["number"].ToString();
                row.Cells[4].Value = rowDeviceInfo["installdate"].ToString();
                row.Cells[5].Value = rowDeviceInfo["id_device_info"].ToString();
            }
        }
        private void LoadSoft()
        {
            gridSoft.Rows.Clear();
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();

            // Заполнение таблицы ПО
            SqlCommand cmd = new SqlCommand("sp_createSoftInfoTable", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_workplace", SqlDbType.Int).Value = tree.SelectedNode.Tag.ToString();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            foreach (DataRow rowSoftInfo in dt.Rows)
            {
                gridSoft.Rows.Add();
                DataGridViewRow row = gridSoft.Rows[gridSoft.Rows.Count - 1];
                row.Cells[0].Value = gridSoft.Rows.Count.ToString();
                row.Cells[1].Value = rowSoftInfo["name_soft"].ToString();
                row.Cells[2].Value = rowSoftInfo["key"].ToString();
                row.Cells[3].Value = rowSoftInfo["license"].ToString();
                row.Cells[4].Value = rowSoftInfo["installdate"].ToString();
                row.Cells[5].Value = rowSoftInfo["id_soft"].ToString();
            }
        }
        private void tabWorkplaceControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ограничение доступа к панелям устройств и ПО
            switch (tabWorkplaceControl.SelectedIndex)
            {
                case 0:     // Выбрана "Общая информация"
                    panelDevices.Enabled = false;
                    panelSoft.Enabled = false;
                    break;
                case 1:     // Выбрана "Устройство компьютера"
                    panelDevices.Enabled = true;
                    panelSoft.Enabled = false;
                    break;
                case 2:     // Выбрана "ПО компьютера"
                    panelDevices.Enabled = false;
                    panelSoft.Enabled = true;
                    break;
            }
            this.Refresh();
        }
        private void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Управление ограничением доступа к панелям и кнопкам
            if (e.Node != null)     // Нет выбраного узла
            {
                buttonDeleteDepartment.Enabled = false;
                panelWorkplaces.Enabled = false;
            }
            if (e.Node.Level == 0)      // Отделы
            {
                buttonDeleteDepartment.Enabled = true;
                buttonCreateWorkplace.Enabled = true;
                panelWorkplaces.Enabled = true;

                buttonDeleteWorkplace.Enabled = false;
                splitContainer1.Panel2.Enabled = false;

                tabWorkplaceControl.SelectedIndex = 0;
            }
            else       // Рабочие места
            {
                buttonDeleteWorkplace.Enabled = true;
                panelWorkplaces.Enabled = true;
                splitContainer1.Panel2.Enabled = true;

                buttonCreateWorkplace.Enabled = false;
                
                // Считываем информацию о рабочем месте
                LoadDevices();
                LoadSoft();

                SqlConnection con = new SqlConnection(sqlCon);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_createWorkplaceInfoTable", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_workplace", SqlDbType.Int).Value = e.Node.Tag;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                textDomainName.Text = dt.Rows[0]["domain_name"].ToString();
                textIP.Text = dt.Rows[0]["ip"].ToString();
                textMAC.Text = dt.Rows[0]["mac"].ToString();
                textWorkerName.Text = 
                    dt.Rows[0]["secondName"].ToString() + " " + 
                    dt.Rows[0]["name"].ToString() + " " + 
                    dt.Rows[0]["middleName"].ToString();

                con.Close();
            }
        }
        private void buttonConnectLocal_Click(object sender, EventArgs e)
        {
            LoadTree();
        }
        private void buttonCreateDepartment_Click(object sender, EventArgs e)
        {
            if (id_acc == 0)
            {
                DepartmentCreateForm form = new DepartmentCreateForm(sqlCon);
                form.ShowDialog();
                LoadTree();
            }
            else MessageBox.Show("Недостаточно прав пользователя");
        }

        private void buttonDeleteDepartment_Click(object sender, EventArgs e)
        {
            if (id_acc == 0)
            {
                if (MessageBox.Show("Удалить выбранный отдел и все рабочие места связанные с ним?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(sqlCon);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_deleteDepartment", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_department", SqlDbType.Int).Value = tree.SelectedNode.Tag.ToString();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    con.Close();

                    LoadTree();
                }
            }
            else MessageBox.Show("Недостаточно прав пользователя");
        }

        private void buttonCreateWorkplace_Click(object sender, EventArgs e)
        {
            WorksplaceCreateForm form = new WorksplaceCreateForm(sqlCon, tree.SelectedNode.Tag.ToString());
            form.ShowDialog();
            LoadTree();
        }
        private void buttonDeleteWorkplace_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить выбранное рабочее место?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(sqlCon);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_deleteWorkplace", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_workplace", SqlDbType.Int).Value = tree.SelectedNode.Tag.ToString();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();

                LoadTree();
            }
        }

        private void buttonCreateDevice_Click(object sender, EventArgs e)
        {
            DeviceInfoCreateForm form = new DeviceInfoCreateForm(sqlCon, tree.SelectedNode.Tag.ToString());
            form.ShowDialog();
            LoadDevices();
        }
        
        private void buttonDeleteDevice_Click(object sender, EventArgs e)
        {
            if (gridDevice.SelectedRows.Count > 0 && MessageBox.Show("Удалить выбранное устройство?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(sqlCon);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_deleteDeviceInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_device_info", SqlDbType.Int).Value = gridDevice.SelectedRows[0].Cells[5].Value.ToString();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();

                LoadDevices();
            }
        }

        private void buttonCreateSoft_Click(object sender, EventArgs e)
        {
            SoftCreateForm form = new SoftCreateForm(sqlCon, tree.SelectedNode.Tag.ToString(), false,"0");
            form.ShowDialog();
            LoadSoft();
        }

        private void buttonDeleteSoft_Click(object sender, EventArgs e)
        {
            if (gridSoft.SelectedRows.Count > 0 && MessageBox.Show("Удалить выбранное ПО?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(sqlCon);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_deleteSoft", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_soft", SqlDbType.Int).Value = gridSoft.SelectedRows[0].Cells[5].Value.ToString();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();

                LoadSoft();
            }
        }

        private void buttonUpdateSoft_Click(object sender, EventArgs e)
        {
            SoftCreateForm form = new SoftCreateForm(sqlCon, tree.SelectedNode.Tag.ToString(), true, gridSoft.SelectedRows[0].Cells[5].Value.ToString());
            form.ShowDialog();
            LoadSoft();
        }

        private void buttonCreateDeviceType_Click(object sender, EventArgs e)
        {
            if (id_acc == 0)
            {
                DeviceCreateForm form = new DeviceCreateForm(sqlCon);
                form.ShowDialog();
            }
            else MessageBox.Show("Недостаточно прав пользователя");
        }

        private void buttonCreateWorkers_Click(object sender, EventArgs e)
        {
            if (id_acc == 0)
            {
                WorkerCreateForm form = new WorkerCreateForm(sqlCon);
                form.ShowDialog();
            }
            else MessageBox.Show("Недостаточно прав пользователя");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTree();
        }
    }
}
