using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityBasic : MonoBehaviour
{
    GameObject player;
    public AudioSource audioSource;
    public void GameObjectBasic()
    {
        // 게임오브젝트 접근 
        // 컴포넌트가 붙어있는 게임오브젝트는 gameObject 속성을 이용하여 접근가능

        // 컴포넌트가 붙어있는 게임오브젝트
        //gameObject.name;
        //gameObject.active;
        //gameObject.tag;
        //gameObject.layer;

        // 게임 오브젝트 탐색

        gameObject.name = "Player";
        player = GameObject.Find("Player");
        player = GameObject.FindGameObjectWithTag("Player");
        GameObject.FindGameObjectsWithTag("Player");

        // 게임오브젝트 생성
        GameObject newObject = new GameObject();
        newObject.name = "New Game Object";

        // 게임오브젝트 삭제
        Destroy(newObject, 5f); // 5초뒤 destroy

        newObject = new GameObject("New Game Object");
    }

    public void ComponentBasic()
    {
        // 게임오브젝트에 있는 컴포넌트 접근
        audioSource = GetComponent<AudioSource>(); // 컴포넌트에서 getComponent를 사용할 경우 
        audioSource = gameObject.GetComponent<AudioSource>(); // 게임오브젝트의 컴포넌트에 접근
        gameObject.GetComponents<AudioSource>(); // 컴포넌트를 기준으로 여러 컴포넌트 접근
        gameObject.GetComponents<AudioSource>(); // 게임오브젝트의 여러 컴포넌트 접근
        gameObject.GetComponentInChildren<AudioSource>(); // 자식게임오브젝트 포함 컴포넌트 접근
        gameObject.GetComponentsInChildren<AudioSource>(); // 자식게임오브젝트 포함 여러 컴포넌트 접근
        gameObject.GetComponentsInParent<AudioSource>(); // 게임오브젝트의 부모게임오브젝트 포함 컴포넌트 접근

        // 컴포넌트 탐색
        FindObjectOfType<UnityScript>();  // 씬 내의 컴포넌트 탐색
        FindObjectsOfType<UnityBasic>(); // 씬 내 모든 컴포넌트 탐색

        // 컴포넌트 추가
        Rigidbody rigid = new Rigidbody(); // 가능하나 의미 없음, 컴포넌트는 게임오브젝트에 부착되어 동작함에 의미가 있음
        Rigidbody rb = gameObject.AddComponent<Rigidbody>(); // 게임오브젝트에 컴포넌트 추가
        // 컴포넌트 삭제
        Destroy(rb);
    }
    // 게임오브젝트를 이름으로 찾는 것은 느려서 태그로 찾는걸 추천한다.
    // 컴포넌트를 찾을때는 tag로 찾을 수 없기때문에 느리다.

}
