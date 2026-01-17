using DAL.SqlHeplers;
using DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface IRegistration
    {
        public DataTable FormerRegistration(RegisterViewModel registerView);  
    }
    public class Registration:IRegistration
    {
        public readonly IDataAccess _dataaccess;
        public Registration(IDataAccess dataAccess)
        {
            this._dataaccess = dataAccess;    
        }

        public DataTable FormerRegistration(RegisterViewModel registerView)
        {
            DataTable dt= _dataaccess.Registration(registerView);
            return dt;
        }
    }
}
