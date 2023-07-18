using FantasyOfSango_Moba_Server.Services;
using FantasyOfSango_Moba_Server.Services.NetService;

//Developer: SangonomiyaSakunovi

namespace FantasyOfSango_Moba_Server.Bases
{
    public abstract class BaseSystem<T> : Singleton<T> where T : new()
    {
        protected NetService netService;
        protected CacheService cacheService;
        protected TimerService timerService;

        public override void Init()
        {
            base.Init();
            netService = NetService.Instance;
            cacheService = CacheService.Instance;
            timerService = TimerService.Instance;
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
