using UnityEngine;
using System.Collections;

public class mercuryMotion : MonoBehaviour {

    public float mercury_Public_speed = 5;
    public float mg;


    public float mercury_self_speed = 2;
    private Transform mercury_transform;
    private GameObject Sun;
    private Vector3 forceDirection;

    void Awake()
    {

    }
    // Use this for initialization
    void Start()
    {
        Sun = GameObject.Find("SUN");
        mercury_transform = transform;
    }


    // Update is called once per frame
    void Update()
    {
        if (mercury_transform != null && Sun != null)
        {
            mercury_transform.Rotate(Vector3.up * mercury_self_speed * Time.deltaTime);
            mercury_transform.RotateAround(Sun.transform.position, Vector3.up, Time.deltaTime * mercury_Public_speed);
        }
    }
}
