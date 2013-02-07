/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Box2DCS {

using System;
using System.Runtime.InteropServices;

public class b2Contact : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2Contact(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2Contact obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public b2Manifold GetManifold() {
    IntPtr cPtr = Box2DPINVOKE.b2Contact_GetManifold__SWIG_0(swigCPtr);
    b2Manifold ret = (cPtr == IntPtr.Zero) ? null : new b2Manifold(cPtr, false);
    return ret;
  }

  public void GetWorldManifold(b2WorldManifold worldManifold) {
    Box2DPINVOKE.b2Contact_GetWorldManifold(swigCPtr, b2WorldManifold.getCPtr(worldManifold));
  }

  public bool IsTouching() {
    bool ret = Box2DPINVOKE.b2Contact_IsTouching(swigCPtr);
    return ret;
  }

  public void SetEnabled(bool flag) {
    Box2DPINVOKE.b2Contact_SetEnabled(swigCPtr, flag);
  }

  public bool IsEnabled() {
    bool ret = Box2DPINVOKE.b2Contact_IsEnabled(swigCPtr);
    return ret;
  }

  public b2Contact GetNext() {
    IntPtr cPtr = Box2DPINVOKE.b2Contact_GetNext__SWIG_0(swigCPtr);
    b2Contact ret = (cPtr == IntPtr.Zero) ? null : new b2Contact(cPtr, false);
    return ret;
  }

  public b2Fixture GetFixtureA() {
    IntPtr cPtr = Box2DPINVOKE.b2Contact_GetFixtureA__SWIG_0(swigCPtr);
    b2Fixture ret = (cPtr == IntPtr.Zero) ? null : new b2Fixture(cPtr, false);
    return ret;
  }

  public int GetChildIndexA() {
    int ret = Box2DPINVOKE.b2Contact_GetChildIndexA(swigCPtr);
    return ret;
  }

  public b2Fixture GetFixtureB() {
    IntPtr cPtr = Box2DPINVOKE.b2Contact_GetFixtureB__SWIG_0(swigCPtr);
    b2Fixture ret = (cPtr == IntPtr.Zero) ? null : new b2Fixture(cPtr, false);
    return ret;
  }

  public int GetChildIndexB() {
    int ret = Box2DPINVOKE.b2Contact_GetChildIndexB(swigCPtr);
    return ret;
  }

  public void SetFriction(float friction) {
    Box2DPINVOKE.b2Contact_SetFriction(swigCPtr, friction);
  }

  public float GetFriction() {
    float ret = Box2DPINVOKE.b2Contact_GetFriction(swigCPtr);
    return ret;
  }

  public void ResetFriction() {
    Box2DPINVOKE.b2Contact_ResetFriction(swigCPtr);
  }

  public void SetRestitution(float restitution) {
    Box2DPINVOKE.b2Contact_SetRestitution(swigCPtr, restitution);
  }

  public float GetRestitution() {
    float ret = Box2DPINVOKE.b2Contact_GetRestitution(swigCPtr);
    return ret;
  }

  public void ResetRestitution() {
    Box2DPINVOKE.b2Contact_ResetRestitution(swigCPtr);
  }

  public virtual void Evaluate(b2Manifold manifold, b2Transform xfA, b2Transform xfB) {
    Box2DPINVOKE.b2Contact_Evaluate(swigCPtr, b2Manifold.getCPtr(manifold), b2Transform.getCPtr(xfA), b2Transform.getCPtr(xfB));
    if (Box2DPINVOKE.SWIGPendingException.Pending) throw Box2DPINVOKE.SWIGPendingException.Retrieve();
  }

}

}