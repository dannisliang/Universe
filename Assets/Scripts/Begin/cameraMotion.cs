using UnityEngine;
using System.Collections;

public class cameraMotion : MonoBehaviour {

    private GameObject plant;
    public float rotatSpeed=2.0f;
    private Transform camera;

	void Start () {
        plant = GameObject.Find("earth");
	  if(camera==null)
      {
          camera = this.transform;
      }
	}
	
	void Update () {
        if(camera!=null&&plant!=null)
        {
            camera.RotateAround(plant.transform.position,Vector3.up,rotatSpeed*Time.deltaTime);
            camera.LookAt(plant.transform);
        }
	}
}
