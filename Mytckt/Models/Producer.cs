using System.ComponentModel.DataAnnotations;

namespace Mytckt.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilepictureURL { get; set; }
        public string Fullname { get; set; }
        public string Bio { get; set; }
    }
}
