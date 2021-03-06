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

public class b2PulleyJoint : b2Joint {
  private HandleRef swigCPtr;

  internal b2PulleyJoint(IntPtr cPtr, bool cMemoryOwn) : base(Box2DPINVOKE.b2PulleyJoint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2PulleyJoint obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2PulleyJoint() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2PulleyJoint(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override b2Vec2 GetAnchorA() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2PulleyJoint_GetAnchorA(swigCPtr), true);
    return ret;
  }

  public override b2Vec2 GetAnchorB() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2PulleyJoint_GetAnchorB(swigCPtr), true);
    return ret;
  }

  public override b2Vec2 GetReactionForce(float inv_dt) {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2PulleyJoint_GetReactionForce(swigCPtr, inv_dt), true);
    return ret;
  }

  public override float GetReactionTorque(float inv_dt) {
    float ret = Box2DPINVOKE.b2PulleyJoint_GetReactionTorque(swigCPtr, inv_dt);
    return ret;
  }

  public b2Vec2 GetGroundAnchorA() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2PulleyJoint_GetGroundAnchorA(swigCPtr), true);
    return ret;
  }

  public b2Vec2 GetGroundAnchorB() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2PulleyJoint_GetGroundAnchorB(swigCPtr), true);
    return ret;
  }

  public float GetLengthA() {
    float ret = Box2DPINVOKE.b2PulleyJoint_GetLengthA(swigCPtr);
    return ret;
  }

  public float GetLengthB() {
    float ret = Box2DPINVOKE.b2PulleyJoint_GetLengthB(swigCPtr);
    return ret;
  }

  public float GetRatio() {
    float ret = Box2DPINVOKE.b2PulleyJoint_GetRatio(swigCPtr);
    return ret;
  }

  public override void Dump() {
    Box2DPINVOKE.b2PulleyJoint_Dump(swigCPtr);
  }

}

}
