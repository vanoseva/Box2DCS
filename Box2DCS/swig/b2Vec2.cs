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

public class b2Vec2 : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2Vec2(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2Vec2 obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2Vec2() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2Vec2(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public b2Vec2() : this(Box2DPINVOKE.new_b2Vec2__SWIG_0(), true) {
  }

  public b2Vec2(float x, float y) : this(Box2DPINVOKE.new_b2Vec2__SWIG_1(x, y), true) {
  }

  public void SetZero() {
    Box2DPINVOKE.b2Vec2_SetZero(swigCPtr);
  }

  public void Set(float x_, float y_) {
    Box2DPINVOKE.b2Vec2_Set(swigCPtr, x_, y_);
  }

  public float Length() {
    float ret = Box2DPINVOKE.b2Vec2_Length(swigCPtr);
    return ret;
  }

  public float LengthSquared() {
    float ret = Box2DPINVOKE.b2Vec2_LengthSquared(swigCPtr);
    return ret;
  }

  public float Normalize() {
    float ret = Box2DPINVOKE.b2Vec2_Normalize(swigCPtr);
    return ret;
  }

  public bool IsValid() {
    bool ret = Box2DPINVOKE.b2Vec2_IsValid(swigCPtr);
    return ret;
  }

  public b2Vec2 Skew() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2Vec2_Skew(swigCPtr), true);
    return ret;
  }

  public float x {
    set {
      Box2DPINVOKE.b2Vec2_x_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Vec2_x_get(swigCPtr);
      return ret;
    } 
  }

  public float y {
    set {
      Box2DPINVOKE.b2Vec2_y_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Vec2_y_get(swigCPtr);
      return ret;
    } 
  }

}

}
