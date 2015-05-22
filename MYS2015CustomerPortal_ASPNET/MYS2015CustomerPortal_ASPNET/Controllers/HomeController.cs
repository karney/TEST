using System;
using System.Collections.Generic;
using System.Data.Entity;
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



        public ActionResult Customers_Update([DataSourceRequest]DataSourceRequest request, Customer customer)
        {

            if (ModelState.IsValid)
            {
                using (var northwind = new MindYourServiceEntities())
                {
                    // Create a new Product entity and set its properties from the posted ProductViewModel
//                    var entity = new Customer();
//                    entity = customer;
                    // Attach the entity
                    northwind.Customers.Attach(customer);
                    // Change its state to Modified so Entity Framework can update the existing product instead of creating a new one
                    northwind.Entry(customer).State = EntityState.Modified;
                    // Or use ObjectStateManager if using a previous version of Entity Framework
                    // northwind.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);
                    // Update the entity in the database
                    northwind.SaveChanges();
                }
            }
            // Return the updated product. Also return any validation errors.
            return Json(new[] { customer }.ToDataSourceResult(request, ModelState));


/*
            // Will keep the updated entitites here. Used to return the result later.
            var entities = new List<Customer>();
            if (ModelState.IsValid)
            {
                using (var northwind = new MindYourServiceEntities())
                {
                    foreach (var customer in customers)
                    {
                        // Create a new Product entity and set its properties from the posted ProductViewModel
                        var entity = new Customer
                        {
                            CustomerID = customer.CustomerID,
                            BillingEmail = customer.BillingEmail
                        };
                        // Store the entity for later use
                        entities.Add(entity);
                        // Attach the entity
                        northwind.Customers.Attach(entity);
                        // Change its state to Modified so Entity Framework can update the existing product instead of creating a new one
                        northwind.Entry(entity).State = EntityState.Modified;
                        // Or use ObjectStateManager if using a previous version of Entity Framework
                        // northwind.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);
                    }
                    // Update the entities in the database
                    northwind.SaveChanges();
                }
            }
            // Return the updated entities. Also return any validation errors.
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Customer()
            {
                BillingEmail = product.BillingEmail
            }));*/
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