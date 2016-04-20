using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MavityFinalProject
{
    class Validations
    {
        /// <summary>
        /// validates the SSN text box
        /// </summary>
        /// <param name="e"></param>
        /// <param name="txt"></param>
        public void ValidateSSN(KeyPressEventArgs e, TextBox txt)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                if (!Char.IsDigit(e.KeyChar) || txt.Text.Length >= 4)
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        ///  validates the Name text box
        /// </summary>
        /// <param name="e"></param>
        public void ValidateName(KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        ///  validates the Cleanliness text box
        /// </summary>
        /// <param name="e"></param>
        public void ValidateClean(KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                if (!Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        ///  validates the Quietness text box
        /// </summary>
        /// <param name="e"></param>
        public void ValidateQuiet(KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                if (!Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        ///  validates the Studiousness text box
        /// </summary>
        /// <param name="e"></param>
        public void ValidateStudy(KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                if (!Char.IsDigit(e.KeyChar))
                {

                }
            }
        }

        /// <summary>
        ///  validates the Guests text box
        /// </summary>
        /// <param name="e"></param>
        public void ValidateGuests(KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                if (!Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        ///  validates the Year text box
        /// </summary>
        /// <param name="e"></param>
        public void ValidateYear(KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                if (!Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

    }
}
