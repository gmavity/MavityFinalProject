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
            // TODO: This line of code loads data into the 'peopleDataSet1.Information' table. You can move, or remove it, as needed.
            this.informationTableAdapter.Fill(this.peopleDataSet1.Information);
           

        }

        /// <summary>
        /// keeps the user from entering anything other than a number into the box, and only 4 of those
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) || txtSSN.Text.Length>=4)
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
            }else if (rad6to7.Checked)
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
            }else if (rad10to11.Checked)
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
            adapter.Insert(int.Parse(txtSSN.Text), txtName.Text, gender, txtPhone.Text, int.Parse(txtClean.Text), int.Parse(txtQuiet.Text), int.Parse(txtStudy.Text), int.Parse(txtGuests.Text), txtYear.Text, txtMajor.Text, wakeup, bedtime);
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
    }
}
