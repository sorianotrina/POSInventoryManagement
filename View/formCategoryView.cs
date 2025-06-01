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
    public partial class formCategoryView : SampleView
    {
        public formCategoryView()
        {
            InitializeComponent();
        }
        private void formCategoryView_Load(object sender, EventArgs e)
        {

        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            formCategoryAdd addForm = new formCategoryAdd();
            MainClass.BlurBackground(addForm);
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
