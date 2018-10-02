using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public GameObject target;
    public float speed = 5f;
    public float offSet = 10f;
   // Vector3 Offset;
   // public float followSpeed = 1f;
	void Start () {
      //  Offset = new Vector3(0,0,-10); //Camera needs an z offset of -10 (or another negative value) in order to see the player

    }
	
	void Update () {

        var targetRotation = Quaternion.LookRotation(target.transform.position - transform.position);
        // Smoothly rotate towards the target point.
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);

        Vector3 cameraToTargetPos = transform.position;
        cameraToTargetPos.z = target.transform.position.z -offSet;
        transform.position = Vector3.Lerp(transform.position, cameraToTargetPos, speed * Time.deltaTime); 
    }

    //Zorg ervoor dat je het nieuwe target ophaalt en als parameter meegeeft in deze functie.
    public void ChangeCameraTarget(GameObject newTarget)
    {
        target = newTarget;
    }
}
