using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RefreshTab : MonoBehaviour {

    public Sprite tab;
    public Sprite tab2;
    public Sprite lvl;
    public Sprite lvl2;
    public Sprite lvl3;
    public Sprite lvl4;
    public Sprite lvl5;
    public GameObject g1;
    public GameObject g2;
    public GameObject g3;
    public GameObject g4;
    public GameObject g5;
    public GameObject[] objectlist; 


	// Use this for initialization
	void Start () {
        objectlist = new GameObject[] { g1, g2, g3, g4, g5 };
        int i = 3;
		while (i != (PlayerPrefs.GetInt("lvl")+ 2) && i < 8)
        {
            objectlist[i - 3].gameObject.GetComponent<Image>().sprite = tab2;
            i += 1;
        }
        int j = i - 2;
        if (PlayerPrefs.GetInt("lvl") == 7)
            j = 7;
        while (j != 2)
        {
            if (j == 7)
                objectlist[j - 3].gameObject.GetComponent<Image>().sprite = lvl5;
            if (j == 6)
                objectlist[j - 3].gameObject.GetComponent<Image>().sprite = lvl4;
            if (j == 5)
                objectlist[j - 3].gameObject.GetComponent<Image>().sprite = lvl3;
            if (j == 4)
                objectlist[j - 3].gameObject.GetComponent<Image>().sprite = lvl2;
            if (j == 3)
                objectlist[j - 3].gameObject.GetComponent<Image>().sprite = lvl;
            j -= 1;

        }
        while (i != 8)
        {
            objectlist[i - 3].gameObject.GetComponent<Button>().enabled = false;
            i += 1;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
