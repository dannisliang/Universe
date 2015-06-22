using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class PlantMotion : MonoBehaviour
{
    public Vector3 translateVec = new Vector3(0,1,0);
    public float speedY = 20f;
    // Use this for initialization
    void Start()
    {
      
    }


    // Update is called once per frame
    void Update()
    {
        //transform.Translate(translateVec * speedY * Time.deltaTime);
        transform.Rotate(translateVec * speedY * Time.deltaTime);
    }

    public void OnCollisionStay(Collision col)
    {
        
    }
  

}
