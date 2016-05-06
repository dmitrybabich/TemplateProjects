using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;

namespace WindowsApplication1 {
    [System.ComponentModel.DesignerCategory("")]
	[UserRepositoryItem("Register")]
	public class RepositoryItemMyButtonEdit : RepositoryItemButtonEdit { 
		static RepositoryItemMyButtonEdit() { 
			Register(); 
		}
		public RepositoryItemMyButtonEdit() {}
		
		internal const string EditorName = "MyButtonEdit";

		public static void Register() {
			EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyButtonEdit), 
				typeof(RepositoryItemMyButtonEdit), typeof(DevExpress.XtraEditors.ViewInfo.ButtonEditViewInfo), 
				new DevExpress.XtraEditors.Drawing.ButtonEditPainter(), true, null));
		}
		public override string EditorTypeName { 
			get { return EditorName; } 
		}
	}
}
