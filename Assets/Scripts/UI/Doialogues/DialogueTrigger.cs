using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class DialogueTrigger : MonoBehaviour
{
   
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindFirstObjectByType<DialogueManager>().StartDialogue(dialogue);
    
    }
}
