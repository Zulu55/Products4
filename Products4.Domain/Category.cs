namespace Products4.Domain
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [MaxLength(50, ErrorMessage = "The field {0} only can contains {1} charactres.")]
        [Index("Category_Description_Index", IsUnique = true)]
        public string Description { get; set; }
    }
}
