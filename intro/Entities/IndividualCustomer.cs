using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.Entities
{
	public class IndividualCustomer:BaseCustomer //ortakları base cutomerda topladığımız için buraya mirası ekledik
	{
		//public int Id { get; set; }
		//public string CustomerNumber { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }	
		public string NationalIndentity { get; set; }
	}
}
