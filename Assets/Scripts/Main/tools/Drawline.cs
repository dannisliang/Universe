using UnityEngine;
using System.Collections;

public class Drawline : MonoBehaviour {

    private Transform target;
    public float speed = 100;
	void Start () {
        target = this.transform.parent;
	}
	
	void Update () {
        if (target != null)
       {
           transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);
       }
	}
}
