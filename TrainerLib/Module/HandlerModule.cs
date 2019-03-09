using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainerLib.Handler;

namespace TrainerLib.Module
{
    public class ModuleHandler : BasicHandler
    {
        #region Fields
        private Dictionary<string, Mod> loadedModules = new Dictionary<string, Mod>();
        #endregion

        #region Properties
        public ICollection<Mod> Modules
        {
            get => loadedModules.Values.ToList();
        }
        #endregion

        public ModuleHandler(Trainer trainer) : base(trainer)
        {
            
        }




    }
}
