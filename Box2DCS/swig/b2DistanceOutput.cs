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

public class b2DistanceOutput : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2DistanceOutput(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2DistanceOutput obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2DistanceOutput() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2DistanceOutput(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public b2Vec2 pointA {
    set {
      Box2DPINVOKE.b2DistanceOutput_pointA_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Box2DPINVOKE.b2DistanceOutput_pointA_get(swigCPtr);
      b2Vec2 ret = (cPtr == IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public b2Vec2 pointB {
    set {
      Box2DPINVOKE.b2DistanceOutput_pointB_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Box2DPINVOKE.b2DistanceOutput_pointB_get(swigCPtr);
      b2Vec2 ret = (cPtr == IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public float distance {
    set {
      Box2DPINVOKE.b2DistanceOutput_distance_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2DistanceOutput_distance_get(swigCPtr);
      return ret;
    } 
  }

  public int iterations {
    set {
      Box2DPINVOKE.b2DistanceOutput_iterations_set(swigCPtr, value);
    } 
    get {
      int ret = Box2DPINVOKE.b2DistanceOutput_iterations_get(swigCPtr);
      return ret;
    } 
  }

  public b2DistanceOutput() : this(Box2DPINVOKE.new_b2DistanceOutput(), true) {
  }

}

}
