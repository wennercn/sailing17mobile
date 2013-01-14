using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sailing17Mobile {
    public class SM {
        private static _RPC rpc;
        public static _RPC RPC {
            get { return SM.rpc; }
            set { SM.rpc = value; }
        }
    }
}