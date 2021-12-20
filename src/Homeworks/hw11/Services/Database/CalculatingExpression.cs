using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hw11.Services.Database
{
    public class CalculatingExpression
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string Expression { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Result { get; set; }
    }
}