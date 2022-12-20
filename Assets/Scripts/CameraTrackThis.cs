using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrackThis : MonoBehaviour
{
    private Transform cameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        var myPosition = transform.position;
        cameraTransform.position = new Vector3(
            myPosition.x,
            myPosition.y,
            cameraTransform.position.z);
    }
}
