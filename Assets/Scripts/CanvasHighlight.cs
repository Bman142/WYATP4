using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WYATP
{
    public class CanvasHighlight : MonoBehaviour
    {
        [SerializeField] Color highlight;
        Color normal;
        Image r;
        new bool enabled = false;
        public bool Enabled { get { return enabled; } set { enabled = value; } }

        private void Start()
        {
            r = this.GetComponent<Image>();
            normal = r.color;
        }
        private void OnMouseOver()
        {
            if (!enabled) { return; }
            float dist = Vector3.Distance(PlayerControl.Player.Instance.transform.position, this.transform.position);
            if (dist < 5)
            {
                r.color = highlight;
                
            }
            else
            {
                r.color = normal;
            }
        }
        private void OnMouseExit()
        {
            r.color = normal;
        }

        public void ToggleHighlight()
        {
            Enabled = !Enabled;
        }

    }
}
