using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;

namespace CustomDocumentApplication {
    [ToolboxItem(true)]
    public class CustomDocumentManager : DocumentManager {
        public CustomDocumentManager() {

        }
        public CustomDocumentManager(IContainer container)
            : base(container) {

        }

        protected override void RegisterViews() {
            base.RegisterViews();
            RegisterView<CustomWidgetViewRegistrator>(ViewType.Widget);
        }

        public override BaseView CreateView(ViewType type) {
            if (type == ViewType.Widget) return new CustomWidgetView(Container);
            return base.CreateView(type);
        }
    }
}
