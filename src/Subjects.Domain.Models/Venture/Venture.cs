﻿using GoodToCode.Shared.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace GoodToCode.Subjects.Models
{
    public class Venture : DomainModel<IVenture>, IVenture
    {
        public override string PartitionKey { get; set; } = "Default";
        public override Guid RowKey { get { return VentureKey; } set { VentureKey = value; } }
        public Guid VentureKey { get; set; }
        public Guid? VentureGroupKey { get; set; }
        public Guid? VentureTypeKey { get; set; }
        public string VentureName { get; set; }
        public string VentureDescription { get; set; }
        public string VentureSlogan { get; set; }
        
        
    }
}
