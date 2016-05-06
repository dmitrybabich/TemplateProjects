using System;
using DevExpress.Xpo;

namespace WindowsApplication1
{

    public class Customer : XPObject
    {
        public Customer()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Customer(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        private string _FirstName;
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                SetPropertyValue("FirstName", ref _FirstName, value);
            }
        }

        private string _LastName;
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                SetPropertyValue("LastName", ref _LastName, value);
            }
        }

    }

}