namespace CustomDocumentApplication {
    partial class Main {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.customDocumentManager1 = new CustomDocumentApplication.CustomDocumentManager(this.components);
            this.customWidgetView1 = new CustomDocumentApplication.CustomWidgetView(this.components);
            this.xtraUserControl3Document = new CustomDocumentApplication.CustomDocument(this.components);
            this.xtraUserControl2Document = new CustomDocumentApplication.CustomDocument(this.components);
            this.xtraUserControl1Document = new CustomDocumentApplication.CustomDocument(this.components);
            this.stackGroup1 = new DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customDocumentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customWidgetView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraUserControl3Document)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraUserControl2Document)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraUserControl1Document)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // customDocumentManager1
            // 
            this.customDocumentManager1.ContainerControl = this;
            this.customDocumentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
            this.customDocumentManager1.View = this.customWidgetView1;
            this.customDocumentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.customWidgetView1});
            // 
            // customWidgetView1
            // 
            this.customWidgetView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.xtraUserControl3Document,
            this.xtraUserControl2Document,
            this.xtraUserControl1Document});
            this.customWidgetView1.StackGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup[] {
            this.stackGroup1});
            // 
            // xtraUserControl3Document
            // 
            this.xtraUserControl3Document.Caption = "XtraUserControl3";
            this.xtraUserControl3Document.ControlName = "XtraUserControl3";
            this.xtraUserControl3Document.ControlTypeName = "CustomDocumentApplication.XtraUserControl3";
            this.xtraUserControl3Document.CustomProperty = "Test3";
            // 
            // xtraUserControl2Document
            // 
            this.xtraUserControl2Document.Caption = "XtraUserControl2";
            this.xtraUserControl2Document.ControlName = "XtraUserControl2";
            this.xtraUserControl2Document.ControlTypeName = "CustomDocumentApplication.XtraUserControl2";
            this.xtraUserControl2Document.CustomProperty = "Test2";
            // 
            // xtraUserControl1Document
            // 
            this.xtraUserControl1Document.Caption = "XtraUserControl1";
            this.xtraUserControl1Document.ControlName = "XtraUserControl1";
            this.xtraUserControl1Document.ControlTypeName = "CustomDocumentApplication.XtraUserControl1";
            this.xtraUserControl1Document.CustomProperty = "Test1";
            // 
            // stackGroup1
            // 
            this.stackGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.Document[] {
            this.xtraUserControl3Document,
            this.xtraUserControl2Document,
            this.xtraUserControl1Document});
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 610);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.customDocumentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customWidgetView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraUserControl3Document)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraUserControl2Document)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraUserControl1Document)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackGroup1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDocumentManager customDocumentManager1;
        private CustomWidgetView customWidgetView1;
        private CustomDocument xtraUserControl3Document;
        private CustomDocument xtraUserControl2Document;
        private CustomDocument xtraUserControl1Document;
        private DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup stackGroup1;





    }
}

