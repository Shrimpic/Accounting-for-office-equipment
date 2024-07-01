
namespace Учёт_офисной_техники
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelSoft = new System.Windows.Forms.Panel();
            this.buttonUpdateSoft = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDeleteSoft = new System.Windows.Forms.Button();
            this.buttonCreateSoft = new System.Windows.Forms.Button();
            this.panelDevices = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDeleteDevice = new System.Windows.Forms.Button();
            this.buttonCreateDevice = new System.Windows.Forms.Button();
            this.panelWorkplaces = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteWorkplace = new System.Windows.Forms.Button();
            this.buttonCreateWorkplace = new System.Windows.Forms.Button();
            this.panelDepartments = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteDepartment = new System.Windows.Forms.Button();
            this.buttonCreateDepartment = new System.Windows.Forms.Button();
            this.Файл = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonCreateDeviceType = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCreateWorkers = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tree = new System.Windows.Forms.TreeView();
            this.tabWorkplaceControl = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textWorkerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textMAC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textDomainName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gridDevice = new System.Windows.Forms.DataGridView();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gridSoft = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1.SuspendLayout();
            this.panelSoft.SuspendLayout();
            this.panelDevices.SuspendLayout();
            this.panelWorkplaces.SuspendLayout();
            this.panelDepartments.SuspendLayout();
            this.Файл.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabWorkplaceControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDevice)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSoft)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(4, 4);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(149, 71);
            this.button3.TabIndex = 0;
            this.button3.Text = "Открыть файл систем";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelSoft);
            this.tabPage1.Controls.Add(this.panelDevices);
            this.tabPage1.Controls.Add(this.panelWorkplaces);
            this.tabPage1.Controls.Add(this.panelDepartments);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(895, 108);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Рабочие места";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelSoft
            // 
            this.panelSoft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSoft.Controls.Add(this.buttonUpdateSoft);
            this.panelSoft.Controls.Add(this.label4);
            this.panelSoft.Controls.Add(this.buttonDeleteSoft);
            this.panelSoft.Controls.Add(this.buttonCreateSoft);
            this.panelSoft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSoft.Enabled = false;
            this.panelSoft.Location = new System.Drawing.Point(474, 2);
            this.panelSoft.Margin = new System.Windows.Forms.Padding(2);
            this.panelSoft.Name = "panelSoft";
            this.panelSoft.Size = new System.Drawing.Size(256, 104);
            this.panelSoft.TabIndex = 4;
            // 
            // buttonUpdateSoft
            // 
            this.buttonUpdateSoft.Image = global::Учёт_офисной_техники.Properties.Resources.Soft_change;
            this.buttonUpdateSoft.Location = new System.Drawing.Point(155, 2);
            this.buttonUpdateSoft.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateSoft.Name = "buttonUpdateSoft";
            this.buttonUpdateSoft.Size = new System.Drawing.Size(94, 80);
            this.buttonUpdateSoft.TabIndex = 3;
            this.buttonUpdateSoft.Text = "Редактировать ПО";
            this.buttonUpdateSoft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUpdateSoft.UseVisualStyleBackColor = true;
            this.buttonUpdateSoft.Click += new System.EventHandler(this.buttonUpdateSoft_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(0, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Программное обеспечение";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDeleteSoft
            // 
            this.buttonDeleteSoft.Image = global::Учёт_офисной_техники.Properties.Resources.Soft_delete;
            this.buttonDeleteSoft.Location = new System.Drawing.Point(80, 2);
            this.buttonDeleteSoft.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteSoft.Name = "buttonDeleteSoft";
            this.buttonDeleteSoft.Size = new System.Drawing.Size(70, 80);
            this.buttonDeleteSoft.TabIndex = 1;
            this.buttonDeleteSoft.Text = "Удалить ПО";
            this.buttonDeleteSoft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteSoft.UseVisualStyleBackColor = true;
            this.buttonDeleteSoft.Click += new System.EventHandler(this.buttonDeleteSoft_Click);
            // 
            // buttonCreateSoft
            // 
            this.buttonCreateSoft.Image = global::Учёт_офисной_техники.Properties.Resources.Soft_add;
            this.buttonCreateSoft.Location = new System.Drawing.Point(4, 2);
            this.buttonCreateSoft.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateSoft.Name = "buttonCreateSoft";
            this.buttonCreateSoft.Size = new System.Drawing.Size(72, 80);
            this.buttonCreateSoft.TabIndex = 0;
            this.buttonCreateSoft.Text = "Добавить ПО";
            this.buttonCreateSoft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCreateSoft.UseVisualStyleBackColor = true;
            this.buttonCreateSoft.Click += new System.EventHandler(this.buttonCreateSoft_Click);
            // 
            // panelDevices
            // 
            this.panelDevices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDevices.Controls.Add(this.label3);
            this.panelDevices.Controls.Add(this.buttonDeleteDevice);
            this.panelDevices.Controls.Add(this.buttonCreateDevice);
            this.panelDevices.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDevices.Enabled = false;
            this.panelDevices.Location = new System.Drawing.Point(316, 2);
            this.panelDevices.Margin = new System.Windows.Forms.Padding(2);
            this.panelDevices.Name = "panelDevices";
            this.panelDevices.Size = new System.Drawing.Size(158, 104);
            this.panelDevices.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(0, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Устройства";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDeleteDevice
            // 
            this.buttonDeleteDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteDevice.Image = global::Учёт_офисной_техники.Properties.Resources.Device_delete;
            this.buttonDeleteDevice.Location = new System.Drawing.Point(80, 2);
            this.buttonDeleteDevice.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteDevice.Name = "buttonDeleteDevice";
            this.buttonDeleteDevice.Size = new System.Drawing.Size(74, 78);
            this.buttonDeleteDevice.TabIndex = 1;
            this.buttonDeleteDevice.Text = "Удалить устройство";
            this.buttonDeleteDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteDevice.UseVisualStyleBackColor = true;
            this.buttonDeleteDevice.Click += new System.EventHandler(this.buttonDeleteDevice_Click);
            // 
            // buttonCreateDevice
            // 
            this.buttonCreateDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateDevice.Image = global::Учёт_офисной_техники.Properties.Resources.Device_add;
            this.buttonCreateDevice.Location = new System.Drawing.Point(4, 2);
            this.buttonCreateDevice.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateDevice.Name = "buttonCreateDevice";
            this.buttonCreateDevice.Size = new System.Drawing.Size(72, 78);
            this.buttonCreateDevice.TabIndex = 0;
            this.buttonCreateDevice.Text = "Добавить устройство";
            this.buttonCreateDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCreateDevice.UseVisualStyleBackColor = true;
            this.buttonCreateDevice.Click += new System.EventHandler(this.buttonCreateDevice_Click);
            // 
            // panelWorkplaces
            // 
            this.panelWorkplaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWorkplaces.Controls.Add(this.label2);
            this.panelWorkplaces.Controls.Add(this.buttonDeleteWorkplace);
            this.panelWorkplaces.Controls.Add(this.buttonCreateWorkplace);
            this.panelWorkplaces.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelWorkplaces.Enabled = false;
            this.panelWorkplaces.Location = new System.Drawing.Point(159, 2);
            this.panelWorkplaces.Margin = new System.Windows.Forms.Padding(2);
            this.panelWorkplaces.Name = "panelWorkplaces";
            this.panelWorkplaces.Size = new System.Drawing.Size(157, 104);
            this.panelWorkplaces.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Рабочее место";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDeleteWorkplace
            // 
            this.buttonDeleteWorkplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteWorkplace.Image = global::Учёт_офисной_техники.Properties.Resources.PC_delete;
            this.buttonDeleteWorkplace.Location = new System.Drawing.Point(80, 2);
            this.buttonDeleteWorkplace.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteWorkplace.Name = "buttonDeleteWorkplace";
            this.buttonDeleteWorkplace.Size = new System.Drawing.Size(70, 78);
            this.buttonDeleteWorkplace.TabIndex = 1;
            this.buttonDeleteWorkplace.Text = "Удалить место";
            this.buttonDeleteWorkplace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteWorkplace.UseVisualStyleBackColor = true;
            this.buttonDeleteWorkplace.Click += new System.EventHandler(this.buttonDeleteWorkplace_Click);
            // 
            // buttonCreateWorkplace
            // 
            this.buttonCreateWorkplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateWorkplace.Image = global::Учёт_офисной_техники.Properties.Resources.PC_add;
            this.buttonCreateWorkplace.Location = new System.Drawing.Point(4, 2);
            this.buttonCreateWorkplace.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateWorkplace.Name = "buttonCreateWorkplace";
            this.buttonCreateWorkplace.Size = new System.Drawing.Size(72, 78);
            this.buttonCreateWorkplace.TabIndex = 0;
            this.buttonCreateWorkplace.Text = "Добавить место";
            this.buttonCreateWorkplace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCreateWorkplace.UseVisualStyleBackColor = true;
            this.buttonCreateWorkplace.Click += new System.EventHandler(this.buttonCreateWorkplace_Click);
            // 
            // panelDepartments
            // 
            this.panelDepartments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDepartments.Controls.Add(this.label1);
            this.panelDepartments.Controls.Add(this.buttonDeleteDepartment);
            this.panelDepartments.Controls.Add(this.buttonCreateDepartment);
            this.panelDepartments.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDepartments.Location = new System.Drawing.Point(2, 2);
            this.panelDepartments.Margin = new System.Windows.Forms.Padding(2);
            this.panelDepartments.Name = "panelDepartments";
            this.panelDepartments.Size = new System.Drawing.Size(157, 104);
            this.panelDepartments.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Отдел";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDeleteDepartment
            // 
            this.buttonDeleteDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteDepartment.Enabled = false;
            this.buttonDeleteDepartment.Image = global::Учёт_офисной_техники.Properties.Resources.Depatment_delete;
            this.buttonDeleteDepartment.Location = new System.Drawing.Point(80, 2);
            this.buttonDeleteDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteDepartment.Name = "buttonDeleteDepartment";
            this.buttonDeleteDepartment.Size = new System.Drawing.Size(70, 78);
            this.buttonDeleteDepartment.TabIndex = 1;
            this.buttonDeleteDepartment.Text = "Удалить отдел";
            this.buttonDeleteDepartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteDepartment.UseVisualStyleBackColor = true;
            this.buttonDeleteDepartment.Click += new System.EventHandler(this.buttonDeleteDepartment_Click);
            // 
            // buttonCreateDepartment
            // 
            this.buttonCreateDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateDepartment.Image = global::Учёт_офисной_техники.Properties.Resources.Depatment_add;
            this.buttonCreateDepartment.Location = new System.Drawing.Point(4, 2);
            this.buttonCreateDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateDepartment.Name = "buttonCreateDepartment";
            this.buttonCreateDepartment.Size = new System.Drawing.Size(72, 78);
            this.buttonCreateDepartment.TabIndex = 0;
            this.buttonCreateDepartment.Text = "Добавить отдел";
            this.buttonCreateDepartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCreateDepartment.UseVisualStyleBackColor = true;
            this.buttonCreateDepartment.Click += new System.EventHandler(this.buttonCreateDepartment_Click);
            // 
            // Файл
            // 
            this.Файл.Controls.Add(this.tabPage1);
            this.Файл.Controls.Add(this.tabPage6);
            this.Файл.Dock = System.Windows.Forms.DockStyle.Top;
            this.Файл.Location = new System.Drawing.Point(0, 0);
            this.Файл.Margin = new System.Windows.Forms.Padding(2);
            this.Файл.Name = "Файл";
            this.Файл.SelectedIndex = 0;
            this.Файл.Size = new System.Drawing.Size(903, 134);
            this.Файл.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.panel8);
            this.tabPage6.Controls.Add(this.panel7);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage6.Size = new System.Drawing.Size(895, 108);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Справочники";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.buttonCreateDeviceType);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(90, 2);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(82, 104);
            this.panel8.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Location = new System.Drawing.Point(0, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Шаблоны";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCreateDeviceType
            // 
            this.buttonCreateDeviceType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateDeviceType.Location = new System.Drawing.Point(4, 2);
            this.buttonCreateDeviceType.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateDeviceType.Name = "buttonCreateDeviceType";
            this.buttonCreateDeviceType.Size = new System.Drawing.Size(72, 78);
            this.buttonCreateDeviceType.TabIndex = 0;
            this.buttonCreateDeviceType.Text = "Типы устройств";
            this.buttonCreateDeviceType.UseVisualStyleBackColor = true;
            this.buttonCreateDeviceType.Click += new System.EventHandler(this.buttonCreateDeviceType_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.buttonCreateWorkers);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(2, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(88, 104);
            this.panel7.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Location = new System.Drawing.Point(0, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Списки";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCreateWorkers
            // 
            this.buttonCreateWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateWorkers.Location = new System.Drawing.Point(4, 2);
            this.buttonCreateWorkers.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateWorkers.Name = "buttonCreateWorkers";
            this.buttonCreateWorkers.Size = new System.Drawing.Size(80, 78);
            this.buttonCreateWorkers.TabIndex = 0;
            this.buttonCreateWorkers.Text = "Сотрудники";
            this.buttonCreateWorkers.UseVisualStyleBackColor = true;
            this.buttonCreateWorkers.Click += new System.EventHandler(this.buttonCreateWorkers_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 134);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(903, 451);
            this.panel4.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabWorkplaceControl);
            this.splitContainer1.Panel2.Enabled = false;
            this.splitContainer1.Size = new System.Drawing.Size(903, 451);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // tree
            // 
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.Location = new System.Drawing.Point(0, 0);
            this.tree.Margin = new System.Windows.Forms.Padding(2);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(271, 451);
            this.tree.TabIndex = 0;
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
            // 
            // tabWorkplaceControl
            // 
            this.tabWorkplaceControl.Controls.Add(this.tabPage3);
            this.tabWorkplaceControl.Controls.Add(this.tabPage4);
            this.tabWorkplaceControl.Controls.Add(this.tabPage5);
            this.tabWorkplaceControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabWorkplaceControl.Location = new System.Drawing.Point(0, 0);
            this.tabWorkplaceControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabWorkplaceControl.Name = "tabWorkplaceControl";
            this.tabWorkplaceControl.SelectedIndex = 0;
            this.tabWorkplaceControl.Size = new System.Drawing.Size(629, 451);
            this.tabWorkplaceControl.TabIndex = 0;
            this.tabWorkplaceControl.SelectedIndexChanged += new System.EventHandler(this.tabWorkplaceControl_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textWorkerName);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textMAC);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.textIP);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.textDomainName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(621, 425);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Общая информация";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textWorkerName
            // 
            this.textWorkerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textWorkerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textWorkerName.Location = new System.Drawing.Point(107, 112);
            this.textWorkerName.Name = "textWorkerName";
            this.textWorkerName.ReadOnly = true;
            this.textWorkerName.Size = new System.Drawing.Size(510, 20);
            this.textWorkerName.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "MAC адрес:";
            // 
            // textMAC
            // 
            this.textMAC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMAC.Location = new System.Drawing.Point(107, 88);
            this.textMAC.Name = "textMAC";
            this.textMAC.ReadOnly = true;
            this.textMAC.Size = new System.Drawing.Size(510, 20);
            this.textMAC.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Отв. сотрудник:";
            // 
            // textIP
            // 
            this.textIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIP.Location = new System.Drawing.Point(107, 61);
            this.textIP.Name = "textIP";
            this.textIP.ReadOnly = true;
            this.textIP.Size = new System.Drawing.Size(510, 20);
            this.textIP.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Доменное имя:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "IP адрес:";
            // 
            // textDomainName
            // 
            this.textDomainName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDomainName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDomainName.Location = new System.Drawing.Point(107, 35);
            this.textDomainName.Name = "textDomainName";
            this.textDomainName.ReadOnly = true;
            this.textDomainName.Size = new System.Drawing.Size(510, 20);
            this.textDomainName.TabIndex = 7;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gridDevice);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(621, 425);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Устройства компьютера";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gridDevice
            // 
            this.gridDevice.AllowUserToAddRows = false;
            this.gridDevice.AllowUserToDeleteRows = false;
            this.gridDevice.AllowUserToResizeColumns = false;
            this.gridDevice.AllowUserToResizeRows = false;
            this.gridDevice.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n,
            this.part,
            this.name,
            this.number,
            this.date,
            this.id});
            this.gridDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDevice.GridColor = System.Drawing.Color.WhiteSmoke;
            this.gridDevice.Location = new System.Drawing.Point(2, 2);
            this.gridDevice.MultiSelect = false;
            this.gridDevice.Name = "gridDevice";
            this.gridDevice.ReadOnly = true;
            this.gridDevice.RowHeadersVisible = false;
            this.gridDevice.RowHeadersWidth = 51;
            this.gridDevice.RowTemplate.Height = 20;
            this.gridDevice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDevice.Size = new System.Drawing.Size(617, 421);
            this.gridDevice.TabIndex = 1;
            // 
            // n
            // 
            this.n.HeaderText = "N:";
            this.n.MinimumWidth = 6;
            this.n.Name = "n";
            this.n.ReadOnly = true;
            this.n.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.n.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.n.Width = 30;
            // 
            // part
            // 
            this.part.HeaderText = "Устройство";
            this.part.MinimumWidth = 6;
            this.part.Name = "part";
            this.part.ReadOnly = true;
            this.part.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.part.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.part.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "Модель";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 210;
            // 
            // number
            // 
            this.number.HeaderText = "Интвент. номер";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.number.Width = 105;
            // 
            // date
            // 
            this.date.HeaderText = "Дата установки";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.date.Width = 105;
            // 
            // id
            // 
            this.id.HeaderText = "";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gridSoft);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(621, 425);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "ПО компьютера";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // gridSoft
            // 
            this.gridSoft.AllowUserToAddRows = false;
            this.gridSoft.AllowUserToDeleteRows = false;
            this.gridSoft.AllowUserToResizeColumns = false;
            this.gridSoft.AllowUserToResizeRows = false;
            this.gridSoft.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridSoft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSoft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.gridSoft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSoft.GridColor = System.Drawing.Color.WhiteSmoke;
            this.gridSoft.Location = new System.Drawing.Point(2, 2);
            this.gridSoft.MultiSelect = false;
            this.gridSoft.Name = "gridSoft";
            this.gridSoft.ReadOnly = true;
            this.gridSoft.RowHeadersVisible = false;
            this.gridSoft.RowHeadersWidth = 51;
            this.gridSoft.RowTemplate.Height = 20;
            this.gridSoft.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridSoft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSoft.Size = new System.Drawing.Size(617, 421);
            this.gridSoft.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "N:";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Название программного обеспечения";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 230;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Лицензионный ключ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Тип лицензии";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата установки";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 105;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 585);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Файл);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Учёт офисной техники";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPage1.ResumeLayout(false);
            this.panelSoft.ResumeLayout(false);
            this.panelDevices.ResumeLayout(false);
            this.panelWorkplaces.ResumeLayout(false);
            this.panelDepartments.ResumeLayout(false);
            this.Файл.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabWorkplaceControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDevice)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSoft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl Файл;
        private System.Windows.Forms.Panel panelDepartments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteDepartment;
        private System.Windows.Forms.Button buttonCreateDepartment;
        private System.Windows.Forms.Panel panelWorkplaces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDeleteWorkplace;
        private System.Windows.Forms.Button buttonCreateWorkplace;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.TabControl tabWorkplaceControl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panelSoft;
        private System.Windows.Forms.Button buttonUpdateSoft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDeleteSoft;
        private System.Windows.Forms.Button buttonCreateSoft;
        private System.Windows.Forms.Panel panelDevices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDeleteDevice;
        private System.Windows.Forms.Button buttonCreateDevice;
        private System.Windows.Forms.TextBox textMAC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textDomainName;
        private System.Windows.Forms.DataGridView gridDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
        private System.Windows.Forms.DataGridViewTextBoxColumn part;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView gridSoft;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox textWorkerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonCreateDeviceType;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCreateWorkers;
    }
}

