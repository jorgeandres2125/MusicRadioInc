using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.Models
{
    [Table("Purchase", Schema = "dbo")]
    public class Purchase
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [StringLength(100)]
        public string OrderStatus { get; set; }

        public virtual ICollection<PurchaseDatail> PurchaseDetails { get; set; }

        public Purchase()
        {
            this.Id = Guid.NewGuid().ToString();
            this.PurchaseDetails = new List<PurchaseDatail>();
        }
    }
}
