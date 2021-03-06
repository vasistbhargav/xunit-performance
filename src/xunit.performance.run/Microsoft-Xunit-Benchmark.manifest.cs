// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Text;
using Microsoft.Diagnostics.Tracing;
using Address = System.UInt64;

#pragma warning disable 1591        // disable warnings on XML comments not being present

// This code was automatically generated by the TraceParserGen tool, which converts
// an ETW event manifest into strongly typed C# classes.

namespace Microsoft.Diagnostics.Tracing.Parsers
{
    using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftXunitBenchmark;

    [System.CodeDom.Compiler.GeneratedCode("traceparsergen", "2.0")]
    public sealed class MicrosoftXunitBenchmarkTraceEventParser : TraceEventParser
    {
        public static string ProviderName = "Microsoft-Xunit-Benchmark";
        public static Guid ProviderGuid = new Guid(unchecked((int)0xa3b447a8), unchecked((short)0x6549), unchecked((short)0x4158), 0x9b, 0xad, 0x76, 0xd4, 0x42, 0xa4, 0x70, 0x61);
        public enum Keywords : long
        {
            Session3 = 0x100000000000,
            Session2 = 0x200000000000,
            Session1 = 0x400000000000,
            Session0 = 0x800000000000,
        };

        public MicrosoftXunitBenchmarkTraceEventParser(TraceEventSource source) : base(source) { }

        public event Action<BenchmarkIterationStartArgs> BenchmarkIterationStart
        {
            add
            {
                source.RegisterEventTemplate(BenchmarkIterationStartTemplate(value));
            }
            remove
            {
                source.UnregisterEventTemplate(value, 3, ProviderGuid);
            }
        }
        public event Action<BenchmarkIterationStopArgs> BenchmarkIterationStop
        {
            add
            {
                source.RegisterEventTemplate(BenchmarkIterationStopTemplate(value));
            }
            remove
            {
                source.UnregisterEventTemplate(value, 4, ProviderGuid);
            }
        }
        public event Action<BenchmarkStartArgs> BenchmarkStart
        {
            add
            {
                source.RegisterEventTemplate(BenchmarkStartTemplate(value));
            }
            remove
            {
                source.UnregisterEventTemplate(value, 1, ProviderGuid);
            }
        }
        public event Action<BenchmarkStopArgs> BenchmarkStop
        {
            add
            {
                source.RegisterEventTemplate(BenchmarkStopTemplate(value));
            }
            remove
            {
                source.UnregisterEventTemplate(value, 2, ProviderGuid);
            }
        }
        public event Action<EventSourceMessageArgs> EventSourceMessage
        {
            add
            {
                source.RegisterEventTemplate(EventSourceMessageTemplate(value));
            }
            remove
            {
                source.UnregisterEventTemplate(value, 0, ProviderGuid);
            }
        }

        #region private
        protected override string GetProviderName() { return ProviderName; }

        static private BenchmarkIterationStartArgs BenchmarkIterationStartTemplate(Action<BenchmarkIterationStartArgs> action)
        {                  // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
            return new BenchmarkIterationStartArgs(action, 3, 3, "BenchmarkIterationStart", Guid.Empty, 0, "", ProviderGuid, ProviderName);
        }
        static private BenchmarkIterationStopArgs BenchmarkIterationStopTemplate(Action<BenchmarkIterationStopArgs> action)
        {                  // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
            return new BenchmarkIterationStopArgs(action, 4, 4, "BenchmarkIterationStop", Guid.Empty, 0, "", ProviderGuid, ProviderName);
        }
        static private BenchmarkStartArgs BenchmarkStartTemplate(Action<BenchmarkStartArgs> action)
        {                  // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
            return new BenchmarkStartArgs(action, 1, 1, "BenchmarkStart", Guid.Empty, 0, "", ProviderGuid, ProviderName);
        }
        static private BenchmarkStopArgs BenchmarkStopTemplate(Action<BenchmarkStopArgs> action)
        {                  // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
            return new BenchmarkStopArgs(action, 2, 2, "BenchmarkStop", Guid.Empty, 0, "", ProviderGuid, ProviderName);
        }
        static private EventSourceMessageArgs EventSourceMessageTemplate(Action<EventSourceMessageArgs> action)
        {                  // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
            return new EventSourceMessageArgs(action, 0, 65534, "EventSourceMessage", Guid.Empty, 0, "", ProviderGuid, ProviderName);
        }

        static private volatile TraceEvent[] s_templates;
        protected override void EnumerateTemplates(Func<string, string, EventFilterResponse> eventsToObserve, Action<TraceEvent> callback)
        {
            if (s_templates == null)
            {
                var templates = new TraceEvent[5];
                templates[0] = EventSourceMessageTemplate(null);
                templates[1] = BenchmarkStartTemplate(null);
                templates[2] = BenchmarkStopTemplate(null);
                templates[3] = BenchmarkIterationStartTemplate(null);
                templates[4] = BenchmarkIterationStopTemplate(null);
                s_templates = templates;
            }
            foreach (var template in s_templates)
                if (eventsToObserve == null || eventsToObserve(template.ProviderName, template.EventName) == EventFilterResponse.AcceptEvent)
                    callback(template);
        }

        #endregion
    }
}

namespace Microsoft.Diagnostics.Tracing.Parsers.MicrosoftXunitBenchmark
{
    public sealed class BenchmarkIterationStartArgs : TraceEvent
    {
        public string RunId { get { return GetUnicodeStringAt(0); } }
        public string BenchmarkName { get { return GetUnicodeStringAt(SkipUnicodeString(0)); } }
        public int Iteration { get { return GetInt32At(SkipUnicodeString(SkipUnicodeString(0))); } }

