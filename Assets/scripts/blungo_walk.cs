using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blungo_walk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + 5* Input.GetAxis("Horizontal") * Time.deltaTime, transform.position.y, transform.position.z);
        // transform.position = this objects position 
        // Vector3 = how coordinates are stored aka Vector3(x,y,z)
        //Input.GetAxis("Horizontal") gives us a float value for the horizontal axis -1 to 1 , left to right 
    }
}
