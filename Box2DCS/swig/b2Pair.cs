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

public class b2Pair : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2Pair(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2Pair obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2Pair() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2Pair(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public int proxyIdA {
    set {
      Box2DPINVOKE.b2Pair_proxyIdA_set(swigCPtr, value);
    } 
    get {
      int ret = Box2DPINVOKE.b2Pair_proxyIdA_get(swigCPtr);
      return ret;
    } 
  }

  public int proxyIdB {
    set {
      Box2DPINVOKE.b2Pair_proxyIdB_set(swigCPtr, value);
    } 
    get {
      int ret = Box2DPINVOKE.b2Pair_proxyIdB_get(swigCPtr);
      return ret;
    } 
  }

  public int next {
    set {
      Box2DPINVOKE.b2Pair_next_set(swigCPtr, value);
    } 
    get {
      int ret = Box2DPINVOKE.b2Pair_next_get(swigCPtr);
      return ret;
    } 
  }

  public b2Pair() : this(Box2DPINVOKE.new_b2Pair(), true) {
  }

}

}
