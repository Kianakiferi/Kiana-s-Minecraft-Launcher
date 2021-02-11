using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1.Authentication
{
	class User
	{
		public Guid UUID { get; set; }
		public string Name { get; set; }
		public string UserType { get; set; }

		public string AccessToken { get; set; }
		public string Properties { get; set; }
		public string Error { get; set; }
		public Dictionary<string, string> AdvancedInfo { get; set; }

	}
}
