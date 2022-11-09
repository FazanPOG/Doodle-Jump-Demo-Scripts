using UnityEngine;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    private Button _Startbutton;
    private Button _Pausebutton;
    private Button _Continuebutton;
    private Label _GameOver;

    void Start()
    {
        var _root = GetComponent<UIDocument>().rootVisualElement;
        _Startbutton = _root.Q<Button>("ButtonStart");
        _Pausebutton = _root.Q<Button>("ButtonPause");
        _Continuebutton = _root.Q<Button>("ButtonContinue");
        _GameOver = _root.Q<Label>("LabelGameOver");

        Time.timeScale = 0;

        SetInvisible(_Pausebutton);
        SetInvisible(_Continuebutton);

        _Startbutton.clickable.clicked += () =>
        {
            StartPlay();
        };
        _Pausebutton.clickable.clicked += () => 
        {
            PauseOn();
        };
        _Continuebutton.clickable.clicked += () => 
        {
            PauseOff();
        };
        
    }
    
    public void PauseOn() 
    {
        Time.timeScale = 0;

        SetInvisible(_Pausebutton);
        SetVisible(_Continuebutton);
    }
    public void PauseOff() 
    {
        Time.timeScale = 1;

        SetVisible(_Pausebutton);
        SetInvisible(_Continuebutton);
    }
    public void StartPlay() 
    {
        Time.timeScale = 1;

        SetInvisible(_Startbutton);
        SetVisible(_Pausebutton);
    }
    public static void SetInvisible(VisualElement uiElement) 
    {
        uiElement.visible = false;
        uiElement.SetEnabled(false);
    }
    public static void SetVisible(VisualElement uiElement)
    {
        uiElement.visible = true;
        uiElement.SetEnabled(true);
    }
}
