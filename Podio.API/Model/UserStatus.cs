using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public partial class UserStatus
	{


		[DataMember(Name = "profile", IsRequired=false)]
		public Dictionary<string,object> Profile { get; set; }


		[DataMember(Name = "properties", IsRequired=false)]
		public Dictionary<string,object> Properties { get; set; }


		[DataMember(Name = "inbox_new", IsRequired=false)]
		public int? InboxNew { get; set; }


		[DataMember(Name = "calendar_code", IsRequired=false)]
		public string CalendarCode { get; set; }


		[DataMember(Name = "task_mail", IsRequired=false)]
		public string TaskMail { get; set; }


		[DataMember(Name = "mailbox", IsRequired=false)]
		public string Mailbox { get; set; }


		[DataMember(Name = "message_unread_count", IsRequired=false)]
		public int? MessageUnreadCount { get; set; }


		[DataMember(Name = "flags", IsRequired=false)]
		public string[] Flags { get; set; }


		[DataMember(Name = "betas", IsRequired=false)]
		public string[] Betas { get; set; }


		[DataMember(Name = "push", IsRequired=false)]
		public Dictionary<string,object> Push { get; set; }


		[DataMember(Name = "presence", IsRequired=false)]
		public Dictionary<string,object> Presence { get; set; }


		[DataMember(Name = "user", IsRequired=false)]
		public User User { get; set; }


		[DataMember(Name = "contact", IsRequired=false)]
		public Contact Contact { get; set; }


		[DataMember(Name = "referral", IsRequired=false)]
		public Referral Referral { get; set; }


	}
}

