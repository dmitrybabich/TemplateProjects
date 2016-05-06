using System;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace WpfApplication
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
            XpoDefault.DataLayer = new SimpleDataLayer(XpoDefault.GetConnectionProvider(MSSqlConnectionProvider.GetConnectionString("(local)", "TestQ326151"), AutoCreateOption.DatabaseAndSchema));
            GenerateTestData();
            _Collection = new XPCollection(typeof(Customer));
        }

        Random r = new Random();

        public int GetRandomValue()
        {
            return r.Next(40);
        }
        private void GenerateTestData()
        {
            using (UnitOfWork uof = new UnitOfWork())
            {
                for (int i = 0; i < 15000; i++)
                {
                    Customer customer = new Customer(uof);
                    customer.FirstName = String.Format("Name{0}", i);
                    customer.LastName = String.Format("LastName{0}", i);
                    customer.BirthDay = DateTime.Today.AddHours(GetRandomValue()).AddMinutes(GetRandomValue());
                }
                uof.CommitChanges();
            }
        }
    }
}
