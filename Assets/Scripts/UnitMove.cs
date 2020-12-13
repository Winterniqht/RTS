﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMove : MonoBehaviour
{
    public float speed;

    private Vector2 targetPosition;
    private bool selected = false;
    public bool Selected {      
        get{return selected;} 
        set{selected = value;}
    }

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = new Vector2(0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {        
        if(Input.GetMouseButtonDown(1))
        {
            targetPosition = Input.mousePosition;
            targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(targetPosition.x, targetPosition.y, 0.0f));
        }
        this.transform.position = Vector2.MoveTowards(this.transform.position, targetPosition, speed * Time.deltaTime);
    }
}
