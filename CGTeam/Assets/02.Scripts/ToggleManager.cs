using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleManager : MonoBehaviour
{
    public void Pa(bool isOn)
    {
        if (isOn)
        {
            Debug.Log("pa등급은: +");
        }
    }

    public void Spf(bool isOn)
    {
        if (isOn)
        {

            Debug.Log("spf등급은: ");
        }
    }


}
