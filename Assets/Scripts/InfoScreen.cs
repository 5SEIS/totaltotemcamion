using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoScreen : MonoBehaviour
{
    protected bool _standby = true;
    protected Animator _myAnim;

    public bool IsStandby => _standby;

    // Start is called before the first frame update
    protected void Start()
    {
        _myAnim = GetComponent<Animator>();
    }

    public void SetVisibility(bool val)
    {
        _myAnim.SetBool("Visible", val);
    }

    public virtual void SetScreen(string prodName)
    {
        _standby = false;
    }

    public virtual void SetProduct(bool view)
    {
        _standby = false;
    }

    public virtual void DisableScreen()
    {
        _standby = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
