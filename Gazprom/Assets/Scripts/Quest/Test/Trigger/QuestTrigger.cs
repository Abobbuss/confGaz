using UnityEngine;
using UnityEngine.Events;

public class QuestTrigger : InteractableObject
{
    private bool _canInteract = false;

    public event UnityAction StartingQuest;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (CanInteract())
                Interact();
        }
    }

    public override bool CanInteract() => _canInteract;

    public override void Interact()
    {
        StartingQuest?.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player _))
            _canInteract = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Player _))
            _canInteract = false;
    }
}
