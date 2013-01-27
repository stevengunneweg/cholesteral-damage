﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Flakcore.Display;
using Display.Tilemap;
using Microsoft.Xna.Framework;
using Flakcore;
using Flakcore.Utils;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace GlamourJam
{
    class EndScreen : State
    {
		public Vetbol winner;
		public GamePadState padState;

		public EndScreen(Vetbol winner)
		{
			this.winner = winner;
			//this.winner.Activate();
			AddChild(this.winner);

			Label lbl = new Label("Player " + winner.player + " has won!", Controller.FontController.GetFont("DefaultFont"));
			lbl.Position.X = (Controller.ScreenSize.X / 2) - (lbl.Width / 2);
			AddChild(lbl);

			Label lblAdvance = new Label("Press A to apply CPR", Controller.FontController.GetFont("DefaultFont"));
			lblAdvance.Position.X = (Controller.ScreenSize.X / 2) - (lblAdvance.Width / 2);
			lblAdvance.Position.Y = 50;
			AddChild(lblAdvance);
		}

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
			padState = GamePad.GetState(PlayerIndex.One);

			if (padState.Buttons.A == ButtonState.Pressed)
			{
				Controller.SwitchState(new MenuState());
			}
		}
    }
}
