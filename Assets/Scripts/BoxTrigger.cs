using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger : Interactable
{
    bool triggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !triggered)
        {
            this.OnInteract();
            triggered = true;
        }
    }

}
