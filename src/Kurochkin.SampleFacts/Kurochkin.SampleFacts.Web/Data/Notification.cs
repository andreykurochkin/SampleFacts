using Calabonga.EntityFrameworkCore.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurochkin.SampleFacts.Web.Data
{
    /// <summary>
    /// Notification entity
    /// </summary>
    public class Notification : Auditable
    {
        public string Subject { get; set; }
        public string Content { get; set; }
        public bool IsCompleted { get; set; }
        public string AddressFrom { get; set; }
        public string AddressTo { get; set; }
    }
}
