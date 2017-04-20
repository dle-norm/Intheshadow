using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {
    private int scene;
    public GameObject valid;

    public IEnumerator soundWait()
    {
        valid.GetComponent<AudioSource>().Play();
        yield return new WaitForSecondsRealtime(1);
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    public void toSceneZero()
    {
        scene = 0;
        StartCoroutine(soundWait());
    }

    public void toSceneUn()
    {
        scene = 1;
        StartCoroutine(soundWait());
    }

    public void toSceneDeux()
    {
        scene = 2;
        StartCoroutine(soundWait());
    }

    public void toSceneTrois()
    {
        scene = 3;
        StartCoroutine(soundWait());
    }

    public void toSceneQuatre()
    {
        scene = 4;
        StartCoroutine(soundWait());
    }

    public void toSceneCinq()
    {
        scene = 5;
        StartCoroutine(soundWait());
    }

    public void toSceneSix()
    {
        scene = 6;
        StartCoroutine(soundWait());
    }

    public void toSceneSept()
    {
        scene = 7;
        StartCoroutine(soundWait());
    }

    public void toSceneHuit()
    {
        scene = 8;
        StartCoroutine(soundWait());
    }

    public void toSceneNeuf()
    {
        scene = 9;
        StartCoroutine(soundWait());
    }

    public void toEasy()
    {
        scene = 0;
        PlayerPrefs.SetString("opt", "lol");
        PlayerPrefs.SetFloat("val", 40);
        PlayerPrefs.SetFloat("dist", 10);
        PlayerPrefs.Save();
        StartCoroutine(soundWait());
    }

    public void toNormal()
    {
        scene = 0;
        PlayerPrefs.SetString("opt", "lol");
        PlayerPrefs.SetFloat("val", 30);
        PlayerPrefs.SetFloat("dist", 5);
        PlayerPrefs.Save();
        StartCoroutine(soundWait());
    }

    public void toHard()
    {
        scene = 0;
        PlayerPrefs.SetString("opt", "lol");
        PlayerPrefs.SetFloat("val", 20);
        PlayerPrefs.SetFloat("dist", 3);
        PlayerPrefs.Save();
        StartCoroutine(soundWait());
    }

    public void toReset()
    {
        scene = 0;
        PlayerPrefs.SetInt("lvl", 2);
        PlayerPrefs.Save();
        StartCoroutine(soundWait());
    }

    public void toSceneQuit()
    {
        Application.Quit();
    } 
}
