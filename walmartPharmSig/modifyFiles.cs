using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace walmartPharmSig
{
    public partial class modifyFiles : UserControl
    {
        //datatable to hold information of sigs
        private DataTable dt;
        //stores filename selected
        private String fileName;
        public modifyFiles(String fileName)
        {
            InitializeComponent();
            //sets filename as value passed
            this.fileName = fileName;
        }

        private void modifyFiles_Load(object sender, EventArgs e)
        {
            //create datatable
            DataTable dt = new DataTable();
            //adds columns to table
            dt.Columns.Add("Expanded Sig");
            dt.Columns.Add("Sig");
            //sets datasource for table grid to dt
            addRemoveTableGrid.DataSource = dt;
            //sets width of sig column
            addRemoveTableGrid.Columns[1].Width = 150;
            setDataTable(dt);
            //sets label text to the filename being used
            fileLabel.Text = fileName;
            //opens filename file
            openSelectedFile(fileName);
        }

        private void cancelChanges_Click(object sender, EventArgs e)
        {
            //goes to addremove panel when changes are cancelled.
            Form1.Instance.PnlContainer.Controls["addRemove"].BringToFront();
            
        }

        private void addToList_Click(object sender, EventArgs e)
        {
            //sets datatable using getdattable function declared below
            dt = getDataTable();
            //if textboxes arent empty add info to tables
            //checks if sig boxes input boxes are empty
            if(expSigBox.Text!="" && sigBox.Text!="")
            {
                //adds row to table
                dt.Rows.Add(expSigBox.Text, sigBox.Text);
                //resets data table with new row
                setDataTable(dt);
                //sets input textboxes to null
                expSigBox.Text = "";
                sigBox.Text = "";
            }
        }
        //sets datatable using passed datatable information
        private void setDataTable(DataTable dt)
        {
            this.dt = dt;
        }
        //returns datatable
        private DataTable  getDataTable()
        {
            return dt;
        }
        //performs when remove button is pressed.  removes selected row from datatable
        private void remove_Click(object sender, EventArgs e)
        {
            try
            {
                //gets datatable
                DataTable dt = getDataTable();
                //removes selected row
                dt.Rows.RemoveAt(addRemoveTableGrid.CurrentCell.RowIndex);
            }
            //if no rows are selected catch to prevent error
            catch   {}

            
         
        }
        //opens file based off of name passed
        private void openSelectedFile(String fileName)
        {
            //gets datatable
             DataTable dt = getDataTable();
               
            //opens file using filename and adds all lines to lines array

            string[] lines = System.IO.File.ReadAllLines(@"SectionFiles\" + fileName + ".txt");

            //sets linecount to 0
            int lineCount = 0;
            //sets sig and expanded sig to empty
            String sig="";
            String expSig="";
            //performs for each line in file
                foreach (string line in lines)
                {
                //every other line is an expanded sig.  this being rows 2,4,6,8, etc
                    if(lineCount%2==0)
                    {//line to expanded sig if even row number
                        expSig = line;
                    }
                    else
                    {//if odd row number it will be a sig code
                       sig = line;
                    //adds both the expanded sig code and sig code to table
                        dt.Rows.Add(expSig, sig);
                     }
                    //increments line count by 1 to keep track of whether it is a expanded sig or a sig code
                    lineCount++;
                }
            }
        //updates changes to file
        private void saveChanges_Click(object sender, EventArgs e)
        {
            //opens selected file
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"SectionFiles\" + fileName + ".txt", false))
            {
                
                try
                {
                    Object cellValue;
                    //performs for size of table
                    for (int x = 0; x < dt.Rows.Count; x++)
                    {
                        //gets value from column 0, being the sig and writes to file as a line
                        cellValue = dt.Rows[x][0];
                        file.WriteLine(cellValue);
                        //gets value from column 1, being hte expanded sig and writes to the file as a line
                        cellValue = dt.Rows[x][1];
                        file.WriteLine(cellValue);
                    }
                    //displays addremove panel when all changes are made
                    Form1.Instance.PnlContainer.Controls["addRemove"].BringToFront();

                }
                catch
                {
                    //if an error has occured, notify user
                    error.Visible = true;
                }

            }
        }



    
    }
    }

