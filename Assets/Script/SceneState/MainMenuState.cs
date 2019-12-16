using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class MainMenuState : ISceneState
{
    public MainMenuState(SceneStateContorller Controller) : base(Controller)
    {
        this.StateName = "MainMenuState";
    }

    public override void StateBegin()
    {
        Button tmpBtn=UITool.GetUIComponent<Button>("StartGameBtn");
        if (tmpBtn != null)
            tmpBtn.onClick.AddListener(() => OnStartGameBtnClick(tmpBtn));
    }

    private void OnStartGameBtnClick(Button theButton)
    {
        Debug.Log("OnStartGameBtnClick:" + theButton.gameObject.name);
        m_Controller.SetState(new BattleState(m_Controller), "BattleState");
    }
}