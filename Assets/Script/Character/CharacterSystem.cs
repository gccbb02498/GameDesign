using System;

public class CharacterSystem : IGameSystem
{
    public CharacterSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
    {
        Initialize();
    }
}