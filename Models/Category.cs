using System.ComponentModel.DataAnnotations;

namespace Book_MGS.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedeDateTime { get; set; } = DateTime.Now;
    }
}
