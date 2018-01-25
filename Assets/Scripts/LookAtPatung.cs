using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPatung : MonoBehaviour {

    // Use this for initialization
    public GameObject person;
    public Material materialPatung;
    public Texture[] texturePatung;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(person.transform);
        float angle = transform.eulerAngles.y;
        print(angle);

        if (angle >= 22.5 && angle <= 67.5)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[5]);
        }
        else if (angle >= 67.5 && angle <= 112.5)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[6]);
        }
        else if (angle >= 112.5 && angle <= 157.5)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[7]);
        }
        else if (angle >= 157.5 && angle <= 202.5)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[0]);
        }
        else if (angle >= 202.5 && angle <= 247.5)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[1]);
        }
        else if (angle >= 247.5 && angle <= 292.5)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[2]);
        }
        else if (angle >= 292.5 && angle <= 337.5)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[3]);
        }
        else if (angle >= 337.5 && angle <= 360 || angle >= 0 && angle <= 22.5)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[4]);
        }
    }
}
