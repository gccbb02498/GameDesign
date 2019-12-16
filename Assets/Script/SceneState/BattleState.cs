using System;

public class BattleState : ISceneState
{
  

    public BattleState(SceneStateContorller Controller) : base(Controller)
    {
        this.StateName = "BattleState";
    }
    public override void StateBegin()
    {
        PBaseDefenseGame.Instance.Initinal();
    }
    public override void StateEnd()
    {
        PBaseDefenseGame.Instance.Release();
    }
    public override void StateUpdate()
    {
        PBaseDefenseGame.Instance.Update();

        if (PBaseDefenseGame.Instance.ThisGameIsOver())
        {
            m_Controller.SetState(new MainMenuState(m_Controller), "MainMenuState");
        }
    }

   
}