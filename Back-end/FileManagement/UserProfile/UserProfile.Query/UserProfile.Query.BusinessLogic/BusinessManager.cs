using System;
using System.Collections.Generic;
using System.Text;
using UserProfile.Query.Abstraction.BusinessLogic;
using UserProfile.Query.Abstraction.DataAccess;

namespace UserProfile.Query.BusinessLogic
{
    public class BusinessManager : IBusinessManager
    {
        private readonly IDataAccessManager _dataAccessManager;
        public BusinessManager(IDataAccessManager dataAccessManager)
        {
            _dataAccessManager = dataAccessManager;
        }
    }
}
