using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3.Interfaces
{
    using ViewModels;

    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}