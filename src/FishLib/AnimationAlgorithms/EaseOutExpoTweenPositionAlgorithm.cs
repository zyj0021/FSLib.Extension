using System;

namespace FSLib.Extension.FishLib.AnimationAlgorithms
{
	/// <summary>
	/// EaseOutExpo
	/// </summary>
	public class EaseOutExpoTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// 获得在指定的时间刻度上应该处于的位置
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return (pos == 1) ? 1 : -Math.Pow(2, -10 * pos) + 1;
		}

		#endregion
	}
}