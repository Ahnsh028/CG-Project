using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    #region 변수
    public GameObject button; // 버튼 
    public GameObject button2; // 버튼2
    public GameObject Hand; // 손 오브젝트
    public Renderer Renderer; // renderer 컴포넌트
    public float hsv = 0.00278f; // H값은 0~1 사이의 값으로 나타야됨. 즉 1%360(H의 범위) = 대략 0.00278
    bool clickB; // 버튼 클릭 확인
    float time; // 시간
    float time2; // 홍반효과가 일어난 후
    #endregion

    private void Start()
    {
        clickB = false; // 실행상태가 아님
    }

    public void ChangeMaterial() // 클릭시 색상 변경(타입1 버튼)
    {
        Hand.GetComponent<Renderer>().material.color = Color.white;
        Debug.Log("클릭");
    }


    #region 버튼 관련 함수
    public void BTon() //버튼 클릭
    {
        clickB = true;
    }

    public void BToff() // 버튼 클릭x
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
                Renderer.material.color = Color.HSVToRGB((21 / 360f - time / 60), 0.26f, 0.91f); //(홍반효과, 원래 피부색의 정보들)
            }

            else //홍반 작용이 일어난 후 명도의 변화
            {
                time2 += Time.deltaTime;
                Renderer.material.color = Color.HSVToRGB((1 / 360f), 0.26f, 0.91f - (0.05f * time2));
            }
        }
    }
}
