using System;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System.Linq;

namespace WindowsApplication1
{
    public class DataHelper
    {







        public static IQueryable GetQueryable()
        {
            return new DataHelper().GetQueryableCore();
        }

        public DataHelper()
        {
            string connectionString = MSSqlConnectionProvider.GetConnectionString(".", "T120971");
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString,      AutoCreateOption.DatabaseAndSchema);
        }

        public IQueryable GetQueryableCore()
        {
            return new XPQuery<Customer>(XpoDefault.Session).Select(x => new { x.Oid, x.FirstName });
        }

        public void CreateRecords(Action<int> onProgress)
        {
            using (UnitOfWork uof = new UnitOfWork())
            {
                for (int i = 0; i < 100; i++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        Customer customer = new Customer(uof);
                        customer.FirstName = String.Format("Name{0}", j);
                        customer.LastName = String.Format("LastName{0}", j);
                    }
                    uof.CommitChanges();
                    onProgress(i);
                }
            }
        }
    }

}
