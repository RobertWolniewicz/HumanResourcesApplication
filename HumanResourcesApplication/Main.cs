using HumanResourcesApplication.Properties;

namespace HumanResourcesApplication
{
    public partial class Main : Form
    {
        List<Department> _departments = new List<Department>();
        FileHelper<List<Worker>> _workerFileHelper =
            new FileHelper<List<Worker>>(Program.WorkersFilePath);
        FileHelper<List<Department>> _departmentFileHelper =
            new FileHelper<List<Department>>(Program.DepartmentsFilePath);

        public bool IsMaximize
        {
            get
            {
                return Settings.Default.IsMaximalize;
            }
            set
            {
                Settings.Default.IsMaximalize = value;
            }
        }

        public Main()
        {
            InitializeComponent();
            InitEmpoymentStatusComboBox();
            InitDepartmentComboBox();
            SetColumnsHeader();

            if (IsMaximize)
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        void InitDepartmentComboBox()
        {
            cmbDepartment.DisplayMember = "Name";
            cmbDepartment.ValueMember = "Id";
        }

        void RefreshApp()
        {
            var workers = _workerFileHelper.DeserializeFromFile();

            switch (cmbEmploymentStatus.SelectedItem.ToString())
            {
                case "Zatrudnieni":
                    workers = workers.Where(x => x.DismissalDate == null).ToList();
                    break;
                case "Zwolnieni":
                    workers = workers.Where(x => x.DismissalDate != null).ToList();
                    break;
                default:
                    break;
            }

            RefreshDepartmentsList();

            var selectedDepartmentId = ((Department)cmbDepartment.SelectedItem).Id;
            if (selectedDepartmentId != 0)
                workers = workers.Where(x => x.DepartmentId == selectedDepartmentId).ToList();

            dgvHR.DataSource = workers;
        }
        void SetColumnsHeader()
        {
            dgvHR.Columns[nameof(Worker.Id)].HeaderText = "Numer Pracownika";
            dgvHR.Columns[nameof(Worker.FirstName)].HeaderText = "Imie";
            dgvHR.Columns[nameof(Worker.LastName)].HeaderText = "Nazwisko";
            dgvHR.Columns[nameof(Worker.Comments)].HeaderText = "Uwagi";
            dgvHR.Columns[nameof(Worker.DateOfEmployment)].HeaderText = "Data zatrudnienia";
            dgvHR.Columns[nameof(Worker.DismissalDate)].HeaderText = "Data zwolnienia";
            dgvHR.Columns[nameof(Worker.Salary)].HeaderText = "Zarobki";
            dgvHR.Columns[nameof(Worker.DepartmentId)].HeaderText = "Dzia³";
        }
        void InitEmpoymentStatusComboBox()
        {
            var items = new List<string> { "Wszyscy", "Zatrudnieni", "Zwolnieni" };
            cmbEmploymentStatus.DataSource = items;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEditWorker = new AddEditWorker();
            addEditWorker.FormClosing += AddEditWorker_FormClosing;
            addEditWorker.ShowDialog();
        }

        private void AddEditWorker_FormClosing(object? sender, FormClosingEventArgs e)
        {
            RefreshApp();
        }

        private void RefreshDepartmentsList()
        {
            _departments.Clear();
            _departments.Add(new Department
            {
                Id = 0,
                Name = "Wszystkie"
            });
            _departments.AddRange(_departmentFileHelper.DeserializeFromFile());
            cmbDepartment.DataSource = _departments;
            cmbDepartment.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvHR.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszê zaznacz pracownika, którego dane chcesz edytowaæ");
                return;
            }

            var addEditWorker = new AddEditWorker(Convert.ToInt32(dgvHR.SelectedRows[0].Cells[0].Value));
            addEditWorker.FormClosing += AddEditWorker_FormClosing;
            addEditWorker.ShowDialog();

        }

        private void btnDismissal_Click(object sender, EventArgs e)
        {
            if (dgvHR.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszê zaznacz pracownika, którego  chcesz zwolniæ");
                return;
            }

            var selectedWorker = dgvHR.SelectedRows[0];

            var confirmDelete = MessageBox.Show($"Czy napewno chcesz zwolniæ tego pracownika?" +
                 $"{(selectedWorker.Cells[1].Value.ToString() + " " + selectedWorker.Cells[2].Value.ToString()).Trim()}",
                 "Zwalnianie",
                 MessageBoxButtons.OKCancel);
            if (confirmDelete == DialogResult.OK)
            {
                DismissalWorker(Convert.ToInt32(dgvHR.SelectedRows[0].Cells[0].Value));
                RefreshApp();
            }
        }

        void DismissalWorker(int id)
        {
            var workers = _workerFileHelper.DeserializeFromFile();
            var dismissalWorker = workers.FirstOrDefault(x => x.Id == id);
            workers.RemoveAll(x => x.Id == id);
            dismissalWorker.DismissalDate = DateTime.Now.Date;
            workers.Add(dismissalWorker);
            _workerFileHelper.SerializeToFile(workers);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                IsMaximize = true;
            }
            else
                IsMaximize = false;

            Settings.Default.Save();
        }

        private void cmbEmploymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshApp();
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshApp();
        }

        private void dgvHR_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvHR.Columns[nameof(Worker.DepartmentId)].Index && e.Value != null)
            {
                int departmentID = (int)e.Value; 
                string departmentName = _departments.First(x =>x.Id == departmentID).Name; 
                e.Value = departmentName; 
                e.FormattingApplied = true; 
            }
        }
    }
}