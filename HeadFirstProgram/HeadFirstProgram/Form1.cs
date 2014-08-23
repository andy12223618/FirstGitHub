using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HeadFirstProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contactTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contectDBDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“contectDBDataSet1.ContactTable”中。您可以根据需要移动或移除它。
            this.contactTableTableAdapter.Fill(this.contectDBDataSet1.ContactTable);

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }
    }
}
