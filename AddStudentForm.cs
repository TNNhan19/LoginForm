using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }
        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBoxStudentID.Text, out int id))
                {
                    MessageBox.Show("Invalid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fname = textBoxFName.Text.Trim();
                string lname = textBoxLName.Text.Trim();
                DateTime bdate = dateTimePickerBDate.Value;
                string phone = textBoxPhone.Text.Trim();
                string adrs = textBoxAddress.Text.Trim();
                string gender = radioButtonMale.Checked ? "Female" : "Male";

                int born_year = bdate.Year;
                int this_year = DateTime.Now.Year;

                if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
                {
                    MessageBox.Show("The Student Age Must Be Between 10 and 100 years", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!VerifyInput(fname, lname, phone, adrs))
                {
                    MessageBox.Show("Please fill all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MemoryStream pic = new MemoryStream();
                pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);

                Student student = new Student();

                if (student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error adding student", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerifyInput(string fname, string lname, string phone, string adrs)
        {
            throw new NotImplementedException();
        }

        private void buttonUploadimage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "Image Files|*.jpg;*.png;*.gif";
                if (opf.ShowDialog() == DialogResult.OK && File.Exists(opf.FileName))
                {
                    pictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
                }
            }
        }
    }
}
