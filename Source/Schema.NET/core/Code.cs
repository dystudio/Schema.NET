namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// </summary>
    [DataContract]
    public partial class Code : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Code";
    }
}