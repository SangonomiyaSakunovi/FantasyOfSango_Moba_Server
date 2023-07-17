using FantasyOfSango_Moba_Server.Bases;
using FantasyOfSango_Moba_Server.Services;
using FantasyOfSango_Moba_Server.Systems;
using SangoLog;

//Developer: SangonomiyaSakunovi

namespace FantasyOfSango_Moba_Server
{
    public class ServerRoot : Singleton<ServerRoot>
    {
        public override void Init()
        {
            base.Init();

            LogTool.InitSettings();

            CacheService.Instance.Init();
            TimerService.Instance.Init();
            NetService.Instance.Init();

            LoginSystem.Instance.Init();
            MatchSystem.Instance.Init();
            RoomSystem.Instance.Init();

            this.LogDone("ServerRoot Init Done.");
        }

        public override void Update()
        {
            base.Update();

            CacheService.Instance.Update();
            TimerService.Instance.Update();
            NetService.Instance.Update();

            LoginSystem.Instance.Update();
            MatchSystem.Instance.Update();
            RoomSystem.Instance.Update();
        }        
    }
}
