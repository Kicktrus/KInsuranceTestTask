using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KInsuranceTestTask
{
    public partial class FilterForm : Form
    {
        public string filterValue;
        public FilterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(filterDropBox.SelectedItem != null)
                filterValue = filterDropBox.SelectedItem.ToString();
            this.Hide();
        }
    }
}
