using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blungo_walk : MonoBehaviour
{
    public float directionX;
    public float speed;
    public float minSpeed;
    public float maxSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            directionX = 1f;
        }
        else if (Input.GetKey("a"))
        {
            directionX = -1f;
        }
        else
        {
            directionX = 0f;
            speed = 5f;
        }
        
        transform.position = new Vector3(transform.position.x + directionX * speed * Time.deltaTime, transform.position.y, transform.position.z);


        //transform.position = this objects position 
        //Vector3 = how coordinates are stored aka Vector3(x,y,z)
        //Input.GetAxis("Horizontal") gives us a float value for the horizontal axis -1f to 1f , left to right
        //Time.deltaTime is the time between updates aka the time between frames 
    }
    private void FixedUpdate()
    {
//minSpeed = 5f
//maxSpeed = 8f
//speedDif = maxSpeed - min Speed
//speed += n * speedDif * Time.deltaTime;

        if(directionX!=0f && speed < maxSpeed)
        {
            speed += 2 * (maxSpeed - minSpeed) * Time.deltaTime;
            print(speed);
        }
    }
}



