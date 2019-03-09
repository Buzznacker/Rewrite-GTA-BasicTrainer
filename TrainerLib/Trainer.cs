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
        private ModuleHandler moduleHandler;

        public Trainer()
        {
            new HandlerEvents(this);
            moduleHandler = new ModuleHandler(this);
        }
    }
}
