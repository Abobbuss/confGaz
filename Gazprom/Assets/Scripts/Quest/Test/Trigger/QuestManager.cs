using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(QuestTrigger))]
public class QuestManager : MonoBehaviour
{
    [SerializeField] private QuestTrigger _questTrigger;
    [SerializeField] private Player _player;
    [SerializeField] private UIQuest _uiQuest;

    private void OnEnable()
    {
        _questTrigger.StartingQuest += StartQuest;
        _uiQuest.QuizOver += EndQuest;
    }

    private void OnDisable()
    {
        _questTrigger.StartingQuest -= StartQuest;
        _uiQuest.QuizOver -= EndQuest;
    }

    private void StartQuest()
    {
        _player.StopPlay();
        _uiQuest.StartUIQuest();
    }

    private void EndQuest()
    {
        _player.StartPlaying();
    }
}
