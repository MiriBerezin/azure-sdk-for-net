// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Resource usage statistics for a <see cref="CloudJobSchedule"/>.
    /// </summary>
    public partial class JobScheduleStatistics : IPropertyMetadata
    {
        #region Constructors

        internal JobScheduleStatistics(Models.JobScheduleStatistics protocolObject)
        {
            this.FailedTaskCount = protocolObject.NumFailedTasks;
            this.KernelCpuTime = protocolObject.KernelCPUTime;
            this.LastUpdateTime = protocolObject.LastUpdateTime;
            this.ReadIOGiB = protocolObject.ReadIOGiB;
            this.ReadIOps = protocolObject.ReadIOps;
            this.StartTime = protocolObject.StartTime;
            this.SucceededTaskCount = protocolObject.NumSucceededTasks;
            this.TaskRetryCount = protocolObject.NumTaskRetries;
            this.Url = protocolObject.Url;
            this.UserCpuTime = protocolObject.UserCPUTime;
            this.WaitTime = protocolObject.WaitTime;
            this.WallClockTime = protocolObject.WallClockTime;
            this.WriteIOGiB = protocolObject.WriteIOGiB;
            this.WriteIOps = protocolObject.WriteIOps;
        }

        #endregion Constructors

        #region JobScheduleStatistics

        /// <summary>
        /// Gets the total number of tasks in the job that failed during the given time range.
        /// </summary>
        public long FailedTaskCount { get; }

        /// <summary>
        /// Gets the total kernel mode CPU time (per core) consumed by all tasks in the job schedule.
        /// </summary>
        public TimeSpan KernelCpuTime { get; }

        /// <summary>
        /// Gets the time at which the statistics were last updated. All statistics are limited to the range between <see 
        /// cref="StartTime"/> and this value.
        /// </summary>
        public DateTime LastUpdateTime { get; }

        /// <summary>
        /// Gets the total gibibytes of I/O read from disk by all tasks in the job schedule.
        /// </summary>
        public double ReadIOGiB { get; }

        /// <summary>
        /// Gets the total number of disk read operations made by all tasks in the job schedule.
        /// </summary>
        public long ReadIOps { get; }

        /// <summary>
        /// Gets the start time of the time range covered by the statistics.
        /// </summary>
        public DateTime StartTime { get; }

        /// <summary>
        /// Gets the total number of tasks successfully completed in the job schedule.
        /// </summary>
        public long SucceededTaskCount { get; }

        /// <summary>
        /// Gets the total number of retries that occurred on all tasks in the job schedule.
        /// </summary>
        public long TaskRetryCount { get; }

        /// <summary>
        /// Gets the URL of the statistics.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Gets the total user mode CPU time (per core) consumed by all tasks in the job schedule.
        /// </summary>
        public TimeSpan UserCpuTime { get; }

        /// <summary>
        /// Gets the total wait time of all tasks in jobs created under the schedule. The wait time for a task is defined 
        /// as the elapsed time between the creation of the task and the start of task execution. (If the task is retried 
        /// due to failures, the wait time is the time to the most recent task execution.)
        /// </summary>
        /// <remarks>
        /// This value is only reported in the account lifetime statistics.
        /// </remarks>
        public TimeSpan WaitTime { get; }

        /// <summary>
        /// Gets the total wall clock time of all tasks in the job schedule. Note that if any task was retried multiple times, 
        /// this includes the wall clock time of all the task retries.
        /// </summary>
        public TimeSpan WallClockTime { get; }

        /// <summary>
        /// Gets the total gibibytes of I/O written to disk by all tasks in the job schedule.
        /// </summary>
        public double WriteIOGiB { get; }

        /// <summary>
        /// Gets the total number of disk write operations made by all tasks in the job schedule.
        /// </summary>
        public long WriteIOps { get; }

        #endregion // JobScheduleStatistics

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}