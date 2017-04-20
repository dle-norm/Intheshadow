using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGameplay : MonoBehaviour {

    private Transform selected;
    private Vector3 mousePos;
    private Vector3 offset;

    private void OnMouseDrag()
    {
        if (selected)
        {
            mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            if ((Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.LeftShift)) && SceneManager.GetActiveScene().buildIndex >= 6)
            {
                selected.position = new Vector3(mousePos.x + offset.x, mousePos.y + offset.y, selected.position.z);
            }
            else if (Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl) && SceneManager.GetActiveScene().buildIndex >= 4)
            {
                if (selected.position.x < (mousePos.x + offset.x))
                {
                    selected.Rotate(new Vector3(0, -1f, 0));
                }
                else if (selected.position.x > (mousePos.x + offset.x))
                {
                    selected.Rotate(new Vector3(0, 1f, 0));
                }
            }
            else if (Input.GetKey(KeyCode.Z) && SceneManager.GetActiveScene().buildIndex >= 5)
            {
                if (selected.position.y < (mousePos.y + offset.y))
                {
                    selected.Rotate(new Vector3(1f, 0, 0));
                }
                else if (selected.position.y > (mousePos.y + offset.y))
                {
                    selected.Rotate(new Vector3(-1f, 0, 0));
                }
            }
            else
            {
                if (selected.position.x < (mousePos.x + offset.x))
                {
                    selected.Rotate(new Vector3(0, 0, -1f));
                }
                else if (selected.position.x > (mousePos.x + offset.x))
                {
                    selected.Rotate(new Vector3(0, 0, 1f));
                }
            }
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hitInfo = new RaycastHit();
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo) && hitInfo.transform.tag == "object")
                {
                    selected = hitInfo.transform;
                    offset = selected.position - Camera.main.ScreenToViewportPoint(Input.mousePosition);
                }
            }
    }
}
