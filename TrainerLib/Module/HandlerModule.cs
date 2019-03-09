using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainerLib.Handler;

namespace TrainerLib.Module
{
    public class HandlerModule : BasicHandler
    {
        #region Fields
        private Dictionary<string, Mod> loadedModules = new Dictionary<string, Mod>();
        #endregion

        #region Properties
        /// <summary>
        /// Returns a collection of all loaded modules.
        /// </summary>
        public List<Mod> Modules
        {
            get => loadedModules.Values.ToList();
        }
        #endregion

        public HandlerModule(Trainer trainer) : base(trainer)
        {
            
        }

        /// <summary>
        /// Allows you to find a mod by it's name. This is used by the menu.
        /// </summary>
        /// <param name="name">Module's name</param>
        /// <param name="mod">Module ptr</param>
        /// <returns></returns>
        public bool FindMod(string name, out Mod mod) 
            => loadedModules.TryGetValue(name, out mod);

        /// <summary>
        /// Register the mod into the loadedMods Dictionary
        /// </summary>
        /// <param name="mod">mod object</param>
        private void registerMod(Mod mod) 
            => loadedModules.Add(mod.Name, mod);
    }
}
