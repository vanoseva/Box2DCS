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

public class b2Jacobian : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2Jacobian(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2Jacobian obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2Jacobian() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2Jacobian(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public b2Vec2 linear {
    set {
      Box2DPINVOKE.b2Jacobian_linear_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Box2DPINVOKE.b2Jacobian_linear_get(swigCPtr);
      b2Vec2 ret = (cPtr == IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public float angularA {
    set {
      Box2DPINVOKE.b2Jacobian_angularA_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Jacobian_angularA_get(swigCPtr);
      return ret;
    } 
  }

  public float angularB {
    set {
      Box2DPINVOKE.b2Jacobian_angularB_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Jacobian_angularB_get(swigCPtr);
      return ret;
    } 
  }

  public b2Jacobian() : this(Box2DPINVOKE.new_b2Jacobian(), true) {
  }

}

}
