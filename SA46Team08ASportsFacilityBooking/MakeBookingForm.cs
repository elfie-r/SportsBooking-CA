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
    
    public partial class MakeBookingForm : Form
    {

        SA46Team08ADatabaseEntities ctx;
        MemberLookupForm mlForm;
        FacilityLookupForm flForm;
        DateTime selectedDateTimeSlot;
        List<Button> slotButtons;
        List<Label> slotLabels;
        int facilityIDChosen;

        public MakeBookingForm()
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

            for (int i = 0; i < 12; i++)
            {
                slotButtons[i].Click += (se, ev) => button_Click(se, ev);
            }
        }

        private void lookUpMemberButton_Click(object sender, EventArgs e)
        {
            mlForm = new MemberLookupForm();
            mlForm.ShowDialog();
            if (mlForm.SelectedMemberCode > 0)
            {
                memberIDTextBox.Text = mlForm.SelectedMemberCode.ToString();
            }
            mlForm.Dispose();

        }

        private void memberIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (memberIDTextBox.Text.Length > 0)
            {
                string input = memberIDTextBox.Text;
                int inputInt = Convert.ToInt32(input);
                var test = ctx.Members.Where(x => x.MembershipNo == inputInt).Count();
                if (test != 0)
                {
                    memberNameTextBox.Text = ctx.Members.First
                        (x => x.MembershipNo == inputInt).MemberName;
                }
                else
                {
                    memberNameTextBox.Text = null;
                    memberIDTextBox.Clear();
                }
            }
            else
            {
                memberNameTextBox.Text = "Enter a valid membership number";
            }
        }
        private void facilityIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (facilityIDTextBox.Text.Length > 0)
            {
                string input = facilityIDTextBox.Text;
                int inputInt = Convert.ToInt32(input);
                facilityIDChosen = inputInt;
                var test = ctx.Facilities.Where(x => x.FacilityID == facilityIDChosen).Count();
                if (test == 1)
                {
                    facilityTypeTextBox.Text = ctx.Facilities.First
                        (x => x.FacilityID == inputInt).FacilityType;
                    facilityAddressTextBox.Text = ctx.Facilities.First
                        (x => x.FacilityID == inputInt).Address;
                    UpdateAvailability();
                    panel1.Visible = true;
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
                panel1.Visible = false;
            }
        }
        private void lookUpFacilityButton_Click(object sender, EventArgs e)
        {
            flForm = new FacilityLookupForm();
            flForm.ShowDialog();
            if (flForm.SelectedFacilityCode > 0)
            {
                facilityIDTextBox.Text = flForm.SelectedFacilityCode.ToString();
            }
            flForm.Dispose();
        }

        
        private void button_Click(object sender, EventArgs e)
        {
            {
                Button button = sender as Button;

                Color buttonColor = button.BackColor;

                if (buttonColor == Color.Lime)
                {
                    button.BackColor = Color.Red;
                }
                else if (buttonColor == Color.Red)
                {
                    button.BackColor = Color.Lime;
                }
            };
        }
        //validation for the confirm button is done through the memberID validity check 
        //in the memberIDTextBox_TextChanged event
        //and through the facilityID not displaying a confirmation button if invalid.

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int countSlotsChosen = 0;
            for (int i = 0; i < 12; i++)
            {
                if (slotButtons[i].BackColor == Color.Red)
                {
                    string dateTimeString =
                        dateTimePicker1.Value.ToShortDateString().ToString() + " "
                        + slotLabels[i].Text;

                    selectedDateTimeSlot = Convert.ToDateTime(dateTimeString);
                    countSlotsChosen++;
                }
            }
            if (countSlotsChosen == 1)
            {
                if (memberIDTextBox.Text.Length == 0 || memberIDTextBox.Text == null)
                {
                    MemberWarningLabel.Visible = true;
                    toolStripStatusLabel1.Text = "Please enter a valid Membership number.";
                }
                else
                {
                    Booking currentBooking = new Booking();

                    currentBooking.MembershipNo = Convert.ToInt32(memberIDTextBox.Text);
                    currentBooking.FacilityID = facilityIDChosen;
                    currentBooking.StartTime = selectedDateTimeSlot;
                    currentBooking.EndTime = selectedDateTimeSlot.AddHours(1);
                    currentBooking.Remark = remarksTextBox.Text;
                    currentBooking.BookingStatus = 1;

                    toolStripStatusLabel1.Text = "Booking Made Successfully!";
                    ctx.Bookings.Add(currentBooking);
                    ctx.SaveChanges();

                    
                    Close();
                }

            }
            else if (countSlotsChosen > 1)
            {
                toolStripStatusLabel1.Text = "Only one slot can be booked per time. Please make the necessary changes.";
            }

            else
            {
                toolStripStatusLabel1.Text = "Please choose a timeslot.";
            }
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

                //color the buttons to indicate availability from this line of code onwards

                //not booked condition is based on whether the booking table has zero entries with 
                //a booking status of 1(booked)
                //OR 
                //whether the booking table has entries where booking status is 0(cancelled)
                // but the total number of entries for that facility must be the same as the 
                //total number of booking status == 0 entries.
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
                timeSlotLabel.Text = "Timeslot required:";
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

        private void memberIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void facilityIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInputIsInteger(e);
        }
    }
}
