using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    Scene uiScene;
    Scene inGameScene;

    private void Start()
    {
        uiScene = SceneManager.GetSceneByName(GameConsts.SceneName.LobbyScene);
        inGameScene = SceneManager.GetSceneByName(GameConsts.SceneName.Level1Scene);
    }

    public void EnterLobby()
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(GameConsts.SceneName.LobbyScene));
        SceneManager.LoadScene(GameConsts.SceneName.LobbyScene, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(GameConsts.SceneName.Level1Scene);
        GameManager.instance.SoundController.PlayInGameBGM(false);
    }

    public void EnterInGame()
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(GameConsts.SceneName.LobbyScene));
        SceneManager.LoadScene(GameConsts.SceneName.Level1Scene, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(GameConsts.SceneName.LobbyScene);
        GameManager.instance.SoundController.PlayInGameBGM(true);
    }

}
