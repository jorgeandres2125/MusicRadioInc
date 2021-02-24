using MusicRadioStore.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.ViewModels
{
    public class SongSetViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Albúm")]
        public int AlbumSetId { get; set; }
        [Display(Name = "Albúm")]
        public AlbumSet AlbumSet { get; set; }
    }
}
