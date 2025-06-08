using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float moveSpeed; // Ball�� �󸶳� ������ �����̰� �Ұ����� ���ǵ尪
    public Rigidbody2D rb; // �������� �����Ű�� ���� Rigibody ������Ʈ�� �����ϱ� ���� ����
                           // Start is called before the first frame update

    public Vector3 startPosition; //���� �ʱⰪ�� �����ϱ� ���� ����
    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
        Init();
    }

    private void Init()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        rb.velocity = new Vector2(x * moveSpeed, y * moveSpeed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Init();
    }

}
