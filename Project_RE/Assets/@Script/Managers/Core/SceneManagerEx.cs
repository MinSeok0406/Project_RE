using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerEx
{
    public BaseScene CurrentScene { get { return GameObject.FindObjectOfType<BaseScene>(); } }

    private Define.Scene nextScene;

    public string NextSceneName { get { return GetSceneName(nextScene); } }

	public void LoadScene(Define.Scene type)
    {
        Managers.Clear();
        nextScene = type;
        SceneManager.LoadScene("LoadingScene");
        //SceneManager.LoadScene(GetSceneName(type));
    }

    string GetSceneName(Define.Scene type)
    {
        string name = System.Enum.GetName(typeof(Define.Scene), type);
        return name;
    }

    public void Clear()
    {
        CurrentScene.Clear();
    }
}
