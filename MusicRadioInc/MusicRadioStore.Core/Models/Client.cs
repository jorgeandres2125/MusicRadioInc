using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRadioStore.Core.Models
{
    [Table("Client", Schema = "dbo")]
    public class Client
    {
        [Key]
        [StringLength(10)]
        public string Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string Mail { get; set; }
        [Required]
        [StringLength(500)]
        public string Direction { get; set; }
        [Required]
        [StringLength(20)]
        [RegularExpression("([0-9]+)", ErrorMessage = "Este campo es solo numerico")]
        public string Phone { get; set; }

    }
}
