using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(QuestTrigger))]
public class QuestManager : MonoBehaviour
{
    [SerializeField] private QuestTrigger _questTrigger;
    [SerializeField] private Canvas _questCanvas;

    private void Awake()
    {
        _questTrigger = GetComponent<QuestTrigger>();
    }

    private void Start()
    {
        _questCanvas.enabled = false;
    }

    private void OnEnable()
    {
        _questTrigger.StartingQuest += StartQuest;
    }

    private void OnDisable()
    {
        _questTrigger.StartingQuest -= StartQuest;
    }

    private void StartQuest()
    {
        _questCanvas.enabled = true;
    }
}
