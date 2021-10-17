using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour {

	public static int TargetSceneIndex = 1;
	public Slider LoadingBar;
	AsyncOperation async;
	IEnumerator StartLoadingProgress(int index){
		async = SceneManager.LoadSceneAsync (index);
		async.allowSceneActivation = false;
		while (async.isDone == false){
			LoadingBar.value = async.progress;
			if (async.progress >= 0.9f){
				LoadingBar.value = 1;
				async.allowSceneActivation = true;
			}
			yield return new WaitForSeconds (3);
			yield return null;
		} 
	}

	// Use this for initialization
	void Start () {
		StartCoroutine (StartLoadingProgress (TargetSceneIndex));
	}
	
	/*
	// Update is called once per frame
	void Update () {
		
	}
	*/
}
