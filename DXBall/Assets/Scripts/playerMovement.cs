using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D pad;
    private Vector2 position;
    public float displacement = 0.1f;
    public Animator animator;

    void Start()
    {
        pad = GetComponent<Rigidbody2D>();
        position = pad.transform.localPosition;
    }

    void Update()
    {
        bool isMoving = false;

        // Move Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            isMoving = true;
            if (position.x <= 9.75f)
                position.x += displacement;
        }

        // Move Left
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            isMoving = true;
            if (position.x >= -9.75f)
                position.x -= displacement;
        }

        // Update animation
        animator.SetBool("isRunning", isMoving);

        // Apply new position using Rigidbody2D
        pad.MovePosition(position);
    }
}
