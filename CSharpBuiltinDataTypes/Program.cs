using System;

namespace CSharpBuiltinDataTypes
{
    class Program
    {
        static void Main ( string [ ] args )
        {
            /********** Boolean Data Type **********/
            Console . WriteLine ( "********** Boolean Data Type **********" );

            // bool .NET Type, Byte, Bit, Default, Minimum and Maximum Value
            bool boolDefaultValue = default;
            int boolByte          = sizeof(bool);
            bool boolMaxValue     = true;
            bool boolMinValue     = false;
            Console . WriteLine ( $"bool Default Value: {boolDefaultValue}\n" +
                                  $"bool .NET Type: {boolDefaultValue . GetType ( )}\n" +
                                  $"bool Byte: {boolByte}, Bit: {boolByte * 8}\n" +
                                  $"bool Maximum Value: {boolMaxValue}\n" +
                                  $"bool Minimum Value: {boolMinValue}\n" );



            /********** Integral Data Types **********/
            Console . WriteLine ( "********** Integral Data Types **********" );

            // sbyte .NET Type, Byte, Bit, Default, Minimum and Maximum Value
            sbyte sByteDefaultValue = default;
            sbyte sByteByte         = sizeof(sbyte);
            sbyte sByteMaxValue     = sbyte.MaxValue;
            sbyte sByteMinValue     = sbyte.MinValue;
            Console . WriteLine ( $"sbyte Default Value: {sByteDefaultValue}\n" +
                                  $"sbyte .NET Type: {sByteDefaultValue . GetType ( )}\n" +
                                  $"sbyte Byte: {sByteByte}, Bit: {sByteByte * 8}\n" +
                                  $"sbyte Maximum Value: {sByteMaxValue}\n" +
                                  $"sbyte Minimum Value: {sByteMinValue}\n" );

            // byte .NET Type, Byte, Bit, Default, Minimum and Maximum Value
            byte byteDefaultValue = default;
            byte byteByte         = sizeof(byte);
            byte byteMaxValue     = byte.MaxValue;
            byte byteMinValue     = byte.MinValue;
            Console . WriteLine ( $"byte Default Value: {byteDefaultValue}\n" +
                                  $"byte .NET Type: {byteDefaultValue . GetType ( )}\n" +
                                  $"byte Byte: {byteByte}, Bit: {byteByte * 8}\n" +
                                  $"byte Maximum Value: {byteMaxValue}\n" +
                                  $"byte Minimum Value: {byteMinValue}\n" );

            // char .NET Type, Byte, Bit, Default, Minimum and Maximum Value
            char charDefaultValue = default;
            int charByte          = sizeof(char);
            char charMaxValue     = char.MaxValue;
            char charMinValue     = char.MinValue;
            Console . WriteLine ( $"char Default Value: {charDefaultValue}\n" +
                                  $"char .NET Type: {charDefaultValue . GetType ( )}\n" +
                                  $"char Byte: {charByte}, Bit: {charByte * 8}\n" +
                                  $"char Maximum Value: {charMaxValue}\n" +
                                  $"char Minimum Value: {charMinValue}\n" );

            // short .NET Type, Byte, Bit, Default, Minimum and Maximum Value
            short shortDefaultValue = default;
            short shortByte         = sizeof(short);
            short shortMaxValue     = short.MaxValue;
            short shortMinValue     = short.MinValue;
            Console . WriteLine ( $"short Default Value: {shortDefaultValue}\n" +
                                  $"short .NET Type: {shortDefaultValue . GetType ( )}\n" +
                                  $"short Byte: {shortByte}, Bit: {shortByte * 8}\n" +
                                  $"short Maximum Value: {shortMaxValue}\n" +
                                  $"short Minimum Value: {shortMinValue}\n" );

            // ushort .NET Type, Byte, Bit, Default, Minimum and Maximum Value
            ushort uShortDefaultValue = default;
            ushort uShortByte         = sizeof(ushort);
            ushort uShortMaxValue     = ushort.MaxValue;
            ushort uShortMinValue     = ushort.MinValue;
            Console . WriteLine ( $"ushort Default Value: {uShortDefaultValue}\n" +
                                  $"ushort .NET Type: {uShortDefaultValue . GetType ( )}\n" +
                                  $"ushort Byte: {uShortByte}, Bit: {uShortByte * 8}\n" +
                                  $"uShort Maximum Value: {uShortMaxValue}\n" +
                                  $"uShort Minimum Value: {uShortMinValue}\n" );

            // int .NET Type, Byte, Bit, Default, Minimum and Maximum Value
            int intDefaultValue = default;
            int intByte         = sizeof(int);
            int intMaxValue     = int.MaxValue;
            int intMinValue     = int.MinValue;
            Console . WriteLine ( $"int Default Value: {intDefaultValue}\n" +
                                  $"int .NET Type: {intDefaultValue . GetType ( )}\n" +
                                  $"int Byte: {intByte}, Bit: {intByte * 8}\n" +
                                  $"int Maximum Value: {intMaxValue}\n" +
                                  $"int Minimum Value: {intMinValue}\n" );

            // uint .NET Type, Byte, Bit, Default, Minimum and Maximum Value
            uint uIntDefaultValue = default;
            uint uIntByte         = sizeof(uint);
            uint uIntMaxValue     = uint.MaxValue;
            uint uIntMinValue     = uint.MinValue;
            Console . WriteLine ( $"uint Default Value: {uIntDefaultValue}\n" +
                                  $"uint .NET Type: {uIntDefaultValue . GetType ( )}\n" +
                                  $"uint Byte: {uIntByte}, Bit: {uIntByte * 8}\n" +
                                  $"uint Maximum Value: {uIntMaxValue}\n" +
                                  $"uint Minimum Value: {uIntMinValue}\n" );

            // long .NET Type, Byte, Bit, Default, Minimum and Maximum Value
            long longDefaultValue = default;
            long longByte         = sizeof(long);
            long longMaxValue     = long.MaxValue;
            long longMinValue     = long.MinValue;
            Console . WriteLine ( $"long Default Value: {longDefaultValue}\n" +
                                  $"long .NET Type: {longDefaultValue . GetType ( )}\n" +
                                  $"long Byte: {longByte}, Bit: {longByte * 8}\n" +
                                  $"long Maximum Value: {longMaxValue}\n" +
                                  $"long Minimum Value: {longMinValue}\n" );

            // ulong .NET Type, Byte, Bit, Default, Minimum and Maximum Value
            ulong uLongDefaultValue = default;
            ulong uLongByte         = sizeof(ulong);
            ulong uLongMaxValue     = ulong.MaxValue;
            ulong uLongMinValue     = ulong.MinValue;
            Console . WriteLine ( $"ulong Default Value: {uLongDefaultValue}\n" +
                                  $"ulong .NET Type: {uLongDefaultValue . GetType ( )}\n" +
                                  $"ulong Byte: {uLongByte}, Bit: {uLongByte * 8}\n" +
                                  $"ulong Maximum Value: {uLongMaxValue}\n" +
                                  $"ulong Minimum Value: {uLongMinValue}\n" );



            /********** Floating Data Types **********/
            Console . WriteLine ( "********** Floating Data Types **********" );

            // float .NET Type, Byte, Bit, Default, Minimum and Maximum Value
            float floatDefaultValue = default;
            float floatByte         = sizeof(float);
            float floatMaxValue     = float.MaxValue;
            float floatMinValue     = float.MinValue;
            Console . WriteLine ( $"float Default Value: {floatDefaultValue}\n" +
                                  $"float .NET Type: {floatDefaultValue . GetType ( )}\n" +
                                  $"float Byte: {floatByte}, Bit: {floatByte * 8}\n" +
                                  $"float Maximum Value: {floatMaxValue}\n" +
                                  $"float Minimum Value: {floatMinValue}\n" );

            // double .NET Type, Byte, Bit, Default, Minimum and Maximum Value
            double doubleDefaultValue = default;
            double doubleByte         = sizeof(double);
            double doubleMaxValue     = double.MaxValue;
            double doubleMinValue     = double.MinValue;
            Console . WriteLine ( $"double Default Value: {doubleDefaultValue}\n" +
                                  $"double .NET Type: {doubleDefaultValue . GetType ( )}\n" +
                                  $"double Byte: {doubleByte}, Bit: {doubleByte * 8}\n" +
                                  $"double Maximum Value: {doubleMaxValue}\n" +
                                  $"double Minimum Value: {doubleMinValue}\n" );



            /********** Decimal Data Type **********/
            Console . WriteLine ( "********** Decimal Data Type **********" );

            // decimal .NET Type, Byte, Bit, Default, Minimum and Maximum Value
            decimal decimalDefaultValue = default;
            decimal decimalByte         = sizeof(decimal);
            decimal decimalMaxValue     = decimal.MaxValue;
            decimal decimalMinValue     = decimal.MinValue;
            Console . WriteLine ( $"decimal Default Value: {decimalDefaultValue}\n" +
                                  $"decimal .NET Type: {decimalDefaultValue . GetType ( )}\n" +
                                  $"decimal Byte: {decimalByte}, Bit: {decimalByte * 8}\n" +
                                  $"decimal Maximum Value: {decimalMaxValue}\n" +
                                  $"decimal Minimum Value: {decimalMinValue}\n" );



            /********** String Data Type **********/
            Console . WriteLine ( "********** String Data Type **********" );

            // string .NET Type, Byte, Bit, Default, Minimum and Maximum Value
            string stringDefaultValue = default;
            int stringLength          = stringDefaultValue.Length;
            // Default Value of string is null, It Throws a RunTime Error, Not
            // Compilation Error; This Error is Called NullReferenceException
            Console . WriteLine ( $"string Default Value: {stringDefaultValue}\n" +
                                  $"string .NET Type: {stringDefaultValue . GetType ( )}\n" +
                                  $"string Byte: Not Defined, Bit: Not Defined\n" +
                                  $"string Maximum Value: Not Defined\n" +
                                  $"string Minimum Value: Not Defined\n" +
                                  $"Default string Length: {stringLength}" );
        }
    }
}