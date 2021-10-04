using System;
using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.PlayerLoop;

public abstract class TextUpdaterBase<T> : MonoBehaviour, ITextUpdater where T: Component
{
    public T textComponent;
    [SerializeField] protected object[] texts;
    [SerializeField] protected string format;

    public abstract void UpdateText();
    public void UpdateText(object text)
    {
        if(text == null)
            UpdateText("null");
        else
        {
            texts = new object[] {text};
            UpdateText();
        }
    }

    public void UpdateText(string text)
    {
        UpdateText((object)text);
    }

    public void UpdateText(object text, string _format)
    {
        format = _format;
        UpdateText(text);
    }

    public void UpdateText(object[] _texts)
    {
        texts = _texts;
        UpdateText();
    }

    public void UpdateText(object[] _texts, string _format)
    {
        format = _format;
        UpdateText(_texts);
    }

    public void UpdateText(ScriptableObject text)
    {
        UpdateText((object)text);
    }

    public void UpdateText(float text)
    {
        UpdateText((object)text);
    }
}
