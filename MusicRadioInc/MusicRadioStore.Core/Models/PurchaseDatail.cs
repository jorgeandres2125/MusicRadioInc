using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.Models
{
    [Table("PurchaseDatail", Schema = "dbo")]
    public class PurchaseDatail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(0, 100000)]
        public decimal Total { get; set; }

        [Required]
        public int AlbumSetId { get; set; }
        public AlbumSet AlbumSet { get; set; }

        [Required]
        public string ClientId { get; set; }
        public Client Client { get; set; }

        [Required]
        public string PurchaseId { get; set; }
        public Purchase Purchase { get; set; }

    }
}
