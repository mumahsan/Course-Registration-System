using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using CMUcrs.Data;
using CMUcrs.Data.Core;

namespace CMUcrs.Web.Models
{
    public class BaseModel : IDisposable
    {
        // Instance of the unit of work class to be used in the model.
        protected IUnitOfWork UnitOfWork;

        public BaseModel()
        {
            UowFactory.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            // Initialize the UnitOfWork from the factory.
            UnitOfWork = UowFactory.Create();
        }

        public void Dispose()
        {
            // Check if the UnitOfWork has been initialized and dispose of it if it has.
            if (UnitOfWork != null)
            {
                UnitOfWork.Dispose();
            }
        }
    }
}