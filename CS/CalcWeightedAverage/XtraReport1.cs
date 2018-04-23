using DevExpress.XtraReports.UI;
// ...

namespace CalcWeightedAverage {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void lblSummaryPrice_SummaryGetResult(object sender, SummaryGetResultEventArgs e) {
            double sum1 = 0;
            double sum2 = 0;
            foreach (string s in e.CalculatedValues) {
                string[] vv = s.Split('|');
                sum1 += double.Parse(vv[0]);
                sum2 += double.Parse(vv[1]);
            }
            e.Result = sum1 / sum2;
            e.Handled = true;
        }

    }
}
