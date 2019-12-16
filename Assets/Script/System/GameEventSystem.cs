public class GameEventSystem : IGameSystem
{
    public GameEventSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
    {
        Initialize();
    }
}