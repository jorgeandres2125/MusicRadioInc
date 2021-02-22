using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.Models
{
    public class BasketItem
    {
        public string Id { get; set; }
        public string BasketId { get; set; }
        public Basket Basket { get; set; }
        public string AlbumSetId { get; set; }
        public AlbumSet AlbumSet { get; set; }
        public int Quanity { get; set; }

        public BasketItem()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
