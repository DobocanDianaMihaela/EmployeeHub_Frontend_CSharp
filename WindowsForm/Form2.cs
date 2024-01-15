using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForm
{
    public partial class Form2 : Form
    {
        DepartmentService departmentService;
        List<Department> departmentList;
        public Form2()
        {
            InitializeComponent();
            departmentService = new DepartmentService();
            departmentService.createConnection();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            Department newDepartment = new Department();
            newDepartment.description = textBoxInsDescript.Text;

            int managerId;
            if (!int.TryParse(textBoxInsManagerId.Text, out managerId))
            {
                MessageBox.Show("Introduceți un număr valid pentru managerID.");
                return;
            }
            newDepartment.managerID = managerId;

            int parentId;
            if (!int.TryParse(textBoxInsParentId.Text, out parentId))
            {
                MessageBox.Show("Introduceți un număr valid pentru parentID.");
                return;
            }
            newDepartment.parentID = parentId;

            bool insertionResult = departmentService.InsertDepartment(newDepartment);

            if (insertionResult)
            {
                textBoxInsDescript.Clear();
                textBoxInsManagerId.Clear();
                textBoxInsParentId.Clear();

                MessageBox.Show("Inserare departamentului s-a realizat cu succes!");
            }
            else
            {
                MessageBox.Show("Inserarea departamentului a eșuat!");
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            int departmentIdToDelete;
            if (!int.TryParse(textBoxDeleteId.Text, out departmentIdToDelete))
            {
                MessageBox.Show("Introduceți un ID valid pentru ștergere.");
                return;
            }

            bool deletionResult = departmentService.DeleteDepartment(departmentIdToDelete);

            if (deletionResult)
            {
                MessageBox.Show("Ștergere departamentului s-a realizat cu succes!");
            }
            else
            {
                MessageBox.Show("Ștergerea a eșuat - ID inexistent!");
            }

            textBoxDeleteId.Clear();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            int departmentIdToUpdate;
            if (!int.TryParse(textBoxUpdId.Text, out departmentIdToUpdate))
            {
                MessageBox.Show("Introduceți un ID valid pentru actualizare.");
                return;
            }

            Department updatedDepartment = new Department();



            if (!string.IsNullOrEmpty(textBoxUpdDesc.Text))
            {
                updatedDepartment.description = textBoxUpdDesc.Text;
            }
            int managerId;
            if (!string.IsNullOrEmpty(textBoxUpdManagId.Text) && int.TryParse(textBoxUpdManagId.Text, out managerId))
            {
                updatedDepartment.managerID = managerId;
            }
            int parentId;
            if (!string.IsNullOrEmpty(textBoxupdParentId.Text) && int.TryParse(textBoxupdParentId.Text, out parentId))
            {
                updatedDepartment.parentID = parentId;
            }

            bool updateResult = departmentService.UpdateDepartment(departmentIdToUpdate, updatedDepartment);

            if (updateResult)
            {
                MessageBox.Show("Actualizare reușită în baza de date!");
            }
            else
            {
                MessageBox.Show("Eroare la actualizare sau ID inexistent!");
            }
            textBoxUpdId.Clear();
            textBoxUpdDesc.Clear();
            textBoxUpdManagId.Clear();
            textBoxupdParentId.Clear();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var departmentList = departmentService.GetDepartmentList();

            comboBox1.DataSource = departmentList;
            comboBox1.DisplayMember = "Description";
        }
    }
}



