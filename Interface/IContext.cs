﻿using System.Data.Entity;

namespace EntityFramework.Interception
{
    /// <summary>
    /// The interception context.
    /// </summary>
    /// <typeparam name="TEntity">The type of entities to intercept.</typeparam>
    public interface IContext<out TEntity> : IHideObjectMembers
    {
        /// <summary>
        /// Gets the entity that's being intercepted.
        /// </summary>
        /// <value>The entity.</value>
        TEntity Entity { get; }

        /// <summary>
        /// Gets or sets the entity's state.
        /// </summary>
        /// <value>The state.</value>
        EntityState State { get; set; }

        /// <summary>
        /// Gets the validation result.
        /// </summary>
        /// <value>The validation result.</value>
        IValidationResult ValidationResult { get; }
    }
}