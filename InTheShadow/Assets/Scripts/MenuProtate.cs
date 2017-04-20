using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuProtate : MonoBehaviour {
	public Vector3 value;
	// Use this for initialization
	void Start () {

        if (PlayerPrefs.GetInt("lvl") < 3 || PlayerPrefs.GetInt("lvl") > 8)
        {
            PlayerPrefs.SetInt("lvl", 2);
            PlayerPrefs.Save();
        }
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(value);
	}
}
