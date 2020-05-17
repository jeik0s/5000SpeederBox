using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform playerTransform;
    public Transform cameraTransform;
    public Vector3 offset;


    // Update is called once per frame
    void Update()
    {
        cameraTransform.position = playerTransform.position + offset;
    }
}
