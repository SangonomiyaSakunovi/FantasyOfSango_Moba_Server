using FantasyOfSango_Moba_Server.Bases;
using FantasyOfSango_Moba_Server.Services.NetService;
using SangoMobaNetProtocol;

//Developer: SangonomiyaSakunovi

namespace FantasyOfSango_Moba_Server.Handlers
{
    public class DefaultHandler : BaseHandler
    {
        public DefaultHandler() 
        { 
            NetOpCode = OperationCode.Default; 
        }

        public override void InitHandler()
        {
            base.InitHandler();
        }

        public override void OnOperationRequest(SangoNetMessage sangoNetMessage, ClientPeer peer)
        {

        }
    }
}
