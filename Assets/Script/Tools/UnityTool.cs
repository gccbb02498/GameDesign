using System;
using UnityEngine;

public class UnityTool
{
    public static GameObject FindGameObject(string GameObjectName)
    {
        GameObject pTmpGameObj=GameObject.Find(GameObjectName);
        if (pTmpGameObj == null)
        {
            Debug.LogWarning(string.Format("場景找不到GameObject[{0}]物件", GameObjectName));
            return null;
        }
        return pTmpGameObj;
    }

    public static GameObject FindChildGameObject(GameObject Container, string GameObjectName)
    {
        if (Container == null)
        {
            Debug.LogError("NGUICustonTools.GetChid : Container = null");
            return null;
        }
        Transform pGameObjectTF=null;

        if (Container.name == GameObjectName)
            pGameObjectTF = Container.transform;
        else
        {
            Transform[] allChildren=Container.transform.GetComponentsInChildren<Transform>();
            foreach (Transform child in allChildren)
            {
                if (child.name == GameObjectName)
                {
                    if (pGameObjectTF == null)
                        pGameObjectTF = child;
                    else
                        Debug.LogWarning(string.Format("Container[{0}]下找出重複的元件名稱[{1}]", Container.name, GameObjectName));

                }
            }
        }

        if (pGameObjectTF == null)
        {
            Debug.LogError(string.Format("元件[{0}]找不到子元件[{1}]", Container.name, GameObjectName));
            return null;
        }
        return pGameObjectTF.gameObject;
    }
}