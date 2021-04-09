using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat_va_cham : MonoBehaviour
{
    GameController m_gc;
    public Rigidbody2D rb;
    // hai loại va chạm đi xuyên qua nhau và không đi xuyên 

    private void Start() {
        m_gc = FindObjectOfType<GameController>();
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * 500);
    }

    // bat va cham voi vat the Player (Tag cua object game is Player)
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player"))
        {
            m_gc.IncrementScore();
            // Destroy(gameObject);
            Debug.Log("Qua bong va cham voi gia do");
        }

        if(other.gameObject.CompareTag("bong"))
        {
            m_gc.IncrementScore();
            Destroy(gameObject);
        }
    }

    // phai set thuoc tinh cua vat the DeathZone trong commpont Box col... is Trigger (xuyen qua)
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("DeathZone")) // bắt sự kiện xuyên qua
        {
            // m_gc.SetGameOverState(true);
            Destroy(gameObject);
            // Debug.Log("Quai vat va cham voi vuc sau");
        }
    }
}

