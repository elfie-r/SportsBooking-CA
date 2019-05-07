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
    public partial class FacilityLookupForm : Form
    {
        SA46Team08ADatabaseEntities ctx;
        int selectedFacilityCode;

        public FacilityLookupForm()
        {
            InitializeComponent();
            ctx = new SA46Team08ADatabaseEntities();
            selectedFacilityCode = 0;
            dataGridView1.AutoGenerateColumns = false;
        }

        public int SelectedFacilityCode
        {
            get { return selectedFacilityCode; }
            set { selectedFacilityCode = value; }
        }

        private void FacilityLookupForm_Load(object sender, EventArgs e)
        {
            

            var listOfFacilityTypes = ctx.Facilities.Select(x => new { x.FacilityType }).Distinct().ToList();
          
            int noOfTypes = listOfFacilityTypes.Count();
            for(int i =0; i< noOfTypes; i++)
            {
                facilityTypeComboBox.Items.Add(listOfFacilityTypes[i].FacilityType.ToString());
            }

            facilityTypeComboBox.SelectedItem = facilityTypeComboBox.Items[0];
        }

        private void displayButton_Click(object sender, EventArgs e)
        {

            var selectedList = ctx.Facilities.
                Where(x => x.FacilityType == facilityTypeComboBox.Text 
                && x.Address == specifySearchComboBox.Text).ToList();
            if (selectedList.Count() > 0)
            {
                dataGridView1.DataSource = selectedList;
                memberStatusLabel.Text = "Select correct facility row " + Environment.NewLine +
                                        "and click Ok to insert.";
            }
          

        }

        private void facilityTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            specifySearchComboBox.Items.Clear();
            specifySearchComboBox.ResetText();

            string selectedParam = facilityTypeComboBox.SelectedItem.ToString();
            helperTextLabel.Text = "Choose a Location";

            var listOfFacilityLocations = ctx.Facilities.Where(x => x.FacilityType == selectedParam).ToList();


            int noOfLocales = listOfFacilityLocations.Count();
            for (int i = 0; i < noOfLocales; i++)
            {
                specifySearchComboBox.Items.Add(listOfFacilityLocations[i].Address.ToString());
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                toolStripStatusLabel1.Text = "No facility row was selected.";
            }
            else
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                selectedFacilityCode = (int)dataGridView1.Rows[rowIndex].Cells[0].Value;
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
