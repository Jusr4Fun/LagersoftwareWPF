﻿using System.Collections.Generic;

namespace Datenbank.Models;

public class ScreenSize
{
    public int ScreenSizeID { get; set; }

    public string ScreenSizeName { get; set; } = null!;
    public int ScreenWidth { get; set; }
    public int ScreenHeight { get; set; }
    public double ScreenDiagonal { get; set; }

    public ICollection<Display> Display { get; set; } = null!;
}
