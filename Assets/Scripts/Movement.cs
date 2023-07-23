using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement
 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"),0.0f,Input.GetAxis("Vertical"));  
        Vector3 speedvector = playerInput * Time.deltaTime *speed;
        transform.Translate(speedvector);
}}