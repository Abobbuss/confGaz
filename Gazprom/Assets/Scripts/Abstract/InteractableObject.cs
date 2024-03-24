using UnityEngine;

public abstract class InteractableObject :  MonoBehaviour, IInteraction
{
    public abstract void Interact();
    public abstract bool CanInteract();

    protected virtual void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && CanInteract())
            Interact();
    }
}
