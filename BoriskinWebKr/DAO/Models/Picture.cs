using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoriskinWebKr.DAO.Models
{
    [Table("pictures")]
    public class Picture
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("content")]
        public byte[] Content { get; set; }

        [Column("painter_id")]
        public long PainterId { get; set; }

        [ForeignKey("PainterId")]
        public virtual Painter Painter { get; set; }
    }
}
