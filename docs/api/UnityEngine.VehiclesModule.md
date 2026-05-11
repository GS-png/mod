# Assembly: UnityEngine.VehiclesModule
- Path: tools/WorldBox.Managed/UnityEngine.VehiclesModule.dll
- Types: 2

## Namespace: UnityEngine

### public class UnityEngine.WheelCollider
- Base: UnityEngine.Collider

#### Properties
- public float brakeTorque { get; set; }
- public UnityEngine.Vector3 center { get; set; }
- public float forceAppPointDistance { get; set; }
- public UnityEngine.WheelFrictionCurve forwardFriction { get; set; }
- public bool isGrounded { get; }
- public float mass { get; set; }
- public float motorTorque { get; set; }
- public float radius { get; set; }
- public float rotationSpeed { get; set; }
- public float rpm { get; }
- public UnityEngine.WheelFrictionCurve sidewaysFriction { get; set; }
- public float sprungMass { get; set; }
- public float steerAngle { get; set; }
- public float suspensionDistance { get; set; }
- public bool suspensionExpansionLimited { get; set; }
- public UnityEngine.JointSpring suspensionSpring { get; set; }
- public float wheelDampingRate { get; set; }

#### Constructors
- public WheelCollider()

#### Methods
- public void ConfigureVehicleSubsteps(float speedThreshold, int stepsBelowThreshold, int stepsAboveThreshold)
- public bool GetGroundHit(out UnityEngine.WheelHit hit)
- public void GetWorldPose(out UnityEngine.Vector3 pos, out UnityEngine.Quaternion quat)
- public void ResetSprungMasses()

### public struct UnityEngine.WheelHit

#### Fields
- private UnityEngine.Collider m_Collider
- private float m_Force
- private UnityEngine.Vector3 m_ForwardDir
- private float m_ForwardSlip
- private UnityEngine.Vector3 m_Normal
- private UnityEngine.Vector3 m_Point
- private UnityEngine.Vector3 m_SidewaysDir
- private float m_SidewaysSlip

#### Properties
- public UnityEngine.Collider collider { get; set; }
- public float force { get; set; }
- public UnityEngine.Vector3 forwardDir { get; set; }
- public float forwardSlip { get; set; }
- public UnityEngine.Vector3 normal { get; set; }
- public UnityEngine.Vector3 point { get; set; }
- public UnityEngine.Vector3 sidewaysDir { get; set; }
- public float sidewaysSlip { get; set; }

