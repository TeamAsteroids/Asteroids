using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoArrowRotate : MonoBehaviour {

    private float currentTime;
    public  float totalTime;
    private float endTime;

    private Vector3 startingRotation;
        

	// Use this for initialization
	void Start () {

        endTime = Time.time + totalTime;
        currentTime = Time.time;

        // rotate x = 70
        // rotate y = 30
        startingRotation = transform.rotation.eulerAngles;

    }
	
	// Update is called once per frame
	void Update () {

        currentTime += Time.deltaTime;
        if (currentTime <= endTime)
        {
            transform.rotation = Quaternion.Euler(new Vector3( startingRotation.x,
                startingRotation.y,
                360f * currentTime / totalTime));
        }


    }
}
