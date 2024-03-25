using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvacuationZoneUI : MonoBehaviour
{
    [SerializeField] private EvacuationZone _evacuationZone;
    [SerializeField] private Canvas _canvas;
    [SerializeField] private GameObject _evacuationMessage;

    private void Start()
    {
        _canvas.enabled = false;
        _evacuationMessage.SetActive(false);
    }

    private void OnEnable()
    {
        _evacuationZone.StartEvacuation += EnableEvacuationMessage;
    }

    private void OnDisable()
    {
        _evacuationZone.StartEvacuation -= EnableEvacuationMessage;
    }

    private void EnableEvacuationMessage()
    {
        _canvas.enabled = true;

        _evacuationMessage.SetActive(true);
    }
}
