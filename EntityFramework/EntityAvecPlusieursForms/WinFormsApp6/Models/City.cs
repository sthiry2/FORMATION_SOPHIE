using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp6.Models;

public partial class City
{
    /*[Key] a ajouter*/
    public int CityId { get; set; }

    public string CityName { get; set; } = null!;

    public string CountryCode { get; set; } = null!;

    public virtual Country CountryCodeNavigation { get; set; } = null!;
}
