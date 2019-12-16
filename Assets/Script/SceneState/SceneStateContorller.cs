﻿using UnityEngine;

public class SceneStateContorller
{
    private ISceneState m_State;
    private bool m_bRunBegin=false;

    public SceneStateContorller()
    {
    }

    public void SetState(ISceneState State, string LoadSceneName)
    {
        Debug.Log("SetState:" + State.ToString());
        m_bRunBegin = false;
        LoadScene(LoadSceneName);
        if (m_State != null)
            m_State.StateEnd();

        m_State = State;
    }

    private void LoadScene(string LoadSceneName)
    {
        if (LoadSceneName == null || LoadSceneName.Length == 0)
            return;
        Application.LoadLevel(LoadSceneName);
        //SceneManager.LoadScene(LoadSceneName
    }

    public void StateUpdate()
    {
        if (Application.isLoadingLevel)
            return;

        if (m_State != null && m_bRunBegin == false)
        {
            m_State.StateBegin();
            m_bRunBegin = true;
        }

        if (m_State != null)
            m_State.StateUpdate();
    }
}