using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace WYATP.Interactions
{
    public class Door : Interactable
    {
        [SerializeField] Transform doorWing;
        // Start is called before the first frame update

        private void Awake()
        {
            this.gameObject.tag = "Door";
        }
        void Start()
        {
        }
        public void OpenDoor(float rotation)
        {
            doorWing.rotation = Quaternion.AngleAxis(rotation, Vector3.up);
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}
