using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class AuditableEntitycs
    {
        public DateTime Created { get; set; }
        public string CretedBy { get; set; }
        public DateTime? Modifited { get; set; }
        public string ModifitedBy { get; set; }

    }
}
