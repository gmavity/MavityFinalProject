using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MavityFinalProject
{
    public partial class MainForm : Form
    {
        PeopleDataSet1TableAdapters.InformationTableAdapter adapter = new PeopleDataSet1TableAdapters.InformationTableAdapter();
        public MainForm()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'peopleDataSet2.Information' table. You can move, or remove it, as needed.
            this.informationTableAdapter1.Fill(this.peopleDataSet2.Information);
        }

        /// <summary>
        /// keeps the user from entering anything other than a number into the box, and only 4 of those
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) || txtSSN.Text.Length >= 4)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// keeps the user from entering anything other than a letter or a space for their name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Keeps user from entering anything other than a number for the level of cleanliness
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtClean_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Keeps user from entering anything other than a number for the level of quietness
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtQuiet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Keeps user from entering anything other than a number for the level of studiousness
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStudy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Keeps user from entering anything other than a number for the number of guests
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGuests_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Keeps user from entering anything other than a letter for their year (ie force "freshman" etc)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Adds a person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            string gender, wakeup, bedtime;
            if (radF.Checked)
            {
                gender = "F";
            }
            else
            {
                gender = "M";
            }
            if (radBefore6.Checked)
            {
                wakeup = "Before 6";
            }
            else if (rad6to7.Checked)
            {
                wakeup = "6-7";
            }
            else if (rad7to8.Checked)
            {
                wakeup = "7-8";
            }
            else if (rad8to9.Checked)
            {
                wakeup = "8-9";
            }
            else
            {
                wakeup = "After 9";
            }
            if (radBefore10.Checked)
            {
                bedtime = "Before 10";
            }
            else if (rad10to11.Checked)
            {
                bedtime = "10-11";
            }
            else if (rad11to12.Checked)
            {
                bedtime = "11-12";
            }
            else if (rad12to1.Checked)
            {
                bedtime = "12-1";
            }
            else
            {
                bedtime = "After 1";
            }

            adapter.Insert(int.Parse(txtSSN.Text), txtName.Text, gender, txtPhone.Text, int.Parse(txtClean.Text), int.Parse(txtQuiet.Text), int.Parse(txtStudy.Text), int.Parse(txtGuests.Text), txtYear.Text, txtMajor.Text, wakeup, bedtime, rtbDescribe.Text);
            this.informationTableAdapter.Fill(this.peopleDataSet1.Information);
        }

        /// <summary>
        /// Brings up a form with a description of the program's functionalities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        /// <summary>
        /// closes application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// brings up a form with the selected person's description and phone number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDescription_Click(object sender, EventArgs e)
        {
            int ssn = (int)dgvPersonViewer.Rows[dgvPersonViewer.CurrentCell.RowIndex].Cells[1].Value;
            string phone = adapter.GetPhone(ssn);
            string description = adapter.GetDescription(ssn);
            DescriptionForm dForm = new DescriptionForm();
            dForm.loadInformation(phone, description);
            dForm.Show();
        }

        /// <summary>
        /// brings up all information but the ssn for the selected person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeRecord_Click(object sender, EventArgs e)
        {
            int ssn = (int)dgvPersonViewer.Rows[dgvPersonViewer.CurrentCell.RowIndex].Cells[1].Value;
            int selectedrowindex = dgvPersonViewer.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvPersonViewer.Rows[selectedrowindex];
            string description = adapter.GetDescription(ssn);
            string gender = adapter.GetGender(ssn);
            if ((gender.Trim()).Equals("F"))
            {
                radF.Checked = true;
            }
            else
            {
                radM.Checked = true;
            }
            txtName.Text = adapter.GetName(ssn);
            txtPhone.Text = adapter.GetPhone(ssn);
            txtClean.Text = adapter.GetCleanliness(ssn).ToString();
            txtQuiet.Text = adapter.GetQuietness(ssn).ToString();
            txtStudy.Text = adapter.GetStudiousness(ssn).ToString();
            txtGuests.Text = adapter.GetGuests(ssn).ToString();
            txtYear.Text = adapter.GetGrade(ssn);
            txtMajor.Text = adapter.GetMajor(ssn);
            string wakeup = adapter.GetWakeup(ssn);
            if (wakeup.Equals("Before 6"))
            {
                radBefore6.Checked = true;
            }
            else if (wakeup.Equals("6-7"))
            {
                rad6to7.Checked = true;
            }
            else if (wakeup.Equals("7-8"))
            {
                rad7to8.Checked = true;
            }
            else if (wakeup.Equals("8-9"))
            {
                rad8to9.Checked = true;
            }
            else
            {
                radAfter9.Checked = true;
            }
            string bedtime = adapter.GetBedtime(ssn);
            if (bedtime.Equals("Before 10"))
            {
                radBefore10.Checked = true;
            }
            else if (bedtime.Equals("10-11"))
            {
                rad10to11.Checked = true;
            }
            else if (bedtime.Equals("11-12"))
            {
                rad11to12.Checked = true;
            }
            else if (bedtime.Equals("12-1"))
            {
                rad12to1.Checked = true;
            }
            else
            {
                radAfter1.Checked = true;
            }
            rtbDescribe.Text = adapter.GetDescription(ssn);
        }

        /// <summary>
        /// changes a record if the entered ssn is correct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            int ssn = (int)dgvPersonViewer.Rows[dgvPersonViewer.CurrentCell.RowIndex].Cells[1].Value;
            if (ssn != int.Parse(txtSSN.Text))
            {
                lblStatus.Text = "Input SSN is not correct.";
            }
            else
            {
                int selectedrowindex = dgvPersonViewer.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPersonViewer.Rows[selectedrowindex];
                string oldgender = adapter.GetGender(ssn);
                string oldwakeup = adapter.GetWakeup(ssn);
                string oldbedtime = adapter.GetBedtime(ssn);

                string newgender, newwakeup, newbedtime;
                if (radF.Checked)
                {
                    newgender = "F";
                }
                else
                {
                    newgender = "M";
                }
                if (radBefore6.Checked)
                {
                    newwakeup = "Before 6";
                }
                else if (rad6to7.Checked)
                {
                    newwakeup = "6-7";
                }
                else if (rad7to8.Checked)
                {
                    newwakeup = "7-8";
                }
                else if (rad8to9.Checked)
                {
                    newwakeup = "8-9";
                }
                else
                {
                    newwakeup = "After 9";
                }
                if (radBefore10.Checked)
                {
                    newbedtime = "Before 10";
                }
                else if (rad10to11.Checked)
                {
                    newbedtime = "10-11";
                }
                else if (rad11to12.Checked)
                {
                    newbedtime = "11-12";
                }
                else if (rad12to1.Checked)
                {
                    newbedtime = "12-1";
                }
                else
                {
                    newbedtime = "After 1";
                }

                adapter.UpdateQuery(ssn, txtName.Text, newgender, txtPhone.Text, int.Parse(txtClean.Text), int.Parse(txtQuiet.Text), int.Parse(txtStudy.Text), int.Parse(txtGuests.Text), txtYear.Text, txtMajor.Text, newwakeup, newbedtime, rtbDescribe.Text, ssn, adapter.GetName(ssn), oldgender, adapter.GetPhone(ssn), (int)adapter.GetCleanliness(ssn), (int)adapter.GetQuietness(ssn), (int)adapter.GetStudiousness(ssn), (int)adapter.GetGuests(ssn), adapter.GetGrade(ssn), adapter.GetMajor(ssn), oldbedtime, oldwakeup);
                this.informationTableAdapter1.Fill(this.peopleDataSet2.Information);
            }
        }

        /// <summary>
        /// deletes a record if the entered ssn is correct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveRecord_Click(object sender, EventArgs e)
        {
            int ssn = (int)dgvPersonViewer.Rows[dgvPersonViewer.CurrentCell.RowIndex].Cells[1].Value;
            if (ssn != int.Parse(txtSSN.Text))
            {
                lblStatus.Text = "Input SSN is not correct.";
            }
            else
            {
                adapter.Delete(ssn);
                this.informationTableAdapter1.Fill(this.peopleDataSet2.Information);
            }
        }
    }
}
