using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NellaiBill.Models
{
    public class DonorRegistrationResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PhoneNo1 { get; set; }
        public string PhoneNo2 { get; set; }
        public string LandlineNo1 { get; set; }
        public string LandlineNo2 { get; set; }
        public string EmailId1 { get; set; }
        public string EmailId2 { get; set; }
        public string DonorFileName { get; set; }
        public string Reference { get; set; }

    }
}
