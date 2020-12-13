using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiation : MonoBehaviour
{
    public GameObject sprite;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(sprite, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
    }
}
