using UnityEngine;
using System.Collections;

public class neptnueMotion : MonoBehaviour {
    public float neptnue_Public_speed = 5;
    public float mg;


    public float neptnue_self_speed = 2;
    private Transform neptnue_transform;
    private GameObject Sun;
    private Vector3 forceDirection;

    void Awake()
    {

    }
    // Use this for initialization
    void Start()
    {
        Sun = GameObject.Find("SUN");
        neptnue_transform = transform;
    }


    // Update is called once per frame
    void Update()
    {
        if (neptnue_transform != null && Sun != null)
        {
            neptnue_transform.Rotate(Vector3.up * neptnue_self_speed * Time.deltaTime);
            neptnue_transform.RotateAround(Sun.transform.position,
                Vector3.up, Time.deltaTime * neptnue_Public_speed);
        }
    }
}
