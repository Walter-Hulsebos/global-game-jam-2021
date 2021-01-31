using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Game
{
    public interface IActor
    {
        // ReSharper disable once InconsistentNaming
        [PublicAPI]
        Vector2 ActorPosition { get; }

        [PublicAPI]
        public void Target();

        [PublicAPI]
        public void Untarget();
    }
}
