using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Qoute
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public string Body { get; set; }
    }
}