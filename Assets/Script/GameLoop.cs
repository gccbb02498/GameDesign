using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    SceneStateContorller  m_SceneStateContorller=new SceneStateContorller();
    
    void Awake()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);

        UnityEngine.Random.InitState((int)DateTime.Now.Ticks);
    }
    // Start is called before the first frame update
    void Start()
    {
        m_SceneStateContorller.SetState(new StartState(m_SceneStateContorller),"");
    }

    // Update is called once per frame
    void Update()
    {
        m_SceneStateContorller.StateUpdate();
    }
}
