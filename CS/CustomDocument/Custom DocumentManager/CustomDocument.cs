using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.Utils.Serializing;
using DevExpress.XtraBars.Docking2010.Views.Widget;

namespace CustomDocumentApplication {
    public class CustomDocument : Document {
        public CustomDocument() {

        }
        public CustomDocument(IContainer container)
            : base(container) {

        }
        public CustomDocument(IDocumentProperties defaultProperties)
            : base(defaultProperties) {

        }

        string customValue;
        [XtraSerializableProperty]
        public string CustomProperty {
            get { return customValue; }
            set {
                customValue = value;
            }
        }
    }
}
