﻿namespace MBINCompiler.Models.Structs
{
    public class GcNGuiTextData : NMSTemplate
    {
        public GcNGuiElementData Data;
        public TkNGuiTextStyle Style;
        public TkNGuiGraphicStyle GraphicStyle;

        [NMS(Size = 0x80)]
        public string Image;

        [NMS(Size = 0x200)]
        public string Text;

        public bool Special;
        [NMS(Size = 0xF, Ignore = true)]
        public byte[] Padding1;
    }
}
