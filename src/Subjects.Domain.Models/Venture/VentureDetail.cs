﻿using GoodToCode.Shared.Domain;
using System;
using System.ComponentModel.DataAnnotations;

namespace GoodToCode.Subjects.Models
{
    public class VentureDetail : DomainEntity<IVentureDetail>, IVentureDetail
    {
        public override string PartitionKey { get; set; } = "Default";
        public override Guid RowKey { get { return VentureDetailKey; } set { VentureDetailKey = value; } }
        public Guid VentureDetailKey { get; set; }
        public Guid VentureKey { get; set; }
        public Guid DetailKey { get; set; }
        
        
    }
}
