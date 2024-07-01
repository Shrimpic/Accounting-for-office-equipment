
namespace Учёт_офисной_техники
{
    partial class WorksplaceCreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorksplaceCreateForm));
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textWorkplaceName = new System.Windows.Forms.TextBox();
            this.textIP = new System.Windows.Forms.TextBox();
            this.textMAC = new System.Windows.Forms.TextBox();
            this.textDomainName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxWorkerName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(199, 202);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "Применить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(118, 202);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textWorkplaceName
            // 
            this.textWorkplaceName.Location = new System.Drawing.Point(10, 24);
            this.textWorkplaceName.Name = "textWorkplaceName";
            this.textWorkplaceName.Size = new System.Drawing.Size(265, 20);
            this.textWorkplaceName.TabIndex = 7;
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(10, 63);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(265, 20);
            this.textIP.TabIndex = 10;
            // 
            // textMAC
            // 
            this.textMAC.Location = new System.Drawing.Point(10, 101);
            this.textMAC.Name = "textMAC";
            this.textMAC.Size = new System.Drawing.Size(265, 20);
            this.textMAC.TabIndex = 11;
            // 
            // textDomainName
            // 
            this.textDomainName.Location = new System.Drawing.Point(10, 139);
            this.textDomainName.Name = "textDomainName";
            this.textDomainName.Size = new System.Drawing.Size(265, 20);
            this.textDomainName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "IP-адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "MAC-адрес";
            // 
            // comboBoxWorkerName
            // 
            this.comboBoxWorkerName.FormattingEnabled = true;
            this.comboBoxWorkerName.Location = new System.Drawing.Point(10, 176);
            this.comboBoxWorkerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxWorkerName.Name = "comboBoxWorkerName";
            this.comboBoxWorkerName.Size = new System.Drawing.Size(265, 21);
            this.comboBoxWorkerName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Название рабочей станции";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Доменное имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Отвественный сотрудник";
            // 
            // WorksplaceCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 229);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxWorkerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDomainName);
            this.Controls.Add(this.textMAC);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textWorkplaceName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WorksplaceCreateForm";
            this.Text = "Создание рабочего места";
            this.Load += new System.EventHandler(this.WorkspaceCreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textWorkplaceName;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.TextBox textMAC;
        private System.Windows.Forms.TextBox textDomainName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxWorkerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}