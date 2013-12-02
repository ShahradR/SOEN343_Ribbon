using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.Design.Behavior;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace System.Windows.Forms
{
    public abstract class RibbonGlyph
        : Glyph
    {
        protected BehaviorService _behaviorService;

        public RibbonGlyph(Behavior behavior, BehaviorService behaviorService)
            : base(behavior)
        {
            _behaviorService = behaviorService;
        }

        public override Cursor GetHitTest(System.Drawing.Point p)
        {
            if (Bounds.Contains(p))
            {
                return Cursors.Hand;
            }

            return null;
        }
    }
}