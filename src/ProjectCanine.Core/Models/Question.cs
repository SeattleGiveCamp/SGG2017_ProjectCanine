﻿using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ProjectCanine.Core.Models
{
	[DataContract]
	public class Question : TestPart
	{
		[DataMember]
		public Guid Test { get; set; }

		[DataMember]
		public string Text { get; set; }

		[DataMember]
		public bool MustPass { get; set; }

		[DataMember]
		public Guid Section { get; set; }

		[DataMember]
		public int QuestionNumber { get; set; }

		[DataMember]
		public bool HasYesNo { get; set; }
	}
}
