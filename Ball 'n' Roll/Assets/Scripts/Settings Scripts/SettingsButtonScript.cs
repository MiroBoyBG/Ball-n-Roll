﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButtonScript : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject gameMusic;
	public GameObject mainMenuMusic;
    public void OnButtonClick()
    {
		DontDestroyOnLoad(transform.gameObject);
		PlayButtonScript.audioLoader.allowSceneActivation = false;
		SceneManager.LoadScene("Settings Menu");
		//Destroy();
    }

}
