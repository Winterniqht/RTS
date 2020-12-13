using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitProperties : MonoBehaviour
{
    public bool selected;
    public bool Selected {
        get{return selected;} 
        set{selected = value;}
    }
}
