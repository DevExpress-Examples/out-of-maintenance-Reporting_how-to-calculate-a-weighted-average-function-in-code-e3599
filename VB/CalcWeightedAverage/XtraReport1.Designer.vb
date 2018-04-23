Imports Microsoft.VisualBasic
Imports System
Namespace CalcWeightedAverage
	Partial Public Class XtraReport1
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

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.nwindDataSet1 = New CalcWeightedAverage.nwindDataSet()
			Me.productsTableAdapter = New CalcWeightedAverage.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
			Me.lblSummaryPrice = New DevExpress.XtraReports.UI.XRLabel()
			Me.fieldWeight = New DevExpress.XtraReports.UI.CalculatedField()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2})
			Me.Detail.HeightF = 46.875F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.HeightF = 50F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.HeightF = 49F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' ReportFooter
			' 
			Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lblSummaryPrice})
			Me.ReportFooter.HeightF = 47.91667F
			Me.ReportFooter.Name = "ReportFooter"
			' 
			' lblSummaryPrice
			' 
			Me.lblSummaryPrice.BackColor = System.Drawing.Color.LightGray
			Me.lblSummaryPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.fieldWeight")})
			Me.lblSummaryPrice.Font = New System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold)
			Me.lblSummaryPrice.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.lblSummaryPrice.Name = "lblSummaryPrice"
			Me.lblSummaryPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lblSummaryPrice.SizeF = New System.Drawing.SizeF(374.375F, 27.91666F)
			Me.lblSummaryPrice.StylePriority.UseBackColor = False
			Me.lblSummaryPrice.StylePriority.UseFont = False
			Me.lblSummaryPrice.StylePriority.UseTextAlignment = False
			xrSummary1.FormatString = "{0:$0.00}"
			xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
			xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
			Me.lblSummaryPrice.Summary = xrSummary1
			Me.lblSummaryPrice.Text = "lblSummaryPrice"
			Me.lblSummaryPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
'			Me.lblSummaryPrice.SummaryGetResult += New DevExpress.XtraReports.UI.SummaryGetResultHandler(Me.lblSummaryPrice_SummaryGetResult);
			' 
			' fieldWeight
			' 
			Me.fieldWeight.DataMember = "Products"
			Me.fieldWeight.DataSource = Me.nwindDataSet1
			Me.fieldWeight.Expression = "ToStr([UnitPrice] * [UnitsInStock]) + '|' + ToStr([UnitPrice])"
			Me.fieldWeight.FieldType = DevExpress.XtraReports.UI.FieldType.String
			Me.fieldWeight.Name = "fieldWeight"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.fieldWeight")})
			Me.xrLabel2.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 13.87501F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(374.375F, 23F)
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.StylePriority.UseTextAlignment = False
			Me.xrLabel2.Text = "xrLabel2"
			Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Font = New System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold)
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00002F, 10.00001F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(374.375F, 41.75F)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.StylePriority.UseTextAlignment = False
			Me.xrLabel1.Text = "Weighted Summary Calculation"
			Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.ReportHeader.HeightF = 60.41667F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter, Me.ReportHeader})
			Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.fieldWeight})
			Me.DataAdapter = Me.productsTableAdapter
			Me.DataMember = "Products"
			Me.DataSource = Me.nwindDataSet1
			Me.Margins = New System.Drawing.Printing.Margins(49, 50, 50, 49)
			Me.Version = "11.1"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private nwindDataSet1 As nwindDataSet
		Private productsTableAdapter As nwindDataSetTableAdapters.ProductsTableAdapter
		Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
		Private WithEvents lblSummaryPrice As DevExpress.XtraReports.UI.XRLabel
		Private fieldWeight As DevExpress.XtraReports.UI.CalculatedField
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
	End Class
End Namespace
