using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    public GameObject gameObject;
    public void resetPosition(GameObject gameObject) 
    {
        gameObject.transform.position = Vector3.zero;
    }
}
