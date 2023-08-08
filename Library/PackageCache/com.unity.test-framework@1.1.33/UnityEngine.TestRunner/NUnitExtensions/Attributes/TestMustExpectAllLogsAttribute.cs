f that method is not generic.</param>
      <exception cref="T:System.ArgumentException">
        <paramref name="metadataToken" /> is not a token for a type in the scope of the current module.-or-<paramref name="metadataToken" /> is a TypeSpec whose signature contains element type var (a type parameter of a generic type) or mvar (a type parameter of a generic method), and the necessary generic type arguments were not supplied for either or both of <paramref name="genericTypeArguments" /> and <paramref name="genericMethodArguments" />.</exception>
      <exception cref="T:System.ArgumentOutOfRangeException">
        <paramref name="metadataToken" /> is not a valid token in the scope of the current module.</exception>
    </member>
    <member name="P:System.Reflection.Module.ScopeName">
      <summary>Gets a string representing the name of the module.</summary>
      <returns>The module name.</returns>
    </member>
    <member name="M:System.Reflection.Module.System#Runtime#InteropServices#_Module#GetIDsOfNames(System.Guid@,System.IntPtr,System.UInt32,System.UInt32,System.IntPtr)">
      <summary>Maps a set of names to a corresponding set of dispatch identifiers.</summary>
      <param name="riid">Reserved for future use. Must be IID_NULL.</param>
      <param name="rgszNames">Passed-in array of names to be mapped.</param>
      <param name="cNames">Count of the names to be mapped.</param>
      <param name="lcid">The locale context in which to interpret the names.</param>
      <param name="rgDispId">Caller-allocated array that receives the IDs corresponding to the names.</param>
      <exception cref="T:System.NotImplementedException">Late-bound access using the COM IDispatch interface is not supported.</exception>
    </member>
    <member name="M:System.Reflection.Module.System#Runtime#InteropServices#_Module#GetTypeInfo(System.UInt32,System.UInt32,System.IntPtr)">
      <summary>Retriev