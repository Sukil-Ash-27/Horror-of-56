using UnityEngine;

public class Sofa : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] private GameObject player;
    [SerializeField] private Transform refrence;

    private void Awake()
    {
         spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.sortingOrder = player.transform.position.y < refrence.position.y ? 0 : 2;
    }
}
