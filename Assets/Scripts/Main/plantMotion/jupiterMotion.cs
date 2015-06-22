using UnityEngine;
using System.Collections;

/// <summary>
/// 木星运动脚本
/// </summary>
public class jupiterMotion : MonoBehaviour {

    public float jupiter_Public_speed = 5;
    public float mg;


    public float jupiter_self_speed = 2;
    private Transform jupiter_transform;
    private GameObject Sun;
    private Vector3 forceDirection;

    void Awake()
    {

    }
    // Use this for initialization
    void Start()
    {
        Sun = GameObject.Find("SUN");
        jupiter_transform = transform;
    }


    // Update is called once per frame
    void Update()
    {
        if (jupiter_transform != null && Sun != null)
        {
            jupiter_transform.Rotate(Vector3.up * jupiter_self_speed * Time.deltaTime);
            jupiter_transform.RotateAround(Sun.transform.position, Vector3.up, Time.deltaTime * jupiter_Public_speed);
        }
    }
}
