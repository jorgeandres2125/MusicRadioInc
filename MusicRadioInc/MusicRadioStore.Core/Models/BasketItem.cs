using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.Models
{
    [Table("BasketItem", Schema = "dbo")]
    public class BasketItem
    {
        [Key]
        public string Id { get; set; }
        
        public string BasketId { get; set; }
        public Basket Basket { get; set; }
        
        public int AlbumSetId { get; set; }
        public AlbumSet AlbumSet { get; set; }
        
        public int Quanity { get; set; }

        public BasketItem()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
