using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sailing17Mobile {
    public class SM{

        private static _RPC rpc = new _RPC();
        public static _RPC RPC {
            get { return SM.rpc; }
            set { SM.rpc = value; }
        }

        //登录后用户RPC
        private static _RPC userrpc;
        public static _RPC UserRPC
        {
            get { return SM.userrpc; }
            set { SM.userrpc = value; }
        }
    }
}