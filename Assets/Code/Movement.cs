using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 10;
    private Vector2 movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(movementSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(movement.x, movement.y, 0) * movementSpeed * Time.deltaTime;
    }
    public void OnMovement(InputValue input)
    {
        movement = input.Get<Vector2>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("DeathScene");
        }
    }
}
