using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Filter 
	{


		[DataMember(Name = "filter_id", IsRequired=false)]
		public int? FilterId { get; set; }


		[DataMember(Name = "name", IsRequired=false)]
		public string Name { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public string CreatedOn { get; set; }


		[DataMember(Name = "items", IsRequired=false)]
		public int? Items { get; set; }


		[DataMember(Name = "sort_by", IsRequired=false)]
		public string SortBy { get; set; }


		[DataMember(Name = "sort_desc", IsRequired=false)]
		public string SortDesc { get; set; }


        [DataMember(Name = "filters", IsRequired=false)]
        public List<Filter> Filters { get; set; }


		[DataMember(Name = "created_by", IsRequired=false)]
		public User CreatedBy { get; set; }


	}
}

