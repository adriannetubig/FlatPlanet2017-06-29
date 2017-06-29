using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatPlanetEntity
{
    [Table("Counter")]
    public class ECounter
    {
        public DateTime CreatedDate { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CounterId { get; set; }
    }
}
