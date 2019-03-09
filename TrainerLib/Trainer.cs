using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTA;
using System.Threading.Tasks;
using TrainerLib.Event;
using TrainerLib.Module;

namespace TrainerLib
{
    public class Trainer : Script
    {
        public HandlerModule ModuleHandler { get; }

        public Trainer()
        {
            ModuleHandler = new HandlerModule(this);
            new HandlerEvents(this);
        }
    }
}
