using System;


namespace R5T.T0191.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToDataDirectoryPath(string)"/>
        public static IDataDirectoryPath ToDataDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToDataDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToDocumentsDirectoryPath(string)"/>
        public static IDocumentsDirectoryPath ToDocumentsDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToDocumentsDirectoryPath(value);
        }
    }
}
