using System;
using UnityEngine;
using TMPro;


/*
How To Use
Copy it and Drag the logger GameObject !

Public GameObject Logger;

at Init,
DebugPrinter p = Logger.getComponent<DebugPrinter>();

Usasge
p.Log("Hi Test");


*/
public class DebugPrinter : MonoBehaviour
{
    public GameObject TextGameObject;
    private TextMeshPro _textBlock;
    private string _messageText = string.Empty;
    private int _messageCount;

    void Start()
    {
        _textBlock = TextGameObject.GetComponent<TextMeshPro>();
    }
    public void Log(string message)
    {
        if(_messageCount >= 20)
            _messageText=_messageText.Substring(0,_messageText.LastIndexOf("\n",_messageText.Length-1));
            var newMessage = $"[{_messageCount++}] {DateTime.Now.ToString("hh:MM:ss")} : {message}\n{_messageText}";
        _messageText = newMessage;
        _textBlock.SetText(newMessage);
    }

}

