﻿using System;
using System.Collections.Generic;

namespace GoodToCode.Shared.Models
{
    public interface ISlot
    {
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
        Guid RecordStateKey { get; set; }
        string SlotDescription { get; set; }
        int SlotId { get; set; }
        Guid SlotKey { get; set; }
        string SlotName { get; set; }
    }
}