using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractSystemManager : MonoBehaviour {

    Transform interactables, doors;
    bool puzzelDone = false;

    void Start () {
        interactables = transform.GetChild(0);
        doors = transform.GetChild(1);
    }
	
	void Update () {
        puzzelDone = true;
        foreach (Transform interactable in interactables)
        {
            if (!interactable.GetComponent<InteractableScript>().activated)
                puzzelDone = false;
        }

        ChangeDoorState(puzzelDone);
    }

    // true = open / false = closed
    void ChangeDoorState(bool state)
    {
        foreach (Transform door in doors)
        {
            door.gameObject.SetActive(!state);
        }
    }
}
