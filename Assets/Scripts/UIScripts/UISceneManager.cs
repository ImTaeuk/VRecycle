using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UISceneManager : MonoBehaviour
{
    [SerializeField] GameObject settingCanvas;
    [SerializeField] GameObject mainCanvas;
    [SerializeField] GameObject statusCanvas;

    public void SetActiveMainCanvas()
    {
        statusCanvas.SetActive(false);
        settingCanvas.SetActive(false);
        mainCanvas.SetActive(true);
    }

    public void SetActiveSettingCanvas()
    {
        statusCanvas.SetActive(false);
        settingCanvas.SetActive(true);
        mainCanvas.SetActive(false);
    }

    public void SetActiveStatusCanvas()
    {
        statusCanvas.SetActive(true);
        settingCanvas.SetActive(false);
        mainCanvas.SetActive(false);
    }

    public void CloseCanavses()
    {
        statusCanvas.SetActive(false);
        settingCanvas.SetActive(false);
        mainCanvas.SetActive(false);
    }

    [SerializeField] Slider slider;

    [SerializeField] FadeScript fadeScript;
    IEnumerator GoToSceneRoutine()
    {
        fadeScript.FadeOut();
        yield return new WaitForSeconds(fadeScript.fadeDuration);
    }

    public void FadeEffect()
    {
        StartCoroutine(GoToSceneRoutine());
    }

    public void PlayClickSound()
    {
        GameManager.instance.SoundController.PlayClickSound();
    }

    public void ChangeVolume(float val)
    {
        Debug.Log(slider.value);
        slider.value += val;
        GameManager.instance.SoundController.ControlVolume(slider.value);
    }
}