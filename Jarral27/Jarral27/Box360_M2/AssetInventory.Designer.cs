namespace Box360_M2
{
    partial class AssetInventory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetInventory));
            this.dsBox360 = new Box360_M2.dsBox360();
            this.assetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetTableAdapter = new Box360_M2.dsBox360TableAdapters.AssetTableAdapter();
            this.tableAdapterManager = new Box360_M2.dsBox360TableAdapters.TableAdapterManager();
            this.assetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.assetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.Assetdb = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddAssetgroupBox = new System.Windows.Forms.GroupBox();
            this.AssetIdBtn = new System.Windows.Forms.Button();
            this.TxtCostPrice = new System.Windows.Forms.TextBox();
            this.TxtType = new System.Windows.Forms.TextBox();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.CostPrice = new System.Windows.Forms.Label();
            this.TxtAssetID = new System.Windows.Forms.TextBox();
            this.txtAssName = new System.Windows.Forms.TextBox();
            this.TxtCondition = new System.Windows.Forms.TextBox();
            this.AssNameLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.AddAsset = new System.Windows.Forms.Button();
            this.DeleteAsset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtUpdateQuantity = new System.Windows.Forms.TextBox();
            this.UpdateQuantity = new System.Windows.Forms.Label();
            this.UpdateCondition = new System.Windows.Forms.Label();
            this.updateconditioncb = new System.Windows.Forms.ComboBox();
            this.UpdateAsset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsBox360)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingNavigator)).BeginInit();
            this.assetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Assetdb)).BeginInit();
            this.AddAssetgroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsBox360
            // 
            this.dsBox360.DataSetName = "dsBox360";
            this.dsBox360.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetBindingSource
            // 
            this.assetBindingSource.DataMember = "Asset";
            this.assetBindingSource.DataSource = this.dsBox360;
            // 
            // assetTableAdapter
            // 
            this.assetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssetTableAdapter = this.assetTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CoachTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.SaleItemTableAdapter = null;
            this.tableAdapterManager.SaleTableAdapter = null;
            this.tableAdapterManager.SupplierOrderTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Box360_M2.dsBox360TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // assetBindingNavigator
            // 
            this.assetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.assetBindingNavigator.BindingSource = this.assetBindingSource;
            this.assetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.assetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.assetBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.assetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.assetBindingNavigatorSaveItem});
            this.assetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.assetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.assetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.assetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.assetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.assetBindingNavigator.Name = "assetBindingNavigator";
            this.assetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.assetBindingNavigator.Size = new System.Drawing.Size(1292, 27);
            this.assetBindingNavigator.TabIndex = 0;
            this.assetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // assetBindingNavigatorSaveItem
            // 
            this.assetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.assetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("assetBindingNavigatorSaveItem.Image")));
            this.assetBindingNavigatorSaveItem.Name = "assetBindingNavigatorSaveItem";
            this.assetBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.assetBindingNavigatorSaveItem.Text = "Save Data";
            this.assetBindingNavigatorSaveItem.Click += new System.EventHandler(this.assetBindingNavigatorSaveItem_Click);
            // 
            // Assetdb
            // 
            this.Assetdb.AutoGenerateColumns = false;
            this.Assetdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Assetdb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.Assetdb.DataSource = this.assetBindingSource;
            this.Assetdb.Location = new System.Drawing.Point(12, 41);
            this.Assetdb.Name = "Assetdb";
            this.Assetdb.RowHeadersWidth = 51;
            this.Assetdb.RowTemplate.Height = 24;
            this.Assetdb.Size = new System.Drawing.Size(809, 220);
            this.Assetdb.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AssetID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AssetID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AssetName";
            this.dataGridViewTextBoxColumn2.HeaderText = "AssetName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Condition";
            this.dataGridViewTextBoxColumn3.HeaderText = "Condition";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CostPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "CostPrice";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn5.HeaderText = "Type";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn6.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // AddAssetgroupBox
            // 
            this.AddAssetgroupBox.Controls.Add(this.AddAsset);
            this.AddAssetgroupBox.Controls.Add(this.ConditionLabel);
            this.AddAssetgroupBox.Controls.Add(this.AssNameLabel);
            this.AddAssetgroupBox.Controls.Add(this.TxtCondition);
            this.AddAssetgroupBox.Controls.Add(this.txtAssName);
            this.AddAssetgroupBox.Controls.Add(this.TxtAssetID);
            this.AddAssetgroupBox.Controls.Add(this.CostPrice);
            this.AddAssetgroupBox.Controls.Add(this.Type);
            this.AddAssetgroupBox.Controls.Add(this.Quantity);
            this.AddAssetgroupBox.Controls.Add(this.TxtQuantity);
            this.AddAssetgroupBox.Controls.Add(this.TxtType);
            this.AddAssetgroupBox.Controls.Add(this.TxtCostPrice);
            this.AddAssetgroupBox.Controls.Add(this.AssetIdBtn);
            this.AddAssetgroupBox.Location = new System.Drawing.Point(12, 286);
            this.AddAssetgroupBox.Name = "AddAssetgroupBox";
            this.AddAssetgroupBox.Size = new System.Drawing.Size(676, 187);
            this.AddAssetgroupBox.TabIndex = 2;
            this.AddAssetgroupBox.TabStop = false;
            this.AddAssetgroupBox.Text = "Add an Asset";
            this.AddAssetgroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AssetIdBtn
            // 
            this.AssetIdBtn.Location = new System.Drawing.Point(15, 38);
            this.AssetIdBtn.Name = "AssetIdBtn";
            this.AssetIdBtn.Size = new System.Drawing.Size(151, 31);
            this.AssetIdBtn.TabIndex = 0;
            this.AssetIdBtn.Text = "Generate Asset ID";
            this.AssetIdBtn.UseVisualStyleBackColor = true;
            this.AssetIdBtn.Click += new System.EventHandler(this.AssetIdBtn_Click);
            // 
            // TxtCostPrice
            // 
            this.TxtCostPrice.Location = new System.Drawing.Point(436, 145);
            this.TxtCostPrice.Name = "TxtCostPrice";
            this.TxtCostPrice.Size = new System.Drawing.Size(111, 22);
            this.TxtCostPrice.TabIndex = 14;
            // 
            // TxtType
            // 
            this.TxtType.Location = new System.Drawing.Point(436, 95);
            this.TxtType.Name = "TxtType";
            this.TxtType.Size = new System.Drawing.Size(111, 22);
            this.TxtType.TabIndex = 15;
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(436, 49);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(111, 22);
            this.TxtQuantity.TabIndex = 16;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(369, 52);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(61, 17);
            this.Quantity.TabIndex = 17;
            this.Quantity.Text = "Quantity";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(390, 95);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(40, 17);
            this.Type.TabIndex = 18;
            this.Type.Text = "Type";
            // 
            // CostPrice
            // 
            this.CostPrice.AutoSize = true;
            this.CostPrice.Location = new System.Drawing.Point(358, 148);
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.Size = new System.Drawing.Size(72, 17);
            this.CostPrice.TabIndex = 19;
            this.CostPrice.Text = "Cost Price";
            // 
            // TxtAssetID
            // 
            this.TxtAssetID.Location = new System.Drawing.Point(172, 47);
            this.TxtAssetID.Name = "TxtAssetID";
            this.TxtAssetID.ReadOnly = true;
            this.TxtAssetID.Size = new System.Drawing.Size(111, 22);
            this.TxtAssetID.TabIndex = 20;
            // 
            // txtAssName
            // 
            this.txtAssName.Location = new System.Drawing.Point(172, 95);
            this.txtAssName.Name = "txtAssName";
            this.txtAssName.ReadOnly = true;
            this.txtAssName.Size = new System.Drawing.Size(111, 22);
            this.txtAssName.TabIndex = 21;
            this.txtAssName.TextChanged += new System.EventHandler(this.TxtAssName_TextChanged);
            // 
            // TxtCondition
            // 
            this.TxtCondition.Location = new System.Drawing.Point(172, 143);
            this.TxtCondition.Name = "TxtCondition";
            this.TxtCondition.ReadOnly = true;
            this.TxtCondition.Size = new System.Drawing.Size(111, 22);
            this.TxtCondition.TabIndex = 22;
            // 
            // AssNameLabel
            // 
            this.AssNameLabel.AutoSize = true;
            this.AssNameLabel.Location = new System.Drawing.Point(82, 100);
            this.AssNameLabel.Name = "AssNameLabel";
            this.AssNameLabel.Size = new System.Drawing.Size(84, 17);
            this.AssNameLabel.TabIndex = 23;
            this.AssNameLabel.Text = "Asset Name";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(99, 148);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(67, 17);
            this.ConditionLabel.TabIndex = 24;
            this.ConditionLabel.Text = "Condition";
            // 
            // AddAsset
            // 
            this.AddAsset.Location = new System.Drawing.Point(570, 114);
            this.AddAsset.Name = "AddAsset";
            this.AddAsset.Size = new System.Drawing.Size(100, 53);
            this.AddAsset.TabIndex = 25;
            this.AddAsset.Text = "Add Asset";
            this.AddAsset.UseVisualStyleBackColor = true;
            this.AddAsset.Click += new System.EventHandler(this.AddAsset_Click);
            // 
            // DeleteAsset
            // 
            this.DeleteAsset.Location = new System.Drawing.Point(885, 120);
            this.DeleteAsset.Name = "DeleteAsset";
            this.DeleteAsset.Size = new System.Drawing.Size(144, 51);
            this.DeleteAsset.TabIndex = 18;
            this.DeleteAsset.Text = "Delete Asset";
            this.DeleteAsset.UseVisualStyleBackColor = true;
            this.DeleteAsset.Click += new System.EventHandler(this.DeleteAsset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UpdateAsset);
            this.groupBox1.Controls.Add(this.updateconditioncb);
            this.groupBox1.Controls.Add(this.UpdateCondition);
            this.groupBox1.Controls.Add(this.UpdateQuantity);
            this.groupBox1.Controls.Add(this.TxtUpdateQuantity);
            this.groupBox1.Location = new System.Drawing.Point(784, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 187);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update an Asset";
            // 
            // TxtUpdateQuantity
            // 
            this.TxtUpdateQuantity.Location = new System.Drawing.Point(164, 54);
            this.TxtUpdateQuantity.Name = "TxtUpdateQuantity";
            this.TxtUpdateQuantity.Size = new System.Drawing.Size(121, 22);
            this.TxtUpdateQuantity.TabIndex = 1;
            // 
            // UpdateQuantity
            // 
            this.UpdateQuantity.AutoSize = true;
            this.UpdateQuantity.Location = new System.Drawing.Point(27, 54);
            this.UpdateQuantity.Name = "UpdateQuantity";
            this.UpdateQuantity.Size = new System.Drawing.Size(111, 17);
            this.UpdateQuantity.TabIndex = 2;
            this.UpdateQuantity.Text = "Update Quantity";
            // 
            // UpdateCondition
            // 
            this.UpdateCondition.AutoSize = true;
            this.UpdateCondition.Location = new System.Drawing.Point(27, 100);
            this.UpdateCondition.Name = "UpdateCondition";
            this.UpdateCondition.Size = new System.Drawing.Size(117, 17);
            this.UpdateCondition.TabIndex = 3;
            this.UpdateCondition.Text = "Update Condition";
            // 
            // updateconditioncb
            // 
            this.updateconditioncb.AutoCompleteCustomSource.AddRange(new string[] {
            "Excellent",
            "Good",
            "Bad",
            "Damaged"});
            this.updateconditioncb.FormattingEnabled = true;
            this.updateconditioncb.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Bad",
            "Damaged"});
            this.updateconditioncb.Location = new System.Drawing.Point(164, 93);
            this.updateconditioncb.Name = "updateconditioncb";
            this.updateconditioncb.Size = new System.Drawing.Size(121, 24);
            this.updateconditioncb.TabIndex = 4;
            // 
            // UpdateAsset
            // 
            this.UpdateAsset.Location = new System.Drawing.Point(314, 64);
            this.UpdateAsset.Name = "UpdateAsset";
            this.UpdateAsset.Size = new System.Drawing.Size(96, 53);
            this.UpdateAsset.TabIndex = 16;
            this.UpdateAsset.Text = "Update Asset";
            this.UpdateAsset.UseVisualStyleBackColor = true;
            this.UpdateAsset.Click += new System.EventHandler(this.UpdateAsset_Click);
            // 
            // AssetInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteAsset);
            this.Controls.Add(this.AddAssetgroupBox);
            this.Controls.Add(this.Assetdb);
            this.Controls.Add(this.assetBindingNavigator);
            this.Name = "AssetInventory";
            this.Text = "AssetInventory";
            this.Load += new System.EventHandler(this.AssetInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBox360)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingNavigator)).EndInit();
            this.assetBindingNavigator.ResumeLayout(false);
            this.assetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Assetdb)).EndInit();
            this.AddAssetgroupBox.ResumeLayout(false);
            this.AddAssetgroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsBox360 dsBox360;
        private System.Windows.Forms.BindingSource assetBindingSource;
        private dsBox360TableAdapters.AssetTableAdapter assetTableAdapter;
        private dsBox360TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator assetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton assetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView Assetdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox AddAssetgroupBox;
        private System.Windows.Forms.Button AddAsset;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label AssNameLabel;
        private System.Windows.Forms.TextBox TxtCondition;
        private System.Windows.Forms.TextBox txtAssName;
        private System.Windows.Forms.TextBox TxtAssetID;
        private System.Windows.Forms.Label CostPrice;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.TextBox TxtType;
        private System.Windows.Forms.TextBox TxtCostPrice;
        private System.Windows.Forms.Button AssetIdBtn;
        private System.Windows.Forms.Button DeleteAsset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UpdateAsset;
        private System.Windows.Forms.ComboBox updateconditioncb;
        private System.Windows.Forms.Label UpdateCondition;
        private System.Windows.Forms.Label UpdateQuantity;
        private System.Windows.Forms.TextBox TxtUpdateQuantity;
    }
}