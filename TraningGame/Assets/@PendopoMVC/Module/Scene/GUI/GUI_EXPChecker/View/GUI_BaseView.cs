using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using NaughtyAttributes;

public abstract class GUI_BaseView : BaseView
{
    [SerializeField] private RectTransform hud;
    [SerializeField] private Vector2 onPosition;
    [SerializeField] private Vector2 offPosition;
    private bool isOpen = false;
    internal UnityAction publishMessage;

    public void SetActive()
    {
        isOpen = !isOpen;
        hud.anchoredPosition = isOpen ? onPosition : offPosition;
    }
    public void CheckSegment()
    {
        publishMessage?.Invoke();
    }


    [Button("On Pos")]
    private void AddOnPos()
    {
        onPosition = hud.anchoredPosition;
    }

    [Button("Off Pos")]
    private void AddOffPos()
    {
        offPosition = hud.anchoredPosition;
    }
}