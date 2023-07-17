using FantasyOfSango_Moba_Server;

ServerRoot.Instance.Init();

while (true)
{
    ServerRoot.Instance.Update();
    Thread.Sleep(10);
}
