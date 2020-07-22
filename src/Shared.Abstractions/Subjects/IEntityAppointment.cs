﻿using System;

namespace GoodToCode.Shared.Models
{
    public interface IEntityAppointment
    {
        Guid AppointmentKey { get; set; }
        DateTime CreatedDate { get; set; }
        int EntityAppointmentId { get; set; }
        Guid EntityAppointmentKey { get; set; }
        Guid EntityKey { get; set; }
        DateTime ModifiedDate { get; set; }
        Guid RecordStateKey { get; set; }
    }
}