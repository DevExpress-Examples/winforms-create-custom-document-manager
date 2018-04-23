using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Serializing;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Widget;

namespace CustomDocumentApplication {
    public class CustomWidgetView : WidgetView {
        public CustomWidgetView() {

        }
        public CustomWidgetView(IContainer container)
            : base(container) {

        }

        internal new bool IsSkinPaintStyle {
            get { return base.IsSkinPaintStyle; }
        }
    }
}
