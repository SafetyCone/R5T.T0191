using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0191
{
    /// <summary>
    /// Strongly-types a string as a data directory path.
    /// <para>Data directories contain data (machine demographic) files by convention.</para>
    /// </summary>
    [StrongTypeMarker]
    public interface IDataDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}
