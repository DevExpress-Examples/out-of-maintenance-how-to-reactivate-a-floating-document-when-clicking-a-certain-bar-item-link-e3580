using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using DevExpress.XtraBars.Docking2010.Views;

namespace Q351232 {
    public partial class Form1 :Form {
        BaseDocument DocumentToRestore;

        public Form1() {
            InitializeComponent();
            for (int i = 0; i < 5; i++) {
                Form form = new Form();
                form.MdiParent = this;
                form.Text = string.Concat("Form ", i);
                form.Show();
            }
        }

        private void tabbedView1_DocumentDeactivated(object sender, DocumentEventArgs e) {
            if (e.Document.IsFloating && bar1.ItemLinks[0].ScreenBounds.Contains(MousePosition))
                DocumentToRestore = e.Document;
            else DocumentToRestore = null;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (DocumentToRestore != null) {
                tabbedView1.Controller.Activate(DocumentToRestore);
                DocumentToRestore = null;
            }
            XtraMessageBox.Show(tabbedView1.ActiveFloatDocument == null ? tabbedView1.ActiveDocument.Caption : tabbedView1.ActiveFloatDocument.Caption);
        }
    }
}
