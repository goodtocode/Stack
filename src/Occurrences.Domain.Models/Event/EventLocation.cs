﻿using GoodToCode.Shared.Models;
using System;
using System.Collections.Generic;

namespace GoodToCode.Occurrences.Models
{
    public class EventLocation : DomainModel<IEventLocation>, IEventLocation
    {
        public Guid EventLocationKey { get; set; }
        public Guid EventKey { get; set; }
        public Guid LocationKey { get; set; }
        public Guid? LocationTypeKey { get; set; }
    }
}