using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnVariableBreakScript : MonoBehaviour
{
    [SerializeField]
    float healthPoints = 100f; //this value can be changed in the inspector

    private void OnMouseDown()
    {
        gameObject.GetComponent<Collider>().isTrigger = false;
        gameObject.AddComponent<Rigidbody>();
        this.enabled = false;
    }
}