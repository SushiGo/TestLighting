using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPatungBesar : MonoBehaviour {

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
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        print(angle);

        if (angle >= 11.25 && angle <= 33.75)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[9]);
        }
        else if (angle >= 33.75 && angle <= 56.25)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[10]);
        }
        else if (angle >= 56.25 && angle <= 78.75)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[11]);
        }
        else if (angle >= 78.75 && angle <= 101.25)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[12]);
        }
        else if (angle >= 101.25 && angle <= 123.75)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[13]);
        }
        else if (angle >= 123.75 && angle <= 146.25)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[14]);
        }
        else if (angle >= 146.25 && angle <= 168.75)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[15]);
        }
        else if (angle >= 168.75 && angle <= 191.25)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[0]);
        }
        else if (angle >= 191.25 && angle <= 213.75)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[1]);
        }
        else if (angle >= 213.75 && angle <= 236.25)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[2]);
        }
        else if (angle >= 236.25 && angle <= 258.75)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[3]);
        }
        else if (angle >= 258.75 && angle <= 281.25)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[4]);
        }
        else if (angle >= 281.25 && angle <= 303.75)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[5]);
        }
        else if (angle >= 303.75 && angle <= 326.25)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[6]);
        }
        else if (angle >= 326.25 && angle <= 348.75)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[7]);
        }
        else if (angle >= 348.75 && angle <= 360 || angle >= 0 && angle <= 11.25)
        {
            materialPatung.SetTexture("_MainTex", texturePatung[8]);
        }
    }
}
