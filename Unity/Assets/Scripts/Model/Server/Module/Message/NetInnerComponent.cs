﻿using System;
using System.Net;

namespace ET.Server
{
    [ComponentOf(typeof(Scene))]
    public class NetInnerComponent: Entity, IAwake<IPEndPoint>, IAwake, IDestroy, IUpdate
    {
        public AService AService;
        
        public NetworkProtocol InnerProtocol = NetworkProtocol.KCP;
    }
}