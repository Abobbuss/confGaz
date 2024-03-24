using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public UnityAction StopPlaying;
    public UnityAction Playing;

    private void Start()
    {
        StartPlaying();
    }

    public void StopPlay()
    {
        StopPlaying?.Invoke();
    }

    public void StartPlaying()
    {
        Playing?.Invoke();
    }
}
