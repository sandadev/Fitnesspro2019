using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnesspro.Infrastructure.Models
{
    public class ServiceViewModel
    {
        public int ServiceGroupId { get; set; }
        public string GroupName { get; set; }
        public int AppointmentColor { get; set; }
        public string Description { get; set; }
        public int EntityId { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public Nullable<int> TreatmentType { get; set; }

    }

}
    
