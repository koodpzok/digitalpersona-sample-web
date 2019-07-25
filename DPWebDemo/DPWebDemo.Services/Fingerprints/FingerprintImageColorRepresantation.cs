﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DPWebDemo.Services.Fingerprints
{
    [DataContract]
    public enum FingerprintImageColorRepresentation
    {
        [EnumMember]
        NoColorRepresentation = 0,

        [EnumMember]
        PlanarColorRepresentation = 1,

        [EnumMember]
        InterleavedColorRepresentation = 2,
    }
}
