using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float moveSpeed; // Ball이 얼마나 빠르게 움직이게 할것인지 스피드값
    public Rigidbody2D rb; // 물리력을 적용시키기 위한 Rigibody 컴포넌트에 연겨하기 위한 변수
                           // Start is called before the first frame update

    public Vector3 startPosition; //시작 초기값을 저장하기 위한 변수
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
