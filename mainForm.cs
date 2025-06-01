using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.View;
using Restaurant_Management.Model;

namespace Restaurant_Management
{
    public partial class mainForm : Form
    {
        public static mainForm Instance { get; private set; }

        public mainForm()
        {
            InitializeComponent();
            Instance = this;
            Load += mainForm_Load;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            btnHome.PerformClick();
            AddControls(new homeForm());
        }

        public void AddControls(Form f)
        {
            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new homeForm());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            AddControls(new formCategoryView());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            AddControls(new formProductView());
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            formPOS posForm = new formPOS();
            posForm.Show();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            AddControls(new formKitchenView());
        }
    }
}
