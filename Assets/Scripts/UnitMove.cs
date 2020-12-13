using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMove : MonoBehaviour
{
    public float speed;

    private Vector2 targetPosition;
    public bool Selected { get; set; } = false;
    public Vector2 TargetPosition { get => targetPosition; set => targetPosition = value; }

    // Start is called before the first frame update
    void Start()
    {
        TargetPosition = new Vector2(0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {        
        if(Input.GetMouseButtonDown(1))
        {
            TargetPosition = Input.mousePosition;
            TargetPosition = Camera.main.ScreenToWorldPoint(new Vector3(TargetPosition.x, TargetPosition.y, 0.0f));
        }
        this.transform.position = Vector2.MoveTowards(this.transform.position, TargetPosition, speed * Time.deltaTime);
    }
}
