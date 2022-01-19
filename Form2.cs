using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationDB_2
{
    public partial class Form2 : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-J9B5TJ3F\SQLEXPRESS;Initial Catalog=Registrants;Integrated Security=True;" + "MultipleActiveResultSets=true");
        int selectedUserRow;
        String selectedUserId;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrantsDataSet.Registrants2' table. You can move, or remove it, as needed.
            this.registrants2TableAdapter.Fill(this.registrantsDataSet.Registrants2);

        }

        private void dgvRegistrants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedUserRow = dgvRegistrants.CurrentCell.RowIndex;
            selectedUserId = dgvRegistrants["idDataGridViewTextBoxColumn", selectedUserRow].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(Convert.ToInt32(selectedUserId));
            form1.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand deleteCurrentUser = new SqlCommand("DELETE FROM Registrants2 WHERE id = " + selectedUserId, connection);
            deleteCurrentUser.ExecuteNonQuery();
            MessageBox.Show("User Successfully Deleted");
            this.registrants2TableAdapter.Fill(this.registrantsDataSet.Registrants2);
            connection.Close();
        }
    }
}
