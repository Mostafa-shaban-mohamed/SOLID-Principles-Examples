using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Examples
{
    //with DIP principle
    class DIP_CustomerBusinessLogic
    {
        ICustomerDataAccess _custDataAccess;

        public DIP_CustomerBusinessLogic()
        {
            _custDataAccess = DIP_DataAccessFactory.GetCustomerDataAccessObj();
        }

        public string GetCustomerName(int id)
        {
            return _custDataAccess.GetCustomerName(id);
        }
    }

    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }

    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        {
        }

        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name";
        }
    }

    public class DIP_DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccessObj()
        {
            return new CustomerDataAccess();
        }
    }
}
