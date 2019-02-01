using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionSample.Domain.Entity.Base;

namespace OnionSample.Domain.Entity
{
    public class Medicine : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Group { get; set; }
        [Required]
        public string Volume { get; set; }
        public string Ingredients { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
