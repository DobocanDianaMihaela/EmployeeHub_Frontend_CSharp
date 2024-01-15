
using MySql.Data.MySqlClient;

namespace WindowsForm
{
    public partial class Form1 : Form
    {

        EmployeeService employeeService;
        List<Employee> employeeList;

        public Form1()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            employeeService.createConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var employeeList = employeeService.getEmployeeList();

            comboBox1.DataSource = employeeList;
            comboBox1.DisplayMember = "Name";
        }

 
        private void btnInsert_Click(object sender, EventArgs e)
        {
            int departmentId;

            if (int.TryParse(textBoxInsDepId.Text, out departmentId))
            {
                int managerId = 0; 

                if (checkBoxIsManager.Checked) 
                {
                    managerId = GetManagerIdForDepartment(departmentId); 
                    if (managerId == -1)
                    {
                        MessageBox.Show("Nu s-a găsit managerID pentru departmentID-ul introdus.");
                        return;
                    }
                }

                Employee newEmployee = new Employee
                {
                    name = textBoxInsName.Text,
                    departmentID = departmentId,
                    email = textBoxInsEmail.Text,
                    managerID = managerId
                };

                bool success = employeeService.InsertEmployee(newEmployee);

                if (success)
                {
                    MessageBox.Show("Angajatul a fost inserat cu succes în baza de date.");

                    textBoxInsDepId.Clear();
                    textBoxInsName.Clear();
                    textBoxInsEmail.Clear();
                    checkBoxIsManager.Checked = false;

                    button1_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Eroare la inserarea angajatului în baza de date.");
                }
            }
            else
            {
                MessageBox.Show("Te rog completează corect toate câmpurile de ID cu valori numerice.");
            }
        }





        public int GetManagerIdForDepartment(int departmentId)
        {
            string connectionString = "server=localhost;user=root;password=ADDcamera321!;database=departmentmanagement";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT managerId FROM Department WHERE departmentId = @DepartmentId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DepartmentId", departmentId);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : -1;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Eroare: " + ex.Message);
                        return -1;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int employeeIdToDelete;

            if (!int.TryParse(textBoxDeleteId.Text, out employeeIdToDelete))
            {
                MessageBox.Show("Introduceți un ID valid pentru ștergere.");
                return;
            }

            bool deletionResult = employeeService.DeleteEmployee(employeeIdToDelete);

            if (deletionResult)
            {
                MessageBox.Show("Ștergere cu succes!");
                textBoxDeleteId.Clear();
                button1_Click(sender, e); 
            }
            else
            {
                MessageBox.Show("Ștergere eșuată! Angajatul nu a fost găsit sau a apărut o eroare.");
            }
        }

       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int employeeIdToUpdate;
            if (!int.TryParse(textBoxUpdId.Text, out employeeIdToUpdate))
            {
                MessageBox.Show("Introduceți un ID valid pentru actualizare.");
                return;
            }

            Employee updatedEmployee = new Employee();

            if (!string.IsNullOrEmpty(textBoxUpdName.Text))
            {
                updatedEmployee.name = textBoxUpdName.Text;
            }
            if (!string.IsNullOrEmpty(textBoxUpdEmail.Text))
            {
                updatedEmployee.email = textBoxUpdEmail.Text;
            }

            int departmentId;
            if (!string.IsNullOrEmpty(textBoxupdDepId.Text) && int.TryParse(textBoxupdDepId.Text, out departmentId))
            {

                int managerId = GetManagerIdForDepartment(departmentId);

             
                bool wasManager = managerId != 0;

           
                DialogResult result = MessageBox.Show("Doriți să fie manager?", "Confirmare", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    
                    if (managerId != -1)
                    {
                        updatedEmployee.departmentID = departmentId;
                        updatedEmployee.managerID = managerId;
                    }
                    else
                    {
                        MessageBox.Show("DepartmentID-ul introdus nu există în baza de date.");
                        return;
                    }
                }
                else
                {
                    
                    updatedEmployee.departmentID = departmentId;
                    updatedEmployee.managerID = 0;
                    MessageBox.Show("Angajatul a fost scos din functia de manager.");
                }
            }
            bool updateResult = employeeService.UpdateEmployee(employeeIdToUpdate, updatedEmployee, this);

            if (updateResult)
            {
                MessageBox.Show("Actualizare reușită în baza de date!");
            }
            else
            {
                MessageBox.Show("Eroare la actualizare sau ID inexistent!");
            }


            textBoxUpdId.Clear();
            textBoxUpdName.Clear();
            textBoxUpdEmail.Clear();
            textBoxupdDepId.Clear();
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}