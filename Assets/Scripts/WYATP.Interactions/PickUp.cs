using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WYATP.Interactions
{
    public class PickUp : Interactable
    {
        [SerializeField] GameObject prefabObject;
        [SerializeField] Vector3 originLocation;
        [SerializeField] Quaternion originRotation;

        [SerializeField] Vector3 viewingLocation;

        bool heldItem = false;
        public void Interact() 
        {
            if (heldItem)
            {
                OnPutDown();
            }
            else if (!heldItem)
            {
                OnPickup();
            }
            void OnPickup()
            {
                this.transform.SetParent(PlayerControl.Player.Instance.gameObject.transform);
                originLocation = this.transform.position;
                originRotation = this.transform.rotation;
                this.transform.position = viewingLocation;
            }

            void OnPutDown()
            {
                this.transform.SetParent(null);
                this.transform.position = originLocation;
                this.transform.rotation = originRotation;
            } 
        }
    }
}
