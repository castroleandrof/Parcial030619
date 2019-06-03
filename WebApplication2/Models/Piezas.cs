using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication2.Interfaces;

namespace WebApplication2.Models
{
    public partial class Piezas : IEntity
    {
        public Piezas()
            {
            }

        public int Id { get; set; }
        public string nombre { get; set; }

    }

    [MetadataType(typeof(PiezasMetadata))]
    public partial class Piezas
    {
        public class PiezasMetadata
        {
            [Key]
            public int Id { get; set; }
            [StringLength(100)]
            [Required]
            public string nombre { get; set; }
        }
    }
}