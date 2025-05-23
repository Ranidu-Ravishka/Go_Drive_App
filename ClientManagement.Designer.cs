namespace GoDrive__Guna_
{
    partial class ClientManagement
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label client_NameLabel;
            System.Windows.Forms.Label client_IDLabel;
            System.Windows.Forms.Label contact_NumberLabel;
            System.Windows.Forms.Label countryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientManagement));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.contact_NumberTextBox = new System.Windows.Forms.TextBox();
            this.cMdatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientManagementDataSet = new GoDrive__Guna_.ClientManagementDataSet();
            this.client_IDTextBox = new System.Windows.Forms.TextBox();
            this.client_NameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.butminimizedash = new Guna.UI2.WinForms.Guna2GradientButton();
            this.butclosedash = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.butback = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cMdatabaseTableAdapter = new GoDrive__Guna_.ClientManagementDataSetTableAdapters.CMdatabaseTableAdapter();
            this.tableAdapterManager = new GoDrive__Guna_.ClientManagementDataSetTableAdapters.TableAdapterManager();
            this.cMdatabaseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cMdatabaseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cMdatabaseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            client_NameLabel = new System.Windows.Forms.Label();
            client_IDLabel = new System.Windows.Forms.Label();
            contact_NumberLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cMdatabaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientManagementDataSet)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cMdatabaseBindingNavigator)).BeginInit();
            this.cMdatabaseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cMdatabaseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.ForeColor = System.Drawing.Color.White;
            idLabel.Location = new System.Drawing.Point(14, 138);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 84;
            idLabel.Text = "Id:";
            // 
            // client_NameLabel
            // 
            client_NameLabel.AutoSize = true;
            client_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            client_NameLabel.ForeColor = System.Drawing.Color.White;
            client_NameLabel.Location = new System.Drawing.Point(17, 215);
            client_NameLabel.Name = "client_NameLabel";
            client_NameLabel.Size = new System.Drawing.Size(99, 20);
            client_NameLabel.TabIndex = 86;
            client_NameLabel.Text = "Client Name:";
            // 
            // client_IDLabel
            // 
            client_IDLabel.AutoSize = true;
            client_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            client_IDLabel.ForeColor = System.Drawing.Color.White;
            client_IDLabel.Location = new System.Drawing.Point(17, 283);
            client_IDLabel.Name = "client_IDLabel";
            client_IDLabel.Size = new System.Drawing.Size(74, 20);
            client_IDLabel.TabIndex = 88;
            client_IDLabel.Text = "Client ID:";
            // 
            // contact_NumberLabel
            // 
            contact_NumberLabel.AutoSize = true;
            contact_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contact_NumberLabel.ForeColor = System.Drawing.Color.White;
            contact_NumberLabel.Location = new System.Drawing.Point(14, 355);
            contact_NumberLabel.Name = "contact_NumberLabel";
            contact_NumberLabel.Size = new System.Drawing.Size(129, 20);
            contact_NumberLabel.TabIndex = 90;
            contact_NumberLabel.Text = "Contact Number:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countryLabel.ForeColor = System.Drawing.Color.White;
            countryLabel.Location = new System.Drawing.Point(14, 431);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(68, 20);
            countryLabel.TabIndex = 92;
            countryLabel.Text = "Country:";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.contact_NumberTextBox);
            this.guna2Panel1.Controls.Add(this.client_IDTextBox);
            this.guna2Panel1.Controls.Add(this.client_NameTextBox);
            this.guna2Panel1.Controls.Add(this.idTextBox);
            this.guna2Panel1.Controls.Add(this.countryTextBox);
            this.guna2Panel1.Controls.Add(idLabel);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(client_NameLabel);
            this.guna2Panel1.Controls.Add(contact_NumberLabel);
            this.guna2Panel1.Controls.Add(client_IDLabel);
            this.guna2Panel1.Controls.Add(countryLabel);
            this.guna2Panel1.Location = new System.Drawing.Point(9, 113);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(366, 676);
            this.guna2Panel1.TabIndex = 4;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // contact_NumberTextBox
            // 
            this.contact_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cMdatabaseBindingSource, "Contact Number", true));
            this.contact_NumberTextBox.Location = new System.Drawing.Point(14, 382);
            this.contact_NumberTextBox.Name = "contact_NumberTextBox";
            this.contact_NumberTextBox.Size = new System.Drawing.Size(331, 20);
            this.contact_NumberTextBox.TabIndex = 91;
            // 
            // cMdatabaseBindingSource
            // 
            this.cMdatabaseBindingSource.DataMember = "CMdatabase";
            this.cMdatabaseBindingSource.DataSource = this.clientManagementDataSet;
            // 
            // clientManagementDataSet
            // 
            this.clientManagementDataSet.DataSetName = "ClientManagementDataSet";
            this.clientManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // client_IDTextBox
            // 
            this.client_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cMdatabaseBindingSource, "Client ID", true));
            this.client_IDTextBox.Location = new System.Drawing.Point(17, 308);
            this.client_IDTextBox.Name = "client_IDTextBox";
            this.client_IDTextBox.Size = new System.Drawing.Size(331, 20);
            this.client_IDTextBox.TabIndex = 89;
            // 
            // client_NameTextBox
            // 
            this.client_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cMdatabaseBindingSource, "Client Name", true));
            this.client_NameTextBox.Location = new System.Drawing.Point(17, 240);
            this.client_NameTextBox.Name = "client_NameTextBox";
            this.client_NameTextBox.Size = new System.Drawing.Size(331, 20);
            this.client_NameTextBox.TabIndex = 87;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cMdatabaseBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(17, 167);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(331, 20);
            this.idTextBox.TabIndex = 85;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cMdatabaseBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(14, 457);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(331, 20);
            this.countryTextBox.TabIndex = 93;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(102, 553);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(151, 30);
            this.guna2Button1.TabIndex = 22;
            this.guna2Button1.Text = "Proceed";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Add Client Profile";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(44, 39);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(425, 31);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "C L I E N T   M A N A G E M E N T";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.butminimizedash);
            this.guna2ShadowPanel1.Controls.Add(this.butclosedash);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(1128, 31);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(70, 44);
            this.guna2ShadowPanel1.TabIndex = 83;
            // 
            // butminimizedash
            // 
            this.butminimizedash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butminimizedash.BackgroundImage")));
            this.butminimizedash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butminimizedash.CheckedState.Parent = this.butminimizedash;
            this.butminimizedash.CustomImages.Parent = this.butminimizedash;
            this.butminimizedash.FillColor = System.Drawing.Color.Transparent;
            this.butminimizedash.FillColor2 = System.Drawing.Color.Transparent;
            this.butminimizedash.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butminimizedash.ForeColor = System.Drawing.Color.White;
            this.butminimizedash.HoverState.Parent = this.butminimizedash;
            this.butminimizedash.Location = new System.Drawing.Point(11, 13);
            this.butminimizedash.Name = "butminimizedash";
            this.butminimizedash.ShadowDecoration.Parent = this.butminimizedash;
            this.butminimizedash.Size = new System.Drawing.Size(20, 20);
            this.butminimizedash.TabIndex = 4;
            this.butminimizedash.Click += new System.EventHandler(this.butminimizedash_Click);
            // 
            // butclosedash
            // 
            this.butclosedash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butclosedash.BackgroundImage")));
            this.butclosedash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butclosedash.CheckedState.Parent = this.butclosedash;
            this.butclosedash.CustomImages.Parent = this.butclosedash;
            this.butclosedash.FillColor = System.Drawing.Color.Transparent;
            this.butclosedash.FillColor2 = System.Drawing.Color.Transparent;
            this.butclosedash.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butclosedash.ForeColor = System.Drawing.Color.White;
            this.butclosedash.HoverState.Parent = this.butclosedash;
            this.butclosedash.Location = new System.Drawing.Point(37, 13);
            this.butclosedash.Name = "butclosedash";
            this.butclosedash.ShadowDecoration.Parent = this.butclosedash;
            this.butclosedash.Size = new System.Drawing.Size(20, 20);
            this.butclosedash.TabIndex = 4;
            this.butclosedash.Click += new System.EventHandler(this.butclosedash_Click);
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.butback);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(-1, 31);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(50, 44);
            this.guna2ShadowPanel2.TabIndex = 82;
            // 
            // butback
            // 
            this.butback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butback.BackgroundImage")));
            this.butback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butback.CheckedState.Parent = this.butback;
            this.butback.CustomImages.Parent = this.butback;
            this.butback.FillColor = System.Drawing.Color.Transparent;
            this.butback.FillColor2 = System.Drawing.Color.Transparent;
            this.butback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butback.ForeColor = System.Drawing.Color.White;
            this.butback.HoverState.Parent = this.butback;
            this.butback.Location = new System.Drawing.Point(10, 0);
            this.butback.Name = "butback";
            this.butback.ShadowDecoration.Parent = this.butback;
            this.butback.Size = new System.Drawing.Size(30, 44);
            this.butback.TabIndex = 5;
            this.butback.Click += new System.EventHandler(this.butback_Click);
            // 
            // cMdatabaseTableAdapter
            // 
            this.cMdatabaseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CMdatabaseTableAdapter = this.cMdatabaseTableAdapter;
            this.tableAdapterManager.UpdateOrder = GoDrive__Guna_.ClientManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cMdatabaseBindingNavigator
            // 
            this.cMdatabaseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cMdatabaseBindingNavigator.BindingSource = this.cMdatabaseBindingSource;
            this.cMdatabaseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cMdatabaseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cMdatabaseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cMdatabaseBindingNavigatorSaveItem});
            this.cMdatabaseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cMdatabaseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cMdatabaseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cMdatabaseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cMdatabaseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cMdatabaseBindingNavigator.Name = "cMdatabaseBindingNavigator";
            this.cMdatabaseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cMdatabaseBindingNavigator.Size = new System.Drawing.Size(1200, 25);
            this.cMdatabaseBindingNavigator.TabIndex = 84;
            this.cMdatabaseBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cMdatabaseBindingNavigatorSaveItem
            // 
            this.cMdatabaseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cMdatabaseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cMdatabaseBindingNavigatorSaveItem.Image")));
            this.cMdatabaseBindingNavigatorSaveItem.Name = "cMdatabaseBindingNavigatorSaveItem";
            this.cMdatabaseBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cMdatabaseBindingNavigatorSaveItem.Text = "Save Data";
            this.cMdatabaseBindingNavigatorSaveItem.Click += new System.EventHandler(this.cMdatabaseBindingNavigatorSaveItem_Click);
            // 
            // cMdatabaseDataGridView
            // 
            this.cMdatabaseDataGridView.AutoGenerateColumns = false;
            this.cMdatabaseDataGridView.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.cMdatabaseDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cMdatabaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cMdatabaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.cMdatabaseDataGridView.DataSource = this.cMdatabaseBindingSource;
            this.cMdatabaseDataGridView.Location = new System.Drawing.Point(380, 113);
            this.cMdatabaseDataGridView.Name = "cMdatabaseDataGridView";
            this.cMdatabaseDataGridView.Size = new System.Drawing.Size(808, 676);
            this.cMdatabaseDataGridView.TabIndex = 84;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Client Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Client Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Client ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Client ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 185;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Contact Number";
            this.dataGridViewTextBoxColumn4.HeaderText = "Contact Number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn5.HeaderText = "Country";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // ClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.cMdatabaseDataGridView);
            this.Controls.Add(this.cMdatabaseBindingNavigator);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ClientManagement_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cMdatabaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientManagementDataSet)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cMdatabaseBindingNavigator)).EndInit();
            this.cMdatabaseBindingNavigator.ResumeLayout(false);
            this.cMdatabaseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cMdatabaseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton butminimizedash;
        private Guna.UI2.WinForms.Guna2GradientButton butclosedash;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2GradientButton butback;
        private ClientManagementDataSet clientManagementDataSet;
        private System.Windows.Forms.BindingSource cMdatabaseBindingSource;
        private ClientManagementDataSetTableAdapters.CMdatabaseTableAdapter cMdatabaseTableAdapter;
        private ClientManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cMdatabaseBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cMdatabaseBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox contact_NumberTextBox;
        private System.Windows.Forms.TextBox client_IDTextBox;
        private System.Windows.Forms.TextBox client_NameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.DataGridView cMdatabaseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}