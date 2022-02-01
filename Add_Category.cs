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
    public partial class Add_Category : Form
    {
        Category category;
       public  List<Category> categories = new List<Category>()
       {
           
       };
        
        public Add_Category()
        {
            InitializeComponent();
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category LastItem = null;
            category = new Category();
            if (categories.Count != 0)
            { LastItem = categories.Last(); }
            if (txtbName.Text == "" || txtbDescriotion.Text == "")
            {
           
                     MessageBox.Show("Plz Enter Category Name");
                return;
            }
            category.CategoryName = txtbName.Text;
            category.CategoryDescription = txtbDescriotion.Text;
            foreach (var item in categories)
            {

                if (item.CategoryName.Equals(txtbName.Text))
                {
                    MessageBox.Show("Item is Exist");
                    txtbName.Text = "";
                    txtbDescriotion.Text = "";
                    return;
                }
            }
            if (LastItem != null)
                category.ID = LastItem.ID + 1;
            categories.Add(category);
            gviewCategory.DataSource = null;
            gviewCategory.DataSource = categories;
            txtbName.Text = "";
            txtbDescriotion.Text = "";
           // Add_Product form=new Add_Product();
            //form.ShowDialog();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gviewCategory.SelectedRows.Count > 0)
            {
                int index = gviewCategory.CurrentCell.RowIndex;
                categories[index].CategoryName = txtbName.Text;
                categories[index].CategoryDescription = txtbDescriotion.Text;
                gviewCategory.DataSource = null;
                gviewCategory.DataSource = categories;

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = gviewCategory.CurrentCell.RowIndex;
            categories.Remove(categories[index]);
            gviewCategory.DataSource = null;
            gviewCategory.DataSource = categories;
        }

        private void gviewCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (gviewCategory.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow row in gviewCategory.SelectedRows)
                {
                    txtbName.Text = row.Cells[0].Value.ToString();
                    txtbDescriotion.Text = row.Cells[1].Value.ToString();
                  

                }
            }
        }

        private void gviewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
