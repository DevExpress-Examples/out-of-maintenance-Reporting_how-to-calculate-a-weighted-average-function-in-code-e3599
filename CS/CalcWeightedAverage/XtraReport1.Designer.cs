namespace CalcWeightedAverage {
    partial class XtraReport1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.nwindDataSet1 = new CalcWeightedAverage.nwindDataSet();
            this.productsTableAdapter = new CalcWeightedAverage.nwindDataSetTableAdapters.ProductsTableAdapter();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.lblSummaryPrice = new DevExpress.XtraReports.UI.XRLabel();
            this.fieldWeight = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
            this.Detail.HeightF = 46.875F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 50F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 49F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // nwindDataSet1
            // 
            this.nwindDataSet1.DataSetName = "nwindDataSet";
            this.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblSummaryPrice});
            this.ReportFooter.HeightF = 47.91667F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // lblSummaryPrice
            // 
            this.lblSummaryPrice.BackColor = System.Drawing.Color.LightGray;
            this.lblSummaryPrice.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.fieldWeight")});
            this.lblSummaryPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSummaryPrice.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.lblSummaryPrice.Name = "lblSummaryPrice";
            this.lblSummaryPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblSummaryPrice.SizeF = new System.Drawing.SizeF(374.375F, 27.91666F);
            this.lblSummaryPrice.StylePriority.UseBackColor = false;
            this.lblSummaryPrice.StylePriority.UseFont = false;
            this.lblSummaryPrice.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:$0.00}";
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.lblSummaryPrice.Summary = xrSummary1;
            this.lblSummaryPrice.Text = "lblSummaryPrice";
            this.lblSummaryPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblSummaryPrice.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.lblSummaryPrice_SummaryGetResult);
            // 
            // fieldWeight
            // 
            this.fieldWeight.DataMember = "Products";
            this.fieldWeight.DataSource = this.nwindDataSet1;
            this.fieldWeight.Expression = "ToStr([UnitPrice] * [UnitsInStock]) + \'|\' + ToStr([UnitPrice])";
            this.fieldWeight.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.fieldWeight.Name = "fieldWeight";
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.fieldWeight")});
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 13.87501F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(374.375F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "xrLabel2";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10.00002F, 10.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(374.375F, 41.75F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Weighted Summary Calculation";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.ReportHeader.HeightF = 60.41667F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportFooter,
            this.ReportHeader});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.fieldWeight});
            this.DataAdapter = this.productsTableAdapter;
            this.DataMember = "Products";
            this.DataSource = this.nwindDataSet1;
            this.Margins = new System.Drawing.Printing.Margins(49, 50, 50, 49);
            this.Version = "11.1";
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private nwindDataSet nwindDataSet1;
        private nwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel lblSummaryPrice;
        private DevExpress.XtraReports.UI.CalculatedField fieldWeight;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
    }
}
