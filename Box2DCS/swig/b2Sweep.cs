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

public class b2Sweep : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2Sweep(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2Sweep obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2Sweep() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2Sweep(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public void GetTransform(b2Transform xfb, float beta) {
    Box2DPINVOKE.b2Sweep_GetTransform(swigCPtr, b2Transform.getCPtr(xfb), beta);
  }

  public void Advance(float alpha) {
    Box2DPINVOKE.b2Sweep_Advance(swigCPtr, alpha);
  }

  public void Normalize() {
    Box2DPINVOKE.b2Sweep_Normalize(swigCPtr);
  }

  public b2Vec2 localCenter {
    set {
      Box2DPINVOKE.b2Sweep_localCenter_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Box2DPINVOKE.b2Sweep_localCenter_get(swigCPtr);
      b2Vec2 ret = (cPtr == IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public b2Vec2 c0 {
    set {
      Box2DPINVOKE.b2Sweep_c0_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Box2DPINVOKE.b2Sweep_c0_get(swigCPtr);
      b2Vec2 ret = (cPtr == IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public b2Vec2 c {
    set {
      Box2DPINVOKE.b2Sweep_c_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Box2DPINVOKE.b2Sweep_c_get(swigCPtr);
      b2Vec2 ret = (cPtr == IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public float a0 {
    set {
      Box2DPINVOKE.b2Sweep_a0_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Sweep_a0_get(swigCPtr);
      return ret;
    } 
  }

  public float a {
    set {
      Box2DPINVOKE.b2Sweep_a_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Sweep_a_get(swigCPtr);
      return ret;
    } 
  }

  public float alpha0 {
    set {
      Box2DPINVOKE.b2Sweep_alpha0_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Sweep_alpha0_get(swigCPtr);
      return ret;
    } 
  }

  public b2Sweep() : this(Box2DPINVOKE.new_b2Sweep(), true) {
  }

}

}
