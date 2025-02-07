using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTrigger : MonoBehaviour
{
    private bool isPlayerNear = false;
    [SerializeField]private Vector3 playerpos;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject Ebut;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
            Ebut.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
            Ebut.SetActive(false);
        }
    }

    private void Update()
    {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
           player.transform.position = playerpos;
        }
    }
}
