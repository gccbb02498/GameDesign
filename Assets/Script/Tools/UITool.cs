using System;
using UnityEngine;

public class UITool
{
    private static GameObject m_CanvasObj=null;

    public static void ReleaseCanvas()
    {
        m_CanvasObj = null;
    }

    public static GameObject FindUIGameObject(string UIName)
    {
        if (m_CanvasObj == null)
            m_CanvasObj = UnityTool.FindGameObject("Canvas");
        if (m_CanvasObj == null)
            return null;
        return UnityTool.FindChildGameObject(m_CanvasObj, UIName);
    }

    public static T GetUIComponent<T>(string UIName) where T : UnityEngine.Component
    {
        GameObject UIRoot=GameObject.Find("Canvas");
        if (UIRoot == null)
        {
            Debug.Log("場景上沒有UI Canvas");
            return null;
        }

        return GetUIComponent<T>(UIRoot, UIName);
    }

    public static T GetUIComponent<T>(GameObject Container, string UIName) where T : UnityEngine.Component
    {
        GameObject ChildGameObject=UnityTool.FindChildGameObject(Container,UIName)   ;
        if (ChildGameObject == null)
            return null;

        T tempObj=ChildGameObject.GetComponent<T>();
        if (tempObj == null)
        {
            Debug.LogWarning(string.Format("元件[{0}]不是[{1}]", UIName, typeof(T)).ToString());
            return null;
        }
        return tempObj;
    }

  
}