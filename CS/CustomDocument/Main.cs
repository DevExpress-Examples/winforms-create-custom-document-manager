using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CustomDocumentApplication {
    public partial class Main : XtraForm {
        public Main() {
            InitializeComponent();
            // Handling the QueryControl event that will populate all automatically generated Documents
            this.customWidgetView1.QueryControl += customWidgetView1_QueryControl;
            this.customWidgetView1.DocumentActivated += customWidgetView1_DocumentActivated;
        }

        void customWidgetView1_DocumentActivated(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e) {
            XtraMessageBox.Show((e.Document as CustomDocument).CustomProperty);
        }

        // Assigning a required content for each auto generated Document
        void customWidgetView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e) {

            if (e.Document == xtraUserControl3Document)
                e.Control = new CustomDocumentApplication.XtraUserControl3();
            if (e.Document == xtraUserControl2Document)
                e.Control = new CustomDocumentApplication.XtraUserControl2();
            if (e.Document == xtraUserControl1Document)
                e.Control = new CustomDocumentApplication.XtraUserControl1();
            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }
    }
}