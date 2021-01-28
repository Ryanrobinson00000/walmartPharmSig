using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace walmartPharmSig
{
    public partial class addRemove : UserControl
    {

        public addRemove()
        {
            InitializeComponent();
        }
     
        private void addRemoveToMain_Click(object sender, EventArgs e)
        {
            //when return to main button is pressed makes "main"panel visible
            Form1.Instance.PnlContainer.Controls["main"].BringToFront();

        }
        private void goToModifyFiles(String fileName)
        {
            //refreshes modify files panel
            //checks if modifyfiles panel already exists
            if (Form1.Instance.PnlContainer.Controls.ContainsKey("modifyFiles"))
            {
                //gets modify files panel
                var panel = Form1.Instance.PnlContainer.Controls["modifyFiles"];
                //deletes modify panels panel
                panel.Dispose();
            }
            //new panel being made 
            modifyFiles mf = new modifyFiles(fileName);
            mf.Dock = DockStyle.Fill;
            //adds panel to the controller
            Form1.Instance.PnlContainer.Controls.Add(mf);

            //displays modify files panel
            Form1.Instance.PnlContainer.Controls["modifyFiles"].BringToFront();
        }
        private void Quantity_Click(object sender, EventArgs e)
        {
            //will allow for modification of quanity files
            goToModifyFiles("Quantity");
        }

        private void Route_Click(object sender, EventArgs e)
        {
            //will allow for modification of route files
            goToModifyFiles("Route");

        }

        private void Verbs_Click(object sender, EventArgs e)
        {
            //will allow for modification of verb files
            goToModifyFiles("Verbs");

        }

        private void Frequencies_Click(object sender, EventArgs e)
        {
            //will allow for modification of frequency files
            goToModifyFiles("Frequency");

        }

        private void Measurements_Click(object sender, EventArgs e)
        {
            //will allow for modification of measurements files
            goToModifyFiles("Measurements");

        }

        private void Connectors_Click(object sender, EventArgs e)
        {
            //will allow for modification of connector files
            goToModifyFiles("Connectors");

        }

        private void AddOns_Click(object sender, EventArgs e)
        {
            //will allow for modification of add-on files
            goToModifyFiles("Add-Ons");

        }

        private void Duration_Click(object sender, EventArgs e)
        {
            //will allow for modification of duration files
            goToModifyFiles("Duration");

        }

        private void MedicalConditions_Click(object sender, EventArgs e)
        {
            //will allow for modification of medical condition sigs
            goToModifyFiles("Medical Conditions");

        }

        private void Special_Click(object sender, EventArgs e)
        {
            //will allow for modification of special sigs
            goToModifyFiles("Special");

        }

        private void Common_Click(object sender, EventArgs e)
        {
            //will allow for modification of common sigs found at that store
            goToModifyFiles("Common");
        }
    }
}
