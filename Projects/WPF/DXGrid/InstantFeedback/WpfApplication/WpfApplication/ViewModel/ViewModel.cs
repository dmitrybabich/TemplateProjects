using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Xpo;
using System.ComponentModel;
using System.Windows;

namespace WpfApplication
{
    public class ViewModel
    {

        public ViewModel()
        {
            
        }

        // Fields...
        private object _DataSource;


        public object DataSource
        {
            get {  
                if (_DataSource == null)
                    _DataSource = GetDataSource();
                return _DataSource;
            }
            set
            {
                _DataSource = value;

            }
        }
        private object GetDataSource()
        {
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
                return null;
            XPCollection collection = new DataHelper().Collection;
            XPInstantFeedbackSource instantDS = new XPInstantFeedbackSource(typeof(Customer));
            instantDS.ResolveSession += new EventHandler<ResolveSessionEventArgs>(instantDS_ResolveSession);
            return instantDS;
        }

        void instantDS_ResolveSession(object sender, ResolveSessionEventArgs e)
        {
            e.Session = XpoDefault.Session;
        }
    }
}
