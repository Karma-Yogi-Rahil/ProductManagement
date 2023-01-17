

using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public string Borower { get; set; }

    }
}
