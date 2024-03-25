using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EvacuationZoneTriger : MonoBehaviour
{
    public event UnityAction InEvacuationZone;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player _))
            InEvacuationZone?.Invoke();
    }

/*    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Player _))
            
    }*/
}
