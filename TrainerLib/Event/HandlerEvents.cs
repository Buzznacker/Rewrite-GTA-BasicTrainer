using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainerLib.Handler;
using TrainerLib.Module;

namespace TrainerLib.Event
{
    public class HandlerEvents : BasicHandler
    {
        public HandlerEvents(Trainer trainer) : base(trainer)
        {
            trainer.Tick += this.onTick;
        }

        public void onTick(object sender, EventArgs args)
        {
            trainer.ModuleHandler.Modules
                .Where(mod => mod.Toggled)
                .ToList()
                .ForEach(mod => mod.onTick());
        }
    }
}
