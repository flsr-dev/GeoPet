using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeoPet.Infrastructure.Entities;

public class PetLocationEntity
{
    [Key, ForeignKey("Pet")]
    public int PetId { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
}