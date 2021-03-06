﻿using NetMQ.Sockets;
using VVVV.PluginInterfaces.V2;

namespace VVVV.ZeroMQ.Nodes.Sockets
{
    #region PluginInfo
    [PluginInfo(Name = "Publisher", Category = SOCKET_CATEGORY, Help = "Creates a socket, use in conjunction with Subscribe", Tags = TAGS, Author = AUTHOR)]
    #endregion PluginInfo
    public class PublisherSocketNode : AbstractSocketNode<PublisherSocket>
    {
        #region fields & pins
        [Config("Bind", DefaultBoolean = true, IsSingle = true)]
        public IDiffSpread<bool> ConfigBind;
        #endregion fields & pins

        public override void OnImportsSatisfied()
        {
            base.OnImportsSatisfied();
            ConfigBind.Changed += _ => Bind = ConfigBind[0];
            NewSocket = () => Context.CreatePublisherSocket();
        }





    }
}
