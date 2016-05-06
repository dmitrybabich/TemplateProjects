using System;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace WindowsApplication1
{
    public class DataHelper
    {

        private XPCollection _Collection;
        public XPCollection Collection
        {
            get
            {
                return _Collection;
            }
        }
        public DataHelper()
        {
            XpoDefault.DataLayer = new SimpleDataLayer(new InMemoryDataStore());
            GenerateTestData();
            _Collection = new XPCollection(typeof(Customer));
        }

        private void GenerateTestData()
        {
            using (UnitOfWork uof = new UnitOfWork())
            {
                for (int i = 0; i < 5; i++)
                {
                    Customer customer = new Customer(uof);
                    customer.FirstName = String.Format("Name{0}", i);
                    customer.LastName = String.Format("LastName{0}", i);
                }
                uof.CommitChanges();
            }
        }
    }
}
