using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    

	void Start () {
		
	}
	
	void Update () {


        if (Input.GetKeyDown(KeyCode.E))
            CheckForInteractable();
	}

    void CheckForInteractable()
    {
        RaycastHit interactableHit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out interactableHit, 0.5f))
        {
            if (interactableHit.collider.gameObject.tag == "Interactable")
            {
                bool actvatedInteract = interactableHit.collider.GetComponent<InteractableScript>().activated;
                actvatedInteract = !actvatedInteract;
                interactableHit.collider.GetComponent<InteractableScript>().activated = actvatedInteract;
            }
        }
    }
}
