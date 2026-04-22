using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerWalk : MonoBehaviour, IDataPersistence
{
    public InputActionAsset InputActions;

    public InputAction m_moveAction;

    private Vector3 m_moveDirection;
    private Rigidbody m_rigidbody;

    public float walkSpeed = 5f;

    private void Awake()
    {
        m_moveAction = InputSystem.actions.FindAction("Move");

        m_rigidbody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        ButtonHandler.instance.OnNewGame += OnNewGame;
    }

    private void OnNewGame()
    {
        transform.position = new Vector3(0, 1.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        m_moveDirection = m_moveAction.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector3 move = new Vector3(m_moveDirection.x, 1.5f, m_moveDirection.y);
        m_rigidbody.MovePosition(transform.position + move * walkSpeed * Time.fixedDeltaTime);
    }

    public void LoadData(GameData data)
    {
        transform.position = data.playerPosition;
    }

    public void SaveData(ref GameData data)
    {
        data.playerPosition = transform.position;
    }
}
