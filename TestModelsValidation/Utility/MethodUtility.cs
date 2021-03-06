﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using FunctionalUtility.ResultUtility;
using ModelsValidation.Attributes;

namespace TestModelsValidation.Utility {
    public static class MethodUtility {
        public static MethodResult NoParameter () =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { },
                showDefaultMessageToUser : false);

        public static MethodResult NoAttribute (string a, int? b,
                IReadOnlyCollection<char> c, List<SimpleModel> d, SimpleModel e) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { a, b, c, d, e },
                showDefaultMessageToUser : false);

        public static MethodResult WrongImplementation (string a, int? b,
                IReadOnlyCollection<char> c, List<SimpleModel> d, SimpleModel _) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { a, b, c, d },
                showDefaultMessageToUser : false);

        public static MethodResult ParametersWithAttributes (
                [Required][StringLength (3)] string a, [Required][Range (0, 10)] int? b, [Required] List<int> c) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { a, b, c },
                showDefaultMessageToUser : false);

        public static MethodResult EnumerableType (
                [Required] IEnumerable<int> a, [Required] IReadOnlyCollection<int> b) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { a, b },
                showDefaultMessageToUser : false);

        public static MethodResult ModelParameters (
                ModelWithAttributes a, [Required] ModelWithAttributes b,
                ComplexModel c, [Required] ComplexModel d, string e) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { a, b, c, d, e },
                showDefaultMessageToUser : false);

        public static MethodResult InputIsClaimType (
                [Required] IEnumerable<Claim> claims) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { claims },
                showDefaultMessageToUser : false);

        public static MethodResult CheckDepth (
                [Required] ModelDepth0 model, int maximumDepth) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { model, maximumDepth },
                showDefaultMessageToUser : false, maximumDepth : maximumDepth);

        public static MethodResult CheckDepthSingleModel (
                [Required] ModelWithAttributes model, int maximumDepth) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { model, maximumDepth },
                showDefaultMessageToUser : false, maximumDepth : maximumDepth);

        public static MethodResult SimpleAttribute (
                [Agreement (ErrorMessage = "{0} is required.")] bool agreement) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { agreement },
                showDefaultMessageToUser : false);

        public static MethodResult AgreementAttributeOnInvalidType (
                [Agreement] string agreement) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { agreement },
                showDefaultMessageToUser : false);

        public static MethodResult AgreementAttribute (
                [Agreement (ErrorMessage = "{0} is required.")] bool agreement) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { agreement },
                showDefaultMessageToUser : false);

        public static MethodResult EmailAttributeOnInvalidType ([Email] bool email) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { email },
                showDefaultMessageToUser : false);

        public static MethodResult EmailAttribute ([Email (MinimumLength = 10, MaximumLength = 90)] string email) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { email },
                showDefaultMessageToUser : false);

        public static MethodResult NonNegativeIntegerAttributeOnInvalidType ([NonNegativeInteger] List<string> nonNegativeInteger) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { nonNegativeInteger },
                showDefaultMessageToUser : false);

        public static MethodResult NonNegativeIntegerAttribute ([NonNegativeInteger] int nonNegativeInteger) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { nonNegativeInteger },
                showDefaultMessageToUser : false);

        public static MethodResult PhoneNumberAttributeOnInvalidType ([PhoneNumber] int phoneNumber) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { phoneNumber },
                showDefaultMessageToUser : false);

        public static MethodResult PhoneNumberAttribute ([PhoneNumber] string phoneNumber) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { phoneNumber },
                showDefaultMessageToUser : false);

        public static MethodResult PositiveIntegerAttributeOnInvalidType ([PositiveInteger] List<string> positiveInteger) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { positiveInteger },
                showDefaultMessageToUser : false);

        public static MethodResult PositiveIntegerAttribute ([PositiveInteger] int positiveInteger) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { positiveInteger },
                showDefaultMessageToUser : false);

        public static MethodResult UserNameAttributeOnInvalidType ([UserName] List<string> username) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { username },
                showDefaultMessageToUser : false);

        public static MethodResult UserNameAttribute ([UserName (MinimumLength = 5, MaximumLength = 35)] string username) =>
            ModelsValidation.Method.MethodParametersMustValid (new object[] { username },
                showDefaultMessageToUser : false);
    }
}