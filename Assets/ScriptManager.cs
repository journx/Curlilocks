using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ScriptManager : MonoBehaviour
{
    public List<string> passages = new List<string>();
    public int currentPassage = 0;
    public StoryManager storyManager;
    public TextMeshProUGUI text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = passages[currentPassage];
    }


    public void NextPassage()
    {
        currentPassage++;
    }
    
}
