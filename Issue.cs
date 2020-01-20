using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIM.Core
{
    /// <summary>
    /// Issue detected and/or raised by the algorithm
    /// </summary>
    public struct Issue
    {
        public int Type { get; set; } // 0: 
        public int User { get; set; } // 0: if user is "ENGINE" it is detected during computation phase
        public string Data { get; set; }

        public Issue(int Type, int User, string Data)
        {
            this.Type = Type;
            this.User = User;
            this.Data = Data;
        }
    }
}