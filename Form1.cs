using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RegistrationDB_2
{
    public partial class Form1 : Form
    {

        // string connectionString = @"Data Source=LAPTOP-J9B5TJ3F\SQLEXPRESS;Initial Catalog=Registrants;Integrated Security=True";
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-J9B5TJ3F\SQLEXPRESS;Initial Catalog=Registrants;Integrated Security=True;" + "MultipleActiveResultSets=true");
        String 
            firstName, 
            middleName, 
            lastName, 
            gender, 
            birthDate, 
            barangay, 
            municipality, 
            province, 
            hobbies = "", 
            otherHobbies;
        int selectedUserId;

        private void tbxBirthDate_TextChanged(object sender, EventArgs e)
        {
            birthDate = tbxBirthDate.Text;
        }

        private void tbxOthers_TextChanged(object sender, EventArgs e)
        {
            otherHobbies = tbxOthers.Text;
        }

        private void tbxBarangay_TextChanged(object sender, EventArgs e)
        {
            barangay = tbxBarangay.Text;
        }

        private void tbxMunicipality_TextChanged(object sender, EventArgs e)
        {
            municipality = tbxMunicipality.Text;
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            lastName = tbxLastName.Text;
        }

        private void tbxMiddleName_TextChanged(object sender, EventArgs e)
        {
            middleName = tbxMiddleName.Text;
        }

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            firstName = tbxFirstName.Text;
        }

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(int id)
        {
            InitializeComponent();

            selectedUserId = id;

            btnSubmit.Enabled = false;
            btnUpdate.Enabled = true;

            //TODO: load exisiting user
            connection.Open();
            SqlCommand loadExisitingUser = new SqlCommand("SELECT * FROM Registrants2 WHERE id = " + id, connection);
            SqlDataReader dataReader = loadExisitingUser.ExecuteReader();

            while (dataReader.Read())
            {
                tbxFirstName.Text = dataReader.GetValue(1).ToString();
                tbxMiddleName.Text = dataReader.GetValue(2).ToString();
                tbxLastName.Text = dataReader.GetValue(3).ToString();
                tbxBirthDate.Text = dataReader.GetValue(5).ToString();
                tbxBarangay.Text = dataReader.GetValue(6).ToString();
                tbxMunicipality.Text = dataReader.GetValue(7).ToString();
                lbxProvince.SelectedItem = dataReader.GetValue(8).ToString();
                tbxOthers.Text = dataReader.GetValue(10).ToString();

                if(!dataReader.GetValue(4).ToString().Equals("Male"))
                {
                    rbnMale.Checked = true;
                } else
                {
                    rbnFemale.Checked = true;
                }

                if (dataReader.GetValue(9).ToString().Contains("Sports"))
                {
                    cbxSports.Checked = true;
                }
                if (dataReader.GetValue(9).ToString().Contains("Music"))
                {
                    cbxMusic.Checked = true;
                }
                if (dataReader.GetValue(9).ToString().Contains("Arts"))
                {
                    cbxArts.Checked = true;
                }
                if (dataReader.GetValue(9).ToString().Contains("Movies"))
                {
                    cbxMovies.Checked = true;
                }
                if (dataReader.GetValue(9).ToString().Contains("Virtual Games"))
                {
                    cbxVirtualGames.Checked = true;
                }

            }
            connection.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (rbnMale.Checked)
            {
                gender = "Male ";
            }
            else if (rbnFemale.Checked)
            {
                gender = "Female ";
            }

            if (cbxSports.Checked)
            {
                hobbies += "Sports ";
            } 
            if (cbxMusic.Checked)
            {
                hobbies += "Music ";
            }
            if (cbxArts.Checked)
            {
                hobbies += "Arts ";
            }
            if (cbxMovies.Checked)
            {
                hobbies += "Movies ";
            }
            if (cbxVirtualGames.Checked)
            {
                hobbies += "Virtual Games ";
            }

            bool isOthersEmpty = String.IsNullOrEmpty(otherHobbies);


            province = lbxProvince.SelectedItem.ToString();

            connection.Open();

            int rowCount = 0;
            SqlCommand fetchAllRegistrantsQuery = new SqlCommand("SELECT * FROM Registrants2", connection);
            SqlDataReader dataReader = fetchAllRegistrantsQuery.ExecuteReader();
            while (dataReader.Read())
            {
                rowCount++;
            }
            rowCount++;

            SqlCommand insertRegistrantsCommand = new SqlCommand();

            insertRegistrantsCommand.Connection = connection;

            insertRegistrantsCommand.Parameters.Add(new SqlParameter("@id", rowCount));
            insertRegistrantsCommand.Parameters.Add(new SqlParameter("@firstName", firstName));
            insertRegistrantsCommand.Parameters.Add(new SqlParameter("@middleName", middleName));
            insertRegistrantsCommand.Parameters.Add(new SqlParameter("@lastName", lastName));
            insertRegistrantsCommand.Parameters.Add(new SqlParameter("@gender", gender));
            insertRegistrantsCommand.Parameters.Add(new SqlParameter("@birthDate", birthDate));
            insertRegistrantsCommand.Parameters.Add(new SqlParameter("@barangay", barangay));
            insertRegistrantsCommand.Parameters.Add(new SqlParameter("@municipality", municipality));
            insertRegistrantsCommand.Parameters.Add(new SqlParameter("@province", province));
            insertRegistrantsCommand.Parameters.Add(new SqlParameter("@hobbies", hobbies));
            insertRegistrantsCommand.Parameters.Add(new SqlParameter("@otherHobbies", otherHobbies));           

            insertRegistrantsCommand.CommandText =
                @"INSERT INTO Registrants2 (id, firstName, middleName, lastName, gender, birthDate, barangay, municipality, province, hobbies, otherHobbies) 
                VALUES(@id, @firstName, @middleName, @lastName, @gender, @birthDate, @barangay, @municipality, @province, @hobbies, @otherHobbies)";

            insertRegistrantsCommand.ExecuteNonQuery();

            MessageBox.Show("User Registered");
            connection.Close();

            tbxFirstName.Text = String.Empty;
            tbxMiddleName.Text = String.Empty;
            tbxLastName.Text = String.Empty;
            rbnMale.Checked = false;
            rbnFemale.Checked = false;
            tbxBirthDate.Text = String.Empty;
            tbxBarangay.Text = String.Empty;
            tbxMunicipality.Text = String.Empty;
        }

        private void btnViewRecords_Click(object sender, EventArgs e)
        {
            Form2 resultsForm = new Form2();
            this.Hide();
            resultsForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rbnMale.Checked)
            {
                gender = "Male ";
            }
            else if (rbnFemale.Checked)
            {
                gender = "Female ";
            }

            if (cbxSports.Checked)
            {
                hobbies += "Sports ";
            }
            if (cbxMusic.Checked)
            {
                hobbies += "Music ";
            }
            if (cbxArts.Checked)
            {
                hobbies += "Arts ";
            }
            if (cbxMovies.Checked)
            {
                hobbies += "Movies ";
            }
            if (cbxVirtualGames.Checked)
            {
                hobbies += "Virtual Games ";
            }
            if (tbxOthers.Text == null)
            {
                otherHobbies = "";
            }

            connection.Open();

            SqlCommand updateRegistrantsCommand = new SqlCommand();

            updateRegistrantsCommand.Connection = connection;

            updateRegistrantsCommand.Parameters.Add(new SqlParameter("@firstName", tbxFirstName.Text));
            updateRegistrantsCommand.Parameters.Add(new SqlParameter("@middleName", tbxMiddleName.Text));
            updateRegistrantsCommand.Parameters.Add(new SqlParameter("@lastName", tbxLastName.Text));
            updateRegistrantsCommand.Parameters.Add(new SqlParameter("@gender", gender));
            updateRegistrantsCommand.Parameters.Add(new SqlParameter("@birthDate", tbxBirthDate.Text));
            updateRegistrantsCommand.Parameters.Add(new SqlParameter("@barangay", tbxBarangay.Text));
            updateRegistrantsCommand.Parameters.Add(new SqlParameter("@municipality", tbxMunicipality.Text));
            updateRegistrantsCommand.Parameters.Add(new SqlParameter("@province", lbxProvince.SelectedItem.ToString()));
            updateRegistrantsCommand.Parameters.Add(new SqlParameter("@hobbies", hobbies));
            updateRegistrantsCommand.Parameters.Add(new SqlParameter("@otherHobbies", tbxOthers.Text));

            updateRegistrantsCommand.CommandText = @"UPDATE Registrants2 SET firstName = @firstName, middleName = @middleName, lastName = @lastName, gender = @gender, birthDate = @birthDate, barangay = @barangay, municipality = @municipality, province = @province, hobbies = @hobbies, otherHobbies = @otherHobbies WHERE id = " + selectedUserId;

            updateRegistrantsCommand.ExecuteNonQuery();

            MessageBox.Show("Updated Successfully");
            connection.Close();
        }
    }
}
