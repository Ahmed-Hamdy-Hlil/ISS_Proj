namespace Project.Reports
{
    partial class Report20
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportVendorTotalBillsNumberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._V9_1DataSet = new Project._V9_1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.cm_vendor = new System.Windows.Forms.ComboBox();
            this.dt_to = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_from = new System.Windows.Forms.DateTimePicker();
            this.report_VendorTotalBillsNumberTableAdapter = new Project._V9_1DataSetTableAdapters.Report_VendorTotalBillsNumberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportVendorTotalBillsNumberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._V9_1DataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportVendorTotalBillsNumberBindingSource
            // 
            this.reportVendorTotalBillsNumberBindingSource.DataMember = "Report_VendorTotalBillsNumber";
            this.reportVendorTotalBillsNumberBindingSource.DataSource = this._V9_1DataSet;
            // 
            // _V9_1DataSet
            // 
            this._V9_1DataSet.DataSetName = "_V9_1DataSet";
            this._V9_1DataSet.EnforceConstraints = false;
            this._V9_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportVendorTotalBillsNumberBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Project.Reports.Report21.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 123);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(820, 492);
            this.reportViewer1.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_show, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cm_vendor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dt_to, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dt_from, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 37, 0, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(820, 123);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vendor name";
            // 
            // btn_show
            // 
            this.btn_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_show.Location = new System.Drawing.Point(659, 82);
            this.btn_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(158, 39);
            this.btn_show.TabIndex = 5;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // cm_vendor
            // 
            this.cm_vendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cm_vendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cm_vendor.FormattingEnabled = true;
            this.cm_vendor.Location = new System.Drawing.Point(126, 39);
            this.cm_vendor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cm_vendor.Name = "cm_vendor";
            this.cm_vendor.Size = new System.Drawing.Size(240, 24);
            this.cm_vendor.TabIndex = 1;
            // 
            // dt_to
            // 
            this.dt_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_to.Location = new System.Drawing.Point(413, 82);
            this.dt_to.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_to.Name = "dt_to";
            this.dt_to.Size = new System.Drawing.Size(240, 22);
            this.dt_to.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 43);
            this.label3.TabIndex = 3;
            this.label3.Text = "To";
            // 
            // dt_from
            // 
            this.dt_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_from.Location = new System.Drawing.Point(126, 82);
            this.dt_from.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_from.Name = "dt_from";
            this.dt_from.Size = new System.Drawing.Size(240, 22);
            this.dt_from.TabIndex = 4;
            // 
            // report_VendorTotalBillsNumberTableAdapter
            // 
            this.report_VendorTotalBillsNumberTableAdapter.ClearBeforeFill = true;
            // 
            // Report20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Report20";
            this.Size = new System.Drawing.Size(820, 615);
            this.Load += new System.EventHandler(this.Report20_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportVendorTotalBillsNumberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._V9_1DataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.ComboBox cm_vendor;
        private System.Windows.Forms.DateTimePicker dt_to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_from;
        private System.Windows.Forms.BindingSource reportVendorTotalBillsNumberBindingSource;
        private _V9_1DataSet _V9_1DataSet;
        private _V9_1DataSetTableAdapters.Report_VendorTotalBillsNumberTableAdapter report_VendorTotalBillsNumberTableAdapter;
    }
}
