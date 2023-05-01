using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickCjill : MonoBehaviour
{
    brick brick;
    private void Start()
    {
        brick = this.GetComponentInParent<brick>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.CompareTag("Ball"))
        {
            Ball b = collision.gameObject.GetComponent<Ball>();

            Vector3 income = b.MovePos; // �Ի纤��
            Vector3 normal = collision.contacts[0].normal; // ��������
            b.MovePos = Vector3.Reflect(income, normal).normalized; // �ݻ纤��

            b.SpeedUp();
            brick.BallCol();
        }
    }
}

