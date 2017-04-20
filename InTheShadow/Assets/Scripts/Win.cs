using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {
    public float x;
    public float y;
    public float z;
    public float val;
    public GameObject obj;
    public GameObject obj2;
    public GameObject finishMenu;
    private static int i = 0;

    public void UpdateUser()
    {
        PlayerPrefs.SetInt("lvl", SceneManager.GetActiveScene().buildIndex);
    }

    public void Save()
    {
        PlayerPrefs.Save();
    }

    // Use this for initialization
    void Start () {
        if (PlayerPrefs.GetString("opt") == "lol")
        {
            val = PlayerPrefs.GetFloat("val");
        }
        i = 0;
    }

    public IEnumerator soundWaited()
    {
        if (i == 0)
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().Stop();
            obj.GetComponent<AudioSource>().Play();
            GameObject.FindGameObjectWithTag("Finish").SetActive(false);
            i += 1;
            yield return new WaitForSecondsRealtime(4);
            obj.SetActive(false);
            obj2.SetActive(true);
            UpdateUser();
            Save();
            finishMenu.SetActive(true);
        }
        yield return new WaitForSecondsRealtime(0);
    }

    // Update is called once per frame
    void Update () {
        float valx = (obj.transform.rotation.eulerAngles.x + 360) % 180;
        float valy = (obj.transform.rotation.eulerAngles.y + 360) % 180;
        float valz = (obj.transform.rotation.eulerAngles.z + 360) % 180;
        float permixp = (x + 360) % 180 + val;
        float permiyp = (y + 360) % 180 + val;
        float permizp = (z + 360) % 180 + val;
        float permixn = (x + 360) % 180 - val;
        float permiyn = (y + 360) % 180 - val;
        float permizn = (z + 360) % 180 - val;

        if (valx > 150)
            valx = 0;
        if (valy > 150)
            valy = 0;
        if (valz > 150)
            valz = 0;

        if ((valx < permixp && valx > permixn)
            && (valy < permiyp && valy > permiyn)
            && (valz < permizp && valz > permizn)) 
        {
            StartCoroutine(soundWaited());
        }
        if(Input.GetKey(KeyCode.X))
        {
            Debug.Log(obj.transform.rotation.eulerAngles.x);
            Debug.Log(valx);
            Debug.Log(permixn);
            Debug.Log(permixp);
        }
        if (Input.GetKey(KeyCode.C))
        {
            Debug.Log(obj.transform.rotation.eulerAngles.y);
            Debug.Log(valy);
            Debug.Log(permiyn);
            Debug.Log(permiyp);
        }
        if (Input.GetKey(KeyCode.V))
        {
            Debug.Log(obj.transform.rotation.eulerAngles.z);
            Debug.Log(valz);
            Debug.Log(permizn);
            Debug.Log(permizp);
        }
    }
}
