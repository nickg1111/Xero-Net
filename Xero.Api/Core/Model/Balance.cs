﻿using System.Runtime.Serialization;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "")]
    public class Balance : CoreData
    {
        [DataMember(EmitDefaultValue = false)]
        public decimal Outstanding { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal Overdue { get; set; }
    }
}