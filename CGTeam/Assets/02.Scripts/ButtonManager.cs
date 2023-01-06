using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour
{
    #region 변수
    public GameObject button; // 버튼 
    public GameObject button2; // 버튼2
    public GameObject Hand; // 손 오브젝트
    public GameObject Hand2; // 손 오브젝트 2
    public Renderer Renderer; // renderer 컴포넌트
    public Renderer Renderer2; // renderer 컴포넌트
    public float hsv = 0.00278f; // H값은 0~1 사이의 값으로 나타야됨. 즉 1%360(H의 범위) = 대략 0.00278
    bool clickB; // start 버튼 클릭 확인
    bool clickA; // 72시간 후 버튼 클릭 확인
    float time; // 시간
    float time2; // 홍반효과가 일어난 후
    float time3; // 홍반효과가 일어난 후
    float back1;
    float back2;
    public float Spf; //spf 등급을 퍼센트로 나타냄
    public float Pa; //pa등급을 퍼센트로 나타냄
    public static float UV; // 자외선 지수
    public int Spf_a; // spf지수
    public int Pa_a; // pa지수
    //public int UV_a;
    public Text timer;
    public float change_h1;
    public float change_v1;
    public float change_h2;
    public float change_v2;
    public float check_h;
    public float check_v;
    public float return_v;

    //pa 버튼 1,2,3,4
    public GameObject button_pa1;
    public GameObject button_pa2;
    public GameObject button_pa3;
    public GameObject button_pa4;

    //spf버튼 1,2,3,4
    public GameObject button_spf1;
    public GameObject button_spf2;
    public GameObject button_spf3;
    public GameObject button_spf4;

    //uv버튼 1,2,3,4
    public GameObject button_uv1;
    public GameObject button_uv2;
    public GameObject button_uv3;
    public GameObject button_uv4;

    public GameObject Start_program; //시작버튼
    public GameObject Change_program; //변경버튼
    #endregion

    //각 수치를 시각화
    public Text txt_spf;
    public Text txt_pa;
    public Text txt_uv;
    private void Start()
    {

        clickB = false; // 실행상태가 아님
        clickA = false; // 실행상태가 아님
        //change_v2 = 0.0f;
        //change_v1 = 0.0f;
        //change_h2 = 0.0f;
        //change_h1 = 0.0f;
        //back1 = 0.0f;
        //back2 = 0.0f;
        //time2 = 0.0f;

    }


    public void GetSpf(float index)
    {
        Spf = index;
    }
    public void GetSpfNum(int a)
    {
        Spf_a = a;
        txt_spf.text = "spf 등급 : " + Spf_a;
    }
    public void GetPa(float index)
    {
        Pa = index;
    }
    public void GetPaNum(int a)
    {
        Pa_a = a;
        txt_pa.text = "pa 등급 : " + Pa_a;
    }
    public void GetUV(float index)
    {
        UV = index;
        txt_uv.text = "자외선 지수 : " + Mathf.Round(UV);
    }


    public void ChangeHandBySpf1(float UV) //자외선 차단제 바르기 전
    {
        time += Time.deltaTime;
        Renderer = Hand.GetComponent<Renderer>();

        if (check_v < 0.05f)
        {
            check_v += 0.001f;
        }

        if (UV == 1)
        {
            if (time <= 90) // H값이 0이될때까지 
            {
                Renderer.material.color = Color.HSVToRGB(21 / 360f - (((21 * time) / 90) / 360), 0.26f+check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
            }
        }

        else if (UV == 2)
        {
            if (time <= 75) // H값이 0이될때까지 
            {
                Renderer.material.color = Color.HSVToRGB(21 / 360f - (((21 * time) / 75) / 360), 0.26f + check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
            }
        }

        else if (UV == 3)
        {
            if (time <= 62) // H값이 0이될때까지 
            {
                Renderer.material.color = Color.HSVToRGB(21 / 360f - (((21 * time) / 62) / 360), 0.26f + check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
            }
        }

        else if (UV == 4)
        {
            if (time <= 50) // H값이 0이될때까지 
            {
                Renderer.material.color = Color.HSVToRGB(21 / 360f - (((21 * time) / 50) / 360), 0.26f+check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
            }
        }

        else if (UV == 5)
        {
            if (time <= 39) // H값이 0이될때까지 
            {
                Renderer.material.color = Color.HSVToRGB(21 / 360f - (((21 * time) / 39) / 360), 0.26f + check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
            }
        }

        else if (UV == 6)
        {
            if (time <= 30) // H값이 0이될때까지 
            {
                Renderer.material.color = Color.HSVToRGB(21 / 360f - (((21 * time) / 30) / 360), 0.26f + check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
            }
        }

        else if (UV == 7)
        {
            if (time <= 22) // H값이 0이될때까지 
            {
                Renderer.material.color = Color.HSVToRGB(21 / 360f - (((21 * time) / 22) / 360), 0.26f + check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
            }
        }

        else if (UV == 8)
        {
            if (time <= 17) // H값이 0이될때까지 
            {
                Renderer.material.color = Color.HSVToRGB(21 / 360f - (((21 * time) / 17) / 360), 0.26f + check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
            }
        }

        else if (UV == 9)
        {
            if (time <= 13) // H값이 0이될때까지 
            {
                Renderer.material.color = Color.HSVToRGB(21 / 360f - (((21 * time) / 13) / 360), 0.26f + check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
            }
        }

        else if (UV == 10)
        {
            if (time <= 10) // H값이 0이될때까지 
            {
                Renderer.material.color = Color.HSVToRGB(21 / 360f - (((21 * time) / 10) / 360), 0.26f + check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
            }
        }
    }
    public void ChangeHandBySpf2(float UV, float Spf, float check_v) // 자외선 차단제 바른 후
    {
        time += Time.deltaTime;
        Renderer = Hand2.GetComponent<Renderer>();
        Debug.Log(UV);
        Debug.Log(Spf);
        if (UV == 1)//만약에 리턴받는 1이 string형식인지 확인해야됨
        {
            if (time <= 90) // H값이 0이될때까지 
            {
                Renderer2.material.color = Color.HSVToRGB(21 / 360f - (Spf * (((21 * time) / 90) / 360)), 0.26f + check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
                check_h = (21 - (Spf * ((21 * time) / 90)));
            }
        }

        else if (UV == 2)
        {
            if (time <= 75) // H값이 0이될때까지 
            {
                Renderer2.material.color = Color.HSVToRGB(21 / 360f - (Spf * (((21 * time) / 75) / 360)), 0.26f + check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
                check_h = (21 - (Spf * ((21 * time) / 75)));
            }
        }

        else if (UV == 3)
        {
            if (time <= 62) // H값이 0이될때까지 
            {
                Renderer2.material.color = Color.HSVToRGB(21 / 360f - (Spf * (((21 * time) / 62) / 360)), 0.26f + check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
                check_h = (21 - (Spf * ((21 * time) / 62)));
            }
        }

        else if (UV == 4)
        {
            if (time <= 50) // H값이 0이될때까지 
            {
                Renderer2.material.color = Color.HSVToRGB(21 / 360f - (Spf * (((21 * time) / 50) / 360)), 0.26f + check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
                check_h = (21 - (Spf * ((21 * time) / 50)));
            }
        }

        else if (UV == 5)
        {
            if (time <= 39) // H값이 0이될때까지 
            {
                Renderer2.material.color = Color.HSVToRGB(21 / 360f - (Spf * (((21 * time) / 39) / 360)), 0.26f + check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
                check_h = (21 - (Spf * ((21 * time) / 39)));
            }
        }

        else if (UV == 6)
        {
            if (time <= 30) // H값이 0이될때까지 
            {
                Renderer2.material.color = Color.HSVToRGB(21 / 360f - (Spf * (((21 * time) / 30) / 360)), 0.26f + check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
                check_h = (21 - (Spf * ((21 * time) / 30)));
            }
        }

        else if (UV == 7)
        {
            if (time <= 22) // H값이 0이될때까지 
            {
                Renderer2.material.color = Color.HSVToRGB(21 / 360f - (Spf * (((21 * time) / 22) / 360)), 0.26f + check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
                check_h = (21 - (Spf * ((21 * time) / 22)));
            }
        }

        else if (UV == 8)
        {
            if (time <= 17) // H값이 0이될때까지 
            {
                Renderer2.material.color = Color.HSVToRGB(21 / 360f - (Spf * (((21 * time) / 17) / 360)), 0.26f + check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
                check_h = (21 - (Spf * ((21 * time) / 17)));
            }
        }

        else if (UV == 9)
        {
            if (time <= 13) // H값이 0이될때까지 
            {
                Renderer2.material.color = Color.HSVToRGB(21 / 360f - (Spf * (((21 * time) / 13) / 360)), 0.26f + check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
                check_h = (21 - (Spf * ((21 * time) / 13)));
            }
        }

        else if (UV == 10)
        {
            if (time <= 10) // H값이 0이될때까지 
            {
                Renderer2.material.color = Color.HSVToRGB(21 / 360f - (Spf * (((21 * time) / 10) / 360)), 0.26f + check_v, 0.91f); //(홍반효과, 원래 피부색의 정보들)
                check_h = (21 - (Spf * ((21 * time) / 10)));
            }
        }

    }
    public void ChangeHandByPa1(float check_v) // pa제품을 바르지 않았을 때
    {
        Renderer = Hand.GetComponent<Renderer>();
        if (return_v < 0.05f)
        {
            return_v += 0.001f;
        }
        if (back1 < 21)
        {
            back1 += Time.deltaTime;
            Renderer.material.color = Color.HSVToRGB((1 / 360f) + back1 / 360, 0.26f + check_v - return_v, 0.91f);
        }
        else
        {
            if (change_h1 <= 3)
            {
                change_h1 += 0.001f;
            }

            if (change_v1 < 0.24f)
            {
                change_v1 += 0.0002f;
            }
            if ((0.91f - (0.01f * time2) >= 0.70f))
            {
                time2 += Time.deltaTime;
                Renderer.material.color = Color.HSVToRGB(((1 + back1) / 360f) + change_h1 / 360, 0.26f + change_v1 + check_v - return_v, 0.91f - (0.01f * time2));
            }
        }



    }
    public void ChangeHandByPa2(float Pa, float check_v, float return_v) // pa 제품을 발랐을 경우
    {
        Renderer2 = Hand2.GetComponent<Renderer>();

        if ((back2 + check_h) < 21)
        {
            back2 += Time.deltaTime;
            Renderer2.material.color = Color.HSVToRGB((check_h / 360f) + back2 / 360, 0.26f + check_v - return_v, 0.91f);
        }
        else
        {
            if (change_h2 <= 2) // H 변화량
            {
                change_h2 += 0.002f;// 변하는 속도
            }

            if (change_v2 <= 0.20f) // 채도변화량
            {
                change_v2 += 0.0002f; // 변하는 속도
            }

            if ((0.91f - (0.01f * time3 * Pa_a) >= 0.70f))
            {
                time3 += Time.deltaTime;
                Renderer2.material.color = Color.HSVToRGB(((check_h + back2) / 360f) + change_h2 / 360, 0.26f + change_v2 + check_v - return_v, 0.91f - (0.01f * time3));
            }
        }


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
    public void ClickA()
    {
        if (!clickA)
        {
            clickA = true;
        }
        else
        {
            clickA = false;
        }

    }
    #endregion


    private void Update()
    {
        if (clickB)
        {
            time += Time.deltaTime;
            timer.text = "시간 : " + Mathf.Round(time) + "분";

            ChangeHandBySpf1(UV);
            ChangeHandBySpf2(UV, Spf, check_v);
            //Debug.Log(Spf);
        }


        if (clickA)
        {
            ChangeHandByPa2(Pa, check_v, return_v);
            ChangeHandByPa1(check_v);
        }





    }
}