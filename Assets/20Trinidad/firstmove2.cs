using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstmove2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lastPosition = GetComponent<Transform>().position;
        //Move UP&Down
        if(Input.GetKey(KeyCode.Q)){
            Debug.Log("We Pressed the key Q");

            GetComponent<Transform>().position =new Vector3(lastPosition.x,GetComponent<Transform>().position.y + 0.5f,lastPosition.z); 
        }

        if(Input.GetKey(KeyCode.E)){
            
            GetComponent<Transform>().position =new Vector3(lastPosition.x,GetComponent<Transform>().position.y - 0.5f,lastPosition.z); 
        }
     
        //Move Left& Right
        if(Input.GetKey(KeyCode.W)){

            GetComponent<Transform>().position =new Vector3(GetComponent<Transform>().position.x - 0.5f,lastPosition.y,lastPosition.z); 
        }

        if(Input.GetKey(KeyCode.S)){
            
            GetComponent<Transform>().position =new Vector3(GetComponent<Transform>().position.x + 0.5f,lastPosition.y,lastPosition.z); 
        }

        //Move Forward & Back
        if(Input.GetKey(KeyCode.D)){

            GetComponent<Transform>().position =new Vector3(lastPosition.x,lastPosition.y,GetComponent<Transform>().position.z + 0.5f); 
        }

        if(Input.GetKey(KeyCode.A)){
            
            GetComponent<Transform>().position =new Vector3(lastPosition.x,lastPosition.y,GetComponent<Transform>().position.z - 0.5f); 
        }
    }
}
