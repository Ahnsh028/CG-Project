using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject button; // 버튼
    public GameObject Hand; // 손 오브젝트


    public void ChangeMaterial()
    {
        Hand.GetComponent<Renderer>().material.color = Color.white;
        Debug.Log("클릭");
    }




}
