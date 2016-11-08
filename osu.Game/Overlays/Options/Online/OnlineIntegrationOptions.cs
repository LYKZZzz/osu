﻿using osu.Framework.Graphics;
using osu.Framework.Graphics.UserInterface;

namespace osu.Game.Overlays.Options.Online
{
    public class OnlineIntegrationOptions : OptionsSubsection
    {
        protected override string Header => "Integration";
    
        public OnlineIntegrationOptions()
        {
            Children = new Drawable[]
            {
                new BasicCheckBox { LabelText = "Integrate with Yahoo! status display" },
                new BasicCheckBox { LabelText = "Integrate with MSN Live status display" },
                new BasicCheckBox { LabelText = "Automatically start osu!direct downloads" },
                new BasicCheckBox { LabelText = "Prefer no-video downloads" },
            };
        }
    }
}