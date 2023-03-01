using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchAction : MonoBehaviour
{
    public MeshRenderer playerMaterial;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ColorPlayer"))
        {
            playerMaterial.material.color = collision.gameObject.GetComponent<MeshRenderer>().material.color;

        }

    }
}
