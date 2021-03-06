﻿namespace MBINCompiler.Models.Structs
{
    public class GcNGuiLayoutData : NMSTemplate
    {
        public float PositionX;
        public float PositionY;
        public float Width; 
        public bool WidthPercentage;

        public float Height;
        public bool HeightPercentage;
        public bool ConstrainProportions;

        public float ConstrainAspect;
        public bool Anchor;
        public bool AnchorPercent;
        public bool SameLine;

        [NMS(Size = 1, Ignore = true)]
        public byte[] Padding1F;

        public TkNGuiAlignment Align;
        public bool SlowCursorOnHover;

        [NMS(Size = 0x7, Ignore = true)]
        public byte[] Padding4;
    }
}
