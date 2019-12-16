public class CampSystem : IGameSystem
{
    public CampSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
    {
        Initialize();
    }
}