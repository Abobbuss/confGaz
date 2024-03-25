using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartEvacuation : MonoBehaviour
{
    public event UnityAction StartEvacuationEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player _))
            StartEvacuationEvent?.Invoke();
    }
}
