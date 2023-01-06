using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReLoadManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void reStart()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        reStart();
    }
}
