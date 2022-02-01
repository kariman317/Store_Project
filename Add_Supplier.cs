using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Add_Supplier : Form
    {
        public Add_Supplier()
        {
            InitializeComponent();
        }
        Supplier suppliers;
        List<Supplier> suppliersList = new List<Supplier>();
        private void txtPhoneDistributer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Supplier LastIndex = null;
            suppliers = new Supplier();
            if (suppliersList.Count != 0)
            { LastIndex = suppliersList.Last(); }
                if (txtNameSupplier.Text == "" || txtCitySupplier.Text == "")
            { 
                    MessageBox.Show("Enter Supplier Data");
                return;
            }
           // suppliers.SupplierID = int.Parse(txtSupplierID.Text);
            suppliers.SupplierName = txtNameSupplier.Text;
            suppliers.SupplierPhone = int.Parse(txtPhoneSupplier.Text);
            suppliers.City = txtCitySupplier.Text;
            foreach (var item in suppliersList)
            {
                if (item.SupplierName.Equals(txtNameSupplier.Text))
                {
                    MessageBox.Show("Supplier is Exist");
                    txtNameSupplier.Text = "";
                    txtCitySupplier.Text = "";
                    return;
                }
            }
            if (LastIndex != null)
                suppliers.SupplierID = LastIndex.SupplierID + 1;
            suppliersList.Add(suppliers);
            gViewAddSupplier.DataSource = null;
            gViewAddSupplier.DataSource = suppliersList;
            txtNameSupplier.Text = "";
            txtCitySupplier.Text = "";
        }

        private void gViewAddSupplier_SelectionChanged(object sender, EventArgs e)
        {
            if (gViewAddSupplier.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow row in gViewAddSupplier.SelectedRows)
                {
                      txtSupplierID.Text = row.Cells[0].Value.ToString();
                     txtNameSupplier.Text = row.Cells[1].Value.ToString();
                     txtPhoneSupplier.Text = row.Cells[2].Value.ToString();
                    txtCitySupplier.Text = row.Cells[3].Value.ToString();

                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gViewAddSupplier.CurrentRow != null)
            {

                int index = gViewAddSupplier.CurrentCell.RowIndex;
                suppliersList[index].SupplierID = Convert.ToInt32(txtSupplierID.Text);
                suppliersList[index].SupplierName = txtNameSupplier.Text;
                suppliersList[index].SupplierPhone = Convert.ToInt32(txtPhoneSupplier.Text);
                suppliersList[index].City = txtCitySupplier.Text;
                suppliersList.Append(suppliersList[index]);
                gViewAddSupplier.DataSource = null;
                gViewAddSupplier.DataSource = suppliersList;
            }
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = gViewAddSupplier.CurrentCell.RowIndex;
            suppliersList.Remove(suppliersList[index]);
            gViewAddSupplier.DataSource = null;
            gViewAddSupplier.DataSource = suppliersList;
        }

        private void gViewAddSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
