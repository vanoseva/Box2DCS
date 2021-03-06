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

public class b2WheelJoint : b2Joint {
  private HandleRef swigCPtr;

  internal b2WheelJoint(IntPtr cPtr, bool cMemoryOwn) : base(Box2DPINVOKE.b2WheelJoint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2WheelJoint obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2WheelJoint() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2WheelJoint(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public void GetDefinition(b2WheelJointDef def) {
    Box2DPINVOKE.b2WheelJoint_GetDefinition(swigCPtr, b2WheelJointDef.getCPtr(def));
  }

  public override b2Vec2 GetAnchorA() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2WheelJoint_GetAnchorA(swigCPtr), true);
    return ret;
  }

  public override b2Vec2 GetAnchorB() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2WheelJoint_GetAnchorB(swigCPtr), true);
    return ret;
  }

  public override b2Vec2 GetReactionForce(float inv_dt) {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2WheelJoint_GetReactionForce(swigCPtr, inv_dt), true);
    return ret;
  }

  public override float GetReactionTorque(float inv_dt) {
    float ret = Box2DPINVOKE.b2WheelJoint_GetReactionTorque(swigCPtr, inv_dt);
    return ret;
  }

  public b2Vec2 GetLocalAnchorA() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2WheelJoint_GetLocalAnchorA(swigCPtr), false);
    return ret;
  }

  public b2Vec2 GetLocalAnchorB() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2WheelJoint_GetLocalAnchorB(swigCPtr), false);
    return ret;
  }

  public b2Vec2 GetLocalAxisA() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2WheelJoint_GetLocalAxisA(swigCPtr), false);
    return ret;
  }

  public float GetJointTranslation() {
    float ret = Box2DPINVOKE.b2WheelJoint_GetJointTranslation(swigCPtr);
    return ret;
  }

  public float GetJointSpeed() {
    float ret = Box2DPINVOKE.b2WheelJoint_GetJointSpeed(swigCPtr);
    return ret;
  }

  public bool IsMotorEnabled() {
    bool ret = Box2DPINVOKE.b2WheelJoint_IsMotorEnabled(swigCPtr);
    return ret;
  }

  public void EnableMotor(bool flag) {
    Box2DPINVOKE.b2WheelJoint_EnableMotor(swigCPtr, flag);
  }

  public void SetMotorSpeed(float speed) {
    Box2DPINVOKE.b2WheelJoint_SetMotorSpeed(swigCPtr, speed);
  }

  public float GetMotorSpeed() {
    float ret = Box2DPINVOKE.b2WheelJoint_GetMotorSpeed(swigCPtr);
    return ret;
  }

  public void SetMaxMotorTorque(float torque) {
    Box2DPINVOKE.b2WheelJoint_SetMaxMotorTorque(swigCPtr, torque);
  }

  public float GetMaxMotorTorque() {
    float ret = Box2DPINVOKE.b2WheelJoint_GetMaxMotorTorque(swigCPtr);
    return ret;
  }

  public float GetMotorTorque(float inv_dt) {
    float ret = Box2DPINVOKE.b2WheelJoint_GetMotorTorque(swigCPtr, inv_dt);
    return ret;
  }

  public void SetSpringFrequencyHz(float hz) {
    Box2DPINVOKE.b2WheelJoint_SetSpringFrequencyHz(swigCPtr, hz);
  }

  public float GetSpringFrequencyHz() {
    float ret = Box2DPINVOKE.b2WheelJoint_GetSpringFrequencyHz(swigCPtr);
    return ret;
  }

  public void SetSpringDampingRatio(float ratio) {
    Box2DPINVOKE.b2WheelJoint_SetSpringDampingRatio(swigCPtr, ratio);
  }

  public float GetSpringDampingRatio() {
    float ret = Box2DPINVOKE.b2WheelJoint_GetSpringDampingRatio(swigCPtr);
    return ret;
  }

  public override void Dump() {
    Box2DPINVOKE.b2WheelJoint_Dump(swigCPtr);
  }

}

}
