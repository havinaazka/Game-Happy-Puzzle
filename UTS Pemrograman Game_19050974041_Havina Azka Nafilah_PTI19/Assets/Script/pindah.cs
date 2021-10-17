using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pindah : MonoBehaviour {
	
	public void ToScene (string namaScene) {
		SceneManager.LoadScene(namaScene);
	}

	public void Quit(){
		Application.Quit();
	}
}
