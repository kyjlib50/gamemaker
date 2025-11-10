using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
public class NewMonoBehaviourScript2_2 : MonoBehaviour
{
    public float moveAcceleration = 5.0f;
    public float maxSpeed = 4.0f;
    public GameObject GameOvertext;
    Rigidbody2D rb3_1;
    Vector2 Move3_1;
    public float TimeSpeed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameOvertext.SetActive(false);
        rb3_1 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move3_1 = rb3_1.linearVelocity;

        float moveX3_1 = 0f;
        if (Keyboard.current.rightArrowKey.isPressed) moveX3_1 += 1f;
        if (Keyboard.current.leftArrowKey.isPressed) moveX3_1 -= 1f;

        // ÁÂ¿ì ÀÌµ¿
        Move3_1.x += moveX3_1 * moveAcceleration * Time.fixedDeltaTime;
        Move3_1.x = Mathf.Clamp(Move3_1.x, -maxSpeed, maxSpeed);

        if (!Keyboard.current.rightArrowKey.isPressed && !Keyboard.current.leftArrowKey.isPressed)
        {
            Move3_1.x = Mathf.Lerp(Move3_1.x, 0, 0.05f); // ¼­¼­È÷ ¸ØÃã
        }

        rb3_1.linearVelocity = Move3_1;

        if (Keyboard.current.shiftKey.isPressed)
        {
            if (Time.timeScale == 1.0f)
                Time.timeScale = 1 / 3f;

            TimeSpeed = Time.timeScale; // Inspector µ¿±âÈ­
        }
        else {
            Time.timeScale = 1.0f;
            TimeSpeed = Time.timeScale;
        }

    }
    void OnCollisionEnter2D(Collision2D playercollision)
    {
        if (playercollision.gameObject.CompareTag("Triangle"))
        {
            GameOvertext.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}