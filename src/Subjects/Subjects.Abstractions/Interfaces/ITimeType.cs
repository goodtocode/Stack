﻿using System;
using System.Collections.Generic;

namespace GoodToCode.Subjects.Models
{
    public interface ITimeType
    {
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
        int TimeBehavior { get; set; }
        string TimeTypeDescription { get; set; }
        int TimeTypeId { get; set; }
        Guid TimeTypeKey { get; set; }
        string TimeTypeName { get; set; }
    }
}