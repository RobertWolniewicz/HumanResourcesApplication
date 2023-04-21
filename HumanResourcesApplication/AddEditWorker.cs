using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourcesApplication
{
    public partial class AddEditWorker : Form
    {
        int _workerId;
        int _newItemId;
        Worker _worker;
        List<Department> _departments;

        FileHelper<List<Worker>> _workerFileHelper =
             new FileHelper<List<Worker>>(Program.WorkersFilePath);
        FileHelper<List<Department>> _departmentFileHelper =
    new FileHelper<List<Department>>(Program.DepartmentsFilePath);

        public AddEditWorker(int id = 0)
        {
            InitializeComponent();
            _departments = _departmentFileHelper.DeserializeFromFile();
            _workerId = id;
            GetWorkerData();
            tbFirstName.Select();
        }

        void GetWorkerData()
        {
            if (_workerId != 0)
            {
                Text = "Edytowanie danych pracownika";

                var workers = _workerFileHelper.DeserializeFromFile();
                _worker = workers.FirstOrDefault(s => s.Id == _workerId);

                if (_worker == null)
                    throw new Exception("Brak pracownika o podanym Id");

                FillBoxes();
            }
        }

        void FillBoxes()
        {
            tbId.Text = _worker.Id.ToString();
            tbFirstName.Text = _worker.FirstName;
            tbLastName.Text = _worker.LastName;
            dtpEmploymentData.Value = _worker.DateOfEmployment;
            rtbComments.Text = _worker.Comments;
            tbDismissalData.Text = _worker.DismissalDate.ToString();
            tbSalary.Text = _worker.Salary.ToString();
            tbDepartment.Text = _departments.FirstOrDefault(x => x.Id == _worker.DepartmentId).Name;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(tbSalary.Text, out var salary))
            {
                MessageBox.Show("Niepoprawne wartosc pensji");
                return;
            }

            if (!_departments.Any(x => x.Name == tbDepartment.Text))
            {
                AssignId(_departments);
                AddNewDepartmentToList();
                _departmentFileHelper.SerializeToFile(_departments);
            }

            var workers = _workerFileHelper.DeserializeFromFile();

            if (_workerId != 0)
            {
                workers.RemoveAll(x => x.Id == _workerId);
            }
            else
                AssignId(workers);

            AddNewUserToList(workers);

            _workerFileHelper.SerializeToFile(workers);

            Close();
        }

        private void AddNewDepartmentToList()
        {
            var department = new Department
            {
                Id = _newItemId,
                Name = tbDepartment.Text,
            };
            _departments.Add(department);
        }

        void AddNewUserToList(List<Worker> workers)
        {

            var worker = new Worker
            {
                Id = _newItemId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                DateOfEmployment = dtpEmploymentData.Value.Date,
                Comments = rtbComments.Text,
                Salary = Int32.Parse(tbSalary.Text),
                DepartmentId = _departments.First(x =>x.Name== tbDepartment.Text).Id,
            };
            workers.Add(worker);
        }

        void AssignId<T>(List<T> items) where T : IHadId
        {
            var itemWithHighterId = items
                    .OrderByDescending(x => x.Id).FirstOrDefault();

            _newItemId = itemWithHighterId == null ?
               1 : itemWithHighterId.Id + 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
