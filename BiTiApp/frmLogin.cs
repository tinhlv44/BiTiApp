using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiTiApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            init();
            resgisterEvent();
        }

        void init()
        {
            pnRegister.Dock = DockStyle.Right;
        }

        #region Event

        void resgisterEvent()
        {
            lblClose.Click += LblClose_Click;
            lblRegClose.Click += LblClose_Click;
            btnLoginChange.Click += BtnLoginChange_Click;
            btnRegChange.Click += BtnRegChange_Click;
        }

        private void BtnRegChange_Click(object sender, EventArgs e)
        {
            pnLogin.Visible = false;
            pnRegister.Visible = true;
        }

        private void BtnLoginChange_Click(object sender, EventArgs e)
        {
            pnLogin.Visible = true;
            pnRegister.Visible = false;
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        }
}   
