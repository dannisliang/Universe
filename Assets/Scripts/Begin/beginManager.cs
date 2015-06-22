using UnityEngine;
using System.Collections;

public class beginManager : MonoBehaviour {

  /// <summary>
  /// 用来控制该场景的整体脚本
  /// </summary>
	void Start () {
        
	}
	
	 
	void Update () {
	    
	}

    /// <summary>
    /// 开始游戏按钮
    /// 后期改为手术控制
    /// </summary>
    public void OnBeginbtnClick()
    {
        StartCoroutine(LoadMainScene());
    }
    /// <summary>
    /// 设置按钮
    /// </summary>
    public  void OnSetbtnClick()
    {
        
    }
    /// <summary>
    /// 退出游戏按钮
    /// </summary>
    public void OnExitbtnClick()
    {
        Application.Quit();
    }
    IEnumerator LoadMainScene()
    {
        yield return new WaitForSeconds(1);
        Application.LoadLevel(1);
    }
}
