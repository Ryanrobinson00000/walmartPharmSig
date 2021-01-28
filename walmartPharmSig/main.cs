using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace walmartPharmSig
{
    public partial class main : UserControl
    {
        public main()
        {
            InitializeComponent();
            
        }
        //simple button click
        private void simple_Click(object sender, EventArgs e)
        {

            //performs if sectionoptions has not already been created
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("sectionOptions"))
            {
                //creates new section options and adds it to the panel
                sectionOptions sc = new sectionOptions();
                sc.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(sc);
            }
            //displays sectionoptions
            Form1.Instance.PnlContainer.Controls["sectionOptions"].BringToFront();
           
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void addRemoveButton_Click(object sender, EventArgs e)
        {
            //performs if addremove has not been created yet
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("addRemove"))
            {
                //creates and adds addremove to display controls
                addRemove sc = new addRemove();
                sc.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(sc);
            }
            //displays addremove
            Form1.Instance.PnlContainer.Controls["addRemove"].BringToFront();
            //ensures error label isn't displaying on re-entry of page because it will not be relevant
            errorLabel.Visible = false;
        }

        private void Simple_Click_1(object sender, EventArgs e)
        {
            //performs if sectionoptions is pressed and not created already
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("sectionOptions"))
            {
                //creates new section options and adds it to the control
                sectionOptions sc = new sectionOptions();
                sc.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(sc);
            }
            //displays sectionOptions
            Form1.Instance.PnlContainer.Controls["sectionOptions"].BringToFront();
            //makes error label invisible to avoid confusion from user on main re-entry after modification
            errorLabel.Visible = false;
        }

        private void Advanced_Click(object sender, EventArgs e)
        {
            try
            {
                
                //removes panel allowing for room for replacement panel with updated information
                if (Form1.Instance.PnlContainer.Controls.ContainsKey("sectionTest"))
                {

                    var panel = Form1.Instance.PnlContainer.Controls["sectionTest"];
                    panel.Dispose();
                }
                //new panel being made 
                sectionTest st = new sectionTest();
                st.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(st);

                //displays sectiontest
                Form1.Instance.PnlContainer.Controls["sectionTest"].BringToFront();
                //ensures error label is inisible because files were found
                errorLabel.Visible = false;
            }
            catch
            {
                //if files were empty an error will be thrown and display the error label for user
                errorLabel.Visible = true;
            }
        }
    }
}
