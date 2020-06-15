using MicroservicesDemo.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesDemo.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        public Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
