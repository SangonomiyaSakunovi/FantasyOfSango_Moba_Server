using FantasyOfSango_Moba_Server.Bases;
using FantasyOfSango_Moba_Server.Configs;
using FantasyOfSango_Moba_Server.Handlers;
using SangoKCPNet;
using SangoMobaNetProtocol;

//Developer: SangonomiyaSakunovi

namespace FantasyOfSango_Moba_Server.Services.NetService
{
    public class NetService : Singleton<NetService>
    {
        private KCPPeer<ClientPeer> _server = new KCPPeer<ClientPeer> ();
        private Dictionary<OperationCode, BaseHandler> _handlerDict = new Dictionary<OperationCode, BaseHandler>();

        public override void Init()
        {
            base.Init();
            _server.StartAsServer(ServerConfig.LocalIpAddress, ServerConfig.port);
            InitHandlers();
            this.LogDone("NetService Init Done.");
        }

        public override void Update()
        {
            base.Update();
        }

        private void InitHandlers()
        {
            DefaultHandler defaultHandler = new DefaultHandler();
            defaultHandler.InitHandler();
        }

        public void AddHandler(BaseHandler handler)
        {
            _handlerDict.Add(handler.NetOpCode, handler);
        }

        public void OnOperationRequestDistribute(SangoNetMessage sangoNetMessage, ClientPeer peer)
        {
            _handlerDict.TryGetValue(sangoNetMessage.MessageHead.OperationCode, out BaseHandler handler);
            if (handler != null)
            {
                handler.OnOperationRequest(sangoNetMessage, peer);
            }
            else
            {
                _handlerDict.TryGetValue(OperationCode.Default, out BaseHandler defaultHandler);
                defaultHandler.OnOperationRequest(sangoNetMessage, peer);
            }
        }
    }
}
