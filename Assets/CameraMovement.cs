using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraPositionZ = -10;
    public Transform morgieTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 cameraPosition = morgieTransform.position;
        cameraPosition.z = cameraPositionZ;
        transform.position = cameraPosition;
    }
}
