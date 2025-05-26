using UnityEngine;

public abstract class InteractionManager : MonoBehaviour
{
    [SerializeField] private string _message;

    public string GetMessage() { return _message; }

    public void BaseInteract() 
    {
        Interact();
    }

    protected virtual void Interact() { }
}
