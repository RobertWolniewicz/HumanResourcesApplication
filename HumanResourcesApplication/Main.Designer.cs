namespace HumanResourcesApplication
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDismissal = new System.Windows.Forms.Button();
            this.dgvHR = new System.Windows.Forms.DataGridView();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lbEmploymentStatus = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.cmbEmploymentStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAdd.Location = new System.Drawing.Point(13, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Orange;
            this.btnEdit.Location = new System.Drawing.Point(94, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDismissal
            // 
            this.btnDismissal.BackColor = System.Drawing.Color.Red;
            this.btnDismissal.Location = new System.Drawing.Point(175, 23);
            this.btnDismissal.Name = "btnDismissal";
            this.btnDismissal.Size = new System.Drawing.Size(75, 23);
            this.btnDismissal.TabIndex = 2;
            this.btnDismissal.Text = "Zwolnij";
            this.btnDismissal.UseVisualStyleBackColor = false;
            this.btnDismissal.Click += new System.EventHandler(this.btnDismissal_Click);
            // 
            // dgvHR
            // 
            this.dgvHR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHR.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHR.Location = new System.Drawing.Point(12, 53);
            this.dgvHR.Name = "dgvHR";
            this.dgvHR.RowHeadersVisible = false;
            this.dgvHR.RowTemplate.Height = 25;
            this.dgvHR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHR.Size = new System.Drawing.Size(953, 397);
            this.dgvHR.TabIndex = 4;
            this.dgvHR.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHR_CellFormatting);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(501, 24);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(128, 23);
            this.cmbDepartment.TabIndex = 5;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // lbEmploymentStatus
            // 
            this.lbEmploymentStatus.AutoSize = true;
            this.lbEmploymentStatus.Location = new System.Drawing.Point(337, 6);
            this.lbEmploymentStatus.Name = "lbEmploymentStatus";
            this.lbEmploymentStatus.Size = new System.Drawing.Size(107, 15);
            this.lbEmploymentStatus.TabIndex = 6;
            this.lbEmploymentStatus.Text = "Status zatrudnienia";
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Location = new System.Drawing.Point(501, 5);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(32, 15);
            this.lbDepartment.TabIndex = 8;
            this.lbDepartment.Text = "Dział";
            // 
            // cmbEmploymentStatus
            // 
            this.cmbEmploymentStatus.FormattingEnabled = true;
            this.cmbEmploymentStatus.Location = new System.Drawing.Point(338, 24);
            this.cmbEmploymentStatus.Name = "cmbEmploymentStatus";
            this.cmbEmploymentStatus.Size = new System.Drawing.Size(121, 23);
            this.cmbEmploymentStatus.TabIndex = 7;
            this.cmbEmploymentStatus.SelectedIndexChanged += new System.EventHandler(this.cmbEmploymentStatus_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.cmbEmploymentStatus);
            this.Controls.Add(this.lbEmploymentStatus);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.dgvHR);
            this.Controls.Add(this.btnDismissal);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "Main";
            this.Text = "Lista pracowników";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDismissal;
        private DataGridView dgvHR;
        private ComboBox cmbDepartment;
        private Label lbEmploymentStatus;
        private Label lbDepartment;
        private ComboBox cmbEmploymentStatus;
    }
}