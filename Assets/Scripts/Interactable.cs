using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    [SerializeField] UnityEvent Interact;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnInteract()
    {
        Interact.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
