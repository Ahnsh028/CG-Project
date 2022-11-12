using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    #region
    public GameObject button; // 버튼 
    public GameObject button2; // 버튼2
    public GameObject Hand; // 손 오브젝트
    public Renderer Renderer; // renderer 컴포넌트
    public float hsv = 0.00278f; // H값은 0~1 사이의 값으로 나타야됨. 즉 1%360(H의 범위) = 대략 0.00278
    bool clickB; // 버튼 클릭 확인
    float time; // 시간
    #endregion

    private void Start()
    {
        clickB = false;
    }

    public void ChangeMaterial() // 클릭시 색상 변경
    {
        Hand.GetComponent<Renderer>().material.color = Color.white;
        Debug.Log("클릭");
    }

    public void ChangeMaterial2() // 클릭시 색상 변경2
    {
        Renderer = Hand.GetComponent<Renderer>();
        Renderer.material.color = Color.HSVToRGB(0.00278f, 1, 1);
    }

    //public void ChangeMaterial3() //클릭시 시간의 흐름에 따른 색상 변경
    //{
    //    Renderer = Hand.GetComponent<Renderer>();
    //    Renderer.material.color = Color.HSVToRGB(21/360f - (Time.deltaTime/360f) ,26/100f, 91/100f);
    //}

    #region 버튼 관련
    public void BTon() //버튼 클릭
    {
        clickB = true;
    }

    public void BToff() // 버튼 클릭 x
    {
        clickB = false;
    }

    public void ClickB()
    {
        if (!clickB)
        {
            BTon();
        }
        else
        {
            BToff();
        }

    }
    #endregion

    private void Update()
    {
        if (clickB)
        {
            time += Time.deltaTime;
            Renderer = Hand.GetComponent<Renderer>();
            if ((21 / 360f - time / 60) > 0) // H값이 0이될때까지
            {
                Renderer.material.color = Color.HSVToRGB((21 / 360f - time / 60), 0.26f, 0.91f);
            }
        }
    }
}
