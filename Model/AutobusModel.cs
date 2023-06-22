using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4projekt3.Model
{
    [Table("Autobus")]
    public class AutobusModel
    {
        [Key]
        public string Nr_rejestracji { get; set; }

        public virtual ICollection<KierowcaModel> KierowcaId { get; set; } = new List<KierowcaModel>();

        [Column(TypeName="nvarhcar(30)")]
        public string Model { get; set; }

        [Column(TypeName ="nvarchar(20)")]
        public string Marka { get; set; }

        [Column(TypeName="decimal(2)")]
        public string Rocznik { get; set; }

    }

}
