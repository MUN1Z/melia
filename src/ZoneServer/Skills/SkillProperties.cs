﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Tos.Const;
using Melia.Zone.Scripting;

namespace Melia.Zone.Skills
{
	/// <summary>
	/// Properties of a skill.
	/// </summary>
	public class SkillProperties : Properties
	{
		/// <summary>
		/// Returns the skill these properties belong to.
		/// </summary>
		public Skill Skill { get; }

		/// <summary>
		/// Creates new properties instance for the given skill.
		/// </summary>
		/// <param name="skill"></param>
		public SkillProperties(Skill skill) : base("Skill")
		{
			this.Skill = skill;
			this.AddDefaultProperties();
		}

		/// <summary>
		/// Adds default properties based on the skill's properties and data.
		/// </summary>
		private void AddDefaultProperties()
		{
			// I don't know what exactly LevelByDB's purpose is, but if
			// it's not sent, skills can be leveled past their max level.
			// It's like that's the value the client uses to calculate
			// the current max level.

			this.Create(new RFloatProperty(PropertyName.Level, () => this.Skill.Level));
			this.Create(new RFloatProperty(PropertyName.LevelByDB, () => this.Skill.Level));

			this.Create(PropertyName.SpendSP, "SCR_Get_SpendSP");
			this.Create(PropertyName.SpendSta, "SCR_Skill_STA");
			this.Create(PropertyName.WaveLength, "SCR_Get_WaveLength");
			this.Create(PropertyName.SplAngle, "SCR_SPLANGLE");
			this.Create(PropertyName.SplRange, "SCR_Get_SplRange");

			// While a property named SR exists for skills, it doesn't seem
			// to be used in the property calculations. Instead, there's
			// SklSR, which is used in combination with PC.SR in the
			// calculation of SkillSR. Confused yet? =) No =<? Did I
			// mention there's also multiple SkillSR calculation functions
			// and that each skill can define its own? We'll probably not
			// do that...
			//this.Create(new RFloatProperty(PropertyName.SR, () => this.Skill.Data.SplashRate));
			this.Create(new RFloatProperty(PropertyName.SklSR, () => this.Skill.Data.SplashRate));
			this.Create(PropertyName.SkillSR, "SCR_GET_SR_LV");

			this.Create(new RFloatProperty(PropertyName.MaxR, () => this.Skill.Data.MaxRange));
			this.Create(new RFloatProperty(PropertyName.CoolDown, () => this.Skill.Data.Cooldown));
			this.Create(new RFloatProperty(PropertyName.SkillFactor, () => this.Skill.Data.Factor));
			this.Create(new RFloatProperty(PropertyName.HitDelay, () => (float)this.Skill.Data.HitDelay.TotalMilliseconds));
			this.Create(new RFloatProperty(PropertyName.AbleShootRotate, () => 0f));
			this.Create(new RFloatProperty(PropertyName.SklSpdRate, () => 1f)); // Constant
			this.Create(new RFloatProperty(PropertyName.SpendPoison, () => 0f));
			this.Create(new RFloatProperty(PropertyName.ReadyTime, () => 0f));
			this.Create(new RFloatProperty(PropertyName.SkillAtkAdd, () => 0f));
			this.Create(new RFloatProperty(PropertyName.EnableShootMove, () => this.Skill.Data.EnableCastMove ? 1f : 0f));
			this.Create(new RFloatProperty(PropertyName.UseOverHeat, () => this.Skill.Data.Overheat));
			this.Create(new RFloatProperty(PropertyName.SkillASPD, () => 1f));
			this.Create(new RFloatProperty(PropertyName.BackHitRange, () => 0f));
			this.Create(new RFloatProperty(PropertyName.Skill_Delay, () => 0f));
			this.Create(new RFloatProperty(PropertyName.ReinforceAtk, () => 0f));

			this.Create(new RFloatProperty(PropertyName.CaptionTime, () => 0f)); // Needs to be calculated if used, uses lua script
			this.Create(new RFloatProperty(PropertyName.CaptionRatio, () => 0f)); // Needs to be calculated if used, uses lua script
			this.Create(new RFloatProperty(PropertyName.CaptionRatio2, () => 0f)); // Needs to be calculated if used, uses lua script
			this.Create(new RFloatProperty(PropertyName.CaptionRatio3, () => 0f)); // Needs to be calculated if used, uses lua script
		}

		/// <summary>
		/// Creates a new calculated float property that uses the given
		/// function.
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="calcFuncName"></param>
		private void Create(string propertyName, string calcFuncName)
		{
			this.Create(new CFloatProperty(propertyName, () => this.CalculateProperty(calcFuncName)));
		}

		/// <summary>
		/// Calls the calculation function with the given name and returns
		/// the result.
		/// </summary>
		/// <param name="calcFuncName"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">
		/// Thrown if the function doesn't exist.
		/// </exception>
		private float CalculateProperty(string calcFuncName)
		{
			if (!ScriptableFunctions.Skill.TryGet(calcFuncName, out var func))
				throw new ArgumentException($"Scriptable skill function '{calcFuncName}' not found.");

			return func(this.Skill);
		}
	}
}
