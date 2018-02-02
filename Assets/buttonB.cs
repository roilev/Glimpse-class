using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buttonB : MonoBehaviour {

	public GameObject character1;
	public GameObject character2;
	public GameObject character3;
	public GameObject character4;

	// Use this for initialization
	void Start () {
		Button btn = GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	
	void TaskOnClick()
	{
		Debug.Log("Changing character");
		if (character1.activeSelf == true) {
			character1.SetActive (false);
			character2.SetActive (true);

		} else if (character2.activeSelf == true) {
			character2.SetActive (false);
			character3.SetActive (true);

		} else if (character3.activeSelf == true) {
			character3.SetActive (false);
			character4.SetActive (true);

		} else if (character4.activeSelf == true) {
			character4.SetActive (false);
			character1.SetActive (true);
		}
	}
}
