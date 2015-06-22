using UnityEngine;
using System.Collections;

public class CustomPlant : MonoBehaviour {

    public Transform taget;//所围绕旋转的星球；
    public float speed;
    public GameObject explo;

    private float distance;//用来检测与摄像机的距离。
    private GameObject camera;
    public float showDistance=100f;
    public GameObject sprite_son;
	void Start () {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
	}
	void Update () {
        if(taget!=null)
        {
            transform.RotateAround(taget.position,Vector3.up,Time.deltaTime*speed);
        }
      if(camera!=null)
      {
          distance = Vector3.Distance(this.transform.position, camera.transform.position);
          if(distance>showDistance)
          {
              if(sprite_son!=null)
              {
                  sprite_son.SetActive(true);
              }
          }
          else
          {
              sprite_son.SetActive(false);
          }
      }
	}
    public void OnCollisionStay(Collision col)
    {
        if(col.transform.tag=="plant")
        {
            GameObject.Instantiate(explo,transform.position,transform.rotation);
            Destroy(this.gameObject);
        }
    }

}
