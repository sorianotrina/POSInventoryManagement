using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management.Model
{
    public partial class formCategoryAdd : SampleAdd
    {
        public formCategoryAdd()
        {
            InitializeComponent();
        }
        public override void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
