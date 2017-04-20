using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinDouble : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    public float val;
    public float x2;
    public float y2;
    public float z2;
    public float val2;
    public float dist;
    public GameObject obj;
    public GameObject objbis;
    public GameObject objbis2;
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
    void Start()
    {
        if (PlayerPrefs.GetString("opt") ==  "lol")
        {
            val = PlayerPrefs.GetFloat("val");
            val2 = PlayerPrefs.GetFloat("val");
            dist = PlayerPrefs.GetFloat("dist");
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
            objbis.SetActive(false);
            objbis2.SetActive(true);
            UpdateUser();
            Save();
            finishMenu.SetActive(true);
        }
        yield return new WaitForSecondsRealtime(0);
    }

    // Update is called once per frame
    void Update()
    {
        float valx = (obj.transform.rotation.eulerAngles.x + 360) % 180;
        float valy = (obj.transform.rotation.eulerAngles.y + 360) % 180;
        float valz = (obj.transform.rotation.eulerAngles.z + 360) % 180;
        float permixp = (x + 360) % 180 + val;
        float permiyp = (y + 360) % 180 + val;
        float permizp = (z + 360) % 180 + val;
        float permixn = (x + 360) % 180 - val;
        float permiyn = (y + 360) % 180 - val;
        float permizn = (z + 360) % 180 - val;

        float valx2 = (objbis.transform.rotation.eulerAngles.x + 360) % 180;
        float valy2 = (objbis.transform.rotation.eulerAngles.y + 360) % 180;
        float valz2 = (objbis.transform.rotation.eulerAngles.z + 360) % 180;
        float permixp2 = (x2 + 360) % 180 + val2;
        float permiyp2 = (y2 + 360) % 180 + val2;
        float permizp2 = (z2 + 360) % 180 + val2;
        float permixn2 = (x2 + 360) % 180 - val2;
        float permiyn2 = (y2 + 360) % 180 - val2;
        float permizn2 = (z2 + 360) % 180 - val2;

        float distx = objbis.transform.position.x - obj.transform.position.x;
        float disty = objbis.transform.position.y - obj.transform.position.y;
        float distz = objbis.transform.position.z - obj.transform.position.z;

        int scene = SceneManager.GetActiveScene().buildIndex;

        if (valx > 150)
            valx = 0;
        if (valy > 150)
            valy = 0;
        if (valz > 150)
            valz = 0;
        if (valx2 > 150)
            valx2 = 0;
        if (valy2 > 150)
            valy2 = 0;
        if (valz2 > 150)
            valz2 = 0;

        if (scene == 6)
        {
            if (distx < 0)
            {
                distx = 50;
            }
        }
        else
        {
            if (distx < 0)
            {
                distx = distx * -1;
            }
        }
        if (disty < 0)
        {
            disty = disty * -1;
        }
        if (distz < 0)
        {
            distz = distz * -1;
        }

        if (((valx < permixp && valx > permixn)
            && (valy < permiyp && valy > permiyn)
            && (valz < permizp && valz > permizn)) &&
            ((valx2 < permixp2 && valx2 > permixn2)
            && (valy2 < permiyp2 && valy2 > permiyn2)
            && (valz2 < permizp2 && valz2 > permizn2)) &&
            (distx < dist && disty < dist && distz < dist)
            )
        {
            StartCoroutine(soundWaited());
        }
        if (Input.GetKey(KeyCode.X))
        {
            Debug.Log(permixp);
            Debug.Log(valx);
            Debug.Log(permixp2);
            Debug.Log(valx2);
        }
        if (Input.GetKey(KeyCode.C))
        {
            Debug.Log(permiyp);
            Debug.Log(valy);
            Debug.Log(permiyp2);
            Debug.Log(valy2);
        }
        if (Input.GetKey(KeyCode.V))
        {
            Debug.Log(permizp2);
            Debug.Log(valz);
            Debug.Log(permizp2);
            Debug.Log(valz2);
        }
        if (Input.GetKey(KeyCode.B))
        {
            Debug.Log(distx);
            Debug.Log(disty);
            Debug.Log(distz);
        }
    }
}
