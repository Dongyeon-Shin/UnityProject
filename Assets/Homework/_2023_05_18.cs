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
        // (전역에 접근 가능)
        public static GameManager Instance
        {
            get { return instance; }
        }
        private void Awake()
        {
            if (instance != null)
            {
                // 이미 게임 매니저가 존재할 경우 새로 생성된 지금의 게임매니저를 파괴하는 코드
                // (하나만 게임에 유지)
                //Destroy(this);
            }
            instance = this;
            // 생성한 게임매니저가 다른 씬으로 넘어갈때 사라지지 않고 같이 넘어가도록 하는 코드
            // (씬이 바꿔도 유지)
            //DontDestroyOnLoad(this);
        }
    }
}

