using System;
using System.Collections.Generic;

namespace Uesan.Logistica.API.Models;

public partial class Categorium
{
    public int Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public string Description { get; set; } = null!;
}
