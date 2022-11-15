using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveObj : MonoBehaviour
{

    public int spf;
    public int pa;

    // Start is called before the first frame update
    void Start()
    {
        //spf = 0;
        //pa = 0;
        int SaveData = PlayerPrefs.GetInt("Save"); // PlaterPrefabs는 유니티 정보를 저장할 수 있는 클래스
        Debug.Log(SaveData);
        PlayerPrefs.SetInt("Save", 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
