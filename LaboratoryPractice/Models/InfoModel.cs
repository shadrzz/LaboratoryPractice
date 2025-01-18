using System;
using System.Collections.Generic;

namespace LaboratoryPractice.Models;

public partial class InfoModel
{
    public long Id { get; set; }

    public string Address { get; set; } = null!;

    public string AccessMode { get; set; } = null!;

    public string AccessDate { get; set; } = null!;

    public InfoModel() { }
    public InfoModel(long id, string address, string accessMode, string accessDate)
    {
        Id = id;
        Address = address;
        AccessMode = accessMode;
        AccessDate = accessDate;
    }
}
