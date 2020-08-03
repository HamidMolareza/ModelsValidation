﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using FunctionalUtility.Extensions;
using FunctionalUtility.ResultUtility;
using ModelsValidation;

namespace TestModelsValidation.Utility {
    public static class MethodUtility {
        public static MethodResult NoParameter () =>
            MethodBase.GetCurrentMethod ()
            .Map (currentMethod =>
                currentMethod!.MethodParametersMustValid (new object[] { }))
            .MapMethodResult ();

        public static MethodResult NoAttribute (string a, int? b,
                IReadOnlyCollection<char> c, List<SimpleModel> d, SimpleModel e) =>
            MethodBase.GetCurrentMethod ()
            .Map (currentMethod =>
                currentMethod!.MethodParametersMustValid (
                    new object[] { a, b, c, d, e }))
            .MapMethodResult ();

        public static MethodResult WrongImplementation (string a, int? b,
                IReadOnlyCollection<char> c, List<SimpleModel> d, SimpleModel e) =>
            MethodBase.GetCurrentMethod ()
            .Map (currentMethod =>
                currentMethod!.MethodParametersMustValid (
                    new object[] { a, b, c, d }))
            .MapMethodResult ();

        public static MethodResult ParametersWithAttributes (
                [Required][StringLength (3)] string a, [Required][Range (0, 10)] int? b, [Required] List<int> c) =>
            MethodBase.GetCurrentMethod ()
            .Map (currentMethod =>
                currentMethod!.MethodParametersMustValid (
                    new object[] { a, b, c }))
            .MapMethodResult ();

        public static MethodResult EnumerableType (
                [Required] IEnumerable<int> a, [Required] IReadOnlyCollection<int> b) =>
            MethodBase.GetCurrentMethod ()
            .Map (currentMethod =>
                currentMethod!.MethodParametersMustValid (
                    new object[] { a, b }))
            .MapMethodResult ();

        public static MethodResult ModelParameters (
                ModelWithAttributes a, [Required] ModelWithAttributes b,
                ComplexModel c, [Required] ComplexModel d, string e) =>
            MethodBase.GetCurrentMethod ()
            .Map (currentMethod =>
                currentMethod!.MethodParametersMustValid (
                    new object[] { a, b, c, d, e }))
            .MapMethodResult ();
    }
}