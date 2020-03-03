using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraManager : MonoBehaviour
{
    public RawImage rawImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takePicture()
    {
        Debug.Log("Taking a picture");
        NativeCamera.Permission permission = NativeCamera.CheckPermission();
        if (permission == NativeCamera.Permission.ShouldAsk)
        {
            permission = NativeCamera.RequestPermission();
            if (permission == NativeCamera.Permission.Granted)
            {
                NativeCamera.TakePicture(takePictureCallback);
            }

        }
        if (permission == NativeCamera.Permission.Granted)
        {
            NativeCamera.TakePicture(takePictureCallback);
        }


    }

    public void takePictureCallback(string path)
    {
        rawImage.texture = NativeCamera.LoadImageAtPath(path);
    }
}
