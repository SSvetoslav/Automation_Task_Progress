namespace Progress.Utils
{
    internal static class Data
    {
        // Valid data
        internal static string validEmail = "test@progress.com";
        internal static string validFirstName = "Svetoslav";
        internal static string validLastName = "Savov";
        internal static string validCompany = "Progress";
        internal static string validPhone = "0888202020";
        internal static string validMessage = "Thank you in advance!";

        // Max lenght
        internal static string validEmailMaxLenght64chars = "testtesttesttesttesttesttesttesttesttesttesttesttes@progress.com"; // 64 chars
        internal static string validFirstNameMaxLenght50chars = "SvetoslavSvetoslavSvetoslavSvetoslavSvetoslavSveto"; // 50 chars
        internal static string validLastNameMaxLenght50chars = "SavovSavovSavovSavovSavovSavovSavovSavovSavovSavov"; // 50 chars
        internal static string validCompanyMaxLenght100chars = "ProgressProgressProgressProgressProgressProgressProgressProgressProgressProgressProgressProgressProg"; // 100 chars
        internal static string validPhoneMaxLenght30chars = "088820202030405060708090102030"; // 30 chars
        internal static string validMessageMaxLenght2000chars = "Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance! Thank you in advance!@#$%^&*()_+1234567890"; // 2000 chars

        // Invalid data
        internal static string invalidNamesLenght51Chars = "InvaliLengthInvaliLengthInvaliLengthInvaliLengthInv";
        internal static string invalidEmailLenght65Chars = "InvaliLengthInvaliLengthInvaliLengthInvaliLengthInv";
        internal static string invalidCompanyLenght101Chars = "InvaliLengthInvaliLengthInvaliLengthInvaliLengthInv";
        internal static string invalidPhoneLenght31Chars = "InvaliLengthInvaliLengthInvaliLengthInvaliLengthInv";
        internal static string invalidMessageLenght2001Chars = "InvaliLengthInvaliLengthInvaliLengthInvaliLengthInv";

        internal static string invalidEmail = "test2progress.com";

        // White spaces
        internal static string whiteSpacesFirstName = "            ";
        internal static string whiteSpacesLastName = "         ";

        // SLQ Injection
        internal static string sqlInjection = @"'  or 1=1--";

        // XSS
        internal static string xssScript = @"<script>alert('XSS')</script>";



    }
}
