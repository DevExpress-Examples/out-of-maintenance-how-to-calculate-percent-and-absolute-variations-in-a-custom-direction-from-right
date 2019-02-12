Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports System

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			excelDataSource1.FileName = "SalesPerson.xlsx"
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			excelDataSource1.Fill()
			pivotGridControl1.BestFit()
			pivotGridControl1.BestFitDataHeaders(True)
		End Sub

		Private Sub pivotGridControl1_CustomCellDisplayText(ByVal sender As Object, ByVal e As PivotCellDisplayTextEventArgs) Handles pivotGridControl1.CustomCellDisplayText
			If e.DataField.Name = "fieldVariation" Then
				Dim nextValue As Object = e.GetNextColumnCellValue(e.DataField)
				If nextValue Is Nothing Then
					e.DisplayText = String.Empty
					Return
				End If
				Dim current As Decimal = Convert.ToDecimal(e.Value)
				Dim [next] As Decimal = Convert.ToDecimal(nextValue)
				If [next] = 0 Then
					e.DisplayText = "100%"
					Return
				End If
				current = (current - [next]) / [next]
				e.DisplayText = current.ToString("P")
			End If
		End Sub
	End Class
End Namespace