using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIBookManagement.Models
{
    [Table("livro")]
    public class Book
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Name { get; set; }
        [Column("autor")]
        public string Autor { get; set; }
        [Column("preco")]
        public double Price { get; set; }
    }
}
