using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YGOEditor.Util {
    public interface IYEForm {
        /// <summary>
        /// set DockContent param from persist string
        /// </summary>
        /// <param name="param"></param>
        /// <returns>false dockconent can't create</returns>
         bool SetParams(string[] param);
    }
}
