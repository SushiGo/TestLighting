using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectObject : MonoBehaviour {

    GameObject Penjelasan_Sekarang;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse is down");

            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f)), Camera.main.transform.forward, out hitInfo, 50f);
            if (hit)
            {
                if (hitInfo.transform.gameObject.tag == "obj_pilihan")
                {
                    print(hitInfo.transform.gameObject.name);
                    GameObject[] UI_Penjelasan = GameObject.FindGameObjectsWithTag("UI Penjelasan");
                    int i = 0;
                    while (UI_Penjelasan[i].name != hitInfo.transform.gameObject.name)
                    {
                        i++;
                    }
                    if(UI_Penjelasan[i].name == hitInfo.transform.gameObject.name)
                    {
                        this.gameObject.GetComponentInParent<Movement>().CanMove = false;
                        Penjelasan_Sekarang = UI_Penjelasan[i];
                        UI_Penjelasan[i].transform.localScale = new Vector3(1, 1, 1);
                    }
                }
            }
            Debug.Log("Mouse is down");
        }
        if (Input.GetMouseButtonDown(1) && Penjelasan_Sekarang != null)
        {
            this.gameObject.GetComponentInParent<Movement>().CanMove = true;
            Penjelasan_Sekarang.transform.localScale = new Vector3(0, 0, 0);
            Penjelasan_Sekarang = null;
        }
    }
}
