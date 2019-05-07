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
    //Code for this page is written by MUHAMMAD ELFIE BIN RAHIM
    public partial class MemberLookupForm : Form
    {
        SA46Team08ADatabaseEntities ctx;
        int selectedMemberCode;
        public MemberLookupForm()
        {
            InitializeComponent();
            ctx = new SA46Team08ADatabaseEntities();
            dataGridView1.AutoGenerateColumns = false;
            selectedMemberCode = 0;
        }

        public int SelectedMemberCode
        {
            get { return selectedMemberCode; }
            set { selectedMemberCode = value; }
        }
        private void searchComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            helperTextLabel.Text = "Enter " + searchComboBox.SelectedItem.ToString();
            
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            string chosenOption = searchComboBox.SelectedItem.ToString();
            string searchString = searchValueTextBox.Text;
            List<Member> listOfMembers = new List<Member>();
            
            if (chosenOption.Equals("Member Name"))
            {
                listOfMembers = ctx.Members.Where(x => x.MemberName.Contains(searchString)).ToList();
                DisplayStatus(listOfMembers);
            }
            else if (chosenOption.Equals("IC Number"))
            {
                listOfMembers = ctx.Members.Where(x => x.MemberIC.Equals(searchString)).ToList();
                DisplayStatus(listOfMembers);
            }
            if (listOfMembers.Count() > 0)
            {
                dataGridView1.DataSource = listOfMembers;
            }
        }

        private void DisplayStatus(List<Member> listOfMembers)
        {
            memberStatusLabel.Text = "Select correct member row " + Environment.NewLine +
                                    "and click Ok to insert.";
            if (listOfMembers.Count == 0)
            {
                memberStatusLabel.Text = "No such member exists." + Environment.NewLine +
                    "Please check entry.";
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.DataSource == null)
            {
                toolStripStatusLabel1.Text = "No member row was selected.";
            }
            else
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                selectedMemberCode = (int)dataGridView1.Rows[rowIndex].Cells[0].Value;
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MemberLookupForm_Load(object sender, EventArgs e)
        {
            searchComboBox.SelectedIndex = 0;
        }
    }
}
