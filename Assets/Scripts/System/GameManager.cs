using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;
using static UnityEditor.PlayerSettings;

public class GameManager : MonoBehaviour
{
    public List<Trash> trashes;
    [SerializeField] TextMeshProUGUI tmp;

    public Transform dot;

    [SerializeField] Transform playerTransform;

    float uiTimer = 0;
    [SerializeField] ControllerManager leftController;
    [SerializeField] ControllerManager rightController;

    [SerializeField] GameObject ui;
    public bool UIActiveStatus => ui.activeSelf;

    public static GameManager instance;

    LevelManager levelManager;
    public LevelManager LevelManager => levelManager;

    ScriptManager scriptManager;
    public ScriptManager ScriptManager => scriptManager;

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
        soundController = GetComponent<SoundController>();

        #endregion

    }

    public void SetActiveUIPanel()
    {
        leftController.btnTimer = 0.5f;
        rightController.btnTimer = 0.5f;
        ui.SetActive(true);
        ui.transform.SetParent(playerTransform);
        ui.transform.localPosition = new Vector3(0, -0.2f, 0.5f);
        ui.transform.localRotation = Quaternion.Euler(0, 0, 0);
        ui.transform.SetParent(null);
        uiTimer = 3.0f;
    }

    public void SetDeactiveUIPanel()
    {
        leftController.btnTimer = 0.5f;
        rightController.btnTimer = 0.5f;
        ui.SetActive(false);
        ui.transform.SetParent(playerTransform);
        ui.transform.localPosition = new Vector3(0, -0.2f, 0.5f);
        ui.transform.SetParent(null);
        uiTimer = 3.0f;
    }

    private void Update()
    {
        dot.gameObject.SetActive(ui.activeSelf);

        if (leftController.IsTriggerActivated && rightController.IsTriggerActivated && !ui.activeSelf)
        {
            SetActiveUIPanel();
        }

        if (Vector3.Distance(ui.transform.position, playerTransform.position) >= 5 && ui.activeSelf)
        {
            uiTimer -= Time.deltaTime;
            if (uiTimer <= 0) 
            {
                ui.SetActive(false);
            }
        }

        int cnt = 0;
        foreach (var itr in trashes)
        {
            if (itr.gameObject.activeSelf)
                cnt++;
        }

        tmp.text = cnt + "";
        
    }
}
