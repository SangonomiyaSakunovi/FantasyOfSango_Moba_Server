using FantasyOfSango_Moba_Server.Services.NetService;
using SangoMobaNetProtocol;
using System.Text.Json;

//Developer: SangonomiyaSakunovi

namespace FantasyOfSango_Moba_Server.Bases
{
    public abstract class BaseHandler
    {
        public OperationCode NetOpCode;

        protected NetService _netService;

        public abstract void OnOperationRequest(SangoNetMessage sangoNetMessage, ClientPeer peer);

        public virtual void InitHandler()
        {
            _netService = NetService.Instance;
            _netService.AddHandler(this);
        }

        protected static string SetJsonString(object ob)
        {
            return JsonSerializer.Serialize(ob);
        }

        protected static T DeJsonString<T>(string str)
        {
            return JsonSerializer.Deserialize<T>(str);
        }
    }
}
