using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

    public class ClickToMove : MonoBehaviour
    {

        public LayerMask whatCanBeClickedOn;
        private NavMeshAgent myAgent;

        void Start()
        {
            myAgent = GetComponent<NavMeshAgent>();
        }
        
        void Update()
        {
            if(Input.GetMouseButtonDown(0)){
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

                if(Physics.Raycast(myRay, out hitInfo, 100, whatCanBeClickedOn)){
                  myAgent.SetDestination(hitInfo.point);
                }
            }
        }
    }