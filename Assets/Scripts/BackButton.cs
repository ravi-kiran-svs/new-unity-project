using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackButton : MonoBehaviour	{

	public Button buttonBack;

	void Start()	{
		buttonBack.onClick.AddListener(OnBackButtonPress);
	}

	private void OnBackButtonPress()	{
		SceneManager.LoadScene("SampleScene");
	}
}
