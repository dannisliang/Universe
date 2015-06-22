using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainCameraManager : MonoBehaviour {


    public GameObject[] plant;
    public GameObject[] Cameratarget;


    private int selected=-1;//表是当前的选择。。
    private int currentselected=-2;//用来保存当前选择；
    //public MouseOrbit mouseOrbit;
    private Vector3 targetPostion;
    public GameObject planList;
    private bool isShowlist = false;
    private bool isMove = false;
    private bool isGotoPlant=false;

    public float timer=0;

    float Distance=40;
    public float ZoomSpeed = 2;
    //鼠标缩放距离最值
    private float MaxDistance = 400f;
    private float MinDistance = 30F;
    public float Damping = 10F;
    private Quaternion mRotation;


    /// <summary>
    /// 旋转
    /// </summary>

    private float SpeedX = 240;
    private float SpeedY = 120;
    //角度限制
    private float MinLimitY = 5;
    private float MaxLimitY = 180;

    //旋转角度
    private float mX = 0.0F;
    private float mY = 0.0F;
    void Awake()
    {
        //初始化旋转角度
        mX = transform.eulerAngles.x;
        mY = transform.eulerAngles.y;
    }
	void Start () {
        
	}
	void Update () {
      
        if(selected==PlantUtil.EARTH )
        {
            Distance = 40;
            SetPostion();
            
        }
        else if (selected == PlantUtil.VENUS)
        {
            Distance = 40;
            SetPostion();
        }
        else if (selected == PlantUtil.MERCURY  )
        {
            Distance = 40;
            SetPostion();
             
        }
        else if (selected == PlantUtil.MARS )
        {
            Distance = 40;
            SetPostion();
             
        }
        else if (selected == PlantUtil.JUPITER)
        {
            Distance = 80;
            SetPostion();
            
        }
        else if (selected == PlantUtil.SATURN)
        {
            Distance = 80;
            SetPostion();
        }
        else if (selected == PlantUtil.URANUS)
        {
            Distance = 40;
            SetPostion();
        }
        else if (selected == PlantUtil.NEPTNUE)
        {
            Distance = 40;
            SetPostion();
        }
        else if(selected==PlantUtil.SUN)
        {
            Distance = 180;
            SetPostion();
        }
        if(currentselected!=-1)
        {
           //当前的选择
        }
       
        if(isMove)
        {
            isGotoPlant = false;
            transform.position = Vector3.Slerp(transform.position, Cameratarget[1].transform.position,Time.deltaTime);
            if(Vector3.Distance(transform.position,Cameratarget[1].transform.position)<10f)
            {
                isMove = false;
                isGotoPlant = true;
            }
        }
        if (isGotoPlant)
        {
            //transform.LookAt(plant[currentselected].transform.position);  
            timer += Time.deltaTime;
            if(timer>0)
            {
                if (Input.GetMouseButton(1))
                {
 
                    mX += Input.GetAxis("Mouse X") * SpeedX * 0.02F;//x方向旋转，绕y轴；
                    mY -= Input.GetAxis("Mouse Y") * SpeedY * 0.02F;//y方向旋转，绕x轴；
 
                    mY = ClampAngle(mY, MinLimitY, MaxLimitY);
                    //旋转角有问题
                    mRotation = Quaternion.Euler(mY, mX, transform.rotation.z);//返回的是一个人旋转角度，绕x旋转x，绕y旋转y，绕z旋转z；

                    transform.rotation = Quaternion.Lerp(transform.rotation, mRotation, Time.deltaTime * Damping);   
                }	
                Distance -= Input.GetAxis("Mouse ScrollWheel") * ZoomSpeed;//检测滑轮滚动
                Distance = Mathf.Clamp(Distance, MinDistance, MaxDistance);
                //重新计算位置
                Vector3 mPosition = mRotation * new Vector3(0.0F, 1.0f , -Distance) + plant[currentselected].transform.position;
                transform.position = Vector3.Lerp(transform.position, mPosition, Time.deltaTime * Damping);
            }
           // isGotoPlant = false;
        }
        if(selected!=-1)
        {
        
        }

        if(isShowlist==true)
        {
            planList.SetActive(true);

        }else if(isShowlist==false)
        {
            planList.SetActive(false);
        }
	}

    public void SetPostion()
    {
        if( currentselected != selected)
        {
            transform.position = Cameratarget[0].transform.position;
            transform.rotation = Cameratarget[0].transform.rotation;
            isMove = true;
            currentselected = selected;
            timer = 0;
            selected = -1;
        }
       
    }
    /// <summary>
    /// BUTTON方法
    /// </summary>
    public void OnEarthBtnClick()
    {
        selected = PlantUtil.EARTH;
    }
    public void OnVenusBtnClick()
    {
        selected = PlantUtil.VENUS;
    }
    public void OnMercuryBtnClick()
    {
        selected = PlantUtil.MERCURY;
    }
    public void OnMarsBtnClick()
    {
        selected = PlantUtil.MARS;
    }
    public void OnJupiterBtnClick()
    {
        selected = PlantUtil.JUPITER;
    }
    public void OnSaturnBtnClick()
    {
        selected = PlantUtil.SATURN;
    }
    public void OnUranusBtnClick()
    {
        selected = PlantUtil.URANUS;
    }
    public void OnNeptuneBtnClick()
    {
        selected = PlantUtil.NEPTNUE;
    }
    public void OnSunBtnClick()
    {
        selected = PlantUtil.SUN;
    }
    public void OnhideBtnClick()
    {
        isShowlist = !isShowlist;
    }
    public void OnCrateBtnClick()
    {

    }
    private float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360) angle += 360;
        if (angle > 360) angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }
}
