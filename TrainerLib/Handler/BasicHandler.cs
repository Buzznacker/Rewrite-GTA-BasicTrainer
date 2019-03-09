using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerLib.Handler
{
    public class BasicHandler
    {
        protected Trainer trainer;

        public BasicHandler(Trainer trainer)
        {
            this.trainer = trainer;
        }
    }
}
