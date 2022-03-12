using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV
{
    public partial class HouseRulesEmployee : UserControl
    {
        public HouseRulesEmployee()
        {
            InitializeComponent();
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            string newRule = txtBAddRule.Text.ToString();
            lBHouseRulesEmp.Items.Add($"--> {newRule}");
        }

        private void btnRemoveRule_Click(object sender, EventArgs e)
        {
            int index = lBHouseRulesEmp.SelectedIndex;
            lBHouseRulesEmp.Items.RemoveAt(index);
        }

        private void lBHouseRulesEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
