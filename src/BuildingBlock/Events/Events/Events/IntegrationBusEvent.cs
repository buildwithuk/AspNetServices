using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
	public class IntegrationBusEvent
	{
		public IntegrationBusEvent()
		{
			Id = Guid.NewGuid();
			CreationDate = DateTime.UtcNow;
		}
		public Guid Id { get; private set; }

		public DateTime CreationDate { get; private set; }
	}
}
