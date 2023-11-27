using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashPlayer : MonoBehaviour
{
    public TrailRenderer _TrailRender; 
    //_TrailRender = GetComponent<TrailRender>();
    [Header("Dashing")]
    public float  dashingVelocity = 14f;
    public float  dashingTime= 0.5f;
    private Vector2 _dashingDir;
    private bool _isDashing=false;
    private bool _canDash=true;

    Rigidbody2D _rigidbody;
private void Start() {
    _rigidbody = GetComponent<Rigidbody2D>();
}
public void Dash()
{
    if(_canDash){
        _isDashing= true;
        _canDash=false;
        _TrailRender.emitting=true;
        _dashingDir= new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (_dashingDir == Vector2.zero)
        {
            _dashingDir = new Vector2(transform.localScale.x, 0);
        }
        StartCoroutine(StopDashing());
    }
    if (_isDashing)
    {
        _rigidbody.velocity = _dashingDir.normalized * dashingVelocity;
        return;
    }
}
    private IEnumerator StopDashing()
    {
        yield return new WaitForSeconds(dashingTime);
        _TrailRender.emitting = false;
        _isDashing = false;

    }
}
