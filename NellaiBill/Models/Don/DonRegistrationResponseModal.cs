using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NellaiBill.Models.Don
{
    public class DonRegistrationResponseModal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }

        public string DoorNo { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int City { get; set; }
        public int District { get; set; }
        public int PinCode { get; set; }
        public int Assembly { get; set; }
        public int Ward { get; set; }
        public int Subward { get; set; }

        public string EpicNumber { get; set; }

    }
}
