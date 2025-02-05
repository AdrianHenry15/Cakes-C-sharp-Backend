using System.ComponentModel.DataAnnotations;

namespace CakesApp.Models
{
    public class Cake
    {
        public int Id { get; set;}
        public required string Name {get; set;}
        public required string Description {get; set;}
        public required string Price {get; set;}
        public required string ImageUrl {get; set;}
    }
}