using NerdAmigo.Abstractions;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Common.SimpleInjector
{
    public class SimpleInjectorQueueMessageWorkerActivator : IQueueMessageWorkerActivator
    {
		private Container container;

		public SimpleInjectorQueueMessageWorkerActivator(Container container)
		{
			this.container = container;
		}

		public IQueueMessageWorker<TQueueMessage> GetWorker<TQueueMessage>() where TQueueMessage : IQueueMessage
		{
			return this.container.GetInstance<IQueueMessageWorker<TQueueMessage>>();
		}
	}
}
