using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string fullname = "배소정";
    public string gender = "여성";
    public string nationality = "한국";
    public string[] hobbies = { "게임", "운동", "영화" };
    public string favoriteGame = "라스트 오브 어스";
    

    
        

    

    void OnEnable()
    {
        
    }
    void Start()
    {
        Debug.Log("안녕하세요");
        Debug.Log($"제 이름은 {fullname}입니다");
        Debug.Log($"성별은 {gender}, 국적은 {nationality}입니다");
     
    }
    void SayHello(string name)
    {
        Debug.Log($"안녕하세요, {name},님");
    }
    
    void Update()
    {
       
    }
}
