using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace walmartPharmSig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Form1 _obj;

        public static Form1 Instance
        {
            //if form 1 doesnt exist create form 1
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            //getter and setter for panel container
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //sets form1 to this
            _obj = this;
            //creates main menu and adds main menu to display
            main mc = new main();
            mc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(mc);

            
        }
    }
}
