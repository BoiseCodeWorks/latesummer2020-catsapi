using System;
using System.ComponentModel.DataAnnotations;

namespace catsAPI.Models
{
    public class Cat
    {
        public Cat()
        {

        }
        public Cat(string name, string description)
        {
            Name = name;
            Description = description;
        }

        [Required]
        [MinLength(5)]
        [MaxLength(10, ErrorMessage = "You userd too many letterrsss and stuffs")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Id { get; set; } = Guid.NewGuid().ToString();

        // NOTE to create a virtual you would supply a new property with a getter that returns the value of another property and modifies it as desired
    }
}

