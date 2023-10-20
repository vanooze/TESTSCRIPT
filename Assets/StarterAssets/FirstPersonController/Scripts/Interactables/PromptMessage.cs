using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromptMessage : Interactable
{
    [SerializeField]
    private GameObject door;
    private bool dooropen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //this function is where we will design our interaction code.
    protected override void Interact()
    {
        dooropen = !dooropen;
        door.GetComponent<Animator>().SetBool("IsOpen", dooropen);
    }
}
