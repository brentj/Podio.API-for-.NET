using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Profile 
	{


		[DataMember(Name = "profile_id", IsRequired=false)]
		public int? ProfileId { get; set; }


		[DataMember(Name = "name", IsRequired=false)]
		public string Name { get; set; }


		[DataMember(Name = "avatar", IsRequired=false)]
		public int? Avatar { get; set; }


		[DataMember(Name = "image", IsRequired=false)]
		public FileAttachment Image { get; set; }


		[DataMember(Name = "birthdate", IsRequired=false)]
		public string Birthdate { get; set; }


		[DataMember(Name = "department", IsRequired=false)]
		public string Department { get; set; }


		[DataMember(Name = "vatin", IsRequired=false)]
		public string Vatin { get; set; }


		[DataMember(Name = "skype", IsRequired=false)]
		public string Skype { get; set; }


		[DataMember(Name = "about", IsRequired=false)]
		public string About { get; set; }


		[DataMember(Name = "address", IsRequired=false)]
		public string[] Address { get; set; }


		[DataMember(Name = "zip", IsRequired=false)]
		public string Zip { get; set; }


		[DataMember(Name = "city", IsRequired=false)]
		public string City { get; set; }


		[DataMember(Name = "country", IsRequired=false)]
		public string Country { get; set; }


		[DataMember(Name = "state", IsRequired=false)]
		public string State { get; set; }


		[DataMember(Name = "im", IsRequired=false)]
		public string[] Im { get; set; }


		[DataMember(Name = "location", IsRequired=false)]
		public string[] Location { get; set; }


		[DataMember(Name = "mail", IsRequired=false)]
		public string[] Mail { get; set; }


		[DataMember(Name = "phone", IsRequired=false)]
		public string[] Phone { get; set; }


		[DataMember(Name = "title", IsRequired=false)]
		public string[] Title { get; set; }


		[DataMember(Name = "url", IsRequired=false)]
		public string[] Url { get; set; }


		[DataMember(Name = "skill", IsRequired=false)]
		public string[] Skill { get; set; }


		[DataMember(Name = "linkedin", IsRequired=false)]
		public string Linkedin { get; set; }


		[DataMember(Name = "twitter", IsRequired=false)]
		public string Twitter { get; set; }


		[DataMember(Name = "app_store_about", IsRequired=false)]
		public string AppStoreAbout { get; set; }


		[DataMember(Name = "app_store_organization", IsRequired=false)]
		public string AppStoreOrganization { get; set; }


		[DataMember(Name = "app_store_location", IsRequired=false)]
		public string AppStoreLocation { get; set; }


		[DataMember(Name = "app_store_title", IsRequired=false)]
		public string AppStoreTitle { get; set; }


		[DataMember(Name = "app_store_url", IsRequired=false)]
		public string AppStoreUrl { get; set; }


		[DataMember(Name = "last_seen_on", IsRequired=false)]
		public string LastSeenOn { get; set; }


		[DataMember(Name = "is_employee", IsRequired=false)]
		public bool IsEmployee { get; set; }


	}
}

