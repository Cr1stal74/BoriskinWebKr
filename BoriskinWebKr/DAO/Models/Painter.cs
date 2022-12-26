using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoriskinWebKr.DAO.Models;

[Table("painters")]
public class Painter
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("descriptions")]
    public string Description { get; set; }

    [Column("photo")]
    public byte[] Photo { get; set; }

    public virtual List<Picture> Pictures { get; set; }
}
