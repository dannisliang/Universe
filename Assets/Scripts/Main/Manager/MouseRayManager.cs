using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MouseRayManager : MonoBehaviour {

	// Use this for initialization
    public GameObject cratePanel;
    public GameObject[] plant;
    public GameObject sprite;
    public bool canCrate = false;

    private int selected;
    private SetCursor sc;
    private string CurrentPlant;//用来保存当前的数据；
	void Start () {
        sc=this.transform.GetComponent<SetCursor>();
        ShowMassage._instance.ClosecratePanel();
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;//射线碰撞
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.transform.name=="mercury")
                {
                    CurrentPlant = "mercury";
                    ShowMassage._instance.ShowcratePanel();
                    string msg = "名称：水星\n轨道半长径：5791万千米(0.38 天文单位）\n公转周期：87.70 天\n自转方向：自西向东逆时针旋转\n平均轨道速度：47.89 千米/每秒\n轨道偏心率：0.206\n轨道倾角：7.0 度\n行星半径：2440 千米(赤道)\n质量(地球质量=1）：0.0553\n密度：5.43 克/立方厘米\n自转周期：58.653485 日\n卫星数：无(至今未发现）\n逃逸速度：4.3 km/s\n公转轨道： 距太阳 57,910,000 千米 (0.38 天文单位）";
                    ShowMassage._instance.showText(msg);
                }
                if(hit.transform.name=="venus")
                {
                    CurrentPlant = "venus";
                    ShowMassage._instance.ShowcratePanel();
                    string msg = "名称：金星\n轨道半径：149,600,000 km（离太阳1.00 天文单位）\n赤道半径：6,378.1 km\n平均轨道速度：29.79km/s\n轨道偏心率：0.0167\n轨道倾角：0°\n质量：　5.9736e24 千克\n赤道引力（地球=1) ：1.00\n逃逸速度（公里/秒）：11.2\n自转周期（日）：0.9973\n卫星数：　1\n公转周期（日）：　365.2422\n黄赤交角（度）：23.5\n反照率：0.30\n自转方向：自西向东";
                    ShowMassage._instance.showText(msg);
                }
                
                if(hit.transform.name=="earth")
                {
                    CurrentPlant = "earth";
                    ShowMassage._instance.ShowcratePanel();
                    string msg = "名称：地球\n轨道半径：149,600,000 km（离太阳1.00 天文单位）\n赤道半径：6,378.1 km\n平均轨道速度：29.79km/s\n轨道偏心率：0.0167\n轨道倾角：0°\n质量：　5.9736e24 千克\n赤道引力（地球=1) ：1.00\n逃逸速度（公里/秒）：11.2\n自转周期（日）：0.9973\n卫星数：　1\n公转周期（日）：　365.2422\n黄赤交角（度）：23.5\n反照率：0.30\n自转方向：自西向东";
                    ShowMassage._instance.showText(msg);
                   // ShowMassage._instance.showMsg();
                }
                if(hit.transform.name=="mars")
                {
                    CurrentPlant = "mars";
                    ShowMassage._instance.ShowcratePanel();
                    string msg = " 名称：火星\n轨道半径：149,600,000 km（离太阳1.00 天文单位）\n赤道半径：6,378.1 km\n平均轨道速度：29.79km/s\n轨道偏心率：0.0167\n轨道倾角：0°\n质量：　5.9736e24 千克\n赤道引力（地球=1) ：1.00\n逃逸速度（公里/秒）：11.2\n自转周期（日）：0.9973\n卫星数：　1\n公转周期（日）：　365.2422\n黄赤交角（度）：23.5\n反照率：0.30\n自转方向：自西向东";
                    ShowMassage._instance.showText(msg);
                }
                if(hit.transform.name=="jupiter")
                {
                    CurrentPlant = "jupiter";
                    ShowMassage._instance.ShowcratePanel();
                    string msg = "名称：木星\n轨道半径：149,600,000 km（离太阳1.00 天文单位）\n赤道半径：6,378.1 km\n平均轨道速度：29.79km/s\n轨道偏心率：0.0167\n轨道倾角：0°\n质量：　5.9736e24 千克\n赤道引力（地球=1) ：1.00\n逃逸速度（公里/秒）：11.2\n自转周期（日）：0.9973\n卫星数：　1\n公转周期（日）：　365.2422\n黄赤交角（度）：23.5\n反照率：0.30\n自转方向：自西向东";
                    ShowMassage._instance.showText(msg);
                }
                if(hit.transform.name=="saturn")
                {
                    CurrentPlant = "saturn";
                    ShowMassage._instance.ShowcratePanel();
                    string msg = "名称：土星\n轨道半径：149,600,000 km（离太阳1.00 天文单位）\n赤道半径：6,378.1 km\n平均轨道速度：29.79km/s\n轨道偏心率：0.0167\n轨道倾角：0°\n质量：　5.9736e24 千克\n赤道引力（地球=1) ：1.00\n逃逸速度（公里/秒）：11.2\n自转周期（日）：0.9973\n卫星数：　1\n公转周期（日）：　365.2422\n黄赤交角（度）：23.5\n反照率：0.30\n自转方向：自西向东";
                    ShowMassage._instance.showText(msg);
                }
                if(hit.transform.name=="uranus")
                {
                    CurrentPlant = "uranus";
                    ShowMassage._instance.ShowcratePanel();
                    string msg = "名称：天王星\n轨道半径：149,600,000 km（离太阳1.00 天文单位）\n赤道半径：6,378.1 km\n平均轨道速度：29.79km/s\n轨道偏心率：0.0167\n轨道倾角：0°\n质量：　5.9736e24 千克\n赤道引力（地球=1) ：1.00\n逃逸速度（公里/秒）：11.2\n自转周期（日）：0.9973\n卫星数：　1\n公转周期（日）：　365.2422\n黄赤交角（度）：23.5\n反照率：0.30\n自转方向：自西向东";
                    ShowMassage._instance.showText(msg);
                }
                if(hit.transform.name=="neptnue")
                {
                    CurrentPlant = "neptnue";
                    ShowMassage._instance.ShowcratePanel();
                    string msg = "名称：海王星\n轨道半径：149,600,000 km（离太阳1.00 天文单位）\n赤道半径：6,378.1 km\n平均轨道速度：29.79km/s\n轨道偏心率：0.0167\n轨道倾角：0°\n质量：　5.9736e24 千克\n赤道引力（地球=1) ：1.00\n逃逸速度（公里/秒）：11.2\n自转周期（日）：0.9973\n卫星数：　1\n公转周期（日）：　365.2422\n黄赤交角（度）：23.5\n反照率：0.30\n自转方向：自西向东";
                    ShowMassage._instance.showText(msg);
                }
                if(hit.transform.tag=="sprite")
                {
                    string msg = "精灵：\n 太空搬运工，可以为你\n收集太空资源 ";
                    ShowMassage._instance.showText(msg);
                }
                //if(hit.transform.name=="")
            }
        }
        if(canCrate)
        {
            if(Input.GetMouseButton(0))
            {
                //创建星球；
                if(CurrentPlant!=null)
                {
                    Transform C_Plant = GameObject.Find(CurrentPlant).transform;
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                   // float Distance = Vector3.Distance(transform.position, C_Plant.transform.position);
                    if(Physics.Raycast(ray,out hit))
                    {
                        GameObject obj_plant = (GameObject)GameObject.Instantiate(plant[selected], hit.point, C_Plant.rotation);
                        canCrate = false;
                        obj_plant.GetComponent<CustomPlant>().speed = Random.Range(8,20);
                        obj_plant.GetComponent<CustomPlant>().taget = C_Plant;
                        sc.currentCur = 0;
                    }
                }
            }
        }

	}
    public void OnPlantBt1Click()
    {
        sc.currentCur = 1;
        canCrate = true;
        selected = 0;
    }
    public void OnPlantBt2Click()
    {
        sc.currentCur = 1;
        canCrate = true;
        selected = 1;
    }
    public void OnSpriteBtnClick()
    {
        sc.currentCur = 1;
        canCrate = true;
    }
    public void OnPlantBt4Click()
    {
        selected = 2;
        sc.currentCur = 1;
        canCrate = true;
    }
    public void OnPlantBt5Click()
    {
        selected = 3;
        sc.currentCur = 1;
        canCrate = true;
    }
}
