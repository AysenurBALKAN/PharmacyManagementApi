using PBusinessLayer.Abstract;
using PEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBusinessLayer.Concrete
{
    public class ReceiptManager : IReceiptService
    {
        public Receipt GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Receipt t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Receipt t)
        {
            throw new NotImplementedException();
        }

        public List<Receipt> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Receipt t)
        {
            throw new NotImplementedException();
        }
    }
}
