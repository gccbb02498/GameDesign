using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public abstract class IUserInterface
{
    protected PBaseDefenseGame  m_PBDGame   =null;
    protected GameObject        m_RootUI    =null;
    private   bool              m_bActive   =true;

    public IUserInterface(PBaseDefenseGame PBDGame)
    {
        m_PBDGame = PBDGame;
    }

    public bool IsVisble()
    {
        return m_bActive;
    }

    public virtual void Show()
    {
        m_RootUI.SetActive(true);
        m_bActive = true;
    }
    public virtual void Hide()
    {
        m_RootUI.SetActive(false);
        m_bActive = false;
    }

    public virtual void Initialize() { }
    public virtual void Release() { }
    public virtual void Update() { }
}

