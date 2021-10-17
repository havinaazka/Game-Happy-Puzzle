using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rsthard : MonoBehaviour {

	public GameObject parent_puzzle, senyum;
	// Use this for initialization
	void Start () {
		
	}
	
	void OnMouseUp() {
		for (int i=0;i<16;i++){
			parent_puzzle.transform.GetChild(i).GetComponent<drghard>().on_tempel=false;
			parent_puzzle.transform.GetChild(i).GetComponent<drghard>().on_pos=false;
			parent_puzzle.transform.GetChild(i).position = parent_puzzle.transform.GetChild(i).GetComponent<drghard>().pos_awal;
			parent_puzzle.transform.GetChild(i).localScale = parent_puzzle.transform.GetChild(i).GetComponent<drghard>().scale_awal;
		}
		senyum.SetActive(false);
		parent_puzzle.GetComponent<fdbckhard>().selesai = false;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
