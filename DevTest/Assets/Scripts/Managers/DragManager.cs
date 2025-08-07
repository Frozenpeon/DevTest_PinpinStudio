using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragManager : MonoBehaviour
{

    private Vector2 _screenPosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            _screenPosition = mousePos;
        }
       // mobile input
       // else if (Input.touchCount > 0)
            //_screenPosition = Input.GetTouch(0).position;

        else
            return;

        Ray ray = Camera.main.ScreenPointToRay(_screenPosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
            if (hit.collider != null)
            {
                InteractibleObject interac = hit.transform.gameObject.GetComponent<InteractibleObject>();
                if (interac != null)
                    interac.Interact();
            }


    }
}
