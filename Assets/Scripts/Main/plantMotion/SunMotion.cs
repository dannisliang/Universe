using UnityEngine;
using System.Collections;

public class SunMotion : MonoBehaviour {

    public float Sun_Self_Speed = 1;
    private Transform Sun_Transform;
	
    void Awake()
    {
        Sun_Transform = transform;
    }
    void Start () {
	  
	}
	void Update () {
        if(Sun_Transform!=null)
        {
            Sun_Transform.Rotate(Vector3.up * Sun_Self_Speed * Time.deltaTime);
        }
	}
}
