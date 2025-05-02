using System.Numerics;
using Vector3 = UnityEngine.Vector3;

public static class MathHelp
{
	public static Vector3 GetCurvePoint(Vector3 p0, Vector3 p1, Vector3 p2, float t)
	{
		return Vector3.Lerp(Vector3.Lerp(p0, p1, t), Vector3.Lerp(p1, p2, t), t);
	}
}
