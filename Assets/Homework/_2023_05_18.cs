using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class _2023_05_18 : MonoBehaviour
{
    public class GameManager
    {
        static private GameManager instance;
        // (������ ���� ����)
        public static GameManager Instance
        {
            get { return instance; }
        }
        private void Awake()
        {
            if (instance != null)
            {
                // �̹� ���� �Ŵ����� ������ ��� ���� ������ ������ ���ӸŴ����� �ı��ϴ� �ڵ�
                // (�ϳ��� ���ӿ� ����)
                //Destroy(this);
            }
            instance = this;
            // ������ ���ӸŴ����� �ٸ� ������ �Ѿ�� ������� �ʰ� ���� �Ѿ���� �ϴ� �ڵ�
            // (���� �ٲ㵵 ����)
            //DontDestroyOnLoad(this);
        }
    }
}

