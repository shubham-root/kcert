﻿namespace KCert.Lib.AcmeModels
{
    public class AccountResponse : AcmeResponse
    {
        public string Status { get; set; }
        public string[] Contact { get; set; }
        public string Orders { get; set; }
    }
}
