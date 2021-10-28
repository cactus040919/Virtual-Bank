using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMgr : MonoBehaviour
{
    public string SceneToLoad;

    public void SceneChange()
    {
        LoadingSceneController.LoadScene(SceneToLoad);
    }
}
