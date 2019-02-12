Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim fieldInfo37 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo38 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo39 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo40 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo41 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo42 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo43 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo44 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo45 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo46 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo47 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo48 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim excelWorksheetSettings4 As New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
			Dim excelSourceOptions4 As New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings4)
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldVariation = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.excelDataSource1
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldProductName, Me.fieldSalesPerson, Me.fieldOrderDate, Me.fieldQuantity, Me.fieldVariation})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(933, 365)
			Me.pivotGridControl1.TabIndex = 0
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.pivotGridControl1.CustomCellDisplayText += new DevExpress.XtraPivotGrid.PivotCellDisplayTextEventHandler(this.pivotGridControl1_CustomCellDisplayText);
			' 
			' fieldProductName
			' 
			Me.fieldProductName.AreaIndex = 0
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldSalesPerson.AreaIndex = 0
			Me.fieldSalesPerson.Caption = "Sales Person"
			Me.fieldSalesPerson.FieldName = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			Me.fieldSalesPerson.Width = 200
			' 
			' fieldOrderDate
			' 
			Me.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderDate.AreaIndex = 0
			Me.fieldOrderDate.Caption = "Order Date"
			Me.fieldOrderDate.FieldName = "OrderDate"
			Me.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldOrderDate.Name = "fieldOrderDate"
			Me.fieldOrderDate.UnboundFieldName = "fieldOrderDate"
			' 
			' fieldQuantity
			' 
			Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity.AreaIndex = 0
			Me.fieldQuantity.Caption = "Quantity"
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			' 
			' fieldVariation
			' 
			Me.fieldVariation.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldVariation.AreaIndex = 1
			Me.fieldVariation.Caption = "Variation"
			Me.fieldVariation.FieldName = "Quantity"
			Me.fieldVariation.Name = "fieldVariation"
			Me.fieldVariation.Options.ShowGrandTotal = False
			' 
			' excelDataSource1
			' 
			Me.excelDataSource1.Name = "excelDataSource1"
			Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
			fieldInfo37.Name = "CategoryName"
			fieldInfo37.Type = GetType(String)
			fieldInfo38.Name = "Country"
			fieldInfo38.Type = GetType(String)
			fieldInfo39.Name = "FirstName"
			fieldInfo39.Type = GetType(String)
			fieldInfo40.Name = "LastName"
			fieldInfo40.Type = GetType(String)
			fieldInfo41.Name = "ProductName"
			fieldInfo41.Type = GetType(String)
			fieldInfo42.Name = "Sales Person"
			fieldInfo42.Type = GetType(String)
			fieldInfo43.Name = "OrderDate"
			fieldInfo43.Type = GetType(Date)
			fieldInfo44.Name = "OrderID"
			fieldInfo44.Type = GetType(Double)
			fieldInfo45.Name = "Quantity"
			fieldInfo45.Type = GetType(Double)
			fieldInfo46.Name = "Discount"
			fieldInfo46.Type = GetType(Double)
			fieldInfo47.Name = "Extended Price"
			fieldInfo47.Type = GetType(Double)
			fieldInfo48.Name = "UnitPrice"
			fieldInfo48.Type = GetType(Double)
			Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() { fieldInfo37, fieldInfo38, fieldInfo39, fieldInfo40, fieldInfo41, fieldInfo42, fieldInfo43, fieldInfo44, fieldInfo45, fieldInfo46, fieldInfo47, fieldInfo48})
			excelWorksheetSettings4.CellRange = Nothing
			excelWorksheetSettings4.WorksheetName = "Data"
			excelSourceOptions4.ImportSettings = excelWorksheetSettings4
			Me.excelDataSource1.SourceOptions = excelSourceOptions4
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(933, 365)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Calculate Variations in Reverse Order"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldVariation As DevExpress.XtraPivotGrid.PivotGridField
		Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource
	End Class
End Namespace

