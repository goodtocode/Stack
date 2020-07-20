﻿using System;
using System.Collections.Generic;

namespace GoodToCode.Subjects.Models
{
    public partial class VentureSchedule
    {
        public int VentureScheduleId { get; set; }
        public Guid VentureScheduleKey { get; set; }
        public Guid VentureKey { get; set; }
        public Guid ScheduleKey { get; set; }
        public Guid? ScheduleTypeKey { get; set; }
        public Guid RecordStateKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual RecordState RecordStateKeyNavigation { get; set; }
        public virtual Schedule ScheduleKeyNavigation { get; set; }
        public virtual ScheduleType ScheduleTypeKeyNavigation { get; set; }
        public virtual Venture VentureKeyNavigation { get; set; }
    }
}
