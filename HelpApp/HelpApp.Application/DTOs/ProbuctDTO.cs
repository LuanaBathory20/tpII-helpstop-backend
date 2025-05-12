using System.ComponentModel.DataAnnotations;
using HelpApp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace HelpApp.Application.DTOs
{
    public class ProbuctDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Update Invalid Id value")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Invalid name, name is required.")]
        [MinLength(5)]
        [MaxLength(200)]
        [DisplayName("Description")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Invalid name, too short, minimum 3 characters.")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        [DisplayName("Price")]

        public decimal Price { get; set; }

        [Required(ErrorMessage = "Invalid description, name is required.")]
        [Range(1,9999)]
        [DisplayName("Stock")]

        public int Stock { get; set; }

        [MaxLength(250)]
        [DisplayName("Product Image")]

        public string? Image { get; set; }

        [JsonIgnore]
        public Category? Category { get; set; }

        [DisplayName("Category")]

        public int CategoryId { get; set; }
    }
}
