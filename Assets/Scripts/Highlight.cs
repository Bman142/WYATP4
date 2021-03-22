using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    Color highlight = Color.red;
    Color normal;
    Renderer r;

    private void Start()
    {
        r = this.GetComponent<Renderer>();
        normal = r.material.color;
    }
    private void OnMouseEnter()
    {
        r.material.color= highlight;
    }
    private void OnMouseExit()
    {
        r.material.color = normal;
    }

}

