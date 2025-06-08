using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1; //true면 Player1에 적용, false면 Player2에 적용
    public float moveSpeed; // Paddle이 얼마나 빠르게 움직이게 할것인지 스피드값
    public Rigidbody2D rb; // 물리력을 적용시키기 위한 Rigibody 컴포넌트에 연겨하기 위한 변수

    private float movement; // 시제 키 값 (w,s Up Down)을 받아 움직이게 하기 위한 변수

    public Vector3 startPosition; //시작 초기값을 저장하기 위한 변수
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
            //Player1 움직임
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            //player2 움직임
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
