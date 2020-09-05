using System;

namespace CSharpBuiltinDataTypes
{
    class Program
    {
        static void Main ( string [ ] args )
        {
            /*>>>>>>>>>> Value Types <<<<<<<<<<*/
            Console . WriteLine ( ">>>>>>>>>>Built-in Value Types<<<<<<<<<<\n" );

            /********** Boolean Data Type **********/
            Console . WriteLine ( "********** Boolean Data Type **********" );

            // bool .NET Type, Byte, Bit, Default, Minimum and Maximum Value
            bool boolDefaultValue = default;
            int  boolByte         = sizeof(bool);
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
            int  charByte         = sizeof(char);
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
                                  $"decimal Minimum Value: {decimalMinValue}\n\n" );



            /*>>>>>>>>>> Reference Types <<<<<<<<<<*/
            Console . WriteLine ( ">>>>>>>>>>Built-in Reference Types<<<<<<<<<<\n" );

            /********** String, Object and Dynamic Data Types **********/
            Console . WriteLine ( "********** String, Object and Dynamic Data Types **********" );

            // string, object and dynamic Defaults, .NET Types
            string stringDefaultValue   = default;
            object objectDefaultValue   = default;
            dynamic dynamicDefaultValue = default;
            // If we want to do any kind of operation with a null variable, such as
            // stringDefaultValue.GetType(); it Throws a RunTime Error, not a Compilation
            // Error; This Error is Called NullReferenceException
            Console . WriteLine ( $"string Default Value : {stringDefaultValue}\n" +
                                  $"object Default Value : {objectDefaultValue}\n" +
                                  $"dynamic Default Value: {dynamicDefaultValue}\n\n" );

            string stringGreeting   = "Welcome ";
            stringGreeting += "to C#!";
            object objectGreeting   = "Welcome to C#!";
            dynamic dynamicGreeting = "Welcome to C#!";

            // object needs typecasting while working with strings
            if ( stringGreeting == ( string ) objectGreeting )
            {
                Console . WriteLine ( $"string : {stringGreeting} and {objectGreeting}" +
                                      $" are Equal\n" );
            }
            else
            {
                Console . WriteLine ( $"string : {stringGreeting} and {objectGreeting}" +
                                      $" are Not Equal\n" );
            }

            // dynamic does not need typecasting while working with strings
            if ( stringGreeting == dynamicGreeting )
            {
                Console . WriteLine ( $"dynamic: {stringGreeting} and {dynamicGreeting}" +
                                      $" are Equal\n\n" );
            }
            else
            {
                Console . WriteLine ( $"dynamic: {stringGreeting} and {dynamicGreeting}" +
                                      $" are Not Equal\n\n" );
            }

            // object can store any kind of value
            object objectBool    =    boolMaxValue;
            object objectSByte   =   sByteMaxValue;
            object objectByte    =    byteMaxValue;
            object objectChar    =    charMaxValue;
            object objectShort   =   shortMaxValue;
            object objectUShort  =  uShortMaxValue;
            object objectInt     =     intMaxValue;
            object objectUInt    =    uIntMaxValue;
            object objectLong    =    longMaxValue;
            object objectULong   =   uLongMaxValue;
            object objectFloat   =   floatMaxValue;
            object objectDouble  =  doubleMaxValue;
            object objectDecimal = decimalMaxValue;
            object objectNull    =            null;
            Console . WriteLine ( $">>>>>>>>>> Object <<<<<<<<<<\n\n" +

                                  $"String Value           : {objectGreeting}\n" +
                                  $"Object Type            : {objectGreeting . GetType ( )}\n\n" +

                                  $"Boolean Value          : {objectBool}\n" +
                                  $"Object Type            : {objectBool . GetType ( )}\n\n" +

                                  $"Signed Byte Value      : {objectSByte}\n" +
                                  $"Object Type            : {objectSByte . GetType ( )}\n\n" +

                                  $"Unsigned Byte Value    : {objectByte}\n" +
                                  $"Object Type            : {objectByte . GetType ( )}\n\n" +

                                  $"Character Value        : {objectChar}\n" +
                                  $"Object Type            : {objectChar . GetType ( )}\n\n" +

                                  $"Signed Short Value     : {objectShort}\n" +
                                  $"Object Type            : {objectShort . GetType ( )}\n\n" +

                                  $"Unsigned Short Value   : {objectUShort}\n" +
                                  $"Object Type            : {objectUShort . GetType ( )}\n\n" +

                                  $"Signed Integer Value   : {objectInt}\n" +
                                  $"Object Type            : {objectInt . GetType ( )}\n\n" +

                                  $"Unsigned Integer Value : {objectUInt}\n" +
                                  $"Object Type            : {objectUInt . GetType ( )}\n\n" +

                                  $"Signed Long Value      : {objectLong}\n" +
                                  $"Object Type            : {objectLong . GetType ( )}\n\n" +

                                  $"Unsigned Long Value    : {objectULong}\n" +
                                  $"Object Type            : {objectULong . GetType ( )}\n\n" +

                                  $"Floating Value         : {objectFloat}\n" +
                                  $"Object Type            : {objectFloat . GetType ( )}\n\n" +

                                  $"Double Value           : {objectDouble}\n" +
                                  $"Object Type            : {objectDouble . GetType ( )}\n\n" +

                                  $"Decimal Value          : {objectDecimal}\n" +
                                  $"Object Type            : {objectDecimal . GetType ( )}\n\n" +

                                  $"Null Value             : {objectNull}\n\n" );

