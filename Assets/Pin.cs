using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;

    public float speed = 20f;
    public Rigidbody2D rb;

    void Start()
    {
        speed = PlayerPrefs.GetFloat("NEWPINSPEED", 20);
    }
    void Update()
    {
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.PinCount++;
            //col.GetComponent<Rotator>().speed += 3f; // *= -1; to change spin direction
            isPinned = true;
        } else if (col.tag == "Pin")
        {
            
            Destroy(gameObject);
            FindObjectOfType<GameManager>().EndGame();
            SceneManager.LoadScene("Credits");
            
        }

    }

    public void GoGoPin(float newSpeed)
    {
        speed = newSpeed;
        PlayerPrefs.SetFloat("NEWPINSPEED", speed);
    }
}
