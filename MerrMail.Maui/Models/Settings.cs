﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerrMail.Maui.Models;

public class Settings : ISettings
{
    public required string Path { get; set; }
}
