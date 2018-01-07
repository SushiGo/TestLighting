using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeTo : MonoBehaviour {

    public string sceneName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GoToScene(string sceneName)
    {
        Initiate.Fade(sceneName, Color.black, 2.0f);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Initiate.Fade(sceneName, Color.black, 2.0f);
        }
    }
}
