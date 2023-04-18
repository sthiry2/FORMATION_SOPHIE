using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp6.Models;

public partial class Country
{
    [Key]
    public string CountryCode { get; set; } = null!;

    public string CountryName { get; set; } = null!;

    public virtual ICollection<City> Cities { get; } = new List<City>();
}
