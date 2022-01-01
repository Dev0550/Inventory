namespace Admin
{
    partial class CompDetail
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.txt_date = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_Ip = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_MacAddress = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_Domain = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_AccountName = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_CompName = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_OsType = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_Os = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_VideoSize = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_VideoCardId = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_VideoCard = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_Ram = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_MotherBoardId = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_MotherBoardName = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_CpuId = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_CpuName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_InverNumber = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.dataSet1 = new Admin.DataSet();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.txt_datePrint = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 27.08333F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(814.6525F, 27.08333F);
            this.xrTable1.StylePriority.UseBorders = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "DataTable1.FullName")});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.Weight = 1.1127516533074209D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "DataTable1.DeviceId")});
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.Weight = 1.3503357933535802D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "DataTable1.Size")});
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.Weight = 0.53691255333899868D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 53F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1,
            this.txt_date,
            this.txt_Ip,
            this.txt_MacAddress,
            this.txt_Domain,
            this.txt_AccountName,
            this.txt_CompName,
            this.txt_OsType,
            this.txt_Os,
            this.txt_VideoSize,
            this.txt_VideoCardId,
            this.txt_VideoCard,
            this.txt_Ram,
            this.txt_MotherBoardId,
            this.txt_MotherBoardName,
            this.txt_CpuId,
            this.txt_CpuName,
            this.xrLabel1,
            this.txt_InverNumber});
            this.ReportHeader.HeightF = 553.5833F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrPanel1
            // 
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 116.7083F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(814.6526F, 426.875F);
            this.xrPanel1.StylePriority.UseBorders = false;
            // 
            // txt_date
            // 
            this.txt_date.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txt_date.LocationFloat = new DevExpress.Utils.PointFloat(26.04171F, 496.8749F);
            this.txt_date.Name = "txt_date";
            this.txt_date.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_date.SizeF = new System.Drawing.SizeF(776.0416F, 22.99998F);
            this.txt_date.StylePriority.UseFont = false;
            this.txt_date.Text = "A";
            // 
            // txt_Ip
            // 
            this.txt_Ip.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txt_Ip.LocationFloat = new DevExpress.Utils.PointFloat(26.04171F, 471.8749F);
            this.txt_Ip.Name = "txt_Ip";
            this.txt_Ip.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_Ip.SizeF = new System.Drawing.SizeF(776.0416F, 22.99998F);
            this.txt_Ip.StylePriority.UseFont = false;
            this.txt_Ip.Text = "Процессор: Intel(R) Core(TM) i5-2430M CPU @ 2.40GHz";
            // 
            // txt_MacAddress
            // 
            this.txt_MacAddress.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txt_MacAddress.LocationFloat = new DevExpress.Utils.PointFloat(26.04167F, 447.8749F);
            this.txt_MacAddress.Name = "txt_MacAddress";
            this.txt_MacAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_MacAddress.SizeF = new System.Drawing.SizeF(776.0416F, 22.99998F);
            this.txt_MacAddress.StylePriority.UseFont = false;
            this.txt_MacAddress.Text = "Процессор: Intel(R) Core(TM) i5-2430M CPU @ 2.40GHz";
            // 
            // txt_Domain
            // 
            this.txt_Domain.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txt_Domain.LocationFloat = new DevExpress.Utils.PointFloat(26.04171F, 423.8749F);
            this.txt_Domain.Name = "txt_Domain";
            this.txt_Domain.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_Domain.SizeF = new System.Drawing.SizeF(776.0416F, 22.99998F);
            this.txt_Domain.StylePriority.UseFont = false;
            this.txt_Domain.Text = "Процессор: Intel(R) Core(TM) i5-2430M CPU @ 2.40GHz";
            // 
            // txt_AccountName
            // 
            this.txt_AccountName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txt_AccountName.LocationFloat = new DevExpress.Utils.PointFloat(26.04167F, 398.9999F);
            this.txt_AccountName.Name = "txt_AccountName";
            this.txt_AccountName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_AccountName.SizeF = new System.Drawing.SizeF(776.0416F, 22.99998F);
            this.txt_AccountName.StylePriority.UseFont = false;
            this.txt_AccountName.Text = "Процессор: Intel(R) Core(TM) i5-2430M CPU @ 2.40GHz";
            // 
            // txt_CompName
            // 
            this.txt_CompName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txt_CompName.LocationFloat = new DevExpress.Utils.PointFloat(26.04171F, 373.9999F);
            this.txt_CompName.Name = "txt_CompName";
            this.txt_CompName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_CompName.SizeF = new System.Drawing.SizeF(776.0416F, 22.99998F);
            this.txt_CompName.StylePriority.UseFont = false;
            this.txt_CompName.Text = "Процессор: Intel(R) Core(TM) i5-2430M CPU @ 2.40GHz";
            // 
            // txt_OsType
            // 
            this.txt_OsType.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txt_OsType.LocationFloat = new DevExpress.Utils.PointFloat(26.04167F, 349.9999F);
            this.txt_OsType.Name = "txt_OsType";
            this.txt_OsType.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_OsType.SizeF = new System.Drawing.SizeF(776.0416F, 22.99998F);
            this.txt_OsType.StylePriority.UseFont = false;
            this.txt_OsType.Text = "Процессор: Intel(R) Core(TM) i5-2430M CPU @ 2.40GHz";
            // 
            // txt_Os
            // 
            this.txt_Os.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txt_Os.LocationFloat = new DevExpress.Utils.PointFloat(26.04171F, 325.9999F);
            this.txt_Os.Name = "txt_Os";
            this.txt_Os.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_Os.SizeF = new System.Drawing.SizeF(776.0416F, 22.99998F);
            this.txt_Os.StylePriority.UseFont = false;
            this.txt_Os.Text = "Процессор: Intel(R) Core(TM) i5-2430M CPU @ 2.40GHz";
            // 
            // txt_VideoSize
            // 
            this.txt_VideoSize.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txt_VideoSize.LocationFloat = new DevExpress.Utils.PointFloat(26.04171F, 302F);
            this.txt_VideoSize.Name = "txt_VideoSize";
            this.txt_VideoSize.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_VideoSize.SizeF = new System.Drawing.SizeF(776.0416F, 22.99998F);
            this.txt_VideoSize.StylePriority.UseFont = false;
            this.txt_VideoSize.Text = "Процессор: Intel(R) Core(TM) i5-2430M CPU @ 2.40GHz";
            // 
            // txt_VideoCardId
            // 
            this.txt_VideoCardId.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txt_VideoCardId.LocationFloat = new DevExpress.Utils.PointFloat(26.04171F, 277F);
            this.txt_VideoCardId.Name = "txt_VideoCardId";
            this.txt_VideoCardId.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_VideoCardId.SizeF = new System.Drawing.SizeF(776.0416F, 22.99998F);
            this.txt_VideoCardId.StylePriority.UseFont = false;
            this.txt_VideoCardId.Text = "Процессор: Intel(R) Core(TM) i5-2430M CPU @ 2.40GHz";
            // 
            // txt_VideoCard
            // 
            this.txt_VideoCard.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txt_VideoCard.LocationFloat = new DevExpress.Utils.PointFloat(26.04167F, 253F);
            this.txt_VideoCard.Name = "txt_VideoCard";
            this.txt_VideoCard.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_VideoCard.SizeF = new System.Drawing.SizeF(776.0416F, 22.99998F);
            this.txt_VideoCard.StylePriority.UseFont = false;
            this.txt_VideoCard.Text = "Процессор: Intel(R) Core(TM) i5-2430M CPU @ 2.40GHz";
            // 
            // txt_Ram
            // 
            this.txt_Ram.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txt_Ram.LocationFloat = new DevExpress.Utils.PointFloat(26.04171F, 229F);
            this.txt_Ram.Name = "txt_Ram";
            this.txt_Ram.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_Ram.SizeF = new System.Drawing.SizeF(776.0416F, 22.99998F);
            this.txt_Ram.StylePriority.UseFont = false;
            this.txt_Ram.Text = "Процессор: Intel(R) Core(TM) i5-2430M CPU @ 2.40GHz";
            // 
            // txt_MotherBoardId
            // 
            this.txt_MotherBoardId.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txt_MotherBoardId.LocationFloat = new DevExpress.Utils.PointFloat(26.04167F, 204.125F);
            this.txt_MotherBoardId.Name = "txt_MotherBoardId";
            this.txt_MotherBoardId.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_MotherBoardId.SizeF = new System.Drawing.SizeF(776.0416F, 22.99998F);
            this.txt_MotherBoardId.StylePriority.UseFont = false;
            this.txt_MotherBoardId.Text = "Процессор: Intel(R) Core(TM) i5-2430M CPU @ 2.40GHz";
            // 
            // txt_MotherBoardName
            // 
            this.txt_MotherBoardName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txt_MotherBoardName.LocationFloat = new DevExpress.Utils.PointFloat(26.04171F, 179.125F);
            this.txt_MotherBoardName.Name = "txt_MotherBoardName";
            this.txt_MotherBoardName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_MotherBoardName.SizeF = new System.Drawing.SizeF(776.0416F, 22.99998F);
            this.txt_MotherBoardName.StylePriority.UseFont = false;
            // 
            // txt_CpuId
            // 
            this.txt_CpuId.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txt_CpuId.LocationFloat = new DevExpress.Utils.PointFloat(26.04167F, 155.125F);
            this.txt_CpuId.Name = "txt_CpuId";
            this.txt_CpuId.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_CpuId.SizeF = new System.Drawing.SizeF(776.0416F, 22.99998F);
            this.txt_CpuId.StylePriority.UseFont = false;
            this.txt_CpuId.Text = "Процессор: Intel(R) Core(TM) i5-2430M CPU @ 2.40GHz";
            // 
            // txt_CpuName
            // 
            this.txt_CpuName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txt_CpuName.LocationFloat = new DevExpress.Utils.PointFloat(26.04171F, 131.125F);
            this.txt_CpuName.Name = "txt_CpuName";
            this.txt_CpuName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_CpuName.SizeF = new System.Drawing.SizeF(776.0416F, 22.99998F);
            this.txt_CpuName.StylePriority.UseFont = false;
            this.txt_CpuName.Text = "Процессор: Intel(R) Core(TM) i5-2430M CPU @ 2.40GHz";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(251.0417F, 24.95832F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(391.6666F, 46.95834F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Маълумот оиди компютер";
            // 
            // txt_InverNumber
            // 
            this.txt_InverNumber.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txt_InverNumber.LocationFloat = new DevExpress.Utils.PointFloat(278.125F, 71.91666F);
            this.txt_InverNumber.Name = "txt_InverNumber";
            this.txt_InverNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_InverNumber.SizeF = new System.Drawing.SizeF(315.625F, 23F);
            this.txt_InverNumber.StylePriority.UseFont = false;
            this.txt_InverNumber.Text = "Номери инвентарӣ №15";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2,
            this.xrTable3});
            this.PageHeader.HeightF = 52.08334F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable2
            // 
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(814.6526F, 25F);
            this.xrTable2.StylePriority.UseBorders = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell6});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "Диски сахт";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell6.Weight = 3D;
            // 
            // xrTable3
            // 
            this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(9.99999F, 25F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.SizeF = new System.Drawing.SizeF(814.6526F, 27.08333F);
            this.xrTable3.StylePriority.UseBorders = false;
            this.xrTable3.StylePriority.UseFont = false;
            this.xrTable3.StylePriority.UseTextAlignment = false;
            this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell7});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "Модел\r\n";
            this.xrTableCell4.Weight = 1.1127516533074209D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "ИД ";
            this.xrTableCell5.Weight = 1.3503357343665761D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "Ҳаҷм (Gb)";
            this.xrTableCell7.Weight = 0.53691261232600307D;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txt_datePrint});
            this.PageFooter.Name = "PageFooter";
            // 
            // txt_datePrint
            // 
            this.txt_datePrint.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txt_datePrint.LocationFloat = new DevExpress.Utils.PointFloat(388.1944F, 24.99987F);
            this.txt_datePrint.Name = "txt_datePrint";
            this.txt_datePrint.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_datePrint.SizeF = new System.Drawing.SizeF(391.6666F, 22.99998F);
            this.txt_datePrint.StylePriority.UseFont = false;
            this.txt_datePrint.Text = "Процессор: Intel(R) Core(TM) i5-2430M CPU @ 2.40GHz";
            // 
            // CompDetail
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.PageFooter});
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 53, 100);
            this.Version = "12.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        public DevExpress.XtraReports.UI.XRLabel txt_CpuId;
        public DevExpress.XtraReports.UI.XRLabel txt_CpuName;
        public DevExpress.XtraReports.UI.XRLabel txt_MotherBoardId;
        public DevExpress.XtraReports.UI.XRLabel txt_MotherBoardName;
        public DevExpress.XtraReports.UI.XRLabel txt_Ip;
        public DevExpress.XtraReports.UI.XRLabel txt_MacAddress;
        public DevExpress.XtraReports.UI.XRLabel txt_Domain;
        public DevExpress.XtraReports.UI.XRLabel txt_AccountName;
        public DevExpress.XtraReports.UI.XRLabel txt_CompName;
        public DevExpress.XtraReports.UI.XRLabel txt_OsType;
        public DevExpress.XtraReports.UI.XRLabel txt_Os;
        public DevExpress.XtraReports.UI.XRLabel txt_VideoSize;
        public DevExpress.XtraReports.UI.XRLabel txt_VideoCardId;
        public DevExpress.XtraReports.UI.XRLabel txt_VideoCard;
        public DevExpress.XtraReports.UI.XRLabel txt_Ram;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DataSet dataSet1;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        public DevExpress.XtraReports.UI.XRLabel txt_datePrint;
        public DevExpress.XtraReports.UI.XRLabel txt_InverNumber;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        public DevExpress.XtraReports.UI.XRLabel txt_date;
    }
}
