using UnityEngine;

public class Raycast : MonoBehaviour
{
    Renderer handColor;

    void Start()
    {
        handColor = gameObject.GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.gameObject);
                hit.transform.gameObject.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1, 1); //White
            }
        }
    }
}
