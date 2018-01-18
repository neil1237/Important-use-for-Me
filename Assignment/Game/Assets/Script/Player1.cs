using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {
    public float maximumvaluey;
    public int Speed = 16;
    void Update()
    {
            Vector3 moving = new Vector3(Input.GetAxis("Vertical") * Speed,0, 0);
            this.transform.Translate(moving * Time.deltaTime);
            Vector3 pos = transform.position;
            pos.y=Mathf.Clamp(pos.y,-4, 4);
            transform.position = pos;
    }
        
    }
