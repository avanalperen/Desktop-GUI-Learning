using E_Contact.E_ContactClasses;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace E_Contact
{
    public partial class E_Contact : Form
    {
        public E_Contact()
        {
            InitializeComponent();
        }

        contactClass c = new contactClass();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            c.firstName = textBoxFirstName.Text;
            c.lastName = textBoxLastName.Text;
            c.contactNo = textBoxContactNo.Text;
            c.address = textBoxAddress.Text;
            c.gender = comboBoxGender.Text;

            //Inserting data into database using the method created
            bool success = c.insert(c);

            if (success == true)
            {
                //Successfully inserted

                //Show message about successfully inserted data
                MessageBox.Show("New contact successfully inserted.");

                //Clear method after something inserted to reset
                clear();
            }
            else
            {
                //Failed to add contact

                //Show message about fail
                MessageBox.Show("New contact could not be inserted, please try again.");
            }

            //Load data on dataGridViewContactList
            DataTable dataTable = c.select();
            dataGridViewContactList.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dataTable = c.select();
            dataGridViewContactList.DataSource = dataTable;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Method to clear fields
        public void clear()
        {
            textBoxContactID.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxContactNo.Text = "";
            textBoxAddress.Text = "";
            comboBoxGender.Text = "";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Get the data from textboxes
            c.contactID = int.Parse(textBoxContactID.Text);
            c.firstName = textBoxFirstName.Text;
            c.lastName = textBoxLastName.Text;
            c.contactNo = textBoxContactNo.Text;
            c.address = textBoxAddress.Text;
            c.gender = comboBoxGender.Text;

            //Update data in database
            bool success = c.update(c);

            if (success == true)
            {
                //Updated successfully
                MessageBox.Show("Contact has been successfully updated.");

                //Load data on data gridView
                DataTable dataTable = c.select();
                dataGridViewContactList.DataSource = dataTable;

                //Clear method after update
                clear();
            }
            else
            {
                //Failed to update
                MessageBox.Show("Contact has not been successfully updated, please try it again.");
            }
        }

        private void dataGridViewContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data from data grid view and load it to the textboxes respectively
            //Identify the which row the mouse is clicked on
            int rowIndex = e.RowIndex;

            textBoxContactID.Text = dataGridViewContactList.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridViewContactList.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridViewContactList.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxContactNo.Text = dataGridViewContactList.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxAddress.Text = dataGridViewContactList.Rows[rowIndex].Cells[4].Value.ToString();
            comboBoxGender.Text = dataGridViewContactList.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clear method
            clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Get the contact ID from the application
            c.contactID = Convert.ToInt32(textBoxContactID.Text);

            bool success = c.delete(c);

            if (success == true)
            {
                //Successfully deleted
                MessageBox.Show("Contact is successfully deleted.");

                //Refresh datagridView
                DataTable dataTable = c.select();
                dataGridViewContactList.DataSource = dataTable;

                //Clear method
                clear();
            }
            else
            {
                //Failed to delete
                MessageBox.Show("Contact can not be deleted, please try again.");
            }
        }

        static string myConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the value from textBox
            string keyword = textBoxSearch.Text;

            SqlConnection connection = new SqlConnection(myConnectionString);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM tableContact WHERE firstName LIKE '%" + keyword + "%' OR lastName LIKE '%" + keyword + "%' OR address LIKE '%" + keyword + "%'", connection);
            
            //Create data table
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridViewContactList.DataSource=dataTable;

        }
    }
}
