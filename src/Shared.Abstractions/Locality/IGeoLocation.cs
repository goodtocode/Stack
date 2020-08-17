﻿using GoodToCode.Shared.Models;
using System;
using System.Drawing;

namespace GoodToCode.Locality.Models
{
    public interface IGeoLocation : IDomainModel<IGeoLocation>
    {
        Point Elevation { get; set; }
        Guid GeoLocationKey { get; set; }
        Guid LatLongKey { get; set; }
    }
}