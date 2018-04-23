Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
' ...

Namespace CalcWeightedAverage
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub lblSummaryPrice_SummaryGetResult(ByVal sender As Object, ByVal e As SummaryGetResultEventArgs) Handles lblSummaryPrice.SummaryGetResult
			Dim sum1 As Double = 0
			Dim sum2 As Double = 0
			For Each s As String In e.CalculatedValues
				Dim vv() As String = s.Split("|"c)
				sum1 += Double.Parse(vv(0))
				sum2 += Double.Parse(vv(1))
			Next s
			e.Result = sum1 / sum2
			e.Handled = True
		End Sub

	End Class
End Namespace
