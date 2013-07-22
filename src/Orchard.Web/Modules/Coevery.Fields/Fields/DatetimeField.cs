﻿using System;
using Orchard.ContentManagement;
using Orchard.ContentManagement.FieldStorage;

namespace Coevery.Fields.Fields {
    public class DatetimeField : ContentField {
        public DateTime? Value {
            get { return Storage.Get<DateTime?>(); }
            set { Storage.Set(value); }
        }
    }
}
