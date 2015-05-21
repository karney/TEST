using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;
using MYS2015Data.Models.Auth;
using Newtonsoft.Json.Linq;

namespace MYS2015Data.Repositories
{
    class AuthRepository
    {
        private readonly EFContextProvider<MindYourServiceAuthenticationEntities> _authContextProvider;
        public AuthRepository()
        {
            _authContextProvider = new EFContextProvider<MindYourServiceAuthenticationEntities>();
           // _entitySaveGuard = new NorthwindEntitySaveGuard();
           // _authContextProvider.BeforeSaveEntityDelegate += _entitySaveGuard.BeforeSaveEntity;


        }

        private MindYourServiceAuthenticationEntities _readContext;



        private MindYourServiceAuthenticationEntities readContext
        {
            get { return _readContext ?? (_readContext = new MindYourServiceAuthenticationEntities()); }
        }


        public MindYourServiceAuthenticationEntities AuthContext
        {
            get { return _authContextProvider.Context; }
        }


        public SaveResult SaveChanges(JObject saveBundle)
        {
            // Todo: transform entities in saveBundle from DTO form into server-model form.
            // At least change the namespace from Northwind.DtoModels to Northwind.Models :-)
            // will fail until then

            // save with server model's "real" contextProvider
            return _authContextProvider.SaveChanges(saveBundle);
        }


        public IQueryable<Company> Companies
        {
            get { return AuthContext.Companies; }
        }
    }
}
