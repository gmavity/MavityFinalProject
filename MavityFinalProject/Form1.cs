using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MavityFinalProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

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
    }
}
