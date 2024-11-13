using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;

namespace ERP.SGA.Infraestructure.CommonModels
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Guid = Guid.NewGuid();
            Enabled = true;
        }

        [Key]
        public virtual long Id { get; set; }

        public Guid Guid { get; set; }

        public bool Enabled { get; set; }

        [Timestamp]
        [Column(TypeName = "TIMESTAMP(6)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime RowVersion { get; set; }

        public string? Display => ToString();
    }
}
