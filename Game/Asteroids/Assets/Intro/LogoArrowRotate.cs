using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoArrowRotate : MonoBehaviour {

    private float currentTime;
    public float totalTime;

    private Vector3 startingRotation;
        

	// Use this for initialization
	void Start () {

        float startTime = Time.time;
        currentTime = Time.time;

        startingRotation = transform.rotation.eulerAngles;

    }
	
	// Update is called once per frame
	void Update () {

        currentTime += Time.deltaTime;
        if (currentTime <= totalTime)
        {
            transform.rotation = Quaternion.Inverse( Quaternion.Euler(new Vector3( startingRotation.x,
                360f * currentTime / totalTime,
                startingRotation.z )));
        }


    }
}
