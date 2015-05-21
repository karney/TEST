using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Breeze.WebApi2;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using MYS2015Data.Models.Company;
using MYS2015Data.Repositories;

namespace MYS2015CustomerPortal_ASPNET.Controllers
{

    [BreezeController]
    public class HomeController : Controller
    {

        private readonly CompanyRepository _repository;


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult GetCustomers([DataSourceRequest]DataSourceRequest request)
        {

            IQueryable<Customer> cust = _repository.Customers;
            DataSourceResult result = cust.ToDataSourceResult(request);
            var sd = Json(result);
            return sd;
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

         public HomeController() : this(null){}


         public HomeController(CompanyRepository repository)
        {
            _repository = repository ?? new CompanyRepository();
        }

    }
}