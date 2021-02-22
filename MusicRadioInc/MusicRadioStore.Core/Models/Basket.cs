using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.Models
{
    public class Basket
    {
        public string Id { get; set; }
        public virtual ICollection<BasketItem> BasketItems { get; set; }

        public Basket()
        {
            this.Id = Guid.NewGuid().ToString();
            this.BasketItems = new List<BasketItem>();
        }
    }
}
