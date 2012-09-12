using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Reference 
	{


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "id", IsRequired=false)]
		public int? Id { get; set; }


		[DataMember(Name = "title", IsRequired=false)]
		public string Title { get; set; }


		[DataMember(Name = "link", IsRequired=false)]
		public string Link { get; set; }


		[DataMember(Name = "data", IsRequired=false)]
		public object Data { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public string CreatedOn { get; set; }


		[DataMember(Name = "created_by", IsRequired=false)]
		public ByLine CreatedBy { get; set; }


		[DataMember(Name = "created_via", IsRequired=false)]
		public Via CreatedVia { get; set; }


	}
}

