using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4projekt3.Model
{
    [Table("Kierowca")]
    public class KierowcaModel
    {
        [Key]
        public int KierowcaId { get; set; }

        [Column(TypeName ="nvarchar(40)")]
        public string FirstName { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string LastName { get; set; }

        [Column(TypeName ="int")]
        public int Nr_tel { get; set; }

        [Column(TypeName ="nvarchar(120)")]
        public string Adres { get; set; }

        [Column(TypeName ="date")]
        public DateTime Data_ur { get; set; }
    }
}
