﻿namespace Morpeh {
    using UnityEngine;

    [AddComponentMenu("ECS/" + nameof(RemoveEntityOnDestroy))]
    public sealed class RemoveEntityOnDestroy : EntityProvider {
        private new void OnDestroy() {
            if (this.Entity != null && !this.Entity.IsDisposed()) {
                World.Default?.RemoveEntity(this.Entity);
            }
        }
    }
}