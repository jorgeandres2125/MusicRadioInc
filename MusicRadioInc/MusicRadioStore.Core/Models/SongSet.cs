using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.Models
{
    [Table("SongSet", Schema = "dbo")]
    public class SongSet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength]
        public string Name { get; set; }

        [Required]
        public int AlbumSetId { get; set; }
        public AlbumSet AlbumSet { get; set; }
    }
}
