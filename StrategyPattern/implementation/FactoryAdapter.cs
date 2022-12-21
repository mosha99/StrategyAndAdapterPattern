using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.implementation
{
    public class FactoryAdapter : User
    {
        public Factory Factory { get; set; }
        public FactoryAdapter(Factory factory)
        {
            Factory = factory;
        }

        public override Contacts GetContacts()
        {
            Contacts AdaptedContacts = new Contacts()
            {
                Email = Factory.Mail,
                MobileNumber = Factory.Admin.MobileNumber,
                HomeAddress = Factory.Address,
            };

            return AdaptedContacts;
        }
    }
}
