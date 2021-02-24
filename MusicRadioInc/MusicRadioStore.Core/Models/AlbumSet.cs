using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.Models
{
    [Table("AlbumSet", Schema = "dbo")]
    public class AlbumSet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength]
        public string Name { get; set; }

        [Required]
        [MaxLength]
        public string Image { get; set; }

        [Required]
        [Range(0, 100000)]
        public decimal Price { get; set; }

        public ICollection<SongSet> SongSets { get; set; }
    }
}
