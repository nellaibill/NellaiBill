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
        public string State { get; set; }
        public string Country { get; set; }
        public string PhoneNo1 { get; set; }
        public string PhoneNo2 { get; set; }
        public string LandlineNo1 { get; set; }
        public string LandlineNo2 { get; set; }
        public string EmailId1 { get; set; }
        public string EmailId2 { get; set; }
        public string DonorFileName { get; set; }
        public string Reference { get; set; }
        public string Notes { get; set; }
        public string RelatedFiles { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string PanCard { get; set; }
        public int DonorAnnual { get; set; }
        public int DonorEndowment { get; set; }
        public int DonorThings { get; set; }
        public int DonorWelfare { get; set; }

        public int SupportCS { get; set; }
        public int SupportFS { get; set; }
        public int SupportBS { get; set; }
        public int SupportCloth { get; set; }
        public int SupportOther { get; set; }
        public int SROOC { get; set; }
        public int SRNTC { get; set; }
        public int SRPost { get; set; }
        public int SRVisitor { get; set; }
        public int SREmail { get; set; }
        public string OtherDetails { get; set; }

    }
}
