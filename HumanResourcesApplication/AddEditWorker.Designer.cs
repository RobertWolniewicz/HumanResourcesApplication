namespace HumanResourcesApplication
{
    partial class AddEditWorker
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
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.lbComments = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbEmploymentData = new System.Windows.Forms.Label();
            this.tbDismissalData = new System.Windows.Forms.TextBox();
            this.lbDismissalDate = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.dtpEmploymentData = new System.Windows.Forms.DateTimePicker();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.nudSalary = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(12, 12);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(17, 15);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Id";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(117, 12);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(200, 23);
            this.tbId.TabIndex = 1;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(117, 41);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(200, 23);
            this.tbFirstName.TabIndex = 3;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(12, 41);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(30, 15);
            this.lbFirstName.TabIndex = 2;
            this.lbFirstName.Text = "Imie";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(117, 70);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(200, 23);
            this.tbLastName.TabIndex = 5;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(12, 70);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(57, 15);
            this.lbLastName.TabIndex = 4;
            this.lbLastName.Text = "Nazwisko";
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(117, 215);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(200, 96);
            this.rtbComments.TabIndex = 16;
            this.rtbComments.Text = "";
            // 
            // lbComments
            // 
            this.lbComments.AutoSize = true;
            this.lbComments.Location = new System.Drawing.Point(12, 215);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(40, 15);
            this.lbComments.TabIndex = 17;
            this.lbComments.Text = "Uwagi";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(117, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 31);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(229, 335);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(88, 31);
            this.btnConfirm.TabIndex = 19;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbEmploymentData
            // 
            this.lbEmploymentData.AutoSize = true;
            this.lbEmploymentData.Location = new System.Drawing.Point(12, 99);
            this.lbEmploymentData.Name = "lbEmploymentData";
            this.lbEmploymentData.Size = new System.Drawing.Size(99, 15);
            this.lbEmploymentData.TabIndex = 20;
            this.lbEmploymentData.Text = "Data zatrudnienia";
            // 
            // tbDismissalData
            // 
            this.tbDismissalData.Location = new System.Drawing.Point(117, 128);
            this.tbDismissalData.Name = "tbDismissalData";
            this.tbDismissalData.ReadOnly = true;
            this.tbDismissalData.Size = new System.Drawing.Size(200, 23);
            this.tbDismissalData.TabIndex = 23;
            // 
            // lbDismissalDate
            // 
            this.lbDismissalDate.AutoSize = true;
            this.lbDismissalDate.Location = new System.Drawing.Point(12, 128);
            this.lbDismissalDate.Name = "lbDismissalDate";
            this.lbDismissalDate.Size = new System.Drawing.Size(90, 15);
            this.lbDismissalDate.TabIndex = 22;
            this.lbDismissalDate.Text = "Data zwolnienia";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Location = new System.Drawing.Point(12, 157);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(47, 15);
            this.lbSalary.TabIndex = 24;
            this.lbSalary.Text = "Zarobki";
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Location = new System.Drawing.Point(12, 186);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(32, 15);
            this.lbDepartment.TabIndex = 27;
            this.lbDepartment.Text = "Dział";
            // 
            // dtpEmploymentData
            // 
            this.dtpEmploymentData.Location = new System.Drawing.Point(117, 99);
            this.dtpEmploymentData.Name = "dtpEmploymentData";
            this.dtpEmploymentData.Size = new System.Drawing.Size(200, 23);
            this.dtpEmploymentData.TabIndex = 28;
            // 
            // tbDepartment
            // 
            this.tbDepartment.Location = new System.Drawing.Point(117, 186);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(200, 23);
            this.tbDepartment.TabIndex = 29;
            // 
            // nudSalary
            // 
            this.nudSalary.Location = new System.Drawing.Point(117, 157);
            this.nudSalary.Name = "nudSalary";
            this.nudSalary.Size = new System.Drawing.Size(200, 23);
            this.nudSalary.TabIndex = 30;
            // 
            // AddEditWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 381);
            this.Controls.Add(this.nudSalary);
            this.Controls.Add(this.tbDepartment);
            this.Controls.Add(this.dtpEmploymentData);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.tbDismissalData);
            this.Controls.Add(this.lbDismissalDate);
            this.Controls.Add(this.lbEmploymentData);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.MaximumSize = new System.Drawing.Size(374, 420);
            this.MinimumSize = new System.Drawing.Size(374, 420);
            this.Name = "AddEditWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie pracownika";
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbId;
        private TextBox tbId;
        private TextBox tbFirstName;
        private Label lbFirstName;
        private TextBox tbLastName;
        private Label lbLastName;
        private RichTextBox rtbComments;
        private Label lbComments;
        private Button btnCancel;
        private Button btnConfirm;
        private Label lbEmploymentData;
        private TextBox tbDismissalData;
        private Label lbDismissalDate;
        private Label lbSalary;
        private Label lbDepartment;
        private DateTimePicker dtpEmploymentData;
        private TextBox tbDepartment;
        private NumericUpDown nudSalary;
    }
}