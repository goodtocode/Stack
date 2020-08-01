﻿using System;

namespace GoodToCode.Subjects.Models
{
    public class Government : IGovernment
    {
        public int GovernmentId { get; set; }
        public Guid GovernmentKey { get; set; }
        public string GovernmentName { get; set; }
        public Guid RecordStateKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}