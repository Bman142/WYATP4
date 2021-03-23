using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WYATP
{
    public class Highlight : MonoBehaviour
    {
        [SerializeField] Color highlight;
        Color normal;
        Renderer r;

        private void Start()
        {
            r = this.GetComponent<Renderer>();
            normal = r.material.color;
        }
        private void OnMouseOver()
        {
            float dist = Vector3.Distance(PlayerControl.Player.Instance.transform.position, this.transform.position);
            if (dist < 5)
            {
                r.material.color = highlight;
            }
            else 
            {
                r.material.color = normal;
                return; 
            }
        }
        private void OnMouseExit()
        {
            r.material.color = normal;
        }

        public void DisableHighlight()
        {
            this.GetComponent<Highlight>().enabled = false;
        }

    }
}
