using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string fullname = "�����";
    public string gender = "����";
    public string nationality = "�ѱ�";
    public string[] hobbies = { "����", "�", "��ȭ" };
    public string favoriteGame = "��Ʈ ���� �";
    

    
        

    

    void OnEnable()
    {
        
    }
    void Start()
    {
        Debug.Log("�ȳ��ϼ���");
        Debug.Log($"�� �̸��� {fullname}�Դϴ�");
        Debug.Log($"������ {gender}, ������ {nationality}�Դϴ�");
     
    }
    void SayHello(string name)
    {
        Debug.Log($"�ȳ��ϼ���, {name},��");
    }
    
    void Update()
    {
       
    }
}
