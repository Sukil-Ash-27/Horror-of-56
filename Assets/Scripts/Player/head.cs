using UnityEngine;

public class head : MonoBehaviour
{
    [SerializeField] private Transform bodypos;
    void Update()
    {
        float xpos= bodypos.position.x;
        float ypos = bodypos.position.y + 0.2f;
        transform.position = new Vector3(xpos, ypos,transform.position.z);
    }
}
