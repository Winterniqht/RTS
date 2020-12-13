using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnits : MonoBehaviour
{
    private int numSelected = 0;
    private static int maxNumSelected = 5;
    private UnitMove unitMove;
    // public GameObject[] Units;
    public GameObject[] SelectedUnits = new GameObject [maxNumSelected];

    
    public int NumSelected {
        get{return numSelected;} 
    }
    public int MaxNumSelected {
        get{return maxNumSelected;}
    }

    public void AddUnit(GameObject unit)
    {
        if(numSelected < maxNumSelected)
        {
            SelectedUnits[numSelected] = unit;

            numSelected++;
        }
    }

    void Update()
    {
        if(Input.GetKeyDown("5"))
        {
            if(SelectedUnits[0] != null)
            {
                unitMove = SelectedUnits[0].GetComponent<UnitMove>();
                unitMove.Selected = !unitMove.Selected;
                Debug.Log("Unit Move = " + unitMove.Selected);
            }
                
        }
    }
}
