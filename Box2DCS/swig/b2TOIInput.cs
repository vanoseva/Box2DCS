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

public class b2TOIInput : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2TOIInput(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2TOIInput obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2TOIInput() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2TOIInput(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public b2DistanceProxy proxyA {
    set {
      Box2DPINVOKE.b2TOIInput_proxyA_set(swigCPtr, b2DistanceProxy.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Box2DPINVOKE.b2TOIInput_proxyA_get(swigCPtr);
      b2DistanceProxy ret = (cPtr == IntPtr.Zero) ? null : new b2DistanceProxy(cPtr, false);
      return ret;
    } 
  }

  public b2DistanceProxy proxyB {
    set {
      Box2DPINVOKE.b2TOIInput_proxyB_set(swigCPtr, b2DistanceProxy.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Box2DPINVOKE.b2TOIInput_proxyB_get(swigCPtr);
      b2DistanceProxy ret = (cPtr == IntPtr.Zero) ? null : new b2DistanceProxy(cPtr, false);
      return ret;
    } 
  }

  public b2Sweep sweepA {
    set {
      Box2DPINVOKE.b2TOIInput_sweepA_set(swigCPtr, b2Sweep.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Box2DPINVOKE.b2TOIInput_sweepA_get(swigCPtr);
      b2Sweep ret = (cPtr == IntPtr.Zero) ? null : new b2Sweep(cPtr, false);
      return ret;
    } 
  }

  public b2Sweep sweepB {
    set {
      Box2DPINVOKE.b2TOIInput_sweepB_set(swigCPtr, b2Sweep.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Box2DPINVOKE.b2TOIInput_sweepB_get(swigCPtr);
      b2Sweep ret = (cPtr == IntPtr.Zero) ? null : new b2Sweep(cPtr, false);
      return ret;
    } 
  }

  public float tMax {
    set {
      Box2DPINVOKE.b2TOIInput_tMax_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2TOIInput_tMax_get(swigCPtr);
      return ret;
    } 
  }

  public b2TOIInput() : this(Box2DPINVOKE.new_b2TOIInput(), true) {
  }

}

}