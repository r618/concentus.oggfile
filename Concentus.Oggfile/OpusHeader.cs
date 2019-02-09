﻿namespace Concentus.Oggfile
{
    internal class OpusHeader
    {
        byte version;
        byte channel_count;
        ushort pre_skip;
        uint input_sample_rate;
        short output_gain;
        byte mapping_family;
        byte stream_count;
        byte coupled_count;
    }
}
