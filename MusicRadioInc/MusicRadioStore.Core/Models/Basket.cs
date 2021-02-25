using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.Models
{
    [Table("Basket", Schema = "dbo")]
    public class Basket
    {
        [Key]
        public string Id { get; set; }
        public virtual ICollection<BasketItem> BasketItems { get; set; }

        public Basket()
        {
            this.Id = Guid.NewGuid().ToString();
            this.BasketItems = new List<BasketItem>();
        }
    }
}
