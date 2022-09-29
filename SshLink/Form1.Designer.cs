namespace SshLink
{
    partial class Form1
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
            this.tlpTable = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtUserOutput = new System.Windows.Forms.TextBox();
            this.lstDeviceNames = new System.Windows.Forms.ListBox();
            this.lstMac = new System.Windows.Forms.ListBox();
            this.lstUser = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtMac = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblMac = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tlpTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTable
            // 
            this.tlpTable.ColumnCount = 3;
            this.tlpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpTable.Controls.Add(this.textBox1, 0, 0);
            this.tlpTable.Controls.Add(this.textBox2, 1, 0);
            this.tlpTable.Controls.Add(this.txtUserOutput, 2, 0);
            this.tlpTable.Controls.Add(this.lstDeviceNames, 0, 1);
            this.tlpTable.Controls.Add(this.lstMac, 1, 1);
            this.tlpTable.Controls.Add(this.lstUser, 2, 1);
            this.tlpTable.Location = new System.Drawing.Point(12, 12);
            this.tlpTable.Name = "tlpTable";
            this.tlpTable.RowCount = 2;
            this.tlpTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTable.Size = new System.Drawing.Size(548, 238);
            this.tlpTable.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Device";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(185, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Mac Address";
            // 
            // txtUserOutput
            // 
            this.txtUserOutput.Location = new System.Drawing.Point(367, 3);
            this.txtUserOutput.Name = "txtUserOutput";
            this.txtUserOutput.ReadOnly = true;
            this.txtUserOutput.Size = new System.Drawing.Size(178, 20);
            this.txtUserOutput.TabIndex = 2;
            this.txtUserOutput.Text = "User";
            // 
            // lstDeviceNames
            // 
            this.lstDeviceNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDeviceNames.FormattingEnabled = true;
            this.lstDeviceNames.Location = new System.Drawing.Point(3, 23);
            this.lstDeviceNames.Name = "lstDeviceNames";
            this.lstDeviceNames.Size = new System.Drawing.Size(176, 212);
            this.lstDeviceNames.TabIndex = 3;
            this.lstDeviceNames.SelectedIndexChanged += new System.EventHandler(this.lstDeviceNames_SelectedIndexChanged);
            // 
            // lstMac
            // 
            this.lstMac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMac.FormattingEnabled = true;
            this.lstMac.Location = new System.Drawing.Point(185, 23);
            this.lstMac.Name = "lstMac";
            this.lstMac.Size = new System.Drawing.Size(176, 212);
            this.lstMac.TabIndex = 4;
            this.lstMac.SelectedIndexChanged += new System.EventHandler(this.lstMac_SelectedIndexChanged);
            // 
            // lstUser
            // 
            this.lstUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUser.FormattingEnabled = true;
            this.lstUser.Location = new System.Drawing.Point(367, 23);
            this.lstUser.Name = "lstUser";
            this.lstUser.Size = new System.Drawing.Size(178, 212);
            this.lstUser.TabIndex = 5;
            this.lstUser.SelectedIndexChanged += new System.EventHandler(this.lstUser_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMac);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.txtMac);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(579, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a device";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(20, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Device Name";
            // 
            // txtMac
            // 
            this.txtMac.Location = new System.Drawing.Point(139, 55);
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(100, 20);
            this.txtMac.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(258, 55);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 3;
            // 
            // lblMac
            // 
            this.lblMac.AutoSize = true;
            this.lblMac.Location = new System.Drawing.Point(159, 39);
            this.lblMac.Name = "lblMac";
            this.lblMac.Size = new System.Drawing.Size(69, 13);
            this.lblMac.TabIndex = 4;
            this.lblMac.Text = "Mac Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(153, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Lime;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(579, 15);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(175, 107);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Maroon;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemove.Location = new System.Drawing.Point(760, 15);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(195, 107);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(967, 262);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tlpTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpTable.ResumeLayout(false);
            this.tlpTable.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtUserOutput;
        private System.Windows.Forms.ListBox lstDeviceNames;
        private System.Windows.Forms.ListBox lstMac;
        private System.Windows.Forms.ListBox lstUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtMac;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMac;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRemove;
    }
}

