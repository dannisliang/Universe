using UnityEngine;
using System.Collections;

public class staurnMotion : MonoBehaviour {

    public float staurn_Public_speed = 5;
    public float mg;


    public float staurn_self_speed = 2;
    private Transform staurn_transform;
    private GameObject Sun;
    private Vector3 forceDirection;

    void Awake()
    {

    }
    // Use this for initialization
    void Start()
    {
        Sun = GameObject.Find("SUN");
        staurn_transform = transform;
    }


    // Update is called once per frame
    void Update()
    {
        if (staurn_transform != null && Sun != null)
        {
            staurn_transform.Rotate(Vector3.up * staurn_self_speed * Time.deltaTime);
            staurn_transform.RotateAround(Sun.transform.position, Vector3.up, Time.deltaTime * staurn_Public_speed);
        }
    }
}
