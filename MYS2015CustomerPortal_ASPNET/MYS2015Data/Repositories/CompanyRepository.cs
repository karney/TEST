using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;
using MYS2015Data.Models.Auth;
using MYS2015Data.Models.Company;
using Newtonsoft.Json.Linq;

namespace MYS2015Data.Repositories
{
    public class CompanyRepository
    {
        private readonly EFContextProvider<MindYourServiceEntities> _companyContextProvider;
        public CompanyRepository()
        {
            _companyContextProvider = new EFContextProvider<MindYourServiceEntities>();
           // _entitySaveGuard = new NorthwindEntitySaveGuard();
           // _companyContextProvider.BeforeSaveEntityDelegate += _entitySaveGuard.BeforeSaveEntity;
        }

        public MindYourServiceEntities AuthContext
        {
            get { return _companyContextProvider.Context; }
        }


        public SaveResult SaveChanges(JObject saveBundle)
        {
            // Todo: transform entities in saveBundle from DTO form into server-model form.
            // At least change the namespace from Northwind.DtoModels to Northwind.Models :-)
            // will fail until then

            // save with server model's "real" contextProvider
            return _companyContextProvider.SaveChanges(saveBundle);
        }

        public IQueryable<Customer> Customers
        {
            get { return AuthContext.Customers; }
        }

    }
}
