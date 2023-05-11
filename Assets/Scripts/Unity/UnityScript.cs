using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.Events;

public class UnityScript : MonoBehaviour
{
    // ������Ʈ Componenet)
    // Ư���� ����� ������ �� �ֵ��� ������ ���� ����� ����
    // ���ӿ�����Ʈ�� �۵��� ���õ� ��ǰ
    // ����������Ʈ�� �߰�, �����ϴ� ����� ������ ��ǰ

    // MonoBehaviour
    // ������Ʈ�� �⺻Ŭ������ �ϴ� Ŭ������ ����Ƽ ��ũ��Ʈ�� �Ļ��Ǵ� �⺻ Ŭ����
    // ���ӿ�����Ʈ�� ��ũ��Ʈ�� ������Ʈ�μ� ������ �� �ִ� ������ ����
    // ��ũ��Ʈ�� ����ȭ ���, ����Ƽ�޽��� �̺�Ʈ�� �޴� ���, �ڷ�ƾ ����� ������

    // ��ũ��Ʈ ����ȭ ���
    // �ν����� â���� ������Ʈ�� �ɹ����� ���� Ȯ���ϰų� �����ϴ� ���
    // ������Ʈ�� ������ �����͸� Ȯ���ϰų� ����
    // ������Ʈ�� �������� �����͸� �巡�� �� ��� ������� ����

    // �ν�����â ����ȭ�� ������ �ڷ���
    [Header("C# Type")]
    public bool boolValue;
    public int intValue;
    public float floatValue;
    public string stringValue;
    // �� �� �⺻ �ڷ���

    // �⺻ �ڷ����� �����ڷᱸ��
    public int[] array;
    public List<int> list;

    [Header("Unity Type")]
    public Vector3 vector3;
    public Color color;
    public LayerMask layerMask;
    public AnimationCurve curve;
    public Gradient gradient;

    [Header("Unity GameObject")]
    public GameObject obj;
    public Rigidbody rb;

    [Header("Unity Component")]
    public new Transform transform;
    public new Rigidbody rigidbody;
    public new Collider collider;

    [Header("Unity Event")]
    public UnityEvent OnEvent;

    // ��Ʈ����Ʈ
    // Ŭ����, ������Ƽ �Ǵ� �Լ� ���� ����Ͽ� Ư���� ������ ���Ƴ� �� �ִ� ��Ŀ

    [Space(30)]
    [Header("Unity Attribute")]
    [SerializeField]
    private int privateValue;
    [HideInInspector]
    public int publicValue;

    [Range(0, 10)]
    public float rangeValue;

    [TextArea(3, 5)]
    public string textField;

    
}
