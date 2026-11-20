using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Porte : MonoBehaviour
{
    private Animator animator;
    private XRSimpleInteractable interactable;

    private void Awake()
    {
        interactable = GetComponent<XRSimpleInteractable>();
        animator = GetComponentInParent<Animator>();
        Debug.Log("Porte : animator trouvé = " + (animator != null));
    }

    private void OnEnable()
    {
        interactable.hoverEntered.AddListener(OnHover);
        interactable.activated.AddListener(OnActivate);
    }

    private void OnDisable()
    {
        interactable.hoverEntered.RemoveListener(OnHover);
        interactable.activated.RemoveListener(OnActivate);
    }

    private void OnHover(HoverEnterEventArgs args)
    {
        Debug.Log("Porte : survol");
    }

    private void OnActivate(ActivateEventArgs args)
    {
        Debug.Log("Porte : trigger");
        animator.SetTrigger("Basculer");
    }
}
