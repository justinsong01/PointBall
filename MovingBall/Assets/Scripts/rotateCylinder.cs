using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCylinder : MonoBehaviour {
    public Color altColor = Color.black;
    public Renderer rend;
    // Use this for initialization
    void Start () {
        
        //Get the renderer of the object so we can access the color
        rend = GetComponent<Renderer>();
        //Set the initial color (0f,0f,0f,0f)
        rend.material.color = altColor;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.G))
        {
            //Alter the color          
            altColor.g += 0.1f;
            //Assign the changed color to the material.
            rend.material.color = altColor;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            //Alter the color           
            altColor.r += 0.1f;
            //Assign the changed color to the material. 
            rend.material.color = altColor;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            //Alter the color            
            altColor.b += 0.1f;
            //Assign the changed color to the material. 
            rend.material.color = altColor;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Alter the color          
            altColor.a += 0.1f;
            //Assign the changed color to the material. 
            rend.material.color = altColor;
        }
        transform.Rotate(new Vector3(0, 0, 10) * Time.deltaTime);
    }

}
