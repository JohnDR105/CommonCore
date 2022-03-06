// ***********************************************************************
// Assembly         : JnSCommon
// Author           : John D Reasor
// Created          : 09-30-2016
//
// Last Modified By : John D Reasor
// Last Modified On : 09-30-2016
// ***********************************************************************
// <copyright file="ControlAction.cs" company="J&S Software, LLC">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.CompositeUI.Actions
{
    using System;
    using System.Linq;

    /// <summary>
    /// Class ControlAction.
    /// </summary>
    /// <seealso cref="JnSCommon.CompositeUI.Actions.PresenterAction" />
    /// <seealso cref="JnSCommon.CompositeUI.Actions.IControlAction" />
    /// <remarks>J&S Software, LLC</remarks>
    public class ControlAction : PresenterAction, IControlAction
    {
        /// <summary>
        /// The action
        /// </summary>
        private Action action;

        /// <summary>
        /// The visible
        /// </summary>
        private bool visible = true;

        /// <summary>
        /// The enabled
        /// </summary>
        private bool enabled = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlAction"/> class.
        /// </summary>
        /// <param name="actionBase">The action base.</param>
        /// <remarks>J&S Software, LLC</remarks>
        public ControlAction(Action actionBase)
            : base(actionBase)
        {
            this.action = actionBase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlAction"/> class.
        /// </summary>
        /// <param name="actionBase">The action base.</param>
        /// <param name="visible">if set to <c>true</c> [visible].</param>
        /// <param name="enabled">if set to <c>true</c> [enabled].</param>
        /// <remarks>J&S Software, LLC</remarks>
        public ControlAction(Action actionBase, bool visible, bool enabled)
            : base(actionBase)
        {
            this.action = actionBase;
            this.visible = visible;
            this.enabled = enabled;
        }


        /// <summary>
        /// Occurs when [enabled changed].
        /// </summary>
        /// <remarks>J&S Software, LLC</remarks>
        public event EventHandler<ControlActionEnabledChangedEventArgs> EnabledChanged;

        /// <summary>
        /// Occurs when [visible changed].
        /// </summary>
        /// <remarks>J&S Software, LLC</remarks>
        public event EventHandler<ControlActionVisibleChangedEventArgs> VisibleChanged;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ControlAction"/> is enabled.
        /// </summary>
        /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
        /// <remarks>J&S Software, LLC</remarks>
        public bool Enabled
        {
            get
            {
                return this.enabled;
            }

            set
            {
                if (this.enabled != value)
                {
                    this.enabled = value;
                    this.OnEnabledChanged(this.enabled);
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ControlAction"/> is visible.
        /// </summary>
        /// <value><c>true</c> if visible; otherwise, <c>false</c>.</value>
        /// <remarks>J&S Software, LLC</remarks>
        public bool Visible
        {
            get
            {
                return this.visible;
            }

            set
            {
                if (this.visible != value)
                {
                    this.visible = value;
                    this. OnVisibleChanged(this.visible);
                }
            }
        }

        /// <summary>
        /// Shows this instance.
        /// </summary>
        /// <remarks>J&S Software, LLC</remarks>
        public virtual void Show()
        {
            this.Visible = true;
        }

        /// <summary>
        /// Hides this instance.
        /// </summary>
        /// <remarks>J&S Software, LLC</remarks>
        public virtual void Hide()
        {
            this.Visible = false;
        }

        /// <summary>
        /// Enables this instance.
        /// </summary>
        /// <remarks>J&S Software, LLC</remarks>
        public virtual void Enable()
        {
            this.Enabled = true;
        }

        /// <summary>
        /// Disabled this instance.
        /// </summary>
        /// <remarks>J&S Software, LLC</remarks>
        public virtual void Disabled()
        {
            this.Enabled = false;
        }

        /// <summary>
        /// Executes this instance.
        /// </summary>
        /// <remarks>J&S Software, LLC</remarks>
        public override void Execute()
        {
            if (this.enabled)
            {
                base.Execute();
            }
        }

        /// <summary>
        /// Called when [enabled changed].
        /// </summary>
        /// <param name="enabled">if set to <c>true</c> [enabled].</param>
        /// <remarks>J&S Software, LLC</remarks>
        protected virtual void OnEnabledChanged(bool enabled)
        {
            if (this.EnabledChanged != null)
            {
                this.EnabledChanged(this, new ControlActionEnabledChangedEventArgs(this.enabled));
            }
        }

        /// <summary>
        /// Called when [visible changed].
        /// </summary>
        /// <param name="visible">if set to <c>true</c> [visible].</param>
        /// <remarks>J&S Software, LLC</remarks>
        protected virtual void OnVisibleChanged(bool visible)
        {
            if (this.VisibleChanged != null)
            {
                this.VisibleChanged(this, new ControlActionVisibleChangedEventArgs(this.visible));
            }
        }
    }
}
