﻿using System;

namespace GoodToCode.Subjects.Models
{
    public interface IVentureLocation
    {
        DateTime CreatedDate { get; set; }
        Guid LocationKey { get; set; }
        Guid? LocationTypeKey { get; set; }
        DateTime ModifiedDate { get; set; }
        
        Guid VentureKey { get; set; }
        Guid VentureLocationKey { get; set; }
    }
}