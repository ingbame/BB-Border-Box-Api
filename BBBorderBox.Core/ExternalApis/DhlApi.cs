using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBBorderBox.Core.ExternalApis
{
    public class DhlApi
    {
        #region Patron de Diseño
        private static DhlApi? _instance;
        private static readonly object _instanceLock = new object();
        public static DhlApi Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if (_instance == null)
                            _instance = new DhlApi();
                    }
                }
                return _instance;
            }
        }

        #endregion
    }
}
