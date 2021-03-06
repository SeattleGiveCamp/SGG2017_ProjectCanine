﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ProjectCanine.Common.Models
{
	[DataContract]
    public class Test : TestPart
    {
		[DataMember]
        public string ShortName { get; set; }

		[DataMember]
        public string Name { get; set; }

		[DataMember]
		public IEnumerable<Question> Questions { get; set; }
    }
}
