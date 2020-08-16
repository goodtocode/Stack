﻿using System;
using System.Collections.Generic;

namespace GoodToCode.Occurrences.Models
{
    public class EventType
    {
        public Guid EventTypeKey { get; set; }
        public Guid EventGroupKey { get; set; }
        public string EventTypeName { get; set; }
        public string EventTypeDescription { get; set; }
    }
}
