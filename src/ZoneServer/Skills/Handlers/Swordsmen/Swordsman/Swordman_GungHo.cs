﻿using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Swordsman
{
	/// <summary>
	/// Handler for the Swordman skill Gung Ho.
	/// </summary>
	[SkillHandler(SkillId.Swordman_GungHo)]
	public class Swordman_GungHo : ISelfSkillHandler
	{
		/// <summary>
		/// Handles skill, applying the buff to the caster.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="dir"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Direction dir)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			var target = caster;

			var duration = TimeSpan.FromMinutes(30);
			target.StartBuff(BuffId.GungHo, skill.Level, 0, duration, caster);

			Send.ZC_SKILL_MELEE_TARGET(caster, skill, target, null);
		}
	}
}
