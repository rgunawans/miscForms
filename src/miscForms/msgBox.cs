using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace miscForms
{
    public partial class msgBox : Form
    {
        public string _ErrorMessage;
        public string _photoURL;
        public string _warna;
        public string _returnform;

        public msgBox()
        {
            InitializeComponent();
            //panjang max: 750, hidden picturebox
            //panjang min: 497, show picturebox
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            if (_returnform != "")
            {
                this.Dispose();
                
                var form = Activator.CreateInstance(Type.GetType("namespace." + _returnform)) as Form;

                form.ShowDialog();

            }
            else
            {
                this.Dispose();
            }
        }

        private void frmMessageBox_Load(object sender, EventArgs e)
        {
            if (_warna == "Merah")
            {
                this.BackColor = Color.DarkRed;
                btnClose.BackColor = Color.DarkRed;
            }
            else
            {
                this.BackColor = Color.DarkBlue;
                btnClose.BackColor = Color.DarkBlue;
            }
            if (_photoURL == "")
            {
                lblError.Width = 750;
                pBoxCapture.Visible = false;
                
            }
            else
            {
                lblError.Width = 497;
                pBoxCapture.Visible = true;
                pBoxCapture.Image = new Bitmap(_photoURL);

            }
            lblError.Text = _ErrorMessage;
        }
    }
}
