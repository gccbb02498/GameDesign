public class AchievementSystem : IGameSystem
{
    public AchievementSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
    {
        Initialize();
    }
}