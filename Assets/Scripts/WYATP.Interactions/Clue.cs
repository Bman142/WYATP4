using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
namespace WYATP.Interactions
{
    public class Clue : Interactable
    {
        bool activated = false;
        Flowchart flowchart;
        private void Awake()
        {
            this.gameObject.tag = "Clue";
            flowchart = GameObject.FindObjectOfType<Flowchart>();
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void Execute(string clue)
        {
            if (!activated)
            {
                flowchart.ExecuteBlock(clue);
                activated = true;
            }
        }
    }
}
