Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.CustomerReports' table. You can move, or remove it, as needed.
			Me.customerReportsTableAdapter.Fill(Me.nwindDataSet.CustomerReports)

		End Sub

		Private Sub pivotGridControl1_CustomCellDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs) Handles pivotGridControl1.CustomCellDisplayText
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