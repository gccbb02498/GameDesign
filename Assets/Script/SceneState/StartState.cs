public class StartState : ISceneState
{

    public StartState(SceneStateContorller Controller) : base(Controller)
    {
        this.StateName = "StartState";
    }

    public override void StateBegin()
    {
    }

    public override void StateUpdate()
    {
        m_Controller.SetState(new MainMenuState(m_Controller), "MainMenuState");
    }
}