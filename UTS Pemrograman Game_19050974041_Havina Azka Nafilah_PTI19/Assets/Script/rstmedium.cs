using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rstmedium : MonoBehaviour {

	public GameObject parent_puzzle, senyum;
	// Use this for initialization
	void Start () {
		
	}
	
	void OnMouseUp() {
		for (int i=0;i<9;i++){
			parent_puzzle.transform.GetChild(i).GetComponent<drgmedium>().on_tempel=false;
			parent_puzzle.transform.GetChild(i).GetComponent<drgmedium>().on_pos=false;
			parent_puzzle.transform.GetChild(i).position = parent_puzzle.transform.GetChild(i).GetComponent<drgmedium>().pos_awal;
			parent_puzzle.transform.GetChild(i).localScale = parent_puzzle.transform.GetChild(i).GetComponent<drgmedium>().scale_awal;
		}
		senyum.SetActive(false);
		parent_puzzle.GetComponent<fdbckmedium>().selesai = false;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
