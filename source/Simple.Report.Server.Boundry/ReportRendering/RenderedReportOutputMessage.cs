﻿using System;

namespace Simple.Report.Server.Boundry.ReportRendering
{
    public class RenderedReportOutputMessage
    {
        public string ReportAsBase64String { get; set; }
        public string ErrorMessages { get; set; }

        public bool HasErrors()
        {
            return !string.IsNullOrWhiteSpace(ErrorMessages);
        }

        public byte[] FetchReportAsByteArray()
        {
            return Convert.FromBase64String(ReportAsBase64String);
        }
    }
}