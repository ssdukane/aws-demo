using efapi1.Infra.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMB.Infra.Domain.Entities
{
    public partial class OMBConfiguration : Auditable
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
