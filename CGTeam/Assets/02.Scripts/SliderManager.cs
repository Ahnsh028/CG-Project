using System.Collections;
using System.Collections.Generic;
//using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class SliderManager : MonoBehaviour
{

    public Slider uvValue; 
    // Start is called before the first frame update
    void Start()
    {
        
        try
        {
            uvValue.onValueChanged.AddListener(UvValueChanged);
        }
        catch (NullReferenceException)
        {
            Debug.Log("입력 값이 없습니다.");
        }
    }

    public void UvValueChanged(float index)
    {
       ButtonManager.UV = index;
       //ButtonManager.txt_uv.text = "자외선 지수 : " + ButtonManager.UV;
    }

}
