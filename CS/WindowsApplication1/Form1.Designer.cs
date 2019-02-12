namespace WindowsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo37 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo38 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo39 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo40 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo41 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo42 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo43 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo44 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo45 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo46 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo47 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo48 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings4 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions4 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings4);
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldVariation = new DevExpress.XtraPivotGrid.PivotGridField();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataSource = this.excelDataSource1;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldProductName,
            this.fieldSalesPerson,
            this.fieldOrderDate,
            this.fieldQuantity,
            this.fieldVariation});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(933, 365);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.CustomCellDisplayText += new DevExpress.XtraPivotGrid.PivotCellDisplayTextEventHandler(this.pivotGridControl1_CustomCellDisplayText);
            // 
            // fieldProductName
            // 
            this.fieldProductName.AreaIndex = 0;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSalesPerson.AreaIndex = 0;
            this.fieldSalesPerson.Caption = "Sales Person";
            this.fieldSalesPerson.FieldName = "Sales Person";
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            this.fieldSalesPerson.Width = 200;
            // 
            // fieldOrderDate
            // 
            this.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDate.AreaIndex = 0;
            this.fieldOrderDate.Caption = "Order Date";
            this.fieldOrderDate.FieldName = "OrderDate";
            this.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderDate.Name = "fieldOrderDate";
            this.fieldOrderDate.UnboundFieldName = "fieldOrderDate";
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity.AreaIndex = 0;
            this.fieldQuantity.Caption = "Quantity";
            this.fieldQuantity.FieldName = "Quantity";
            this.fieldQuantity.Name = "fieldQuantity";
            // 
            // fieldVariation
            // 
            this.fieldVariation.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldVariation.AreaIndex = 1;
            this.fieldVariation.Caption = "Variation";
            this.fieldVariation.FieldName = "Quantity";
            this.fieldVariation.Name = "fieldVariation";
            this.fieldVariation.Options.ShowGrandTotal = false;
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            this.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable");
            fieldInfo37.Name = "CategoryName";
            fieldInfo37.Type = typeof(string);
            fieldInfo38.Name = "Country";
            fieldInfo38.Type = typeof(string);
            fieldInfo39.Name = "FirstName";
            fieldInfo39.Type = typeof(string);
            fieldInfo40.Name = "LastName";
            fieldInfo40.Type = typeof(string);
            fieldInfo41.Name = "ProductName";
            fieldInfo41.Type = typeof(string);
            fieldInfo42.Name = "Sales Person";
            fieldInfo42.Type = typeof(string);
            fieldInfo43.Name = "OrderDate";
            fieldInfo43.Type = typeof(System.DateTime);
            fieldInfo44.Name = "OrderID";
            fieldInfo44.Type = typeof(double);
            fieldInfo45.Name = "Quantity";
            fieldInfo45.Type = typeof(double);
            fieldInfo46.Name = "Discount";
            fieldInfo46.Type = typeof(double);
            fieldInfo47.Name = "Extended Price";
            fieldInfo47.Type = typeof(double);
            fieldInfo48.Name = "UnitPrice";
            fieldInfo48.Type = typeof(double);
            this.excelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo37,
            fieldInfo38,
            fieldInfo39,
            fieldInfo40,
            fieldInfo41,
            fieldInfo42,
            fieldInfo43,
            fieldInfo44,
            fieldInfo45,
            fieldInfo46,
            fieldInfo47,
            fieldInfo48});
            excelWorksheetSettings4.CellRange = null;
            excelWorksheetSettings4.WorksheetName = "Data";
            excelSourceOptions4.ImportSettings = excelWorksheetSettings4;
            this.excelDataSource1.SourceOptions = excelSourceOptions4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 365);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Calculate Variations in Reverse Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesPerson;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantity;
        private DevExpress.XtraPivotGrid.PivotGridField fieldVariation;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
    }
}

