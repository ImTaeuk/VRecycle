using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    LevelManager levelManager;
    public LevelManager LevelManager => levelManager;

    ScriptManager scriptManager;
    public ScriptManager ScriptManager => scriptManager;

    UIManager uiManager;
    public UIManager UIManager => uiManager;

    SoundController soundController;
    public SoundController SoundController => soundController;


    private void Awake()
    {
        // Singleton Pattern -> Only one GameManager
        instance = this;
        Assert.IsNotNull(instance);


        #region Initalize Components

        levelManager = GetComponent<LevelManager>();
        scriptManager = GetComponent<ScriptManager>();
        uiManager = GetComponent<UIManager>();
        soundController = GetComponent<SoundController>();

        #endregion

    }
}
