﻿namespace WindowsFormsApp1
{
    partial class Store_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gviewDataStore = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Cutomers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Supplier = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Prduect = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2ComboBox5 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gviewDataStore)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(102, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Store";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.guna2NumericUpDown1);
            this.panel1.Controls.Add(this.gviewDataStore);
            this.panel1.Controls.Add(this.Cutomers);
            this.panel1.Controls.Add(this.Supplier);
            this.panel1.Controls.Add(this.Prduect);
            this.panel1.Controls.Add(this.Category);
            this.panel1.Controls.Add(this.lblCustomers);
            this.panel1.Controls.Add(this.lblSupplier);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.lblProduct);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 587);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gviewDataStore
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gviewDataStore.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gviewDataStore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gviewDataStore.BackgroundColor = System.Drawing.Color.Silver;
            this.gviewDataStore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gviewDataStore.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gviewDataStore.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gviewDataStore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gviewDataStore.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gviewDataStore.DefaultCellStyle = dataGridViewCellStyle3;
            this.gviewDataStore.EnableHeadersVisualStyles = false;
            this.gviewDataStore.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gviewDataStore.Location = new System.Drawing.Point(14, 236);
            this.gviewDataStore.Name = "gviewDataStore";
            this.gviewDataStore.RowHeadersVisible = false;
            this.gviewDataStore.RowHeadersWidth = 51;
            this.gviewDataStore.RowTemplate.Height = 26;
            this.gviewDataStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gviewDataStore.Size = new System.Drawing.Size(1009, 351);
            this.gviewDataStore.TabIndex = 22;
            this.gviewDataStore.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gviewDataStore.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gviewDataStore.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gviewDataStore.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gviewDataStore.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gviewDataStore.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.gviewDataStore.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gviewDataStore.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gviewDataStore.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gviewDataStore.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gviewDataStore.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gviewDataStore.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gviewDataStore.ThemeStyle.HeaderStyle.Height = 4;
            this.gviewDataStore.ThemeStyle.ReadOnly = false;
            this.gviewDataStore.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gviewDataStore.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gviewDataStore.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gviewDataStore.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gviewDataStore.ThemeStyle.RowsStyle.Height = 26;
            this.gviewDataStore.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gviewDataStore.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Cutomers
            // 
            this.Cutomers.AutoRoundedCorners = true;
            this.Cutomers.BackColor = System.Drawing.Color.Transparent;
            this.Cutomers.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Cutomers.BorderRadius = 17;
            this.Cutomers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cutomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cutomers.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cutomers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cutomers.FocusedState.Parent = this.Cutomers;
            this.Cutomers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cutomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Cutomers.HoverState.Parent = this.Cutomers;
            this.Cutomers.ItemHeight = 30;
            this.Cutomers.ItemsAppearance.Parent = this.Cutomers;
            this.Cutomers.Location = new System.Drawing.Point(504, 180);
            this.Cutomers.Name = "Cutomers";
            this.Cutomers.ShadowDecoration.Parent = this.Cutomers;
            this.Cutomers.Size = new System.Drawing.Size(202, 36);
            this.Cutomers.TabIndex = 21;
            // 
            // Supplier
            // 
            this.Supplier.AutoRoundedCorners = true;
            this.Supplier.BackColor = System.Drawing.Color.Transparent;
            this.Supplier.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Supplier.BorderRadius = 17;
            this.Supplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Supplier.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Supplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Supplier.FocusedState.Parent = this.Supplier;
            this.Supplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Supplier.HoverState.Parent = this.Supplier;
            this.Supplier.ItemHeight = 30;
            this.Supplier.ItemsAppearance.Parent = this.Supplier;
            this.Supplier.Location = new System.Drawing.Point(152, 180);
            this.Supplier.Name = "Supplier";
            this.Supplier.ShadowDecoration.Parent = this.Supplier;
            this.Supplier.Size = new System.Drawing.Size(215, 36);
            this.Supplier.TabIndex = 20;
            // 
            // Prduect
            // 
            this.Prduect.AutoRoundedCorners = true;
            this.Prduect.BackColor = System.Drawing.Color.Transparent;
            this.Prduect.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Prduect.BorderRadius = 17;
            this.Prduect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Prduect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Prduect.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Prduect.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Prduect.FocusedState.Parent = this.Prduect;
            this.Prduect.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Prduect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Prduect.HoverState.Parent = this.Prduect;
            this.Prduect.ItemHeight = 30;
            this.Prduect.ItemsAppearance.Parent = this.Prduect;
            this.Prduect.Location = new System.Drawing.Point(329, 78);
            this.Prduect.Name = "Prduect";
            this.Prduect.ShadowDecoration.Parent = this.Prduect;
            this.Prduect.Size = new System.Drawing.Size(161, 36);
            this.Prduect.TabIndex = 16;
            // 
            // Category
            // 
            this.Category.AutoRoundedCorners = true;
            this.Category.BackColor = System.Drawing.Color.Transparent;
            this.Category.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Category.BorderRadius = 17;
            this.Category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Category.FocusedState.Parent = this.Category;
            this.Category.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Category.HoverState.Parent = this.Category;
            this.Category.ItemHeight = 30;
            this.Category.ItemsAppearance.Parent = this.Category;
            this.Category.Location = new System.Drawing.Point(14, 78);
            this.Category.Name = "Category";
            this.Category.ShadowDecoration.Parent = this.Category;
            this.Category.Size = new System.Drawing.Size(215, 36);
            this.Category.TabIndex = 15;
            this.Category.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblCustomers.Location = new System.Drawing.Point(542, 137);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(129, 30);
            this.lblCustomers.TabIndex = 10;
            this.lblCustomers.Text = "Customers";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblSupplier.Location = new System.Drawing.Point(177, 137);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(103, 30);
            this.lblSupplier.TabIndex = 8;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblQuantity.Location = new System.Drawing.Point(723, 32);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(106, 30);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblProduct.Location = new System.Drawing.Point(365, 32);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(98, 30);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Product";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblCategory.Location = new System.Drawing.Point(43, 32);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(111, 30);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.salesInvoiceToolStripMenuItem,
            this.purchaseInvoiceToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStoreToolStripMenuItem,
            this.addCategoyToolStripMenuItem,
            this.addProductsToolStripMenuItem,
            this.addSuppliersToolStripMenuItem,
            this.addCustomersToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.editToolStripMenuItem.Text = "Go to";
            // 
            // addStoreToolStripMenuItem
            // 
            this.addStoreToolStripMenuItem.Name = "addStoreToolStripMenuItem";
            this.addStoreToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addStoreToolStripMenuItem.Text = "Store";
            this.addStoreToolStripMenuItem.Click += new System.EventHandler(this.addStoreToolStripMenuItem_Click);
            // 
            // addCategoyToolStripMenuItem
            // 
            this.addCategoyToolStripMenuItem.Name = "addCategoyToolStripMenuItem";
            this.addCategoyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addCategoyToolStripMenuItem.Text = "Category";
            this.addCategoyToolStripMenuItem.Click += new System.EventHandler(this.addCategoyToolStripMenuItem_Click);
            // 
            // addProductsToolStripMenuItem
            // 
            this.addProductsToolStripMenuItem.Name = "addProductsToolStripMenuItem";
            this.addProductsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addProductsToolStripMenuItem.Text = "Products";
            this.addProductsToolStripMenuItem.Click += new System.EventHandler(this.addProductsToolStripMenuItem_Click);
            // 
            // addSuppliersToolStripMenuItem
            // 
            this.addSuppliersToolStripMenuItem.Name = "addSuppliersToolStripMenuItem";
            this.addSuppliersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addSuppliersToolStripMenuItem.Text = "Suppliers";
            this.addSuppliersToolStripMenuItem.Click += new System.EventHandler(this.addSuppliersToolStripMenuItem_Click);
            // 
            // addCustomersToolStripMenuItem
            // 
            this.addCustomersToolStripMenuItem.Name = "addCustomersToolStripMenuItem";
            this.addCustomersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addCustomersToolStripMenuItem.Text = "Distributers";
            this.addCustomersToolStripMenuItem.Click += new System.EventHandler(this.addCustomersToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.exitToolStripMenuItem.Text = "Edit";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportToolStripMenuItem.Text = "Reports";
            // 
            // salesInvoiceToolStripMenuItem
            // 
            this.salesInvoiceToolStripMenuItem.Name = "salesInvoiceToolStripMenuItem";
            this.salesInvoiceToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.salesInvoiceToolStripMenuItem.Text = "Sales Invoice";
            // 
            // purchaseInvoiceToolStripMenuItem
            // 
            this.purchaseInvoiceToolStripMenuItem.Name = "purchaseInvoiceToolStripMenuItem";
            this.purchaseInvoiceToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.purchaseInvoiceToolStripMenuItem.Text = "Purchase Invoice";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // guna2ComboBox5
            // 
            this.guna2ComboBox5.AutoRoundedCorners = true;
            this.guna2ComboBox5.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox5.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2ComboBox5.BorderThickness = 0;
            this.guna2ComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox5.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox5.FocusedState.Parent = this.guna2ComboBox5;
            this.guna2ComboBox5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox5.HoverState.Parent = this.guna2ComboBox5;
            this.guna2ComboBox5.ItemHeight = 30;
            this.guna2ComboBox5.ItemsAppearance.Parent = this.guna2ComboBox5;
            this.guna2ComboBox5.Location = new System.Drawing.Point(211, 51);
            this.guna2ComboBox5.Name = "guna2ComboBox5";
            this.guna2ComboBox5.ShadowDecoration.Parent = this.guna2ComboBox5;
            this.guna2ComboBox5.Size = new System.Drawing.Size(215, 36);
            this.guna2ComboBox5.TabIndex = 16;
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.AutoRoundedCorners = true;
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown1.BorderRadius = 17;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown1.DisabledState.Parent = this.guna2NumericUpDown1;
            this.guna2NumericUpDown1.FocusedState.Parent = this.guna2NumericUpDown1;
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2NumericUpDown1.ForeColor = System.Drawing.Color.Black;
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(729, 78);
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.ShadowDecoration.Parent = this.guna2NumericUpDown1;
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(100, 36);
            this.guna2NumericUpDown1.TabIndex = 23;
            this.guna2NumericUpDown1.UseTransparentBackground = true;
            // 
            // Store_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1055, 733);
            this.Controls.Add(this.guna2ComboBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Store_Form";
            this.Text = "Store_Form";
            this.Load += new System.EventHandler(this.Store_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gviewDataStore)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2ComboBox Prduect;
        private Guna.UI2.WinForms.Guna2ComboBox Category;
        private Guna.UI2.WinForms.Guna2ComboBox Supplier;
        private Guna.UI2.WinForms.Guna2DataGridView gviewDataStore;
        private Guna.UI2.WinForms.Guna2ComboBox Cutomers;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox5;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseInvoiceToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
    }
}