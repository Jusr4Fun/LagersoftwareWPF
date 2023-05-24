﻿using System;
using System.Collections.Generic;

namespace Datenbank.Models;

public class Manufacturer
{
    public int ManufacturerID { get; set; }
    public string ManufacturerName { get; set;}

    public ICollection<Device> Device { get; set; }
}
