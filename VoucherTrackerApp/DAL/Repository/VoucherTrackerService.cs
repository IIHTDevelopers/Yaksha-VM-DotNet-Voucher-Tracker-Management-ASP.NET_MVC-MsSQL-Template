using VoucherTrackerApp.DAL.Interface;
using VoucherTrackerApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace VoucherTrackerApp.DAL.Repository
{
    public class VoucherTrackerService : IVoucherTrackerInterface
    {
        private IVoucherTrackerRepository _repo;
        public VoucherTrackerService(IVoucherTrackerRepository repo)
        {
            this._repo = repo;
        }

        public int DeleteVoucher(int voucherId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Voucher GetVoucherByID(int voucherId)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }


        IEnumerable<Voucher> IVoucherTrackerInterface.GetVouchers()
        {
            //write your code here
            throw new NotImplementedException();
        }

        Voucher IVoucherTrackerInterface.InsertVoucher(Voucher voucher)
        {
            //write your code here
            throw new NotImplementedException();
        }

        bool IVoucherTrackerInterface.UpdateVoucher(Voucher voucher)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}