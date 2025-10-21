using TMPro;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class WalkMoviment : MonoBehaviour
{
    [SerializeField] float velocidade = 5;
    [SerializeField] float velocidadeAngular = 30;

    InputSystem_Actions inputSystemActions;//isso é um campo
    InputAction move;
    float velY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputSystemActions = new InputSystem_Actions();
        move = inputSystemActions.Player.Move;
        inputSystemActions.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        {
            Vector2 sentido = move.ReadValue<Vector2>();
            // transform.Translate(0, velocidade * sentido.y * Time.deltaTime, 0);
            velY = velocidade * sentido.y;
            transform.Rotate(0, 0, -velocidadeAngular * sentido.x * Time.deltaTime);
        }
    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().linearVelocity = transform.up * velY;
    }
}
