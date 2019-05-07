using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA46Team08ASportsFacilityBooking
{
    //Code for this page is written by A0180508H BAI XINYU
    public partial class MainForm : Form
    {
        MakeBookingForm mbForm;
        MainSearchForm msForm;


        public MainForm()
        {
            InitializeComponent();
        }

        private void makebookingbutton_Click(object sender, EventArgs e)
        {
            mbForm = new MakeBookingForm();
            mbForm.ShowDialog();
            mbForm.Dispose();
        }

        

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

        private void Searchavailabilitybutton_Click(object sender, EventArgs e)
        {
            msForm = new MainSearchForm();
            msForm.ShowDialog();
            msForm.Dispose();
        }
    }
}
