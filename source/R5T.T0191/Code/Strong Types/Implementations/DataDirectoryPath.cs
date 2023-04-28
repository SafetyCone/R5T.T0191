using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0191
{
    /// <inheritdoc cref="IDataDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class DataDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IDataDirectoryPath
    {
        public DataDirectoryPath(string value)
            : base(value)
        {
        }
    }
}
