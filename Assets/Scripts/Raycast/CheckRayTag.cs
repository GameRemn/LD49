using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckRayTag : MonoBehaviour
{
    public UnityEvent<Vector3> onHitEvent;
    public string tag;
    public void SetHit(RaycastHit raycastHit)
    {
        if (raycastHit.transform.gameObject.CompareTag(tag))
            onHitEvent?.Invoke(raycastHit.point);
    }
}
