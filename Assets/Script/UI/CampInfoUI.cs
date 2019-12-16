using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;

public class CampInfoUI : IUserInterface
{
    private ICamp m_Camp=null;

    private Button  m_LevelUpBtn        = null;
    private Button  m_WeaponLvUpBtn     = null;
    private Button  m_TrainBtn          = null;
    private Button  m_CancelBtn         = null;
    private Text    m_AliveCountTxt     = null;
    private Text    m_CampLvTxt         = null;
    private Text    m_WeaponLvTxt       = null;
    private Text    m_TrainCostText     = null;
    private Text    m_TrainTimerText    = null;
    private Text    m_OnTrainCountTxt   = null;
    private Text    m_CampNameTxt       = null;
    private Image   m_CampImage         = null;

    public CampInfoUI(PBaseDefenseGame PBDGame) : base(PBDGame)
    {
        Initialize();
    }

    public override void Initialize()
    {
        m_RootUI = UITool.FindUIGameObject("CampInfoUI");

        m_LevelUpBtn                    =UITool.GetUIComponent<Button>(m_RootUI, "LevelUpBtn");
        m_WeaponLvUpBtn                 =UITool.GetUIComponent<Button>(m_RootUI, "WeaponLvUpBtn");
        m_TrainBtn                      =UITool.GetUIComponent<Button>(m_RootUI, "TrainBtn");
        m_CancelBtn                     =UITool.GetUIComponent<Button>(m_RootUI, "CancelBtn");
        m_AliveCountTxt                 =UITool.GetUIComponent<Text>(m_RootUI, "AliveCountTxt");
        m_CampLvTxt                     =UITool.GetUIComponent<Text>(m_RootUI, "CampLvTxt");
        m_WeaponLvTxt                   =UITool.GetUIComponent<Text>(m_RootUI, "WeaponLvTxt");
        m_TrainCostText                 =UITool.GetUIComponent<Text>(m_RootUI, "TrainCostText");
        m_TrainTimerText                =UITool.GetUIComponent<Text>(m_RootUI, "TrainTimerText");
        m_OnTrainCountTxt               =UITool.GetUIComponent<Text>(m_RootUI, "OnTrainCountTxt");
        m_CampNameTxt                   =UITool.GetUIComponent<Text>(m_RootUI, "CampNameTxt");
        m_CampImage                     =UITool.GetUIComponent<Image>(m_RootUI, "CampImage");

    }

    public override void Release()
    {
        base.Release();
    }

    public override void Update()
    {
        ShowOnTrainInfo();


    }

    private void ShowOnTrainInfo()
    {
        throw new NotImplementedException();
    }
}
