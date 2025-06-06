using UnityEngine;

public class Door : Interactable
{
    [SerializeField]
    private Animator doorAnimator;
    private bool doorOpen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected override void Interact()
    {
        doorOpen = !doorOpen;
        doorAnimator.SetBool("isOpen", doorOpen);
    }
    
}
