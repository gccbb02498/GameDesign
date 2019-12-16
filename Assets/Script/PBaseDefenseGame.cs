using System;
using UnityEngine;

public class PBaseDefenseGame
{
    private static PBaseDefenseGame _instance;

    public static PBaseDefenseGame Instance
    {
        get
        {
            if (_instance == null)
                _instance = new PBaseDefenseGame(); return _instance;
        }
    }

    private bool m_bGameOver;

    private GameEventSystem      m_GameEventSystem      = null;
    private CampSystem           m_CampSystem           = null;
    private StageSystem          m_StageSystem          = null;
    private CharacterSystem      m_CharacterSystem      = null;
    private APSystem             m_APSystem             = null;
    private AchievementSystem    m_AchievementSystem    = null;

    private CampInfoUI m_CampInfoUI=null;

    public void Initinal()
    {
        m_bGameOver = false;
        m_GameEventSystem = new GameEventSystem(this);
        m_CampSystem = new CampSystem(this);
        m_StageSystem = new StageSystem(this);
        m_CharacterSystem = new CharacterSystem(this);
        m_APSystem = new APSystem(this);
        m_AchievementSystem = new AchievementSystem(this);

        m_CampInfoUI = new CampInfoUI(this);
    }

    public void Release()
    {

        m_GameEventSystem.Release();
        m_CampSystem.Release();
        m_StageSystem.Release();
        m_CharacterSystem.Release();
        m_APSystem.Release();
        m_AchievementSystem.Release();



    }

    public void Update()
    {
        InputProcess();

        m_GameEventSystem.Update();
        m_CampSystem.Update();
        m_StageSystem.Update();
        m_CharacterSystem.Update();
        m_APSystem.Update();
        m_AchievementSystem.Update();

        m_CampInfoUI.Update();
    }

    public bool ThisGameIsOver()
    {
        return m_bGameOver;
    }

    private void InputProcess()
    {
        if (Input.GetMouseButtonUp(0) == false)
            return;
        Ray ray =Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit[] hits =Physics.RaycastAll(ray);

        foreach(RaycastHit hit in hits)
        {

        }
    }
    //public int GetUnitCount(ENum_Soldier emSolider)
    //{
    //    return m_CharacterSystem.GetUnitCount(emSolider);
    //}

    //public int GetUnitCount(ENum_Enemy emEnemy)
    //{
    //    return m_CharacterSystem.GetUnitCount(emEnemy);
    //}
}