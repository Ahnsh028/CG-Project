using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject button; // ��ư
    public GameObject Hand; // �� ������Ʈ


    public void ChangeMaterial()
    {
        Hand.GetComponent<Renderer>().material.color = Color.white;
        Debug.Log("Ŭ��");
    }




}
