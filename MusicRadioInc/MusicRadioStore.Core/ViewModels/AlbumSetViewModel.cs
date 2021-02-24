using MusicRadioStore.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.ViewModels
{
    public class AlbumSetViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Imagen")]
        public string Image { get; set; }

        [Required]
        [RegularExpression("([0-9]+)", ErrorMessage = "Este campo es solo numerico")]
        [Display(Name = "Precio")]
        [StringLength(10,ErrorMessage = "Numero muy alto"), MinLength(2,ErrorMessage = "Numero muy bajo")]
        public string Price { get; set; }

        public ICollection<SongSet> SongSets { get; set; }

    }
}
