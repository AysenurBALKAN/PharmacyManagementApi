using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEntityLayer.Concrete
{
   public class Receipt
    {
        [Key]
        public int ReceiptId { get; set; }
        public int MedicineId { get; set; }
        public int PatientId { get; set; }
        public string DoctorName { get; set; }
        public string HospitalName { get; set; }
        public string Diagnosis { get; set; }
        public DateTime Date { get; set; }
        public List<PatientInfo> PatientInfos { get; set; }
        public List<MedicineInfo> MedicineInfos { get; set; }

    }
}
