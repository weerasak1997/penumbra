﻿using Microsoft.Xna.Framework.Graphics;
using Penumbra;
using Penumbra.Core;
using Sandbox.Utilities;

namespace Sandbox
{
    public abstract class Scenario
    {
        internal GraphicsDevice Device { get; set; }

        protected Scenario()
        {
            string typeName = GetType().Name;
            Name = typeName.Substring(typeName.IndexOf('_') + 1).SeparateTitleCases();
            Name = Name.Replace(" Or ", " or ");
            Name = Name.Replace(" And ", " and ");
        }

        public string Name { get; private set; }

        public abstract void Activate(PenumbraComponent penumbra);

        public virtual void Update(float deltaSeconds)
        {            
        }
    }
}
