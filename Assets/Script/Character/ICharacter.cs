using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AI;

public abstract class ICharacter
{
    protected string m_Name=string.Empty;

    protected GameObject    m_GameObject    =null;
    protected NavMeshAgent  m_NavAgent      =null;

    public ICharacter() { }

    public void SetGameObject(GameObject theGameObject)
    {
        m_GameObject = theGameObject;
        m_NavAgent = m_GameObject.GetComponent<NavMeshAgent>();
    }
}

