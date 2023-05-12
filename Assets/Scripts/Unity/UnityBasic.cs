using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityBasic : MonoBehaviour
{
    GameObject player;
    public AudioSource audioSource;
    public void GameObjectBasic()
    {
        // ���ӿ�����Ʈ ���� 
        // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ�� gameObject �Ӽ��� �̿��Ͽ� ���ٰ���

        // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ
        //gameObject.name;
        //gameObject.active;
        //gameObject.tag;
        //gameObject.layer;

        // ���� ������Ʈ Ž��

        gameObject.name = "Player";
        player = GameObject.Find("Player");
        player = GameObject.FindGameObjectWithTag("Player");
        GameObject.FindGameObjectsWithTag("Player");

        // ���ӿ�����Ʈ ����
        GameObject newObject = new GameObject();
        newObject.name = "New Game Object";

        // ���ӿ�����Ʈ ����
        Destroy(newObject, 5f); // 5�ʵ� destroy

        newObject = new GameObject("New Game Object");
    }

    public void ComponentBasic()
    {
        // ���ӿ�����Ʈ�� �ִ� ������Ʈ ����
        audioSource = GetComponent<AudioSource>(); // ������Ʈ���� getComponent�� ����� ��� 
        audioSource = gameObject.GetComponent<AudioSource>(); // ���ӿ�����Ʈ�� ������Ʈ�� ����
        gameObject.GetComponents<AudioSource>(); // ������Ʈ�� �������� ���� ������Ʈ ����
        gameObject.GetComponents<AudioSource>(); // ���ӿ�����Ʈ�� ���� ������Ʈ ����
        gameObject.GetComponentInChildren<AudioSource>(); // �ڽİ��ӿ�����Ʈ ���� ������Ʈ ����
        gameObject.GetComponentsInChildren<AudioSource>(); // �ڽİ��ӿ�����Ʈ ���� ���� ������Ʈ ����
        gameObject.GetComponentsInParent<AudioSource>(); // ���ӿ�����Ʈ�� �θ���ӿ�����Ʈ ���� ������Ʈ ����

        // ������Ʈ Ž��
        FindObjectOfType<UnityScript>();  // �� ���� ������Ʈ Ž��
        FindObjectsOfType<UnityBasic>(); // �� �� ��� ������Ʈ Ž��

        // ������Ʈ �߰�
        Rigidbody rigid = new Rigidbody(); // �����ϳ� �ǹ� ����, ������Ʈ�� ���ӿ�����Ʈ�� �����Ǿ� �����Կ� �ǹ̰� ����
        Rigidbody rb = gameObject.AddComponent<Rigidbody>(); // ���ӿ�����Ʈ�� ������Ʈ �߰�
        // ������Ʈ ����
        Destroy(rb);
    }
    // ���ӿ�����Ʈ�� �̸����� ã�� ���� ������ �±׷� ã�°� ��õ�Ѵ�.
    // ������Ʈ�� ã������ tag�� ã�� �� ���⶧���� ������.

}
