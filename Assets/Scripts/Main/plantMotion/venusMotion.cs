using UnityEngine;
using System.Collections;

public class venusMotion : MonoBehaviour {

    public float venus_Public_speed = 5;
    public float mg;


    public float venus_self_speed = 2;
    private Transform venus_transform;
    private GameObject Sun;
    private Vector3 forceDirection;

    void Awake()
    {

    }
    // Use this for initialization
    void Start()
    {
        Sun = GameObject.Find("SUN");
        venus_transform = transform;
    }


    // Update is called once per frame
    void Update()
    {
        if (venus_transform != null && Sun != null)
        {
            venus_transform.Rotate(Vector3.up * venus_self_speed * Time.deltaTime);
            venus_transform.RotateAround(Sun.transform.position, Vector3.up, Time.deltaTime * venus_Public_speed);
        }
    }
}
