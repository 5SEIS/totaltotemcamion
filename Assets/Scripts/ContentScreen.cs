using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContentScreen : MonoBehaviour
{
    public Animator ctaAnim;
    public Animator camionAnim;
    private InfoScreen _currentScreen;
    private Animator _myAnim;
    private bool _canInteract = true;

    private float _resetT = 0;

    // Start is called before the first frame update
    void Start()
    {
        _myAnim = GetComponent<Animator>();
    }

    public void SetScreen(GameObject screen)
    {
        _currentScreen = screen.GetComponent<InfoScreen>();
    }

    public void GoBack()
    {
        if (_canInteract)
        {
            _canInteract = false;
            Invoke("ReactivateInteraction",1f);
            if (_currentScreen != null)
            {
                if (_currentScreen.IsStandby)
                {
                    BackToCamion();
                }
                else
                {
                    _currentScreen.DisableScreen();
                }
            }
            else
            {
                BackToCamion();
            }
        }
    }

    private void BackToCamion()
    {
        SetContentButtons(false);
        _currentScreen.SetVisibility(false);
        Invoke("ReturnCamion",1f);
    }

    private void ReturnCamion()
    {
        camionAnim.SetTrigger("Camion");
    }

    private void ReactivateInteraction()
    {
        _canInteract = true;
    }

    public void SetContentButtons(bool val)
    {
        _myAnim.SetBool("Visible",val);
    }

    public void BackHome()
    {
        ctaAnim.SetTrigger("Appear");
        Invoke("ResetApp",0.5f);
    }

    private void ResetApp()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown || Input.touchCount > 0)
        {
            _resetT = 0;
        }
        if(_resetT >= 60)
        {
            _resetT = 0;
            ResetApp();
        }
        else
        {
            _resetT += Time.deltaTime;
        }
    }
}
