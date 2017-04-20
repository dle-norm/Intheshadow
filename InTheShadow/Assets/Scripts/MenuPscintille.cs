using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPscintille : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	IEnumerator Wait()
	{
		Color sav = GetComponent<Text> ().color;
		yield return new WaitForSeconds(1f);   //Wait
		GetComponent<Text> ().color = Color.grey;
		yield return new WaitForSeconds(1f);
		GetComponent<Text> ().color = Color.black;
		yield return new WaitForSeconds(1f);
		GetComponent<Text> ().color = sav;
	}

	// Update is called once per frame
	void Update () {
		StartCoroutine (Wait());
	}
}
