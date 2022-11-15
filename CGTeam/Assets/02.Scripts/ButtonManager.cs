using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    #region ����
    public GameObject button; // ��ư 
    public GameObject button2; // ��ư2
    public GameObject Hand; // �� ������Ʈ
    public Renderer Renderer; // renderer ������Ʈ
    public float hsv = 0.00278f; // H���� 0~1 ������ ������ ��Ÿ�ߵ�. �� 1%360(H�� ����) = �뷫 0.00278
    bool clickB; // ��ư Ŭ�� Ȯ��
    float time; // �ð�
    float time2; // ȫ��ȿ���� �Ͼ ��
    #endregion

    private void Start()
    {
        clickB = false; // ������°� �ƴ�
    }

    public void ChangeMaterial() // Ŭ���� ���� ����(Ÿ��1 ��ư)
    {
        Hand.GetComponent<Renderer>().material.color = Color.white;
        Debug.Log("Ŭ��");
    }


    #region ��ư ���� �Լ�
    public void BTon() //��ư Ŭ��
    {
        clickB = true;
    }

    public void BToff() // ��ư Ŭ��x
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
            if ((21 / 360f - time / 60) > 0) // H���� 0�̵ɶ�����
            {
                Renderer.material.color = Color.HSVToRGB((21 / 360f - time / 60), 0.26f, 0.91f); //(ȫ��ȿ��, ���� �Ǻλ��� ������)
            }

            else //ȫ�� �ۿ��� �Ͼ �� ���� ��ȭ
            {
                time2 += Time.deltaTime;
                Renderer.material.color = Color.HSVToRGB((1 / 360f), 0.26f, 0.91f - (0.05f * time2));
            }
        }
    }
}
