using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public Queue<string> names;
    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public string[] sentences2;
    public string[] names2;
    public Queue<string> sentences;
    private void Start() {
        sentences = new Queue<string>();
        names = new Queue<string>();
        foreach (string sentence in sentences2) {
            sentences.Enqueue(sentence);
        }
        foreach (string name in names2) {
            names.Enqueue(name);
        }
        
    }
    public void StartDialogue(Dialogue dialogue) {
        sentences.Clear();
        foreach (string sentence in dialogue.sentences) {
            sentences.Enqueue(sentence);
        }
        foreach (string name in dialogue.names)
        {
            names.Enqueue(name);
        }

        DisplayNextSentence();
    }
    public void DisplayNextSentence() {
        if (sentences.Count == 0) {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        string name= names.Dequeue();
        nameText.text = name;

    }
    public void EndDialogue() {
        SceneManager.LoadScene(3);
    }
}
