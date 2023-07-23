using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
RaycastHit hit;
public GameObject player;
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            if(Physics.Raycast(player.transform.position,player.transform.forward, out hit,Mathf.Infinity)){
                if(hit.collider.gameObject.tag=="enemy"){
                    Destroy(hit.collider.gameObject);         
                }
                else{
                Debug.Log("Missed!"); 
                }
            }
        }
        
    }
}
