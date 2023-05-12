using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Pool;

public class UnityInput : MonoBehaviour
{
    // ����Ƽ �Է�
    // ����Ƽ���� ������� ����� ������ �� �ִ� ����
    // ����ڴ� �ܺ� ��ġ�� �̿��Ͽ� ������ ������ �� ����
    // ����Ƽ�� �پ��� Ÿ���� �Է±�� (Ű���� �� ���콺, ���̽�ƽ, ��ġ��ũ�� ��)�� ����

    // Device
    // Ư���� ��ġ�� �������� �Է� ����
    // Ư���� ��ġ�� �Է��� �����ϱ� ������ ���� �÷����� ������ �����
    private void InputByDevice()
    {
        // Ű���� �Է�
        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("Key up");
        }
        if ( Input.GetKeyDown(KeyCode.Space) )
        {
            print("Key Down");
        }
        if ( Input.GetKey(KeyCode.Space) )
        {
            print("Key Pressing");
        }

        // ���콺 �Է�
        if(Input.GetMouseButton(0))
        {
            print("Mouse Left button pressing");
        }
        if ( Input.GetMouseButtonUp(0))
        {
            print("Mouse Left button Up");
        }
        if ( Input.GetMouseButtonUp(0))
        {
            print("Mouse Left button Down");
        }
    }
    
    // InputManager
    // ���� ��ġ�� �Է��� �Է¸Ŵ����� �̸��� �Է��� ����
    // �Է¸Ŵ����� �̸����� ������ �Է��� ��������� Ȯ��
    // ����Ƽ �������� Edit > Project Settings > Input Manager ���� ����
    private void InputbyInputManager()
    {
        // ��ư �Է�
        // Fire1 : Ű���� (Left ctrl), ���콺 (Left Button) , ���̽�ƽ(button0) ���� ����
        if ( Input.GetButton("Fire1"))
        {
            print("Fire1 is pressing");
        }
        if (Input.GetButtonDown("Fire1"))
        {
            print("Fire1 is down");
        }
        if (Input.GetButtonUp("Fire1"))
        {
            print("Fire1 is up");
        }

        // ���Է�
        // horizontal ����: Ű����(a,d/ <- ->), ���̽�ƽ(���� �Ƴ��α׽�ƽ �¿�)
        float x = Input.GetAxis("Horizontal");
        print(x);
        float y = Input.GetAxis("Vertical");
        print(y);
    }

    // <InputSystem>
    // Unity 2019.1 ���� �����ϰ� �� �Է¹��
    // ������Ʈ�� ���� �Է��� ��������� Ȯ��
    // GamePad, JoyStick, Mouse, Keyboard, Pointer, Pen, TouchScreen, XR ��� ���� ����
    private void InputByInputSystem()
    {
        // InputSystem�� �̺�Ʈ ������� ������
        // Update���� �Էº�������� Ȯ���ϴ� ��� ��� ������ ���� ��� �̺�Ʈ�� Ȯ��
        // �޽����� ���� �޴� ��İ� �̺�Ʈ �Լ��� ���� �����ϴ� ��� ������ ����
    }

    // Move �Է¿� �����ϴ� OnMove �޽��� �Լ�
    private void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
    }
    private void OnJump(InputValue value)
    {
        bool isPress = value.isPressed;
    }
}
