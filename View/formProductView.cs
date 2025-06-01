using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.Model;

namespace Restaurant_Management.View
{
    public partial class formProductView : SampleView
    {
        public formProductView()
        {
            InitializeComponent();
        }

        private void formProductView_Load(object sender, EventArgs e)
        {

        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            formProductAdd addForm = new formProductAdd();
            MainClass.BlurBackground(addForm);
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
