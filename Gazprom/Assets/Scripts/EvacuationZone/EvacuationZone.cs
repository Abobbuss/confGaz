using UnityEngine;
using UnityEngine.Events;

public class EvacuationZone : MonoBehaviour
{
    [SerializeField] private EvacuationZoneTriger _evacuationZoneTriger;
    [SerializeField] private EvacuationZoneUI _evacuationZoneUI;
    [SerializeField] private StartEvacuation _triggerStartEvacuation;

    public UnityAction StartEvacuation;

    private void OnEnable()
    {
        _evacuationZoneTriger.InEvacuationZone += InEvacuationZoneTriger;
        _triggerStartEvacuation.StartEvacuationEvent += Evacuation;
    }

    private void OnDisable()
    {
        _triggerStartEvacuation.StartEvacuationEvent -= Evacuation;
        _evacuationZoneTriger.InEvacuationZone -= InEvacuationZoneTriger;
    }

    private void InEvacuationZoneTriger()
    {

    }

    private void Evacuation()
    {
        StartEvacuation?.Invoke();
    }
}
