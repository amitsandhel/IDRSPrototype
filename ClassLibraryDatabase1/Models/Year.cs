using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryDatabase1.Models;

[Table("year")]
public partial class Year
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("year")]
    public int Year1 { get; set; }

    [Column("description")]
    public string? Description { get; set; }
}
