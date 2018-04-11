﻿namespace Coderr.Client.NetStd.Processor
{
    /// <summary>
    ///     Invoked for every report that is about to be uploaded.
    /// </summary>
    /// <remarks>
    ///     Register the filter using <c>Err.Configuration.FilterCollection.</c>
    /// </remarks>
    public interface IReportFilter
    {
        /// <summary>
        ///     Filter method.
        /// </summary>
        /// <param name="context">Exception context information</param>
        /// <remarks>
        ///     <para>
        ///         Set <c>ReportFilterContext.CanSubmitReport</c> to <c>false</c> to abort upload.
        ///     </para>
        /// </remarks>
        void Invoke(ReportFilterContext context);
    }
}