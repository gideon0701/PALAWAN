using System;
using System.Collections.Generic;
using System.Linq;


namespace ScannerSampleLab1.Model
{
    interface IModel
    {
        string USERNAME { get; set; }
        string PASSWORD { get; set; }
        bool validateLogin();
        bool validateInputs();
    }
}
