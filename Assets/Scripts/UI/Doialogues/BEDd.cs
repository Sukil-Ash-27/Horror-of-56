using UnityEngine;

public class BEDd : MonoBehaviour
{
    private DialogueTrigger dt;
    private bool t=false;
    
    private void Awake()
    {
        dt = GetComponent<DialogueTrigger>();
    }
    private void Start()
    {
        t = true;
    }



    void Update()
     {
     // if (Input.GetKeyDown(KeyCode.V))
     if (t)
      {
        dt.TriggerDialogue();
            t = false;
      }
   }
}
