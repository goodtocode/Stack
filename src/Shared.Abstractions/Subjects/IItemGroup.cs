﻿using System;
using System.Collections.Generic;

namespace GoodToCode.Shared.Models
{
    public interface IItemGroup
    {
        DateTime CreatedDate { get; set; }
        string ItemGroupDescription { get; set; }
        int ItemGroupId { get; set; }
        Guid ItemGroupKey { get; set; }
        string ItemGroupName { get; set; }
        DateTime ModifiedDate { get; set; }
    }
}