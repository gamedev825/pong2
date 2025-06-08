using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1; //true�� Player1�� ����, false�� Player2�� ����
    public float moveSpeed; // Paddle�� �󸶳� ������ �����̰� �Ұ����� ���ǵ尪
    public Rigidbody2D rb; // �������� �����Ű�� ���� Rigibody ������Ʈ�� �����ϱ� ���� ����

    private float movement; // ���� Ű �� (w,s Up Down)�� �޾� �����̰� �ϱ� ���� ����

    public Vector3 startPosition; //���� �ʱⰪ�� �����ϱ� ���� ����
    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1.Equals(true))
        {
            //Player1 ������
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            //player2 ������
            movement = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * moveSpeed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
