﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grindpipe_app
{
    public partial class ViewAndAddCollection : Form
    {
        public ViewAndAddCollection()
        {
            InitializeComponent();
        }

        private void collectionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.collectionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grindpipe_dbDataSet);

        }

        private void ViewAndAddCollection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grindpipe_dbDataSet.collection' table. You can move, or remove it, as needed.
            this.collectionTableAdapter.Fill(this.grindpipe_dbDataSet.collection);

        }
    }
}
