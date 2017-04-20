using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPChanson : MonoBehaviour {

	void Start () {
		StartCoroutine (Wait());
	}

	IEnumerator Wait()
	{
		GetComponent<Text> ().text = "No sleep";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "No sleep, until I’m done with finding the answer";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "Won’t stop";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "Won’t stop before I find the cure for this cancer";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "Sometimes";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "I feel like going down, I’m so disconnected";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "Somehow";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "I know that I am haunted to be wanted";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "I’ve been watching, I’ve been waiting";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "In the shadows for my time";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "I’ve been searching, I’ve been living";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "For tomorrows all my life";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "Oh oh oh oh";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "In the shadows";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "Oh oh oh oh";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "In the shadows";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "They say";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "That I must learn to kill before I can feel safe";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "But I,";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "I’d rather kill myself than turn into their slave";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "Sometimes";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "I feel that I should go and play with the thunder";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "Somehow";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "I just don’t wanna stay and wait for a wonder";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "I’ve been watching, I’ve been waiting";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "In the shadows for my time";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "I’ve been searching, I’ve been living";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "For tomorrow’s all my life";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "Lately, I’ve been walking, walking in circles";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "Watching, waiting for something";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "Feel me, touch me, heal me, come take me higher";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "I’ve been watching, I’ve been waiting";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "For tomorrow’s all my life";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "I’ve been watching";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "I’ve been waiting";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "I’ve been searching";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "I’ve been living";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "For tomorrow’s";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "Oh oh oh oh";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "In the shadows";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "Oh oh oh oh";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "In the shadows";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "I’ve been waiting";
		yield return new WaitForSeconds(2f);   //Wait
		GetComponent<Text> ().text = "In the shadows - The Rasmus";
		yield return new WaitForSeconds(2f);   //Wait
	}

	// Update is called once per frame
	void Update () {
		//StartCoroutine (Wait());
	}
}
