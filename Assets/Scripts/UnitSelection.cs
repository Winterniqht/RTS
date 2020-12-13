using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelection : MonoBehaviour
{
    public RectTransform selectionBox;
    private Vector2 startPos;
    
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            startPos = Input.mousePosition;

        if(Input.GetMouseButton(0))
            UpdateSelectionBox(Input.mousePosition);

        if(Input.GetMouseButtonUp(0))
        {
            ReleaseSelectionBox();
        }
    }

    void UpdateSelectionBox(Vector2 curMousePos)
    {
        if(!selectionBox.gameObject.activeInHierarchy)
            selectionBox.gameObject.SetActive(true);

        float width = curMousePos.x - startPos.x;
        float height = curMousePos.y - startPos.y;

        selectionBox.sizeDelta = new Vector2(Mathf.Abs(width), Mathf.Abs(height));
        selectionBox.anchoredPosition = startPos + new Vector2(width / 2, height / 2);
    }

    void ReleaseSelectionBox()
    {
        selectionBox.gameObject.SetActive(false);
        Vector2 min = selectionBox.anchoredPosition - (selectionBox.sizeDelta / 2);
        Vector2 max = selectionBox.anchoredPosition + (selectionBox.sizeDelta / 2);
    //     PlayerUnits pUnits = GetComponent<PlayerUnits>();

    //     foreach (GameObject unit in pUnits.SelectedUnits)
    //     {
    //         // Vector3 screenPos = Camera.WorldToScreenPoint(unit.transform.position);

    // //         if(screenPos.x > min.x && screenPos.x < max.x && screenPos.y > min.y && screenPos.y < max.y)
    // //         {
    // //             selectionUnits.Add(unit);
    // //             unit.ToggleSelctionVisual(true);
    // //         }
    //     }
    }
}