        #region Private
        internal BenchmarkIterationStartArgs(Action<BenchmarkIterationStartArgs> target, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.m_target = target;
        }
        protected override void Dispatch()
        {
            m_target(this);
        }
        protected override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != SkipUnicodeString(SkipUnicodeString(0)) + 4));
            Debug.Assert(!(Version > 0 && EventDataLength < SkipUnicodeString(SkipUnicodeString(0)) + 4));
        }
        protected override Delegate Target
        {
            get { return m_target; }
            set { m_target = (Action<BenchmarkIterationStartArgs>)value; }
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
            Prefix(sb);
            XmlAttrib(sb, "RunId", RunId);
            XmlAttrib(sb, "BenchmarkName", BenchmarkName);
            XmlAttrib(sb, "Iteration", Iteration);
            sb.Append("/>");
            return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "RunId", "BenchmarkName", "Iteration" };
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return RunId;
                case 1:
                    return BenchmarkName;
                case 2:
                    return Iteration;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<BenchmarkIterationStartArgs> m_target;
        #endregion
    }
    public sealed class BenchmarkIterationStopArgs : TraceEvent
    {
        public string RunId { get { return GetUnicodeStringAt(0); } }
        public string BenchmarkName { get { return GetUnicodeStringAt(SkipUnicodeString(0)); } }
        public int Iteration { get { return GetInt32At(SkipUnicodeString(SkipUnicodeString(0))); } }

        #region Private
        internal BenchmarkIterationStopArgs(Action<BenchmarkIterationStopArgs> target, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.m_target = target;
        }
        protected override void Dispatch()
        {
            m_target(this);
        }
        protected override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != SkipUnicodeString(SkipUnicodeString(0)) + 8));
            Debug.Assert(!(Version > 0 && EventDataLength < SkipUnicodeString(SkipUnicodeString(0)) + 8));
        }
        protected override Delegate Target
        {
            get { return m_target; }
            set { m_target = (Action<BenchmarkIterationStopArgs>)value; }
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
            Prefix(sb);
            XmlAttrib(sb, "RunId", RunId);
            XmlAttrib(sb, "BenchmarkName", BenchmarkName);
            XmlAttrib(sb, "Iteration", Iteration);
            sb.Append("/>");
            return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "RunId", "BenchmarkName", "Iteration" };
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return RunId;
                case 1:
                    return BenchmarkName;
                case 2:
                    return Iteration;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<BenchmarkIterationStopArgs> m_target;
        #endregion
    }
    public sealed class BenchmarkStartArgs : TraceEvent
    {
        public string RunId { get { return GetUnicodeStringAt(0); } }
        public string BenchmarkName { get { return GetUnicodeStringAt(SkipUnicodeString(0)); } }

        #region Private
        internal BenchmarkStartArgs(Action<BenchmarkStartArgs> target, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.m_target = target;
        }
        protected override void Dispatch()
        {
            m_target(this);
        }
        protected override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != SkipUnicodeString(SkipUnicodeString(0))));
            Debug.Assert(!(Version > 0 && EventDataLength < SkipUnicodeString(SkipUnicodeString(0))));
        }
        protected override Delegate Target
        {
            get { return m_target; }
            set { m_target = (Action<BenchmarkStartArgs>)value; }
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
            Prefix(sb);
            XmlAttrib(sb, "RunId", RunId);
            XmlAttrib(sb, "BenchmarkName", BenchmarkName);
            sb.Append("/>");
            return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "RunId", "BenchmarkName" };
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return RunId;
                case 1:
                    return BenchmarkName;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<BenchmarkStartArgs> m_target;
        #endregion
    }
    public sealed class BenchmarkStopArgs : TraceEvent
    {
        public string RunId { get { return GetUnicodeStringAt(0); } }
        public string BenchmarkName { get { return GetUnicodeStringAt(SkipUnicodeString(0)); } }
        public string StopReason { get { return GetUnicodeStringAt(SkipUnicodeString(SkipUnicodeString(0))); } }

        #region Private
        internal BenchmarkStopArgs(Action<BenchmarkStopArgs> target, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.m_target = target;
        }
        protected override void Dispatch()
        {
            m_target(this);
        }
        protected override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != SkipUnicodeString(SkipUnicodeString(SkipUnicodeString(0)))));
            Debug.Assert(!(Version > 0 && EventDataLength < SkipUnicodeString(SkipUnicodeString(SkipUnicodeString(0)))));
        }
        protected override Delegate Target
        {
            get { return m_target; }
            set { m_target = (Action<BenchmarkStopArgs>)value; }
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
            Prefix(sb);
            XmlAttrib(sb, "RunId", RunId);
            XmlAttrib(sb, "BenchmarkName", BenchmarkName);
            XmlAttrib(sb, "StopReason", StopReason);
            sb.Append("/>");
            return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "RunId", "BenchmarkName", "StopReason" };
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return RunId;
                case 1:
                    return BenchmarkName;
                case 2:
                    return StopReason;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<BenchmarkStopArgs> m_target;
        #endregion
    }
    public sealed class EventSourceMessageArgs : TraceEvent
    {
        public string message { get { return GetUnicodeStringAt(0); } }

        #region Private
        internal EventSourceMessageArgs(Action<EventSourceMessageArgs> target, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.m_target = target;
        }
        protected override void Dispatch()
        {
            m_target(this);
        }
        protected override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != SkipUnicodeString(0)));
            Debug.Assert(!(Version > 0 && EventDataLength < SkipUnicodeString(0)));
        }
        protected override Delegate Target
        {
            get { return m_target; }
            set { m_target = (Action<EventSourceMessageArgs>)value; }
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
            Prefix(sb);
            XmlAttrib(sb, "message", message);
            sb.Append("/>");
            return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "message" };
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return message;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<EventSourceMessageArgs> m_target;
        #endregion
    }
}
