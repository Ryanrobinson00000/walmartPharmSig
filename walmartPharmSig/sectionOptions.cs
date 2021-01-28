using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace walmartPharmSig
{
    public partial class sectionOptions : UserControl
    {
        public sectionOptions()
        {
            InitializeComponent();
        }

        private void simpleToMain_Click(object sender, EventArgs e)
        {
     //when back button is pressed display main
            Form1.Instance.PnlContainer.Controls["main"].BringToFront();

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                //will hold textbox elements that are selected
                List<String> chosen = new List<String>();
                //gets textbox elements chosen
                checkBoxList(chosen);





                //removes panel allowing for room for replacement panel with updated information
                if (Form1.Instance.PnlContainer.Controls.ContainsKey("sectionTest"))
                {
                    //gets panel sectiontest
                    var panel = Form1.Instance.PnlContainer.Controls["sectionTest"];
                    //removes panel
                    panel.Dispose();
                }
                //new panel being made 
                sectionTest st = new sectionTest(chosen);
                st.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(st);

                //displays sectionTest panel for user
                Form1.Instance.PnlContainer.Controls["sectionTest"].BringToFront();
                //removes sibility on errorlabel because error no longer occurs
                errorLabel.Visible = false;
            }
            catch
            {
                //display error label if no sigs are in file
                errorLabel.Visible = true;
            }
        }
        
        private void checkBoxList(List<String> checkBoxChosen)
        {
            //performs for controls in panel
            foreach (var control in this.Controls)
            {//the control is a checkbox
                if (control is CheckBox)
                {//determine if it is checked
                    if (((CheckBox)control).Checked)
                    {//if it is checked add the name of the textbox to the checkboxchosen list
                        checkBoxChosen.Add(((CheckBox)control).Text);
                    }
                   
                }
            }
        }
        //determines if one or more checkboxex has been checked
        private void checkBoxCheck()
        {
            //iterates through all controls in panel
            foreach (var control in this.Controls) 
            {
                //if the control is a checkbox
                if (control is CheckBox)
                {//if a checkbox is checked
                    if (((CheckBox)control).Checked)
                    {
                        //enable submit and braek from loop
                        Submit.Enabled = true;
                        break;
                    }
                    //if a checkbox isn't used disable submit
                    Submit.Enabled = false;
                }
            }
        }

   
  
    
        //when add all is pressed set all checkboxes to true
        private void addAll_Click(object sender, EventArgs e)
        {
            QualityCheckBox.Checked = true;
            FrequencyCheckBox.Checked = true;
            RouteCheckBox.Checked = true;
            AddOnsCheckBox.Checked = true;
            MeasurementsCheckBox.Checked = true;
            DurationCheckBox.Checked = true;
            VerbsCheckBox.Checked = true;
            ConnectorsChecBox.Checked = true;
            MedicalCCheckBox.Checked = true;
            SpecialCheckBox.Checked = true;


        }
        //when removeall button is pressed, set all checkboxes to false
        private void removeAll_Click(object sender, EventArgs e)
        {
            QualityCheckBox.Checked = false;
            FrequencyCheckBox.Checked = false;
            RouteCheckBox.Checked = false;
            AddOnsCheckBox.Checked = false;
            MeasurementsCheckBox.Checked = false;
            DurationCheckBox.Checked = false;
            VerbsCheckBox.Checked = false;
            ConnectorsChecBox.Checked = false;
            MedicalCCheckBox.Checked = false;
            SpecialCheckBox.Checked = false;
        }
        //determines if a checkbox is checked whenever the status of a textbox on the page changes
        private void QualityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCheck();
        }

        private void RouteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCheck();
        }

        private void VerbsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCheck();
        }

        private void SpecialCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCheck();
        }

        private void FrequencyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCheck();
        }

        private void MeasurementsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCheck();
        }

        private void ConnectorsChecBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCheck();
        }

        private void AddOnsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCheck();
        }

        private void DurationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCheck();
        }

        private void MedicalCCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCheck();
        }
    }
}
