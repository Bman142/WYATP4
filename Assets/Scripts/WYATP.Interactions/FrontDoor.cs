using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

namespace WYATP.Interactions
{
    public class FrontDoor : StoryItem
    {
        bool letter = false;
        [SerializeField] Flowchart flowchart;
        new public void OnInteract()
        {
            if (!letter)
            {
                flowchart.ExecuteBlock("Door");
                letter = true;
            }
            else if (letter && PlayerControl.Player.Instance.GetComponent<FinalDecisionScript>().CluesFound() >=3)
            {
                flowchart.ExecuteBlock("Final Decision1");
            }
        }
    }
}