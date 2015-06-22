using UnityEngine;
using System.Collections;

public class uransMotion : MonoBehaviour {

    public float urans_Public_speed = 5;
    public float mg;


    public float urans_self_speed = 2;
    private Transform urans_transform;
    private GameObject Sun;
    private Vector3 forceDirection;

    void Awake()
    {

    }
    // Use this for initialization
    void Start()
    {
        Sun = GameObject.Find("SUN");
        urans_transform = transform;
    }


    // Update is called once per frame
    void Update()
    {
        if (urans_transform != null && Sun != null)
        {
            urans_transform.Rotate(Vector3.up * urans_self_speed * Time.deltaTime);
            urans_transform.RotateAround(Sun.transform.position, Vector3.up, Time.deltaTime * urans_Public_speed);
        }
    }
}
