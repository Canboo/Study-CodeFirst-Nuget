using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api.Models;

public class City
{
    /// <summary>
    /// 城市系統識別碼
    /// </summary>
    [Comment("城市系統識別碼")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// 城市名稱
    /// </summary>
    [Required]
    [Comment("城市名稱")]
    [Column(TypeName = "nvarchar(50)")]
    public string CityName { get; set; }
}