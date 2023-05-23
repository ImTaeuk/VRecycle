using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    Scene curScene;

    private void Start()
    {
    }

    public void EnterLobby()
    {
        if (SceneManager.GetActiveScene().name == GameConsts.SceneName.LobbyScene)
        {
            Debug.Assert(false, "Already in lobby");
        }
        else
        {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(GameConsts.SceneName.LobbyScene));

            SceneManager.LoadScene(GameConsts.SceneName.LobbyScene, LoadSceneMode.Single);

            curScene = SceneManager.GetSceneByName(GameConsts.SceneName.LobbyScene);

            //GameManager.instance.SoundController.PlayAudioSource(GameConsts.AudioSourceName.LobbyBGM, true);
        }
            
    }

    public void EnterLevel1()
    {
        if (SceneManager.GetActiveScene().name == GameConsts.SceneName.Level1Scene)
        {
            Debug.Assert(false, "Already in Level1");
        }
        else
        {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(GameConsts.SceneName.Level1Scene));

            SceneManager.LoadScene(GameConsts.SceneName.LobbyScene, LoadSceneMode.Additive);

            curScene = SceneManager.GetSceneByName(GameConsts.SceneName.Level1Scene);

            //GameManager.instance.SoundController.PlayAudioSource(GameConsts.AudioSourceName.Level1BGM, true);
        }
    }

}
