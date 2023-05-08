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
    
    InputManager inputManager;
    public InputManager InputManager => inputManager;

    UIManager uiManager;
    public UIManager UIManager => uiManager;

    SoundController soundController;
    public SoundController SoundController => soundController;

    EffectManager effectManager;
    public EffectManager EffectManager => effectManager;

    PlayerController player;
    public PlayerController Player => player;


    private void Awake()
    {
        // Singleton Pattern -> Only one GameManager
        Assert.IsNotNull(instance);

        instance = this;

        #region Initalize Components

        levelManager = GetComponent<LevelManager>();
        scriptManager = GetComponent<ScriptManager>();
        uiManager = GetComponent<UIManager>();
        soundController = GetComponent<SoundController>();
        effectManager = GetComponent<EffectManager>();
        player = GetComponent<PlayerController>();
        InputManager inputManager = GetComponent<InputManager>();

        #endregion

    }
}
