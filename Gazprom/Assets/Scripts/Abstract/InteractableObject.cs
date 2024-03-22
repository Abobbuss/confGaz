using UnityEngine;

public abstract class InteractableObject :  MonoBehaviour, IInteraction
{
    public abstract void Interact();
    public abstract bool CanInteract();
}
