using MyStore.Domain;
using MyStore.Domain.RepositoryInterfaces;
using MyStore.Infrastructure.DataMSSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MyStore.Infrastructure.StoreAdminUI.Controllers
{
    public class StoresController : Controller
    {
        IRepository<Store> storeRepository = new StoreRepository();
        // GET: Stores
        public ActionResult Index()
        {
            var stores = storeRepository.GetAll();
            return View(stores);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Store store)
        {
            if (ModelState.IsValid)
            {
                storeRepository.Create(store);
                return RedirectToAction("Index");
            }

            return View();
        }        

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Store store)
        {
            storeRepository.Delete(store.ID);
            return RedirectToAction("Index");
        }

    }
}