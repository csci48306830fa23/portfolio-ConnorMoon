using UnityEngine;
using VelUtils.VRInteraction;

public class Grab : MonoBehaviour
{
    public VRGrabbableHand grabbableHand; // Reference to the VRGrabbableHand instance

    [SerializeField]
    public GameObject rightHandModel; // Reference to the right hand model GameObject

    private void Start()
    {
        if (grabbableHand != null)
        {
            // Subscribe to the OnGrab and OnRelease events
            grabbableHand.OnGrab += OnGrabHandler;
            grabbableHand.OnRelease += OnReleaseHandler;
        }
    }

    private void OnDestroy()
    {
        if (grabbableHand != null)
        {
            // Unsubscribe from the events to prevent memory leaks
            grabbableHand.OnGrab -= OnGrabHandler;
            grabbableHand.OnRelease -= OnReleaseHandler;
        }
    }

    private void OnGrabHandler(VRGrabbable grabbable)
    {
        // When OnGrab event occurs, deactivate the rightHandModel
        if (rightHandModel != null)
        {
            rightHandModel.SetActive(false);
        }
    }

    private void OnReleaseHandler(VRGrabbable grabbable)
    {
        // When OnRelease event occurs, activate the rightHandModel
        if (rightHandModel != null)
        {
            rightHandModel.SetActive(true);
        }
    }
}