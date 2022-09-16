using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

    [SerializeField] Vector3 rotation;
    [SerializeField] float moveSpeed;

    void Update()
    {
        gameObject.transform.Rotate(rotation * moveSpeed * Time.deltaTime);
    }

}
