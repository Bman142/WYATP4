using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WYATP.Interactions
{
    public class Highlight : MonoBehaviour
    {
        [SerializeField] Color highlight;
        Color normal;
        Renderer r;
        new bool enabled = false;
        public bool Enabled { get { return enabled; } set { enabled = value; } }

        private void Start()
        {
            r = this.GetComponent<Renderer>();
            normal = r.material.color;
        }
        private void OnMouseOver()
        {
            if (!enabled) { return; }
            float dist = Vector3.Distance(PlayerControl.Player.Instance.transform.position, this.transform.position);
            if (dist < 5)
            {
                r.material.color = highlight;
            }
            else 
            {
                r.material.color = normal;
            }
        }
        private void OnMouseExit()
        {
            r.material.color = normal;
        }

        public void ToggleHighlight()
        {
            Enabled = !Enabled;
        }

    }
}
