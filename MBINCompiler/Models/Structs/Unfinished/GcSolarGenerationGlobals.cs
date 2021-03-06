﻿namespace MBINCompiler.Models.Structs
{
    public class GcSolarGenerationGlobals : NMSTemplate
    {
        public bool Unknown0;
        [NMS(Size = 0xF)]
        public byte[] Unknown1;

        public float Unknown10;
        public float Unknown14;
        public float Unknown18; // unused? 
        public float Unknown1C; // unused? 

        public float minPlanetDistance;
        public float maxPlanetDistance;
        public float Unknown28; // unused?   // changed bool to float
        public int Unknown2c; // unused? non-float?

        public float Unknown30; // changed bool to float
        public float Unknown34; // unused?
        public float Unknown38; // unused?
        public float Unknown3C; // qword?

        public float Unknown40; // unused?
        public float Unknown44;
        public float Unknown48;
        public float Unknown4C;

        public float Unknown50;
        public int Unknown54;
        public int Unknown58;
        public float Unknown5C;

        public int Unknown60;
        public int Unknown64;
        public float Unknown68;
        public float Unknown6C;

        public float Unknown70;
        public uint Unknown74; // changed bool to uint
        public float Unknown78;
        public float Unknown7C;

        public int Unknown80;
        public float Unknown84; // unused?
        public float Unknown88; // unused?
        public float Unknown8C;

        public float Unknown90;
        public float Unknown94;
        public float Unknown98;
        public float Unknown9C;

        public float UnknownA0;
        public float UnknownA4;
        public float UnknownA8;
        public float UnknownAC;

        public float UnknownB0;
        public float UnknownB4;
        public float UnknownB8;
        public float UnknownAsteroidSpacing;

        public float UnknownAsteroidFadeIn;
        public float UnknownC4;
        public int UnknownAsteroidMinDropAmount;
        public int UnknownAsteroidMaxDropAmount;

        [NMS(Size = 16)]
        public string UnknownAsteroidDroppedItem;

        public float SmallAsteroidScale;
        public float SmallAsteroidSpacing;
        public float SmallAsteroidFadeIn;
        public float UnknownEC;

        public int SmallAsteroidMinDropAmount;
        public int SmallAsteroidMaxDropAmount;

        [NMS(Size = 0x10)]
        public string SmallAsteroidDroppedItem;

        public float Unknown108; // unused?
        public float Unknown10C; // unused?

        public float LargeAsteroidSpacing_maybe;
        public float Unknown114;
        public float LargeAsteroidFadeIn_maybe;
        public float Unknown11C;

        public float Unknown120; // unused?
        public float Unknown124; // unused?
        public int Unknown128;
        public float Unknown12C;

        public float Unknown130;

        [NMS(Size = 0x6)]
        public Vector3i Unknown134;

        public int Unknown17C;
    }
}
