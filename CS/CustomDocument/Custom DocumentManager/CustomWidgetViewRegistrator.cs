using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Widget;

namespace CustomDocumentApplication {
    class CustomWidgetViewRegistrator : BaseRegistrator {
        public CustomWidgetViewRegistrator()
            : base(null) {
        }
        public CustomWidgetViewRegistrator(WidgetView view)
            : base(view) {
        }
        public override BaseViewPainter CreatePainter() {
            if (View.IsSkinPaintStyle)
                return new WidgetViewSkinPainter(View as WidgetView);
            return new WidgetViewPainter(View as WidgetView);
        }
        public override BaseViewInfo CreateViewInfo() {
            return new WidgetViewInfo(View as WidgetView);
        }
        public override BaseViewHitInfo CreateHitInfo() {
            return new WidgetViewHitInfo(View as WidgetView);
        }
        public override BaseDocument CreateDocument(Control control) {
            return new CustomDocument(View.DocumentProperties as IDocumentProperties);
        }
        protected override Create Register() {
            return delegate(BaseView view) {
                return new CustomWidgetViewRegistrator(view as WidgetView);
            };
        }
        public override DocumentContainer CreateDocumentContainer(BaseDocument document) {
            return new WidgetContainer(document);
        }
        public override Control CreateDocumentsHost(IDocumentsHostOwner owner) {
            return new WidgetsHost(owner);
        }

        new CustomWidgetView View {
            get { return base.View as CustomWidgetView; }
        }
    }
}