            // dynamic can store any kind of value
            dynamic dynamicBool    =    boolMinValue;
            dynamic dynamicSByte   =   sByteMinValue;
            dynamic dynamicByte    =    byteMinValue;
            dynamic dynamicChar    =    charMinValue;
            dynamic dynamicShort   =   shortMinValue;
            dynamic dynamicUShort  =  uShortMinValue;
            dynamic dynamicInt     =     intMinValue;
            dynamic dynamicUInt    =    uIntMinValue;
            dynamic dynamicLong    =    longMinValue;
            dynamic dynamicULong   =   uLongMinValue;
            dynamic dynamicFloat   =   floatMinValue;
            dynamic dynamicDouble  =  doubleMinValue;
            dynamic dynamicDecimal = decimalMinValue;
            dynamic dynamicNull    =            null;
            Console . WriteLine ( $">>>>>>>>>> Dynamic <<<<<<<<<<\n\n" +

                                  $"String Value           : {dynamicGreeting}\n" +
                                  $"Object Type            : {dynamicGreeting . GetType ( )}\n\n" +

                                  $"Boolean Value          : {dynamicBool}\n" +
                                  $"Object Type            : {dynamicBool . GetType ( )}\n\n" +

                                  $"Signed Byte Value      : {dynamicSByte}\n" +
                                  $"Object Type            : {dynamicSByte . GetType ( )}\n\n" +

                                  $"Unsigned Byte Value    : {dynamicByte}\n" +
                                  $"Object Type            : {dynamicByte . GetType ( )}\n\n" +

                                  $"Character Value        : {dynamicChar}\n" +
                                  $"Object Type            : {dynamicChar . GetType ( )}\n\n" +

                                  $"Signed Short Value     : {dynamicShort}\n" +
                                  $"Object Type            : {dynamicShort . GetType ( )}\n\n" +

                                  $"Unsigned Short Value   : {dynamicUShort}\n" +
                                  $"Object Type            : {dynamicUShort . GetType ( )}\n\n" +

                                  $"Signed Integer Value   : {dynamicInt}\n" +
                                  $"Object Type            : {dynamicInt . GetType ( )}\n\n" +

                                  $"Unsigned Integer Value : {dynamicUInt}\n" +
                                  $"Object Type            : {dynamicUInt . GetType ( )}\n\n" +

                                  $"Signed Long Value      : {dynamicLong}\n" +
                                  $"Object Type            : {dynamicLong . GetType ( )}\n\n" +

                                  $"Unsigned Long Value    : {dynamicULong}\n" +
                                  $"Object Type            : {dynamicULong . GetType ( )}\n\n" +

                                  $"Floating Value         : {dynamicFloat}\n" +
                                  $"Object Type            : {dynamicFloat . GetType ( )}\n\n" +

                                  $"Double Value           : {dynamicDouble}\n" +
                                  $"Object Type            : {dynamicDouble . GetType ( )}\n\n" +

                                  $"Decimal Value          : {dynamicDecimal}\n" +
                                  $"Object Type            : {dynamicDecimal . GetType ( )}\n\n" +

                                  $"Null Value             : {dynamicNull}\n\n" );
        }
    }
}