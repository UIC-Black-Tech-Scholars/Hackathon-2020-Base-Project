using UnityEngine;
using System.Collections;

public class ResetPosition : MonoBehaviour
{
    public bool HideOnStartup = true;
    void Start()
    {
        if (HideOnStartup) gameObject.SetActive(false);
        transform.localPosition = new Vector3(0, 0, transform.localPosition.z);
    }
}
