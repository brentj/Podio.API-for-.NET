using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class ContractAccounting 
	{


		[DataMember(Name = "contract_id", IsRequired=false)]
		public int? ContractId { get; set; }


		[DataMember(Name = "first_name", IsRequired=false)]
		public string FirstName { get; set; }


		[DataMember(Name = "last_name", IsRequired=false)]
		public string LastName { get; set; }


		[DataMember(Name = "organization", IsRequired=false)]
		public string Organization { get; set; }


		[DataMember(Name = "phone", IsRequired=false)]
		public string Phone { get; set; }


		[DataMember(Name = "address1", IsRequired=false)]
		public string Address1 { get; set; }


		[DataMember(Name = "address2", IsRequired=false)]
		public string Address2 { get; set; }


		[DataMember(Name = "zip", IsRequired=false)]
		public string Zip { get; set; }


		[DataMember(Name = "city", IsRequired=false)]
		public string City { get; set; }


		[DataMember(Name = "state", IsRequired=false)]
		public string State { get; set; }


		[DataMember(Name = "country", IsRequired=false)]
		public string Country { get; set; }


	}
}

