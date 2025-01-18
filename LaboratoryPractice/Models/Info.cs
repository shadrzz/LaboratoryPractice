using System;
using System.Collections.Generic;

namespace LaboratoryPractice.Models;

public partial class Info
{
    public long Id { get; set; }

    public string Address { get; set; } = null!;

    public string AccessMode { get; set; } = null!;

    public string AccessDate { get; set; } = null!;
    
    public Info() { }
    public Info(string address, string accessMode, string accessDate)
    {
        Address = address;
        AccessMode = accessMode;
        AccessDate = accessDate;
    }
}
