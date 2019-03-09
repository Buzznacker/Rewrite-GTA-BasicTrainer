using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerLib.Module
{
    public interface Mod
    {
        /// <summary>
        /// Returns if the module is toggled or not
        /// </summary>
        bool Toggled
        {
            get;
        }

        /// <summary>
        /// Returns the name of that module
        /// </summary>
        string Name
        {
            get;
        }

        /// <summary>
        /// On Tick event is called inside the toggled module
        /// </summary>
        void onTick();

    }
}
