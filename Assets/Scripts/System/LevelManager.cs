using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    Scene curScene;

    private void Start()
    {


        EnterLobby();
    }

    public void EnterLobby()
    {
        if (SceneManager.GetActiveScene().name == GameConsts.SceneName.LobbyScene)
        {
            Debug.Assert(false, "Already in lobby");
        }

        SceneManager.LoadScene(GameConsts.SceneName.LobbyScene, LoadSceneMode.Additive);

        curScene = SceneManager.GetSceneByName(GameConsts.SceneName.LobbyScene);

        GameManager.instance.SoundController.PlayAudioSource(GameConsts.AudioSourceName.LobbyBGM, true);
    }

}
