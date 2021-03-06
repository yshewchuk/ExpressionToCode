﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpressionToCodeLib
{
    static class CSharpFriendlyTypeName
    {
        public static string Get(Type type, bool useFullName = false)
        {
            return ArrayTypeName(type, useFullName)
                ?? GenericTypeName(type, useFullName)
                    ?? AliasName(type)
                        ?? NormalName(type, useFullName);
        }

        static string AliasName(Type type)
        {
            if (type == typeof(bool)) {
                return "bool";
            } else if (type == typeof(byte)) {
                return "byte";
            } else if (type == typeof(sbyte)) {
                return "sbyte";
            } else if (type == typeof(char)) {
                return "char";
            } else if (type == typeof(decimal)) {
                return "decimal";
            } else if (type == typeof(double)) {
                return "double";
            } else if (type == typeof(float)) {
                return "float";
            } else if (type == typeof(int)) {
                return "int";
            } else if (type == typeof(uint)) {
                return "uint";
            } else if (type == typeof(long)) {
                return "long";
            } else if (type == typeof(ulong)) {
                return "ulong";
            } else if (type == typeof(object)) {
                return "object";
            } else if (type == typeof(short)) {
                return "short";
            } else if (type == typeof(ushort)) {
                return "ushort";
            } else if (type == typeof(string)) {
                return "string";
            } else if (type == typeof(void)) {
                return "void";
            } else {
                return null;
            }
        }

        static string NormalName(Type type, bool useFullName = false)
        {
            return type.IsGenericParameter
                ? type.Name
                : type.DeclaringType != null
                    ? Get(type.DeclaringType, useFullName) + "." + type.Name
                    : useFullName ? type.FullName : type.Name;
        }

        static string GenericTypeName(Type type, bool useFullName = false)
        {
            if (!type.IsGenericType) {
                return null;
            }

            Type typedef = type.GetGenericTypeDefinition();
            if (typedef == typeof(Nullable<>)) {
                return Get(type.GetGenericArguments().Single(), useFullName) + "?";
            }

            var typeArgs = type.GetGenericArguments();
            var typeArgIdx = typeArgs.Length;
            var revNestedTypeNames = new List<string>();

            while (type != null) {
                var name = useFullName ? type.FullName ?? type.Name : type.Name;
                var backtickIdx = name.IndexOf('`');
                if (backtickIdx == -1) {
                    revNestedTypeNames.Add(name);
                } else {
                    var afterArgCountIdx = name.IndexOf('[', backtickIdx + 1);
                    if (afterArgCountIdx == -1) {
                        afterArgCountIdx = name.Length;
                    }
                    var thisTypeArgCount = int.Parse(name.Substring(backtickIdx + 1, afterArgCountIdx - backtickIdx - 1));
                    var argsNames = new List<string>();
                    for (int i = typeArgIdx - thisTypeArgCount; i < typeArgIdx; i++) {
                        argsNames.Add(Get(typeArgs[i], useFullName));
                    }
                    typeArgIdx -= thisTypeArgCount;
                    revNestedTypeNames.Add(name.Substring(0, backtickIdx) + "<" + string.Join(", ", argsNames) + ">");
                }
                type = type.DeclaringType;
            }
            revNestedTypeNames.Reverse();
            return string.Join(".", revNestedTypeNames);
        }

        static string ArrayTypeName(Type type, bool useFullName = false)
        {
            if (!type.IsArray) {
                return null;
            }
            string arraySuffix = null;
            do {
                var rankCommas = new string(',', type.GetArrayRank() - 1);
                type = type.GetElementType();
                arraySuffix = arraySuffix + "[" + rankCommas + "]";
            }
            while (type.IsArray);
            string basename = Get(type, useFullName);
            return basename + arraySuffix;
        }
    }
}
