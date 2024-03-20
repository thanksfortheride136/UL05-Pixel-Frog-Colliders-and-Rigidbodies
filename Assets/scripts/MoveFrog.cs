using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFrog : MonoBehaviour
{
    public int moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
        transform.up = Vector3.up;
    }

    // Update is called once per frame
    void Update()
    {
      transform.up = Vector3.up;
      transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 0f, 0f); 
    }

    
}
