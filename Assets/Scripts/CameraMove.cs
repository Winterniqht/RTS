using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    
    public float speed;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w") || Input.GetKey("up"))
        {
            this.transform.position += Vector3.up * Time.deltaTime * speed;
        }
        if(Input.GetKey("s") || Input.GetKey("down"))
        {
            this.transform.position += Vector3.down * Time.deltaTime * speed;
        }
        if(Input.GetKey("a") || Input.GetKey("left"))
        {
            this.transform.position += Vector3.left * Time.deltaTime * speed;
        }
        if(Input.GetKey("d") || Input.GetKey("right"))
        {
            this.transform.position += Vector3.right * Time.deltaTime * speed;
        }
    }
}
