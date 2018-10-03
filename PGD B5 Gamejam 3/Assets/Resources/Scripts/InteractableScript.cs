using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableScript : MonoBehaviour {

    public bool activated = false;

    public Material active, nonActive;
    MeshRenderer meshRenderer;

	void Start () {
        meshRenderer = GetComponent<MeshRenderer>();

    }
	
	void Update () {

        meshRenderer.material = (activated) ? active : nonActive;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (name.Contains("pressable"))
        {
            if (other.tag == "Player")
                activated = !activated;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        if (Input.GetKeyDown(KeyCode.E)) {
                activated = !activated;
        }
    }
}
