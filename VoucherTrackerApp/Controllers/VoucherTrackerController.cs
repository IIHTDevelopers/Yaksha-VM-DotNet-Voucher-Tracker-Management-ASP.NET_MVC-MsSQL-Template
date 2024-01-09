using VoucherTrackerApp.DAL.Interface;
using VoucherTrackerApp.DAL.Repository;
using VoucherTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace VoucherTrackerApp.Controllers
{
    public class VoucherTrackerController : Controller
    {
        private readonly IVoucherTrackerInterface _Repository;
        public VoucherTrackerController(IVoucherTrackerInterface service)
        {
            _Repository = service;
        }
        public VoucherTrackerController()
        {
            // Constructor logic, if needed
        }
        // GET: VoucherTracker
        public ActionResult Index()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ViewResult Details(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult Create()
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Create(Voucher voucher)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult EditAsync(int id)
        {
            Voucher voucher =  _Repository.GetVoucherByID(id);
            return View(voucher);
        }
        [HttpPost]
        public ActionResult Edit(Voucher voucher)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult Delete(int id, bool? saveChangesError)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}