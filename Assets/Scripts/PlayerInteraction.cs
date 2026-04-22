using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathPlane"))
        {
            GameEventsManager.instance.PlayerDeath();
            transform.position = new Vector3(0, 1.5f, 0);
        }
    }
}
