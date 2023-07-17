//Developer: SangonomiyaSakunovi

namespace FantasyOfSango_Moba_Server.Bases
{
    public class Singleton<T> where T : new()
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new T();
                }
                return _instance;
            }
        }

        public virtual void Init() { }

        public virtual void Update() { }
    }
}
