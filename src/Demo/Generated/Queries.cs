using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Demo
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Queries
        : global::StrawberryShake.IDocument
    {
        private readonly byte[] _hashName = new byte[]
        {
            109,
            100,
            53,
            72,
            97,
            115,
            104
        };
        private readonly byte[] _hash = new byte[]
        {
            56,
            56,
            101,
            50,
            48,
            49,
            55,
            48,
            52,
            97,
            49,
            54,
            57,
            55,
            54,
            49,
            101,
            98,
            51,
            101,
            49,
            98,
            53,
            101,
            57,
            52,
            100,
            56,
            48,
            48,
            57,
            101
        };
        private readonly byte[] _content = new byte[]
        {
            113,
            117,
            101,
            114,
            121,
            32,
            103,
            101,
            116,
            86,
            101,
            104,
            105,
            99,
            108,
            101,
            115,
            32,
            123,
            32,
            118,
            101,
            104,
            105,
            99,
            108,
            101,
            115,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            46,
            46,
            46,
            32,
            111,
            110,
            32,
            67,
            97,
            114,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            110,
            98,
            83,
            101,
            97,
            116,
            115,
            32,
            125,
            32,
            125,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Queries Default { get; } = new Queries();

        public override string ToString() => 
            @"query getVehicles {
              vehicles {
                ... on Car {
                  nbSeats
                }
              }
            }";
    }
}
