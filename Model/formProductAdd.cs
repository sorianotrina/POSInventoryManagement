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
    public partial class formProductAdd : SampleAdd
    {
        public formProductAdd()
        {
            InitializeComponent();
        }
        private void formProductAdd_Load(object sender, EventArgs e)
        {

        }
        public override void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
