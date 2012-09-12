using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Search 
	{


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "id", IsRequired=false)]
		public int? Id { get; set; }


		[DataMember(Name = "title", IsRequired=false)]
		public string Title { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public string CreatedOn { get; set; }


		[DataMember(Name = "link", IsRequired=false)]
		public string Link { get; set; }


		[DataMember(Name = "search_id", IsRequired=false)]
		public int? SearchId { get; set; }


		[DataMember(Name = "rank", IsRequired=false)]
		public int? Rank { get; set; }


		[DataMember(Name = "created_by", IsRequired=false)]
		public ByLine CreatedBy { get; set; }


		[DataMember(Name = "app", IsRequired=false)]
		public Application App { get; set; }


		[DataMember(Name = "org", IsRequired=false)]
		public Organization Org { get; set; }


		[DataMember(Name = "space", IsRequired=false)]
		public Space Space { get; set; }


	}
}

