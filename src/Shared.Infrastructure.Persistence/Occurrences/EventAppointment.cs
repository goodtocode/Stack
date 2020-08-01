﻿using System;
using System.Collections.Generic;

namespace GoodToCode.Shared.Models
{
    public partial class EventAppointment : IEventAppointment
    {
        public int EventAppointmentId { get; set; }
        public Guid EventAppointmentKey { get; set; }
        public Guid EventKey { get; set; }
        public Guid AppointmentKey { get; set; }
        public Guid RecordStateKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Appointment AppointmentKeyNavigation { get; set; }
        public virtual Event EventKeyNavigation { get; set; }
        public virtual RecordState RecordStateKeyNavigation { get; set; }
    }
}