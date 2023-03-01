using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 screenPosition , worldPosition;
    public int movementSpeed = 100000;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            screenPosition = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(screenPosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo ))
            {
                worldPosition = hitInfo.point;
              
            }
            else
            {
                Debug.Log("nothing hit");
            }

            //transform.position = Vector3.Lerp(transform.position, worldPosition, movementSpeed * Time.deltaTime);
            transform.position = worldPosition;
        }
    }
}
