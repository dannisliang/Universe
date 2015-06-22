using UnityEngine;
using System.Collections;

public class marsMotion : MonoBehaviour {

    public float mars_Public_speed = 5;
    public float mg;


    public float mars_self_speed = 2;
    private Transform mars_transform;
    private GameObject Sun;
    private Vector3 forceDirection;

    void Awake()
    {

    }
    // Use this for initialization
    void Start()
    {
        Sun = GameObject.Find("SUN");
        mars_transform = transform;
    }


    // Update is called once per frame
    void Update()
    {
        if (mars_transform != null && Sun != null)
        {
            mars_transform.Rotate(Vector3.up * mars_self_speed * Time.deltaTime);
            mars_transform.RotateAround(Sun.transform.position, Vector3.up, Time.deltaTime * mars_Public_speed);
        }
    }
}
