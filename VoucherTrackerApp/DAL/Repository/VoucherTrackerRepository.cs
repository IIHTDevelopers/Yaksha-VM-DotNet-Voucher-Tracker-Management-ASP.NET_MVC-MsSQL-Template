using VoucherTrackerApp.DAL.Interface;
using VoucherTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace VoucherTrackerApp.DAL.Repository
{
    public class VoucherTrackerRepository : IVoucherTrackerRepository
    {
        private VoucherTrackerDbContext _context;
        public VoucherTrackerRepository(VoucherTrackerDbContext Context)
        {
            this._context = Context;
        }
        public IEnumerable<Voucher> GetVouchers()
        {
            //write your code here
            throw new NotImplementedException();
        }
        public Voucher GetVoucherByID(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public Voucher InsertVoucher(Voucher voucher)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public int DeleteVoucher(int voucherID)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public bool UpdateVoucher(Voucher voucher)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
