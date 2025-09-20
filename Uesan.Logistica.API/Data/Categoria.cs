using System;
using System.Collections.Generic;

namespace Uesan.Logistica.API.Data;

public partial class Categoria
{
    public int Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public string Description { get; set; } = null!;
}
