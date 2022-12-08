using System.ComponentModel.DataAnnotations.Schema;
using GeoPet.ApplicationCore.Domains;

namespace GeoPet.Infrastructure.Entities;

public class PetEntity
{
    public int Id { get; set; }
    [ForeignKey("Caretaker")]
    public int CaretakerId { get; set; }
    public string Name { get; set; }
    [ForeignKey("PetCategory")]
    public string Category { get; set; }
    public int Age { get; set; }
    public PetSex Sex { get; set; }
}