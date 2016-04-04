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
    public partial class DescriptionForm : Form
    {
        public DescriptionForm()
        {
            InitializeComponent();
        }

       
        public void loadInformation(string phone, string description)
        {
            lblPhone.Text += phone;
            txtDescription.Text += description;
        }
    }
}
