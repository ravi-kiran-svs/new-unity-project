using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour  {

    public Button buttonFire;
    public Button buttonWater;
    public Button buttonWind;
    void Start()    {
        buttonFire.onClick.AddListener(OnFireButtonPress);
        buttonWater.onClick.AddListener(OnWaterButtonPress);
        buttonWind.onClick.AddListener(OnWindButtonPress);
    }

    private void OnFireButtonPress()    {
        ChangeScene("FireLevel");
    }

    private void OnWaterButtonPress()
    {
        ChangeScene("WaterLevel");
    }

    private void OnWindButtonPress()
    {
        ChangeScene("WindLevel");
    }

    private void ChangeScene(string levelName) {
        SceneManager.LoadScene(levelName);
    }
}
