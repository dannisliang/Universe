using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowMassage : MonoBehaviour {
    public static ShowMassage _instance;
    public GameObject messagePanel;
    public GameObject mainWindow;
    public GameObject crateTip_panel;
    public Text cratetext;
    private Animator manim;
    public Text allmessageText;

    public GameObject cratePanel;
	void Start () {
        manim = crateTip_panel.transform.GetComponent<Animator>();
	   if(_instance==null)
       {
          _instance = this;
       }
	}
	void Update () {
	
	}
    public  void showMsg()
    {
        messagePanel.SetActive(true);
    }
    public void showWindow()
    {
        mainWindow.SetActive(true);
    }
    public void Close()
    {
        messagePanel.SetActive(false);
        mainWindow.SetActive(false);
    }
    public void ShowCrateTip(string message)
    {
        //manim.Play();
        manim.SetBool("iscrateTip", true);
        
    }
    public void CloseCrateTip()
    {
        manim.SetBool("iscrateTip", false);
    }
    public void showText(string message)
    {
        allmessageText.text = message;
    }
    public void ShowcratePanel()
    {
        cratePanel.SetActive(true);
    }
    public void ClosecratePanel()
    {
        cratePanel.SetActive(false);
    }

}
