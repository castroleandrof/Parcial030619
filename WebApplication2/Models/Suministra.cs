using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public partial class Suministra
    {
        public Suministra()
        {

        }
        public int codigoPieza { get; set; }
        public int idProveedor { get; set; }
        public int precio { get; set; }
    }

    [MetadataType(typeof(SuministraMetadata))]
    public partial class Suministra
    {
        public class SuministraMetadata
        {
            [Key]
            [Column(Order=1)]
            public int idProveedor { get; set; }
            [Key]
            [Column(Order=2)]
            public int codigoPieza { get; set; }
            [Required]
            public int precio { get; set; }
        }
    }
}