using UnityEngine;
using UnityEngine.InputSystem;

public class PauseManager : MonoBehaviour
{
    public InputActionAsset InputActions;

    public InputAction m_pauseAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        m_pauseAction = InputSystem.actions.FindAction("Pause/Pause");
    }

    // Update is called once per frame
    void Update()
    {
        if(m_pauseAction.WasPressedThisFrame())
        {
            if(Time.timeScale == 1f)
            {
                Time.timeScale = 0f; // Pause the game
            }
            else
            {
                Time.timeScale = 1f; // Resume the game
            }
        }
    }
}
