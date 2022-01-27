using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WinServiceManager.BLL
{
    public interface IWindowServiceMgr
    {
        void StartOrRestart();
        void StopServiceIfRunning();
    }
}
