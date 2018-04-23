Imports Microsoft.VisualBasic
Imports System
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
			Me.components = New System.ComponentModel.Container()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.nwindDataSet = New WindowsApplication1.nwindDataSet()
			Me.customerReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.customerReportsTableAdapter = New WindowsApplication1.nwindDataSetTableAdapters.CustomerReportsTableAdapter()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCompanyName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductAmount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldVariation = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customerReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.customerReportsBindingSource
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldProductName, Me.fieldCompanyName, Me.fieldOrderDate, Me.fieldProductAmount, Me.fieldVariation})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(990, 365)
			Me.pivotGridControl1.TabIndex = 0
'			Me.pivotGridControl1.CustomCellDisplayText += New DevExpress.XtraPivotGrid.PivotCellDisplayTextEventHandler(Me.pivotGridControl1_CustomCellDisplayText);
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' customerReportsBindingSource
			' 
			Me.customerReportsBindingSource.DataMember = "CustomerReports"
			Me.customerReportsBindingSource.DataSource = Me.nwindDataSet
			' 
			' customerReportsTableAdapter
			' 
			Me.customerReportsTableAdapter.ClearBeforeFill = True
			' 
			' fieldProductName
			' 
			Me.fieldProductName.AreaIndex = 0
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' fieldCompanyName
			' 
			Me.fieldCompanyName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCompanyName.AreaIndex = 0
			Me.fieldCompanyName.Caption = "Company Name"
			Me.fieldCompanyName.FieldName = "CompanyName"
			Me.fieldCompanyName.Name = "fieldCompanyName"
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
			' fieldProductAmount
			' 
			Me.fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldProductAmount.AreaIndex = 0
			Me.fieldProductAmount.Caption = "Product Amount"
			Me.fieldProductAmount.FieldName = "ProductAmount"
			Me.fieldProductAmount.Name = "fieldProductAmount"
			' 
			' fieldVariation
			' 
			Me.fieldVariation.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldVariation.AreaIndex = 1
			Me.fieldVariation.Caption = "Variation"
			Me.fieldVariation.FieldName = "ProductAmount"
			Me.fieldVariation.Name = "fieldVariation"
			Me.fieldVariation.Options.ShowGrandTotal = False
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(990, 365)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customerReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private nwindDataSet As nwindDataSet
		Private customerReportsBindingSource As System.Windows.Forms.BindingSource
		Private customerReportsTableAdapter As WindowsApplication1.nwindDataSetTableAdapters.CustomerReportsTableAdapter
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCompanyName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductAmount As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldVariation As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

