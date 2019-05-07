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
    
    public partial class MainSearchForm : Form
    {

        SA46Team08ADatabaseEntities ctx;
        MemberLookupForm mlForm;
        FacilityLookupForm flForm;
        DateTime selectedDateTimeSlot;
        List<Button> slotButtons;
        List<Label> slotLabels;
        int facilityIDChosen;

        public MainSearchForm()
        {
            InitializeComponent();
            mlForm = new MemberLookupForm();
            flForm = new FacilityLookupForm();
            ctx = new SA46Team08ADatabaseEntities();
            selectedDateTimeSlot = new DateTime();

            slotButtons = new List<Button>()
            {button1, button2, button3, button4,
            button5, button6, button7, button8,
            button9, button10, button11, button12 };

            slotLabels = new List<Label>()
            {timeSlotLabel1, timeSlotLabel2, timeSlotLabel3, timeSlotLabel4,
            timeSlotLabel5, timeSlotLabel6, timeSlotLabel7, timeSlotLabel8,
            timeSlotLabel9, timeSlotLabel10, timeSlotLabel11, timeSlotLabel12 };

            dateTimePicker1.MinDate = DateTime.Today.AddDays(1);
            
        }

        

        
        private void facilityIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (facilityIDTextBox.Text.Length > 0)
            {
                
                string input = facilityIDTextBox.Text;
                int inputInt = Convert.ToInt32(input);
                facilityIDChosen = inputInt;
                var test = ctx.Facilities.Where(x => x.FacilityID == inputInt).Count();
                if (test != 0)
                {
                    facilityTypeTextBox.Text = ctx.Facilities.First
                        (x => x.FacilityID == inputInt).FacilityType;
                    facilityAddressTextBox.Text = ctx.Facilities.First
                        (x => x.FacilityID == inputInt).Address;
                    UpdateAvailability();
                }
                else
                {
                    facilityTypeTextBox.Text = null;
                    facilityAddressTextBox.Text = null;
                    facilityIDTextBox.Clear();
                }
            }
            else
            {
                facilityTypeTextBox.Text = "Enter a valid Facility ID";
                facilityAddressTextBox.Text = null;
            }
        }
        private void lookUpFacilityButton_Click(object sender, EventArgs e)
        {
            flForm = new FacilityLookupForm();
            flForm.ShowDialog();
            facilityIDTextBox.Text = flForm.SelectedFacilityCode.ToString();
            flForm.Dispose();
        }

        private void facilityAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            dateLabel.Visible = true;
            dateTimePicker1.Visible = true;
        }

        private void dateTimePicker1_VisibleChanged(object sender, EventArgs e)
        {
            int countUnavailableSlot = 0;
            //loop through buttons to color them
            for (int i = 0; i < 12; i++)
            {
                string dateTimeString
                = dateTimePicker1.Value.ToShortDateString().ToString() + " " + slotLabels[i].Text;
                DateTime dateTimeForButton = Convert.ToDateTime(dateTimeString);

                //color the buttons
                bool isNotBooked =
                    
                    (ctx.Bookings.Where(x => x.BookingStatus == 1
                    && x.StartTime == dateTimeForButton
                    && x.FacilityID == facilityIDChosen).Count() == 0) ||
                    ((ctx.Bookings.Where(x => x.BookingStatus == 0
                    && x.StartTime == dateTimeForButton
                    && x.FacilityID == facilityIDChosen).Count()) ==
                    (ctx.Bookings.Where(x => x.StartTime == dateTimeForButton
                    && x.FacilityID == facilityIDChosen).Count()));
                if (isNotBooked) //no such booking
                {
                    slotButtons[i].BackColor = Color.Lime;
                }
                else
                {
                    slotButtons[i].BackColor = Color.DarkBlue;
                    countUnavailableSlot++;
                }

                //add button mouseclickevent
                
                
                
            }

        
            //inform user that there is no available time slot
            if (countUnavailableSlot < 12)
            {
                timeSlotLabel.ForeColor = DefaultForeColor;
                timeSlotLabel.Text = "Timeslot required:";
            }
            else
            {
                timeSlotLabel.ForeColor = Color.Red;
                timeSlotLabel.Text = "No timeslot available." + Environment.NewLine
                    + "Select another day.";
            }
            //show panel
            panel1.Visible = true;
        }
        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateAvailability();
        }

        private void UpdateAvailability()
        {
            int countUnavailableSlot = 0;
            //loop through buttons to color them
            for (int i = 0; i < 12; i++)
            {
                string dateTimeString
                = dateTimePicker1.Value.ToShortDateString().ToString() + " " + slotLabels[i].Text;
                DateTime dateTimeForButton = Convert.ToDateTime(dateTimeString);

                //color the buttons
                bool isNotBooked =
                    
                    (ctx.Bookings.Where(x => x.BookingStatus == 1
                    && x.StartTime == dateTimeForButton
                    && x.FacilityID == facilityIDChosen).Count() == 0) ||
                    ((ctx.Bookings.Where(x => x.BookingStatus == 0
                    && x.StartTime == dateTimeForButton
                    && x.FacilityID == facilityIDChosen).Count()) ==
                    (ctx.Bookings.Where(x => x.StartTime == dateTimeForButton
                    && x.FacilityID == facilityIDChosen).Count()));
                if (isNotBooked) //no such booking
                {
                    slotButtons[i].BackColor = Color.Lime;
                }
                else
                {
                    slotButtons[i].BackColor = Color.DarkBlue;
                    countUnavailableSlot++;
                }

            }

            //inform user that there is no available time slot
            if (countUnavailableSlot < 12)
            {
                timeSlotLabel.ForeColor = DefaultForeColor;
                timeSlotLabel.Text = "Timeslots available:";
            }
            else
            {
                timeSlotLabel.ForeColor = Color.Red;
                timeSlotLabel.Text = "No timeslot available." + Environment.NewLine
                    + "Select another day.";
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void facilityIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInputIsInteger(e);
        }

        private static void CheckInputIsInteger(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
