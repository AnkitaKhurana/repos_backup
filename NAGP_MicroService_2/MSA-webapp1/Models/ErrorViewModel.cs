using System;

namespace MSA_webapp1.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public string Error { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
