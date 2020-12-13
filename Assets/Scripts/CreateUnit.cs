using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateUnit : MonoBehaviour
{
    public GameObject unit;
    public GameObject player;
    private UnitProperties unitProperties;
    private PlayerUnits playerUnits;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        unitProperties = unit.GetComponent<UnitProperties>();
        playerUnits = player.GetComponent<PlayerUnits>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            if(player != null && playerUnits.NumSelected < playerUnits.MaxNumSelected)
            {
                GameObject unitInstance;
                unitInstance = Instantiate(unit, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity, player.transform);
                playerUnits.AddUnit(unitInstance);
                // unitInstance.Selected = true;
            }
        }
        if(Input.GetKeyDown("2"))
        {
            // unitProperties.Selected = true;
            // Debug.Log("Unit Selected is " + unitProperties.Selected);
        }
            
        if(Input.GetKeyDown("3"))
        {
            // unitProperties.Selected = false;
            // Debug.Log("Unit Selected is " + unitProperties.Selected);
        }
    }
}
