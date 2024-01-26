using PBusinessLayer.Abstract;
using PEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBusinessLayer.Concrete
{
    public class PatientManager : IPatientService
    {
        public PatientInfo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(PatientInfo t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(PatientInfo t)
        {
            throw new NotImplementedException();
        }

        public List<PatientInfo> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(PatientInfo t)
        {
            throw new NotImplementedException();
        }
    }
}
