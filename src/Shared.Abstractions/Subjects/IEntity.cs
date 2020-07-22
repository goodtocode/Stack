﻿using System;
using System.Collections.Generic;

namespace GoodToCode.Shared.Models
{
    public interface IEntity
    {
        DateTime CreatedDate { get; set; }
        int EntityId { get; set; }
        Guid EntityKey { get; set; }
        DateTime ModifiedDate { get; set; }
    }
}