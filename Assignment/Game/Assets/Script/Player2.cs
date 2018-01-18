using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {
    
	void Start () {
		
	}
	
	void Update () {
     

        float mousePosition = (Input.mousePosition.y / Screen.height * 16) - 8;

        Vector3 PaddlePosition = new Vector3(gameObject.transform.position.x , mousePosition,gameObject.transform.position.z);
        

        PaddlePosition.y = Mathf.Clamp(mousePosition, -4f, 4f);

        gameObject.transform.position = PaddlePosition;



    }
}
