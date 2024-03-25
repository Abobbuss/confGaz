using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvacuationZoneUI : MonoBehaviour
{
    [SerializeField] private EvacuationZone _evacuationZone;
    [SerializeField] private Canvas _canvas;
    [SerializeField] private GameObject _evacuationMessage;
    [SerializeField] private GameObject _inEvacuationZone;
    [SerializeField] private EvacuationZoneTriger _evacuationZoneTriger;

    private void Start()
    {
        _canvas.enabled = false;
        _evacuationMessage.SetActive(false);
        _inEvacuationZone.SetActive(false);
    }

    private void OnEnable()
    {
        _evacuationZone.StartEvacuation += EnableEvacuationMessage;
        _evacuationZoneTriger.InEvacuationZone += EnableEvacuationZonePanel;
    }

    private void OnDisable()
    {
        _evacuationZone.StartEvacuation -= EnableEvacuationMessage;
        _evacuationZoneTriger.InEvacuationZone -= EnableEvacuationZonePanel;
    }

    private void EnableEvacuationMessage()
    {
        _canvas.enabled = true;

        _evacuationMessage.SetActive(true);
    }

    private void EnableEvacuationZonePanel()
    {
        _evacuationMessage.SetActive(false) ;
        _inEvacuationZone.SetActive(true) ;
    }
}
