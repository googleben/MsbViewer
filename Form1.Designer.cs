namespace MsbViewer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.msbListControl = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.msbItemsDgv = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.msbItemListInnerDgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msbItemListItemDgv = new System.Windows.Forms.DataGridView();
            this.gridViewColumnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.headerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerContainerStyleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerTemplateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerTemplateSelectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerStringFormatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayMemberBindingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellTemplateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellTemplateSelectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualWidthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dependencyObjectTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSealedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dispatcherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msbListControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msbItemsDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msbItemListInnerDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msbItemListItemDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewColumnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.msbListControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1748, 450);
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer1.TabIndex = 0;
            // 
            // msbListControl
            // 
            this.msbListControl.AllowUserToAddRows = false;
            this.msbListControl.AllowUserToDeleteRows = false;
            this.msbListControl.AllowUserToResizeRows = false;
            this.msbListControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msbListControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name});
            this.msbListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msbListControl.Location = new System.Drawing.Point(0, 0);
            this.msbListControl.Name = "msbListControl";
            this.msbListControl.ReadOnly = true;
            this.msbListControl.RowHeadersVisible = false;
            this.msbListControl.RowTemplate.Height = 25;
            this.msbListControl.Size = new System.Drawing.Size(176, 450);
            this.msbListControl.TabIndex = 0;
            this.msbListControl.SelectionChanged += new System.EventHandler(this.msbListControl_SelectionChanged);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.msbItemsDgv);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1568, 450);
            this.splitContainer2.SplitterDistance = 196;
            this.splitContainer2.TabIndex = 0;
            // 
            // msbItemsDgv
            // 
            this.msbItemsDgv.AllowUserToResizeRows = false;
            this.msbItemsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msbItemsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item});
            this.msbItemsDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msbItemsDgv.Location = new System.Drawing.Point(0, 0);
            this.msbItemsDgv.Name = "msbItemsDgv";
            this.msbItemsDgv.RowHeadersVisible = false;
            this.msbItemsDgv.RowTemplate.Height = 25;
            this.msbItemsDgv.Size = new System.Drawing.Size(196, 450);
            this.msbItemsDgv.TabIndex = 0;
            this.msbItemsDgv.SelectionChanged += new System.EventHandler(this.msbItemsDgv_SelectionChanged);
            // 
            // item
            // 
            this.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.msbItemListInnerDgv);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.msbItemListItemDgv);
            this.splitContainer3.Size = new System.Drawing.Size(1368, 450);
            this.splitContainer3.SplitterDistance = 456;
            this.splitContainer3.TabIndex = 0;
            // 
            // msbItemListInnerDgv
            // 
            this.msbItemListInnerDgv.AllowUserToAddRows = false;
            this.msbItemListInnerDgv.AllowUserToDeleteRows = false;
            this.msbItemListInnerDgv.AllowUserToResizeRows = false;
            this.msbItemListInnerDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.msbItemListInnerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msbItemListInnerDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.msbItemListInnerDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msbItemListInnerDgv.Location = new System.Drawing.Point(0, 0);
            this.msbItemListInnerDgv.Name = "msbItemListInnerDgv";
            this.msbItemListInnerDgv.ReadOnly = true;
            this.msbItemListInnerDgv.RowHeadersVisible = false;
            this.msbItemListInnerDgv.RowTemplate.Height = 25;
            this.msbItemListInnerDgv.Size = new System.Drawing.Size(456, 450);
            this.msbItemListInnerDgv.TabIndex = 0;
            this.msbItemListInnerDgv.SelectionChanged += new System.EventHandler(this.msbItemListInnerDgv_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // msbItemListItemDgv
            // 
            this.msbItemListItemDgv.AllowUserToAddRows = false;
            this.msbItemListItemDgv.AllowUserToDeleteRows = false;
            this.msbItemListItemDgv.AllowUserToResizeRows = false;
            this.msbItemListItemDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.msbItemListItemDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msbItemListItemDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msbItemListItemDgv.Location = new System.Drawing.Point(0, 0);
            this.msbItemListItemDgv.Name = "msbItemListItemDgv";
            this.msbItemListItemDgv.ReadOnly = true;
            this.msbItemListItemDgv.RowHeadersVisible = false;
            this.msbItemListItemDgv.RowTemplate.Height = 25;
            this.msbItemListItemDgv.Size = new System.Drawing.Size(908, 450);
            this.msbItemListItemDgv.TabIndex = 0;
            // 
            // headerDataGridViewTextBoxColumn
            // 
            this.headerDataGridViewTextBoxColumn.DataPropertyName = "Header";
            this.headerDataGridViewTextBoxColumn.HeaderText = "Header";
            this.headerDataGridViewTextBoxColumn.Name = "headerDataGridViewTextBoxColumn";
            this.headerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // headerContainerStyleDataGridViewTextBoxColumn
            // 
            this.headerContainerStyleDataGridViewTextBoxColumn.DataPropertyName = "HeaderContainerStyle";
            this.headerContainerStyleDataGridViewTextBoxColumn.HeaderText = "HeaderContainerStyle";
            this.headerContainerStyleDataGridViewTextBoxColumn.Name = "headerContainerStyleDataGridViewTextBoxColumn";
            this.headerContainerStyleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // headerTemplateDataGridViewTextBoxColumn
            // 
            this.headerTemplateDataGridViewTextBoxColumn.DataPropertyName = "HeaderTemplate";
            this.headerTemplateDataGridViewTextBoxColumn.HeaderText = "HeaderTemplate";
            this.headerTemplateDataGridViewTextBoxColumn.Name = "headerTemplateDataGridViewTextBoxColumn";
            this.headerTemplateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // headerTemplateSelectorDataGridViewTextBoxColumn
            // 
            this.headerTemplateSelectorDataGridViewTextBoxColumn.DataPropertyName = "HeaderTemplateSelector";
            this.headerTemplateSelectorDataGridViewTextBoxColumn.HeaderText = "HeaderTemplateSelector";
            this.headerTemplateSelectorDataGridViewTextBoxColumn.Name = "headerTemplateSelectorDataGridViewTextBoxColumn";
            this.headerTemplateSelectorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // headerStringFormatDataGridViewTextBoxColumn
            // 
            this.headerStringFormatDataGridViewTextBoxColumn.DataPropertyName = "HeaderStringFormat";
            this.headerStringFormatDataGridViewTextBoxColumn.HeaderText = "HeaderStringFormat";
            this.headerStringFormatDataGridViewTextBoxColumn.Name = "headerStringFormatDataGridViewTextBoxColumn";
            this.headerStringFormatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // displayMemberBindingDataGridViewTextBoxColumn
            // 
            this.displayMemberBindingDataGridViewTextBoxColumn.DataPropertyName = "DisplayMemberBinding";
            this.displayMemberBindingDataGridViewTextBoxColumn.HeaderText = "DisplayMemberBinding";
            this.displayMemberBindingDataGridViewTextBoxColumn.Name = "displayMemberBindingDataGridViewTextBoxColumn";
            this.displayMemberBindingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cellTemplateDataGridViewTextBoxColumn
            // 
            this.cellTemplateDataGridViewTextBoxColumn.DataPropertyName = "CellTemplate";
            this.cellTemplateDataGridViewTextBoxColumn.HeaderText = "CellTemplate";
            this.cellTemplateDataGridViewTextBoxColumn.Name = "cellTemplateDataGridViewTextBoxColumn";
            this.cellTemplateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cellTemplateSelectorDataGridViewTextBoxColumn
            // 
            this.cellTemplateSelectorDataGridViewTextBoxColumn.DataPropertyName = "CellTemplateSelector";
            this.cellTemplateSelectorDataGridViewTextBoxColumn.HeaderText = "CellTemplateSelector";
            this.cellTemplateSelectorDataGridViewTextBoxColumn.Name = "cellTemplateSelectorDataGridViewTextBoxColumn";
            this.cellTemplateSelectorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actualWidthDataGridViewTextBoxColumn
            // 
            this.actualWidthDataGridViewTextBoxColumn.DataPropertyName = "ActualWidth";
            this.actualWidthDataGridViewTextBoxColumn.HeaderText = "ActualWidth";
            this.actualWidthDataGridViewTextBoxColumn.Name = "actualWidthDataGridViewTextBoxColumn";
            this.actualWidthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dependencyObjectTypeDataGridViewTextBoxColumn
            // 
            this.dependencyObjectTypeDataGridViewTextBoxColumn.DataPropertyName = "DependencyObjectType";
            this.dependencyObjectTypeDataGridViewTextBoxColumn.HeaderText = "DependencyObjectType";
            this.dependencyObjectTypeDataGridViewTextBoxColumn.Name = "dependencyObjectTypeDataGridViewTextBoxColumn";
            this.dependencyObjectTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isSealedDataGridViewCheckBoxColumn
            // 
            this.isSealedDataGridViewCheckBoxColumn.DataPropertyName = "IsSealed";
            this.isSealedDataGridViewCheckBoxColumn.HeaderText = "IsSealed";
            this.isSealedDataGridViewCheckBoxColumn.Name = "isSealedDataGridViewCheckBoxColumn";
            this.isSealedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // dispatcherDataGridViewTextBoxColumn
            // 
            this.dispatcherDataGridViewTextBoxColumn.DataPropertyName = "Dispatcher";
            this.dispatcherDataGridViewTextBoxColumn.HeaderText = "Dispatcher";
            this.dispatcherDataGridViewTextBoxColumn.Name = "dispatcherDataGridViewTextBoxColumn";
            this.dispatcherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msbListControl)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msbItemsDgv)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msbItemListInnerDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msbItemListItemDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewColumnBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView msbListControl;
        private SplitContainer splitContainer2;
        private DataGridViewTextBoxColumn headerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn headerContainerStyleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn headerTemplateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn headerTemplateSelectorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn headerStringFormatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn displayMemberBindingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cellTemplateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cellTemplateSelectorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn actualWidthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dependencyObjectTypeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isSealedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn dispatcherDataGridViewTextBoxColumn;
        private BindingSource gridViewColumnBindingSource;
        private DataGridViewTextBoxColumn name;
        private DataGridView msbItemsDgv;
        private SplitContainer splitContainer3;
        private DataGridView msbItemListInnerDgv;
        private DataGridView msbItemListItemDgv;
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}